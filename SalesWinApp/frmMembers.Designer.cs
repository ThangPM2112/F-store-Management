namespace SalesWinApp
{
    partial class frmMembers
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberId = new TextBox();
            txtEmail = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnUpdate = new Button();
            btnViewOrder = new Button();
            btnExit = new Button();
            btnOrder = new Button();
            btnProduct = new Button();
            gvMember = new DataGridView();
            btnDelete = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)gvMember).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 7);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 58);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Member ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 91);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 124);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 1;
            label4.Text = "Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 58);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 1;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 91);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 1;
            label6.Text = "Country";
            label6.Click += label6_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(150, 50);
            txtMemberId.Margin = new Padding(3, 2, 3, 2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(140, 23);
            txtMemberId.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 83);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(140, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(150, 116);
            txtCompany.Margin = new Padding(3, 2, 3, 2);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(140, 23);
            txtCompany.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(401, 52);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(162, 23);
            txtCity.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(401, 83);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(162, 23);
            txtCountry.TabIndex = 2;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(104, 160);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Location = new Point(301, 160);
            btnViewOrder.Margin = new Padding(3, 2, 3, 2);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(82, 22);
            btnViewOrder.TabIndex = 3;
            btnViewOrder.Text = "View Order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(607, 160);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(401, 160);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(82, 22);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(504, 160);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(82, 22);
            btnProduct.TabIndex = 5;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // gvMember
            // 
            gvMember.AllowUserToAddRows = false;
            gvMember.AllowUserToDeleteRows = false;
            gvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvMember.Location = new Point(-2, 245);
            gvMember.Margin = new Padding(3, 2, 3, 2);
            gvMember.MultiSelect = false;
            gvMember.Name = "gvMember";
            gvMember.ReadOnly = true;
            gvMember.RowHeadersWidth = 51;
            gvMember.RowTemplate.Height = 29;
            gvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvMember.Size = new Size(705, 137);
            gvMember.TabIndex = 6;
            gvMember.CellClick += gvMember_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 160);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(10, 160);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(gvMember);
            Controls.Add(btnProduct);
            Controls.Add(btnOrder);
            Controls.Add(btnExit);
            Controls.Add(btnViewOrder);
            Controls.Add(btnUpdate);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMembers";
            Text = "frmMember";
            WindowState = FormWindowState.Maximized;
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)gvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnUpdate;
        private Button btnViewOrder;
        private Button btnExit;
        private Button btnOrder;
        private Button btnProduct;
        private DataGridView gvMember;
        private Button btnDelete;
        private Button btnCreate;
    }
}