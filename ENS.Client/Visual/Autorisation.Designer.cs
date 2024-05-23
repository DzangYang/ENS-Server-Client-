using System.Xml.Linq;

namespace ENS.Client
{
    partial class Autorisation
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
            nametxt = new TextBox();
            passwordtxt = new TextBox();
            Entbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            Mainbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Autorisation";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(248, 122);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(125, 27);
            nametxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(248, 212);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(125, 27);
            passwordtxt.TabIndex = 2;
            // 
            // Entbtn
            // 
            Entbtn.Location = new Point(217, 299);
            Entbtn.Name = "Entbtn";
            Entbtn.Size = new Size(186, 66);
            Entbtn.TabIndex = 3;
            Entbtn.Text = "Enter";
            Entbtn.UseVisualStyleBackColor = true;
            Entbtn.Click += Entbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 99);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 189);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Mainbtn
            // 
            Mainbtn.Location = new Point(217, 388);
            Mainbtn.Name = "Mainbtn";
            Mainbtn.Size = new Size(186, 66);
            Mainbtn.TabIndex = 6;
            Mainbtn.Text = "MAIN";
            Mainbtn.UseVisualStyleBackColor = true;
            Mainbtn.Click += Mainbtn_Click;
            // 
            // Autorisation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 488);
            Controls.Add(Mainbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Entbtn);
            Controls.Add(passwordtxt);
            Controls.Add(nametxt);
            Controls.Add(label1);
            Name = "Autorisation";
            Text = "Autorisation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nametxt;
        private TextBox passwordtxt;
        private Button Entbtn;
        private Label label2;
        private Label label3;
        private Button Mainbtn;
    }
}