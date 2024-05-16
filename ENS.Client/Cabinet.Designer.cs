namespace ENS.Client
{
    partial class Cabinet
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
            TicketBox = new TextBox();
            Evbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Cabinet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 172);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 246);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Your Ticket";
            // 
            // TicketBox
            // 
            TicketBox.Location = new Point(180, 239);
            TicketBox.Name = "TicketBox";
            TicketBox.Size = new Size(125, 27);
            TicketBox.TabIndex = 4;
            // 
            // Evbtn
            // 
            Evbtn.Location = new Point(59, 345);
            Evbtn.Name = "Evbtn";
            Evbtn.Size = new Size(159, 48);
            Evbtn.TabIndex = 5;
            Evbtn.Text = "Create Event";
            Evbtn.UseVisualStyleBackColor = true;
            Evbtn.Click += Evbtn_Click;
            // 
            // Cabinet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 474);
            Controls.Add(Evbtn);
            Controls.Add(TicketBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cabinet";
            Text = "Cabinet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TicketBox;
        private Button Evbtn;
    }
}