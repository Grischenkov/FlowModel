namespace FlowModel
{
    partial class ParameterInput
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_Label = new System.Windows.Forms.Label();
            this.value_TextBox = new System.Windows.Forms.TextBox();
            this.unit_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_Label
            // 
            this.name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_Label.Location = new System.Drawing.Point(8, 5);
            this.name_Label.Name = "name_Label";
            this.name_Label.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.name_Label.Size = new System.Drawing.Size(203, 23);
            this.name_Label.TabIndex = 0;
            // 
            // value_TextBox
            // 
            this.value_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.value_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.value_TextBox.Location = new System.Drawing.Point(217, 8);
            this.value_TextBox.Name = "value_TextBox";
            this.value_TextBox.Size = new System.Drawing.Size(98, 20);
            this.value_TextBox.TabIndex = 1;
            this.value_TextBox.TabStop = false;
            this.value_TextBox.Enter += new System.EventHandler(this.Clear);
            this.value_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInput);
            this.value_TextBox.Leave += new System.EventHandler(this.Validate);
            // 
            // unit_Label
            // 
            this.unit_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unit_Label.Location = new System.Drawing.Point(321, 5);
            this.unit_Label.Name = "unit_Label";
            this.unit_Label.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.unit_Label.Size = new System.Drawing.Size(99, 23);
            this.unit_Label.TabIndex = 2;
            this.unit_Label.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.value_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.unit_Label, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 33);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ParameterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ParameterInput";
            this.Size = new System.Drawing.Size(428, 33);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox value_TextBox;
        private System.Windows.Forms.Label unit_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
