namespace Tic_Tac_Tok
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            restart = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Image = Properties.Resources.s;
            button1.Location = new Point(416, 30);
            button1.Name = "button1";
            button1.Size = new Size(149, 122);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.s;
            button2.Location = new Point(642, 30);
            button2.Name = "button2";
            button2.Size = new Size(149, 122);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.s;
            button3.Location = new Point(867, 30);
            button3.Name = "button3";
            button3.Size = new Size(149, 122);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(243, 62);
            label1.TabIndex = 6;
            label1.Text = "GAME_START";
            label1.Click += label1_Click;
            // 
            // restart
            // 
            restart.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            restart.Location = new Point(89, 197);
            restart.Name = "restart";
            restart.Size = new Size(127, 49);
            restart.TabIndex = 10;
            restart.Text = "RESTART GAME";
            restart.Click += restart_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.s;
            button4.Location = new Point(867, 197);
            button4.Name = "button4";
            button4.Size = new Size(149, 122);
            button4.TabIndex = 13;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.s;
            button5.Location = new Point(642, 197);
            button5.Name = "button5";
            button5.Size = new Size(149, 122);
            button5.TabIndex = 12;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.s;
            button6.Location = new Point(416, 197);
            button6.Name = "button6";
            button6.Size = new Size(149, 122);
            button6.TabIndex = 11;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.s;
            button7.Location = new Point(867, 369);
            button7.Name = "button7";
            button7.Size = new Size(149, 122);
            button7.TabIndex = 16;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.s;
            button8.Location = new Point(642, 369);
            button8.Name = "button8";
            button8.Size = new Size(149, 122);
            button8.TabIndex = 15;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Image = Properties.Resources.s;
            button9.Location = new Point(416, 369);
            button9.Name = "button9";
            button9.Size = new Size(149, 122);
            button9.TabIndex = 14;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(51, 107);
            button10.Name = "button10";
            button10.Size = new Size(98, 67);
            button10.TabIndex = 17;
            button10.Text = "PLAYER 1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(155, 108);
            button11.Name = "button11";
            button11.Size = new Size(98, 66);
            button11.TabIndex = 18;
            button11.Text = "PLAYER 2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(39, 420);
            label2.Name = "label2";
            label2.Size = new Size(145, 71);
            label2.TabIndex = 19;
            label2.Text = "Design By Danya Muna";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1037, 518);
            Controls.Add(label2);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(restart);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label restart;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label2;
    }
}
