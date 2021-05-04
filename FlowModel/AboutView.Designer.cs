using System.ComponentModel;

namespace FlowModel
{
    partial class AboutView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Version = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Discription_third_line = new System.Windows.Forms.Label();
            this.Discription_second_line = new System.Windows.Forms.Label();
            this.Discription_first_line = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(20, 204);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(133, 13);
            this.Version.TabIndex = 19;
            this.Version.Text = "Version: 1.2    03/05/2021";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Author.Location = new System.Drawing.Point(20, 189);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(284, 15);
            this.Author.TabIndex = 18;
            this.Author.Text = "Грищенков Никита, гр.№ 485, 2021, СПбГТИ(ТУ)";
            // 
            // Discription_third_line
            // 
            this.Discription_third_line.AutoSize = true;
            this.Discription_third_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Discription_third_line.Location = new System.Drawing.Point(20, 126);
            this.Discription_third_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_third_line.Name = "Discription_third_line";
            this.Discription_third_line.Size = new System.Drawing.Size(381, 17);
            this.Discription_third_line.TabIndex = 17;
            this.Discription_third_line.Text = "верхней крышкой (скорости и температуры крышки) на ";
            // 
            // Discription_second_line
            // 
            this.Discription_second_line.AutoSize = true;
            this.Discription_second_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Discription_second_line.Location = new System.Drawing.Point(20, 109);
            this.Discription_second_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_second_line.Name = "Discription_second_line";
            this.Discription_second_line.Size = new System.Drawing.Size(449, 17);
            this.Discription_second_line.TabIndex = 16;
            this.Discription_second_line.Text = "расплавленного материала в прямоугольном канале с подвижной ";
            // 
            // Discription_first_line
            // 
            this.Discription_first_line.AutoSize = true;
            this.Discription_first_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Discription_first_line.Location = new System.Drawing.Point(20, 92);
            this.Discription_first_line.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Discription_first_line.Name = "Discription_first_line";
            this.Discription_first_line.Size = new System.Drawing.Size(440, 17);
            this.Discription_first_line.TabIndex = 15;
            this.Discription_first_line.Text = "Исследования влияния режимных параметров процесса течения";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Title.Location = new System.Drawing.Point(20, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(304, 63);
            this.Title.TabIndex = 14;
            this.Title.Text = "Flow Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(20, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "производительность канала и показатели качества (температуру, вязкость) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "продукта для различных геометрических параметров каналов и типов материалов";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Discription_third_line);
            this.Controls.Add(this.Discription_second_line);
            this.Controls.Add(this.Discription_first_line);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Discription_first_line;
        private System.Windows.Forms.Label Discription_second_line;
        private System.Windows.Forms.Label Discription_third_line;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;

        #endregion
    }
}