﻿namespace LowBank.Windows.Presentation
{
    partial class Home
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
            this.accountTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ammountTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.CPFTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox1 = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.newClientButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountTextbox
            // 
            this.accountTextbox.Location = new System.Drawing.Point(12, 333);
            this.accountTextbox.Name = "accountTextbox";
            this.accountTextbox.Size = new System.Drawing.Size(217, 23);
            this.accountTextbox.TabIndex = 0;
            this.accountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountTextbox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(235, 333);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 25);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Carregar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(362, 248);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(42, 15);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Saldo: ";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(46, 15);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Nome: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ammountTextBox);
            this.panel1.Controls.Add(this.emailTextbox);
            this.panel1.Controls.Add(this.CPFTextBox);
            this.panel1.Controls.Add(this.accountTextBox1);
            this.panel1.Controls.Add(this.telefoneTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 303);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefone: ";
            // 
            // ammountTextBox
            // 
            this.ammountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ammountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountTextBox.Enabled = false;
            this.ammountTextBox.Location = new System.Drawing.Point(362, 266);
            this.ammountTextBox.Name = "ammountTextBox";
            this.ammountTextBox.Size = new System.Drawing.Size(215, 23);
            this.ammountTextBox.TabIndex = 9;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextbox.Enabled = false;
            this.emailTextbox.Location = new System.Drawing.Point(12, 96);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(356, 23);
            this.emailTextbox.TabIndex = 8;
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CPFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPFTextBox.Enabled = false;
            this.CPFTextBox.Location = new System.Drawing.Point(12, 162);
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(204, 23);
            this.CPFTextBox.TabIndex = 7;
            // 
            // accountTextBox1
            // 
            this.accountTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.accountTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountTextBox1.Enabled = false;
            this.accountTextBox1.Location = new System.Drawing.Point(374, 96);
            this.accountTextBox1.Name = "accountTextBox1";
            this.accountTextBox1.Size = new System.Drawing.Size(203, 23);
            this.accountTextBox1.TabIndex = 6;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.Enabled = false;
            this.telefoneTextBox.Location = new System.Drawing.Point(339, 31);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(238, 23);
            this.telefoneTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(12, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(321, 23);
            this.nameTextBox.TabIndex = 4;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(342, 333);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(124, 25);
            this.transferButton.TabIndex = 14;
            this.transferButton.Text = "Transferir";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Visible = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(472, 333);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(128, 25);
            this.newClientButton.TabIndex = 15;
            this.newClientButton.Text = "Cadastrar Cliente";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.accountTextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Name = "Home";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountTextbox_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox accountTextbox;
        private Button searchButton;
        private Label amountLabel;
        private Label userLabel;
        private Panel panel1;
        private TextBox nameTextBox;
        private TextBox ammountTextBox;
        private TextBox emailTextbox;
        private TextBox CPFTextBox;
        private TextBox accountTextBox1;
        private TextBox telefoneTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button transferButton;
        private Button newClientButton;
        private readonly EventHandler transferButton_VisibleChanged;
    }
}