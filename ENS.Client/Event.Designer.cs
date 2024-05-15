namespace ENS.Client
{
    partial class Event
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Token = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TimeBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Entbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "My Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 51);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Token";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 113);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 51);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Contacts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 109);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Mail theme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 161);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 5;
            label6.Text = "Mail";
            // 
            // Token
            // 
            Token.Location = new Point(97, 44);
            Token.Name = "Token";
            Token.Size = new Size(250, 27);
            Token.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TimeBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Token);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 181);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Event Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(420, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 376);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mail";
            // 
            // TimeBox
            // 
            TimeBox.Location = new Point(97, 106);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(250, 27);
            TimeBox.TabIndex = 8;
            TimeBox.Text = "dd.mm.yy hh:mm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 161);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 188);
            textBox3.TabIndex = 8;
            // 
            // Entbtn
            // 
            Entbtn.Location = new Point(12, 355);
            Entbtn.Name = "Entbtn";
            Entbtn.Size = new Size(193, 83);
            Entbtn.TabIndex = 9;
            Entbtn.Text = "Enter";
            Entbtn.UseVisualStyleBackColor = true;
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Entbtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Event";
            Text = "Event";
            Load += Event_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Token;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TimeBox;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button Entbtn;
    }
}