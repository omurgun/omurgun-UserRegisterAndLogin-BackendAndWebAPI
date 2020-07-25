namespace UserRAL.WindowsFormsUI
{
    partial class Form1
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
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxUserPasswordLogin = new System.Windows.Forms.TextBox();
            this.tbxUserNameLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxRoleUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUserSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxUserPasswordUpdate = new System.Windows.Forms.TextBox();
            this.tbxUserEmailUpdate = new System.Windows.Forms.TextBox();
            this.tbxUserUserNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxUserNameUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.tbxUserSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUserPassword = new System.Windows.Forms.TextBox();
            this.tbxUserEmail = new System.Windows.Forms.TextBox();
            this.tbxUserUserName = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUniy = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUsers
            // 
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(480, 0);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(1064, 784);
            this.dgwUsers.TabIndex = 19;
            this.dgwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsers_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.tbxUserPasswordLogin);
            this.groupBox1.Controls.Add(this.tbxUserNameLogin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(1570, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 223);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tbxUserPasswordLogin
            // 
            this.tbxUserPasswordLogin.Location = new System.Drawing.Point(114, 104);
            this.tbxUserPasswordLogin.Name = "tbxUserPasswordLogin";
            this.tbxUserPasswordLogin.Size = new System.Drawing.Size(157, 20);
            this.tbxUserPasswordLogin.TabIndex = 22;
            // 
            // tbxUserNameLogin
            // 
            this.tbxUserNameLogin.Location = new System.Drawing.Point(115, 53);
            this.tbxUserNameLogin.Name = "tbxUserNameLogin";
            this.tbxUserNameLogin.Size = new System.Drawing.Size(157, 20);
            this.tbxUserNameLogin.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Şifre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kullanıcı Adı  :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(123, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 33);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1570, 37);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 33);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxUpdate.Controls.Add(this.label6);
            this.gbxUpdate.Controls.Add(this.cbxRoleUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUserSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUserPasswordUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUserEmailUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUserUserNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUserNameUpdate);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.label5);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(1570, 86);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(338, 391);
            this.gbxUpdate.TabIndex = 28;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Kullanıcı Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Roller :";
            // 
            // cbxRoleUpdate
            // 
            this.cbxRoleUpdate.FormattingEnabled = true;
            this.cbxRoleUpdate.Location = new System.Drawing.Point(113, 269);
            this.cbxRoleUpdate.Name = "cbxRoleUpdate";
            this.cbxRoleUpdate.Size = new System.Drawing.Size(157, 21);
            this.cbxRoleUpdate.TabIndex = 24;
            // 
            // tbxUserSurnameUpdate
            // 
            this.tbxUserSurnameUpdate.Location = new System.Drawing.Point(113, 95);
            this.tbxUserSurnameUpdate.Name = "tbxUserSurnameUpdate";
            this.tbxUserSurnameUpdate.Size = new System.Drawing.Size(157, 20);
            this.tbxUserSurnameUpdate.TabIndex = 23;
            // 
            // tbxUserPasswordUpdate
            // 
            this.tbxUserPasswordUpdate.Location = new System.Drawing.Point(113, 226);
            this.tbxUserPasswordUpdate.Name = "tbxUserPasswordUpdate";
            this.tbxUserPasswordUpdate.Size = new System.Drawing.Size(157, 20);
            this.tbxUserPasswordUpdate.TabIndex = 22;
            // 
            // tbxUserEmailUpdate
            // 
            this.tbxUserEmailUpdate.Location = new System.Drawing.Point(113, 183);
            this.tbxUserEmailUpdate.Name = "tbxUserEmailUpdate";
            this.tbxUserEmailUpdate.Size = new System.Drawing.Size(157, 20);
            this.tbxUserEmailUpdate.TabIndex = 21;
            // 
            // tbxUserUserNameUpdate
            // 
            this.tbxUserUserNameUpdate.Location = new System.Drawing.Point(113, 139);
            this.tbxUserUserNameUpdate.Name = "tbxUserUserNameUpdate";
            this.tbxUserUserNameUpdate.Size = new System.Drawing.Size(157, 20);
            this.tbxUserUserNameUpdate.TabIndex = 20;
            // 
            // tbxUserNameUpdate
            // 
            this.tbxUserNameUpdate.Location = new System.Drawing.Point(113, 54);
            this.tbxUserNameUpdate.Name = "tbxUserNameUpdate";
            this.tbxUserNameUpdate.Size = new System.Drawing.Size(157, 20);
            this.tbxUserNameUpdate.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kullanıcı Adı  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ad :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxProductAdd.Controls.Add(this.tbxUserSurname);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUserPassword);
            this.gbxProductAdd.Controls.Add(this.tbxUserEmail);
            this.gbxProductAdd.Controls.Add(this.tbxUserUserName);
            this.gbxProductAdd.Controls.Add(this.tbxUserName);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUniy);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(41, 356);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(354, 367);
            this.gbxProductAdd.TabIndex = 32;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Kullanıcı Ekle";
            // 
            // tbxUserSurname
            // 
            this.tbxUserSurname.Location = new System.Drawing.Point(110, 82);
            this.tbxUserSurname.Name = "tbxUserSurname";
            this.tbxUserSurname.Size = new System.Drawing.Size(157, 20);
            this.tbxUserSurname.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUserPassword
            // 
            this.tbxUserPassword.Location = new System.Drawing.Point(110, 213);
            this.tbxUserPassword.Name = "tbxUserPassword";
            this.tbxUserPassword.Size = new System.Drawing.Size(157, 20);
            this.tbxUserPassword.TabIndex = 10;
            // 
            // tbxUserEmail
            // 
            this.tbxUserEmail.Location = new System.Drawing.Point(110, 170);
            this.tbxUserEmail.Name = "tbxUserEmail";
            this.tbxUserEmail.Size = new System.Drawing.Size(157, 20);
            this.tbxUserEmail.TabIndex = 9;
            // 
            // tbxUserUserName
            // 
            this.tbxUserUserName.Location = new System.Drawing.Point(110, 126);
            this.tbxUserUserName.Name = "tbxUserUserName";
            this.tbxUserUserName.Size = new System.Drawing.Size(157, 20);
            this.tbxUserUserName.TabIndex = 8;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(110, 41);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(157, 20);
            this.tbxUserName.TabIndex = 7;
            // 
            // lblQuantityPerUniy
            // 
            this.lblQuantityPerUniy.AutoSize = true;
            this.lblQuantityPerUniy.Location = new System.Drawing.Point(21, 217);
            this.lblQuantityPerUniy.Name = "lblQuantityPerUniy";
            this.lblQuantityPerUniy.Size = new System.Drawing.Size(34, 13);
            this.lblQuantityPerUniy.TabIndex = 6;
            this.lblQuantityPerUniy.Text = "Şifre :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(21, 171);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Email :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(19, 133);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(73, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Kullanıcı Adı  :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(19, 89);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(43, 13);
            this.lblCategoryId.TabIndex = 3;
            this.lblCategoryId.Text = "Soyad :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 48);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(26, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ad :";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(24, 170);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(396, 131);
            this.gbxSearch.TabIndex = 31;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Kullanıcı Adına Göre Ara";

            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(113, 64);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(268, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(45, 67);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara :";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblRole);
            this.gbxCategory.Controls.Add(this.cbxRole);
            this.gbxCategory.Location = new System.Drawing.Point(24, 37);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(396, 109);
            this.gbxCategory.TabIndex = 30;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Role Göre Listele";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(45, 69);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Roller :";
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(113, 66);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(268, 21);
            this.cbxRole.TabIndex = 0;
            this.cbxRole.SelectedIndexChanged += new System.EventHandler(this.cbxRole_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 858);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.dgwUsers);
            this.Name = "Form1";
            this.Text = "UserRegisterAndLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxUserPasswordLogin;
        private System.Windows.Forms.TextBox tbxUserNameLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxRoleUpdate;
        private System.Windows.Forms.TextBox tbxUserSurnameUpdate;
        private System.Windows.Forms.TextBox tbxUserPasswordUpdate;
        private System.Windows.Forms.TextBox tbxUserEmailUpdate;
        private System.Windows.Forms.TextBox tbxUserUserNameUpdate;
        private System.Windows.Forms.TextBox tbxUserNameUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox tbxUserSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUserPassword;
        private System.Windows.Forms.TextBox tbxUserEmail;
        private System.Windows.Forms.TextBox tbxUserUserName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblQuantityPerUniy;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbxRole;
    }
}

