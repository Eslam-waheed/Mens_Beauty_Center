namespace Mens_Beauty_Center
{
    partial class AddPackageCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblEmployeeStatus = new System.Windows.Forms.Label();
            this.CalculateThePRiceForTheCustomer = new System.Windows.Forms.Button();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.comboBoxPackages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "عرض باكج العميل";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(197, 122);
            this.textBoxCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(288, 30);
            this.textBoxCustomerPhone.TabIndex = 5;
            // 
            // lblEmployeeStatus
            // 
            this.lblEmployeeStatus.AutoSize = true;
            this.lblEmployeeStatus.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblEmployeeStatus.Location = new System.Drawing.Point(556, 195);
            this.lblEmployeeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeStatus.Name = "lblEmployeeStatus";
            this.lblEmployeeStatus.Size = new System.Drawing.Size(118, 30);
            this.lblEmployeeStatus.TabIndex = 9;
            this.lblEmployeeStatus.Text = "الموظفين ";
            // 
            // CalculateThePRiceForTheCustomer
            // 
            this.CalculateThePRiceForTheCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateThePRiceForTheCustomer.Location = new System.Drawing.Point(197, 339);
            this.CalculateThePRiceForTheCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CalculateThePRiceForTheCustomer.Name = "CalculateThePRiceForTheCustomer";
            this.CalculateThePRiceForTheCustomer.Size = new System.Drawing.Size(313, 39);
            this.CalculateThePRiceForTheCustomer.TabIndex = 22;
            this.CalculateThePRiceForTheCustomer.Text = "حساب الباكج";
            this.CalculateThePRiceForTheCustomer.UseVisualStyleBackColor = true;
            this.CalculateThePRiceForTheCustomer.Click += new System.EventHandler(this.CalculateThePRiceForTheCustomer_Click);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(197, 197);
            this.comboBoxEmployees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(288, 24);
            this.comboBoxEmployees.TabIndex = 13;
            // 
            // comboBoxPackages
            // 
            this.comboBoxPackages.FormattingEnabled = true;
            this.comboBoxPackages.Location = new System.Drawing.Point(197, 271);
            this.comboBoxPackages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPackages.Name = "comboBoxPackages";
            this.comboBoxPackages.Size = new System.Drawing.Size(288, 24);
            this.comboBoxPackages.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(572, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "الباكج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "هاتف العميل";
            // 
            // AddPackageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.CalculateThePRiceForTheCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPackages);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.lblEmployeeStatus);
            this.Controls.Add(this.textBoxCustomerPhone);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddPackageCustomer";
            this.Text = "AddPackageCustomer";
            this.Load += new System.EventHandler(this.AddPackageCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label lblEmployeeStatus;
        private System.Windows.Forms.Button CalculateThePRiceForTheCustomer;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.ComboBox comboBoxPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}