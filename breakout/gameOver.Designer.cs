namespace breakout
{
    partial class GameOver
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
            pictureBox1 = new PictureBox();
            saveButton = new Button();
            button2 = new Button();
            pointLabel = new Label();
            NevBevitel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cooltext468574741414235;
            pictureBox1.Location = new Point(202, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 156);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            saveButton.Location = new Point(342, 290);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(116, 39);
            saveButton.TabIndex = 1;
            saveButton.Text = "Mentés";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(342, 363);
            button2.Name = "button2";
            button2.Size = new Size(116, 44);
            button2.TabIndex = 2;
            button2.Text = "Főmenü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pointLabel.Location = new Point(342, 210);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new Size(116, 21);
            pointLabel.TabIndex = 3;
            pointLabel.Text = "Elért pontszám:";
            // 
            // NevBevitel
            // 
            NevBevitel.Location = new Point(342, 244);
            NevBevitel.Name = "NevBevitel";
            NevBevitel.Size = new Size(116, 23);
            NevBevitel.TabIndex = 4;
            NevBevitel.Text = "Név";
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NevBevitel);
            Controls.Add(pointLabel);
            Controls.Add(button2);
            Controls.Add(saveButton);
            Controls.Add(pictureBox1);
            Name = "GameOver";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button saveButton;
        private Button button2;
        private Label pointLabel;
        private TextBox NevBevitel;
    }
}