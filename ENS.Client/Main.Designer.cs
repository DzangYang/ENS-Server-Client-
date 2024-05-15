namespace ENS.Client
{
    partial class Main
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
            label1 = new Label();
            Regbtn = new Button();
            Autbnt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 41);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            // 
            // Regbtn
            // 
            Regbtn.Location = new Point(168, 128);
            Regbtn.Name = "Regbtn";
            Regbtn.Size = new Size(211, 55);
            Regbtn.TabIndex = 1;
            Regbtn.Text = "Registration";
            Regbtn.UseVisualStyleBackColor = true;
            Regbtn.Click += Regbtn_Click;
            // 
            // Autbnt
            // 
            Autbnt.Location = new Point(168, 237);
            Autbnt.Name = "Autbnt";
            Autbnt.Size = new Size(211, 55);
            Autbnt.TabIndex = 2;
            Autbnt.Text = "Autorisation";
            Autbnt.UseVisualStyleBackColor = true;
            Autbnt.Click += Autbnt_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 418);
            Controls.Add(Autbnt);
            Controls.Add(Regbtn);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Regbtn;
        private Button Autbnt;
    }
}