namespace ENS.Client
{
    partial class Registration
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
            Entbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nametxt = new TextBox();
            passwordtxt = new TextBox();
            rolletxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISRTATION";
            // 
            // Entbtn
            // 
            Entbtn.Location = new Point(349, 341);
            Entbtn.Name = "Entbtn";
            Entbtn.Size = new Size(125, 48);
            Entbtn.TabIndex = 1;
            Entbtn.Text = "ENTER";
            Entbtn.UseVisualStyleBackColor = true;
            Entbtn.Click += Entbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 140);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 204);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 274);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Rolle";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(192, 133);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(125, 27);
            nametxt.TabIndex = 5;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(192, 197);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(125, 27);
            passwordtxt.TabIndex = 6;
            // 
            // rolletxt
            // 
            rolletxt.Location = new Point(192, 267);
            rolletxt.Name = "rolletxt";
            rolletxt.Size = new Size(125, 27);
            rolletxt.TabIndex = 7;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 401);
            Controls.Add(rolletxt);
            Controls.Add(passwordtxt);
            Controls.Add(nametxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Entbtn);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Entbtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nametxt;
        private TextBox passwordtxt;
        private TextBox rolletxt;
    }
}