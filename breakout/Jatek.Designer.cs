namespace breakout
{
    partial class Jatek
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
            components = new System.ComponentModel.Container();
            labda = new Ball();
            deszka = new Board();
            gameTimer = new System.Windows.Forms.Timer(components);
            button1 = new Brick();
            button2 = new Brick();
            button3 = new Brick();
            button4 = new Brick();
            button5 = new Brick();
            button6 = new Brick();
            button7 = new Brick();
            button8 = new Brick();
            button9 = new Brick();
            button10 = new Brick();
            button11 = new Brick();
            button12 = new Brick();
            button13 = new Brick();
            button14 = new Brick();
            button15 = new Brick();
            button16 = new Brick();
            button17 = new Brick();
            button18 = new Brick();
            button19 = new Brick();
            button20 = new Brick();
            button21 = new Brick();
            button22 = new Brick();
            button23 = new Brick();
            button24 = new Brick();
            button25 = new Brick();
            button26 = new Brick();
            button27 = new Brick();
            button28 = new Brick();
            button29 = new Brick();
            button30 = new Brick();
            livesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)deszka).BeginInit();
            SuspendLayout();
            // 
            // labda
            // 
            labda.AutoSize = true;
            labda.Checked = true;
            labda.Location = new Point(421, 500);
            labda.Name = "labda";
            labda.Size = new Size(14, 13);
            labda.TabIndex = 0;
            labda.TabStop = true;
            labda.UseVisualStyleBackColor = true;
            labda.X = 3;
            labda.XAlap = 3;
            labda.XKezdo = 421;
            labda.XTouchCount = 1;
            labda.Y = 3;
            labda.YAlap = 3;
            labda.YKezdo = 500;
            labda.YTouchCount = 1;
            // 
            // deszka
            // 
            deszka.Location = new Point(355, 525);
            deszka.Name = "deszka";
            deszka.ReadOnly = true;
            deszka.Size = new Size(147, 23);
            deszka.TabIndex = 1;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 25;
            gameTimer.Tick += mainGameTimer;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 65);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 2;
            button1.Tag = "Brick";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(144, 65);
            button2.Name = "button2";
            button2.Size = new Size(126, 47);
            button2.TabIndex = 3;
            button2.Tag = "Brick";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(12, 118);
            button3.Name = "button3";
            button3.Size = new Size(126, 47);
            button3.TabIndex = 4;
            button3.Tag = "Brick";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(408, 65);
            button4.Name = "button4";
            button4.Size = new Size(126, 47);
            button4.TabIndex = 5;
            button4.Tag = "Brick";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(540, 65);
            button5.Name = "button5";
            button5.Size = new Size(126, 47);
            button5.TabIndex = 6;
            button5.Tag = "Brick";
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F);
            button6.Location = new Point(672, 65);
            button6.Name = "button6";
            button6.Size = new Size(126, 47);
            button6.TabIndex = 7;
            button6.Tag = "Brick";
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F);
            button7.Location = new Point(276, 65);
            button7.Name = "button7";
            button7.Size = new Size(126, 47);
            button7.TabIndex = 8;
            button7.Tag = "Brick";
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F);
            button8.Location = new Point(144, 118);
            button8.Name = "button8";
            button8.Size = new Size(126, 47);
            button8.TabIndex = 9;
            button8.Tag = "Brick";
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15F);
            button9.Location = new Point(276, 118);
            button9.Name = "button9";
            button9.Size = new Size(126, 47);
            button9.TabIndex = 10;
            button9.Tag = "Brick";
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15F);
            button10.Location = new Point(408, 118);
            button10.Name = "button10";
            button10.Size = new Size(126, 47);
            button10.TabIndex = 11;
            button10.Tag = "Brick";
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15F);
            button11.Location = new Point(540, 118);
            button11.Name = "button11";
            button11.Size = new Size(126, 47);
            button11.TabIndex = 12;
            button11.Tag = "Brick";
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15F);
            button12.Location = new Point(672, 118);
            button12.Name = "button12";
            button12.Size = new Size(126, 47);
            button12.TabIndex = 13;
            button12.Tag = "Brick";
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 15F);
            button13.Location = new Point(12, 171);
            button13.Name = "button13";
            button13.Size = new Size(126, 47);
            button13.TabIndex = 14;
            button13.Tag = "Brick";
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 15F);
            button14.Location = new Point(144, 171);
            button14.Name = "button14";
            button14.Size = new Size(126, 47);
            button14.TabIndex = 15;
            button14.Tag = "Brick";
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 15F);
            button15.Location = new Point(276, 171);
            button15.Name = "button15";
            button15.Size = new Size(126, 47);
            button15.TabIndex = 16;
            button15.Tag = "Brick";
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 15F);
            button16.Location = new Point(408, 171);
            button16.Name = "button16";
            button16.Size = new Size(126, 47);
            button16.TabIndex = 17;
            button16.Tag = "Brick";
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 15F);
            button17.Location = new Point(540, 171);
            button17.Name = "button17";
            button17.Size = new Size(126, 47);
            button17.TabIndex = 18;
            button17.Tag = "Brick";
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 15F);
            button18.Location = new Point(672, 171);
            button18.Name = "button18";
            button18.Size = new Size(126, 47);
            button18.TabIndex = 19;
            button18.Tag = "Brick";
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 15F);
            button19.Location = new Point(12, 224);
            button19.Name = "button19";
            button19.Size = new Size(126, 47);
            button19.TabIndex = 20;
            button19.Tag = "Brick";
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 15F);
            button20.Location = new Point(144, 224);
            button20.Name = "button20";
            button20.Size = new Size(126, 47);
            button20.TabIndex = 21;
            button20.Tag = "Brick";
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 15F);
            button21.Location = new Point(276, 224);
            button21.Name = "button21";
            button21.Size = new Size(126, 47);
            button21.TabIndex = 22;
            button21.Tag = "Brick";
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 15F);
            button22.Location = new Point(408, 224);
            button22.Name = "button22";
            button22.Size = new Size(126, 47);
            button22.TabIndex = 23;
            button22.Tag = "Brick";
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 15F);
            button23.Location = new Point(540, 224);
            button23.Name = "button23";
            button23.Size = new Size(126, 47);
            button23.TabIndex = 24;
            button23.Tag = "Brick";
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 15F);
            button24.Location = new Point(672, 224);
            button24.Name = "button24";
            button24.Size = new Size(126, 47);
            button24.TabIndex = 25;
            button24.Tag = "Brick";
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Font = new Font("Segoe UI", 15F);
            button25.Location = new Point(12, 277);
            button25.Name = "button25";
            button25.Size = new Size(126, 47);
            button25.TabIndex = 26;
            button25.Tag = "Brick";
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Font = new Font("Segoe UI", 15F);
            button26.Location = new Point(144, 277);
            button26.Name = "button26";
            button26.Size = new Size(126, 47);
            button26.TabIndex = 27;
            button26.Tag = "Brick";
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Font = new Font("Segoe UI", 15F);
            button27.Location = new Point(276, 277);
            button27.Name = "button27";
            button27.Size = new Size(126, 47);
            button27.TabIndex = 28;
            button27.Tag = "Brick";
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Font = new Font("Segoe UI", 15F);
            button28.Location = new Point(408, 277);
            button28.Name = "button28";
            button28.Size = new Size(126, 47);
            button28.TabIndex = 29;
            button28.Tag = "Brick";
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            button29.Font = new Font("Segoe UI", 15F);
            button29.Location = new Point(540, 277);
            button29.Name = "button29";
            button29.Size = new Size(126, 47);
            button29.TabIndex = 30;
            button29.Tag = "Brick";
            button29.Text = "button29";
            button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            button30.Font = new Font("Segoe UI", 15F);
            button30.Location = new Point(673, 277);
            button30.Name = "button30";
            button30.Size = new Size(126, 47);
            button30.TabIndex = 31;
            button30.Tag = "Brick";
            button30.Text = "button30";
            button30.UseVisualStyleBackColor = true;
            // 
            // livesLabel
            // 
            livesLabel.AutoSize = true;
            livesLabel.BackColor = Color.Transparent;
            livesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            livesLabel.ForeColor = SystemColors.ControlText;
            livesLabel.Location = new Point(702, 9);
            livesLabel.Name = "livesLabel";
            livesLabel.Size = new Size(97, 37);
            livesLabel.TabIndex = 33;
            livesLabel.Text = "lives: 3";
            // 
            // Jatek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 594);
            Controls.Add(livesLabel);
            Controls.Add(button30);
            Controls.Add(button29);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button26);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deszka);
            Controls.Add(labda);
            Name = "Jatek";
            Text = "Form1";
            Load += Jatek_Load;
            ((System.ComponentModel.ISupportInitialize)deszka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Ball labda;
        private Board deszka;
        private System.Windows.Forms.Timer gameTimer;
        private Brick button1;
        private Brick button2;
        private Brick button3;
        private Brick button4;
        private Brick button5;
        private Brick button6;
        private Brick button7;
        private Brick button8;
        private Brick button9;
        private Brick button10;
        private Brick button11;
        private Brick button12;
        private Brick button13;
        private Brick button14;
        private Brick button15;
        private Brick button16;
        private Brick button17;
        private Brick button18;
        private Brick button19;
        private Brick button20;
        private Brick button21;
        private Brick button22;
        private Brick button23;
        private Brick button24;
        private Brick button25;
        private Brick button26;
        private Brick button27;
        private Brick button28;
        private Brick button29;
        private Brick button30;
        private Label livesLabel;
        //private System.Windows.Forms.Timer timer1;
        }
}
