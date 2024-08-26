using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    partial class PackageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Package_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PackageNameTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package_ID,
            this.Package_Name,
            this.PackageDescription,
            this.PackagePrice});
            this.dataGridView1.Location = new System.Drawing.Point(584, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(576, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // Package_ID
            // 
            this.Package_ID.HeaderText = "الرقم";
            this.Package_ID.MinimumWidth = 6;
            this.Package_ID.Name = "Package_ID";
            // 
            // Package_Name
            // 
            this.Package_Name.HeaderText = "الاسم";
            this.Package_Name.MinimumWidth = 6;
            this.Package_Name.Name = "Package_Name";
            // 
            // PackageDescription
            // 
            this.PackageDescription.HeaderText = "المحتويات";
            this.PackageDescription.MinimumWidth = 6;
            this.PackageDescription.Name = "PackageDescription";
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "السعر";
            this.PackagePrice.MinimumWidth = 6;
            this.PackagePrice.Name = "PackagePrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "بكج العريس";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(216, 475);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "اضافه";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(57, 475);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 37);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "تعديل";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = ":اسم البكج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = ":محتويات البكج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = ":سعر البكج";
            // 
            // PackageNameTxt
            // 
            this.PackageNameTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageNameTxt.Location = new System.Drawing.Point(56, 103);
            this.PackageNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PackageNameTxt.Name = "PackageNameTxt";
            this.PackageNameTxt.Size = new System.Drawing.Size(259, 32);
            this.PackageNameTxt.TabIndex = 6;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(57, 171);
            this.DescriptionTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(259, 185);
            this.DescriptionTxt.TabIndex = 7;
            this.DescriptionTxt.Text = "";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.Location = new System.Drawing.Point(59, 409);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(257, 32);
            this.PriceTxt.TabIndex = 8;
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 551);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.PackageNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PackageForm";
            this.Text = "PckageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PackageNameTxt;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private DataGridViewTextBoxColumn Package_ID;
        private DataGridViewTextBoxColumn Package_Name;
        private DataGridViewTextBoxColumn PackageDescription;
        private DataGridViewTextBoxColumn PackagePrice;
    }
}