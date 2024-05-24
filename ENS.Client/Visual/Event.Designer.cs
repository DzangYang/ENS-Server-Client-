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
            TokenBox = new TextBox();
            groupBox1 = new GroupBox();
            TimeBox = new TextBox();
            groupBox2 = new GroupBox();
            typeBox = new TextBox();
            label7 = new Label();
            mailBox = new TextBox();
            themeBox = new TextBox();
            contactsBox = new TextBox();
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
            // TokenBox
            // 
            TokenBox.Location = new Point(97, 44);
            TokenBox.Name = "TokenBox";
            TokenBox.Size = new Size(250, 27);
            TokenBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TimeBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TokenBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 181);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Event Information";
            // 
            // TimeBox
            // 
            TimeBox.Location = new Point(97, 106);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(250, 27);
            TimeBox.TabIndex = 8;
            TimeBox.Text = "dd.mm.yy hh:mm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(typeBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(mailBox);
            groupBox2.Controls.Add(themeBox);
            groupBox2.Controls.Add(contactsBox);
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
            // typeBox
            // 
            typeBox.Location = new Point(148, 324);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(192, 27);
            typeBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 327);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 9;
            label7.Text = "Type";
            // 
            // mailBox
            // 
            mailBox.Location = new Point(148, 161);
            mailBox.Multiline = true;
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(192, 144);
            mailBox.TabIndex = 8;
            // 
            // themeBox
            // 
            themeBox.Location = new Point(148, 106);
            themeBox.Name = "themeBox";
            themeBox.Size = new Size(192, 27);
            themeBox.TabIndex = 7;
            // 
            // contactsBox
            // 
            contactsBox.Location = new Point(148, 44);
            contactsBox.Name = "contactsBox";
            contactsBox.Size = new Size(192, 27);
            contactsBox.TabIndex = 6;
            // 
            // Entbtn
            // 
            Entbtn.Location = new Point(12, 355);
            Entbtn.Name = "Entbtn";
            Entbtn.Size = new Size(193, 83);
            Entbtn.TabIndex = 9;
            Entbtn.Text = "Enter";
            Entbtn.UseVisualStyleBackColor = true;
            Entbtn.Click += Entbtn_Click;
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
        private TextBox TokenBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TimeBox;
        private TextBox contactsBox;
        private TextBox mailBox;
        private TextBox themeBox;
        private Button Entbtn;
        private TextBox typeBox;
        private Label label7;
    }
}