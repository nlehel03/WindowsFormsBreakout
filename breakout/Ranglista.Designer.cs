namespace breakout
{
    partial class Ranglista
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
            startButton = new Button();
            listBox1 = new ListBox();
            listaz = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 11.25F);
            startButton.Location = new Point(12, 22);
            startButton.Name = "startButton";
            startButton.Size = new Size(116, 39);
            startButton.TabIndex = 3;
            startButton.Text = "Vissza";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "        ", "        " });
            listBox1.Location = new Point(276, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 334);
            listBox1.TabIndex = 4;
            // 
            // listaz
            // 
            listaz.Font = new Font("Segoe UI", 11.25F);
            listaz.Location = new Point(341, 22);
            listaz.Name = "listaz";
            listaz.Size = new Size(116, 39);
            listaz.TabIndex = 5;
            listaz.Text = "Listázás";
            listaz.UseVisualStyleBackColor = true;
            listaz.Click += listaz_Click;
            // 
            // Ranglista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listaz);
            Controls.Add(listBox1);
            Controls.Add(startButton);
            Name = "Ranglista";
            Text = "Ranglista";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private ListBox listBox1;
        private Button listaz;
    }
}