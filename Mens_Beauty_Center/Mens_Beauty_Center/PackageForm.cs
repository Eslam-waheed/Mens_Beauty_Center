using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class PackageForm : Form
    {
        private int selectedPackageId = -1;
        public PackageForm()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من غلق هذه الصفحه؟", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();

        #region load data
        private void LoadPackages()
        {
            try
            {
                var packages = context.Packages.Select(p => new
                {
                    p.ID,
                    p.Name,
                    p.Description,
                    p.TotalAmount
                }).ToList();

                dataGridView1.Rows.Clear();
                foreach (var package in packages)
                {
                    dataGridView1.Rows.Add(package.ID, package.Name, package.Description, package.TotalAmount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PackageForm_Load(object sender, EventArgs e)
        {
            LoadPackages();
        }
        #endregion

        #region add Package
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string packageName = PackageNameTxt.Text;
            string description = DescriptionTxt.Text;
            decimal price;

            if (decimal.TryParse(PriceTxt.Text, out price))
            {
                // Show confirmation dialog before adding the package
                DialogResult confirmationResult = MessageBox.Show("هل انت متاكد من اضافه هذه البكج؟", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationResult == DialogResult.Yes)
                {
                    try
                    {
                        var result = context.SP_AddPackage(packageName, description, price);
                        if (result > 0)
                        {
                            LoadPackages(); // Reload the DataGridView

                            PackageNameTxt.Clear();
                            DescriptionTxt.Clear();
                            PriceTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the package. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("يجب عليك املاء البيانات للاضافه؟", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPackages2()
        {
            dataGridView1.Rows.Clear();
            var packages = context.Packages.ToList(); // Assuming 'Packages' is the table name

            foreach (var package in packages)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = package.Name;
                row.Cells[1].Value = package.Description;
                row.Cells[2].Value = package.TotalAmount.ToString("C2");
                dataGridView1.Rows.Add(row);
            }
        }

        #endregion

        #region Update Package
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedPackageId != -1) // Ensure a package is selected
            {
                string newName = PackageNameTxt.Text;
                string newDescription = DescriptionTxt.Text;
                decimal newTotalAmount;

                if (decimal.TryParse(PriceTxt.Text, out newTotalAmount))
                {
                    DialogResult confirmResult = MessageBox.Show("هل انت متاكد من تحديث هذه البكج؟",
                                                                 "Confirm Update",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new Mens_Beauty_Center_DBEntities())
                            {
                                var result = context.SP_UpdatePackage(selectedPackageId, newName, newDescription, newTotalAmount);

                                if (result != null && result.Any())
                                {
                                    // Update the DataGridView to reflect the changes
                                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                                    selectedRow.Cells["Package_Name"].Value = newName;
                                    selectedRow.Cells["PackageDescription"].Value = newDescription;
                                    selectedRow.Cells["PackagePrice"].Value = newTotalAmount.ToString("C2");

                                    MessageBox.Show("تم التحديث بنجاح");

                                    PackageNameTxt.Clear();
                                    DescriptionTxt.Clear();
                                    PriceTxt.Clear();

                                    selectedPackageId = -1; // Reset the selected package ID
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a package to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion



        #region DataGridView CellClick Event
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                selectedPackageId = Convert.ToInt32(selectedRow.Cells["Package_ID"].Value);
                PackageNameTxt.Text = selectedRow.Cells["Package_Name"].Value.ToString();
                DescriptionTxt.Text = selectedRow.Cells["PackageDescription"].Value.ToString();
                PriceTxt.Text = selectedRow.Cells["PackagePrice"].Value.ToString();
            }
        }
        #endregion
    }
}
