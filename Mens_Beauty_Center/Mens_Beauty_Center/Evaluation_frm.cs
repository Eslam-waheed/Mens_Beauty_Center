using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class Evaluation_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();
        Evaluation ev;

        public Evaluation_frm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";
            dateTimePicker1.ShowUpDown = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void fillDGV()
        {
            // استعلام لربط جدول Evaluation مع Employee واسترجاع البيانات المطلوبة
            var q2 = from evv in my_context.Evaluations
                     join empp in my_context.Employees on evv.NationalID equals empp.NationalID
                     select new
                     {
                         ID = evv.NationalID,
                         Month = evv.Month,
                         TotalAmountOfMonth = evv.TotalAmountOfMonth,
                         ProfitPercentage = evv.ProfitPercentage,
                         Bonus = evv.Bonus,
                         FirstName = empp.FirstName
                     };

            // تعيين البيانات إلى DataGridView
            dataGridView1.DataSource = q2.ToList();

            // تخصيص أسماء الأعمدة المعروضة في DataGridView
            dataGridView1.Columns["ID"].HeaderText = "رقم العامل";
            dataGridView1.Columns["Month"].HeaderText = "الشهر";
            dataGridView1.Columns["TotalAmountOfMonth"].HeaderText = "إجمالي الشهر";
            dataGridView1.Columns["ProfitPercentage"].HeaderText = "النسبة";
            dataGridView1.Columns["Bonus"].HeaderText = "الإضافي";
            dataGridView1.Columns["FirstName"].HeaderText = "اسم العامل";
        }

        private void clear_txts()
        {
            txt_percent.Text = "";
        }

        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    if (decimal.Parse(txt_percent.Text) > 10)
        //    {
        //        MessageBox.Show("النسبة المدخلة لا يمكن أن تكون أكثر من 10%", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // استخراج رقم الشهر فقط
        //    int selectedMonthNumber = dateTimePicker1.Value.Month;

        //    // تحويل رقم الشهر إلى نص بصيغة مكونة من خانتين
        //    string selectedMonthString = selectedMonthNumber.ToString("D2");

        //    // التحقق مما إذا كان قد تم إضافة تقييم لهذا الشهر مسبقًا
        //    var month = my_context.Evaluations
        //                    .Select(mo => mo.Month)
        //                    .Distinct() // لإرجاع الأشهر الفريدة فقط
        //                    .FirstOrDefault();

        //    var existingEvaluation = my_context.Evaluations
        //        .FirstOrDefault(x => x.Month == month);

        //    if (existingEvaluation != null)
        //    {
        //        MessageBox.Show("تم إضافة تقييم لهذا الشهر مسبقًا.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // إذا لم يتم إضافة التقييم مسبقًا، أضفه الآن
        //    DialogResult result = MessageBox.Show("هل انت متاكد من إضافة الحوافز لهذا الشهر؟", "إضافة التقييم", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        //    if (result == DialogResult.No)
        //    {
        //        return;
        //    }
        //    else if (result == DialogResult.Yes)
        //    {
        //        my_context.SP_InsertEmployeeEvaluationWithPackages(selectedMonthString, decimal.Parse(txt_percent.Text));
        //        my_context.SaveChanges();

        //        MessageBox.Show("تم إضافة التقييم بنجاح!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // تفريغ الحقول بعد الإضافة
        //        clear_txts();
        //        // تحديث بيانات DataGridView
        //        fillDGV();
        //    }
        //}

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txt_percent.Text, out var percent))
                {
                    MessageBox.Show("Please enter a valid percentage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (percent > 10)
                {
                    MessageBox.Show("The percentage cannot be more than 10%.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedMonthNumber = dateTimePicker1.Value.Month;
                string selectedMonthString = selectedMonthNumber.ToString("D2");

                var existingEvaluation = my_context.Evaluations
                    .FirstOrDefault(x => x.Month == selectedMonthString);

                if (existingEvaluation != null)
                {
                    MessageBox.Show("تم إضافة تقييم لهذا الشهر مسبقًا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("هل انت متاكد من إضافة الحوافز لهذا الشهر؟", "Add Evaluation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    my_context.SP_InsertEmployeeEvaluationWithPackages(selectedMonthString, percent);
                    my_context.SaveChanges();

                    MessageBox.Show("تم إضافة التقييم بنجاح!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear_txts();
                    fillDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.MidnightBlue;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.SteelBlue;
        }

        private void Evaluation_frm_Load(object sender, EventArgs e)
        {
            fillDGV();
        }

    }
}
