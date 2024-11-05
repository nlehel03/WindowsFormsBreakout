namespace breakout
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox2 = new PictureBox();
            startButton = new Button();
            topListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(586, 156);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 11.25F);
            startButton.Location = new Point(341, 246);
            startButton.Name = "startButton";
            startButton.Size = new Size(116, 39);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // topListButton
            // 
            topListButton.Font = new Font("Segoe UI", 11.25F);
            topListButton.Location = new Point(341, 309);
            topListButton.Name = "topListButton";
            topListButton.Size = new Size(116, 39);
            topListButton.TabIndex = 3;
            topListButton.Text = "Ranglista";
            topListButton.UseVisualStyleBackColor = true;
            topListButton.Click += topListButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(topListButton);
            Controls.Add(startButton);
            Controls.Add(pictureBox2);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button startButton;
        private Button topListButton;
    }
}