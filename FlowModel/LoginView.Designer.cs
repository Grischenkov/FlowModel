namespace FlowModel
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.login_GroupBox = new System.Windows.Forms.GroupBox();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.password_GroupBox = new System.Windows.Forms.GroupBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.login_Button = new System.Windows.Forms.Button();
            this.login_GroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.password_GroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_GroupBox
            // 
            this.login_GroupBox.Controls.Add(this.login_TextBox);
            this.login_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.login_GroupBox.Name = "login_GroupBox";
            this.login_GroupBox.Size = new System.Drawing.Size(559, 50);
            this.login_GroupBox.TabIndex = 2;
            this.login_GroupBox.TabStop = false;
            this.login_GroupBox.Text = "Логин:";
            // 
            // login_TextBox
            // 
            this.login_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_TextBox.Location = new System.Drawing.Point(3, 16);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(553, 20);
            this.login_TextBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.login_GroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.password_GroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 224);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // password_GroupBox
            // 
            this.password_GroupBox.Controls.Add(this.password_TextBox);
            this.password_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_GroupBox.Location = new System.Drawing.Point(3, 59);
            this.password_GroupBox.Name = "password_GroupBox";
            this.password_GroupBox.Size = new System.Drawing.Size(559, 50);
            this.password_GroupBox.TabIndex = 3;
            this.password_GroupBox.TabStop = false;
            this.password_GroupBox.Text = "Пароль:";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_TextBox.Location = new System.Drawing.Point(3, 16);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(553, 20);
            this.password_TextBox.TabIndex = 0;
            this.password_TextBox.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.login_Button, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 106);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // login_Button
            // 
            this.login_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_Button.Location = new System.Drawing.Point(189, 34);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(180, 36);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "Войти";
            this.login_Button.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.login_GroupBox.ResumeLayout(false);
            this.login_GroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.password_GroupBox.ResumeLayout(false);
            this.password_GroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_GroupBox;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox password_GroupBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button login_Button;
    }
}