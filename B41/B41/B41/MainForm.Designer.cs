namespace B41
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            commonText = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBoxKN = new PictureBox();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            pictureBoxBia = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBia).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1363, 700);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1355, 667);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quy tắc chung";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(commonText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 661);
            panel1.TabIndex = 0;
            // 
            // commonText
            // 
            commonText.BackColor = Color.White;
            commonText.Location = new Point(7, 6);
            commonText.Multiline = true;
            commonText.Name = "commonText";
            commonText.Size = new Size(617, 652);
            commonText.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(630, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 652);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBoxKN);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(pictureBoxBia);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1355, 667);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bắn mục tiêu cố định";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxKN
            // 
            pictureBoxKN.Image = Properties.Resources.KNB41;
            pictureBoxKN.Location = new Point(510, 144);
            pictureBoxKN.Name = "pictureBoxKN";
            pictureBoxKN.Size = new Size(407, 462);
            pictureBoxKN.TabIndex = 2;
            pictureBoxKN.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(863, 12);
            button4.Name = "button4";
            button4.Size = new Size(194, 34);
            button4.TabIndex = 1;
            button4.Text = "Đặt hướng gió";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(612, 12);
            button6.Name = "button6";
            button6.Size = new Size(140, 29);
            button6.TabIndex = 0;
            button6.Text = "Bia số 12b";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(466, 12);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 0;
            button5.Text = "Bia số 11b";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(320, 12);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 0;
            button3.Text = "Bia số 15";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(174, 12);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 0;
            button2.Text = "Bia số 12";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(28, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 0;
            button1.Text = "Bia số 11";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1355, 667);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bắn bài 1";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBia
            // 
            pictureBoxBia.Location = new Point(430, 64);
            pictureBoxBia.Name = "pictureBoxBia";
            pictureBoxBia.Size = new Size(564, 510);
            pictureBoxBia.TabIndex = 3;
            pictureBoxBia.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 713);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxKN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox commonText;
        private PictureBox pictureBox1;
        private TabPage tabPage3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button6;
        private Button button5;
        private PictureBox pictureBoxKN;
        private PictureBox pictureBoxBia;
    }
}
