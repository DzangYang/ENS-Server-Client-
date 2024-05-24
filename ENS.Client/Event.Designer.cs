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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Entbtn = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "My Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Token";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 38);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Contacts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 82);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Mail theme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 121);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Mail";
            // 
            // TokenBox
            // 
            TokenBox.Location = new Point(85, 33);
            TokenBox.Margin = new Padding(3, 2, 3, 2);
            TokenBox.Name = "TokenBox";
            TokenBox.Size = new Size(219, 23);
            TokenBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TimeBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TokenBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(10, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(326, 136);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Event Information";
            // 
            // TimeBox
            // 
            TimeBox.Location = new Point(85, 80);
            TimeBox.Margin = new Padding(3, 2, 3, 2);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(219, 23);
            TimeBox.TabIndex = 8;
            TimeBox.Text = "dd.mm.yy hh:mm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(368, 46);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(322, 282);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mail";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 121);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 108);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 80);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 33);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 6;
            // 
            // Entbtn
            // 
            Entbtn.Location = new Point(10, 266);
            Entbtn.Margin = new Padding(3, 2, 3, 2);
            Entbtn.Name = "Entbtn";
            Entbtn.Size = new Size(169, 62);
            Entbtn.TabIndex = 9;
            Entbtn.Text = "Enter";
            Entbtn.UseVisualStyleBackColor = true;
            Entbtn.Click += Entbtn_ClickAsync;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 244);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 10;
            label7.Text = "Event Type";
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Entbtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button Entbtn;
        private Label label7;
        private TextBox textBox4;
    }
}