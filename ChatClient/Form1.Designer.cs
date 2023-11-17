namespace ChatClient
{
    partial class Form1
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
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPesan = new TextBox();
            BtnSend = new Button();
            lb = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(79, 16);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Message";
            // 
            // txtPesan
            // 
            txtPesan.Location = new Point(79, 45);
            txtPesan.Multiline = true;
            txtPesan.Name = "txtPesan";
            txtPesan.Size = new Size(222, 91);
            txtPesan.TabIndex = 2;
            // 
            // BtnSend
            // 
            BtnSend.Location = new Point(307, 113);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(75, 23);
            BtnSend.TabIndex = 4;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // lb
            // 
            lb.FormattingEnabled = true;
            lb.ItemHeight = 15;
            lb.Location = new Point(79, 174);
            lb.Name = "lb";
            lb.Size = new Size(303, 289);
            lb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Chat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 476);
            Controls.Add(label3);
            Controls.Add(lb);
            Controls.Add(BtnSend);
            Controls.Add(label2);
            Controls.Add(txtPesan);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private TextBox txtPesan;
        private Button BtnSend;
        private ListBox lb;
        private Label label3;
    }
}