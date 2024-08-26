using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Text.RegularExpressions;


namespace Mens_Beauty_Center
{
    public partial class AddPackageCustomer : Form
    {
        Dictionary<int, Tuple<int, decimal>> dicforPackages = new Dictionary<int, Tuple<int, decimal>>();
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        public AddPackageCustomer()
        {
            InitializeComponent();
        }
        private void AddPackageCustomer_Load(object sender, EventArgs e)
        {
            // Fill the comboBox for the packages
            fillThePackages();
            DateTime today = DateTime.Today;


            // Fill the comboBox for employees who attended today
            var employeesAttendedToday = (from emp in context.Employees
                                          join att in context.Attendances
                                          on emp.NationalID equals att.NationalID
                                          where DbFunctions.TruncateTime(att.ArrivalTime) == DbFunctions.TruncateTime(DateTime.Now) && emp.Type == false
                                          select new { emp.NationalID, emp.FirstName, emp.LastName }).ToList();

            if (employeesAttendedToday.Any())
            {
                comboBoxEmployees.DataSource = employeesAttendedToday;
                comboBoxEmployees.DisplayMember = "FirstName"; // عرض الاسم الأول فقط
                comboBoxEmployees.ValueMember = "NationalID";
            }
        }

        private void fillThePackages()
        {
            dicforPackages.Clear();
            comboBoxPackages.Items.Clear(); // تفريغ العناصر القديمة
            var _Packages = context.Packages.ToList();

            for (int i = 0; i < _Packages.Count; i++)
            {
                dicforPackages[i] = Tuple.Create(_Packages[i].ID, _Packages[i].TotalAmount);
                comboBoxPackages.Items.Add(_Packages[i].Name); // عرض اسم الباكدج فقط
            }
        }

        private void CalculateThePRiceForTheCustomer_Click(object sender, EventArgs e)
        {
            if (comboBoxPackages.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار باكدج واحدة على الأقل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal thePriceOfThePackage = dicforPackages[comboBoxPackages.SelectedIndex].Item2; // سعر الباكدج المختارة فقط

            // التحقق من صحة رقم الهاتف
            string pattern = @"^01[0125]\d{8}$";
            if (!Regex.IsMatch(textBoxCustomerPhone.Text, pattern))
            {
                MessageBox.Show("رقم الموبايل يجب أن يبدأ بـ 010 أو 011 أو 012 أو 015", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customer = context.Customers.FirstOrDefault(x => x.PhoneNumber == textBoxCustomerPhone.Text);
            if (customer == null)
            {
                MessageBox.Show($"هذا العميل أول مرة يزورنا، وهذا هو حسابه: {thePriceOfThePackage} ج", "حساب العميل");
                return;
            }

            DialogResult result = MessageBox.Show($"حساب العميل: {thePriceOfThePackage} جنيه\nهل ترغب في حفظ هذه البيانات؟", "حساب العميل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int packageId = dicforPackages[comboBoxPackages.SelectedIndex].Item1;
                string employeeNationalID = comboBoxEmployees.SelectedValue.ToString();
                DateTime dateTime = DateTime.Now;

                // Insert into PackageCustomer table
                context.PackageCustomers.Add(new PackageCustomer
                {
                    CustomerId = customer.Code,
                    PackageId = packageId,
                    Deposit = 0, // This could be dynamic based on your requirements
                    TakeDate = dateTime
                });


                context.SaveChanges();

                // إعادة ضبط الحقول
                comboBoxPackages.SelectedIndex = -1;
                textBoxCustomerPhone.Text = string.Empty;
                fillThePackages();

            }
        }
        }

       
    }



