namespace UTS_PBO
{
    partial class V_Welcome
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
            button_Login = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.BackgroundImageLayout = ImageLayout.Center;
            button_Login.Location = new Point(993, 37);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(150, 46);
            button_Login.TabIndex = 0;
            button_Login.Text = "Admin";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += this.button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(993, 353);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Inventaris";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(993, 431);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Pendaftaran";
            button2.UseVisualStyleBackColor = true;
            // 
            // V_Welcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 649);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_Login);
            Name = "V_Welcome";
            Text = "Welcome to Invent.io";
            Load += this.V_Welcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_Login;
        private Button button1;
        private Button button2;
    }
}
