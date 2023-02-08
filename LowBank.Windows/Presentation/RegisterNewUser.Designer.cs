namespace LowBank.Windows.Presentation
{
    partial class RegisterNewUser
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
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.nameRegister = new System.Windows.Forms.TextBox();
            this.telefoneRegister = new System.Windows.Forms.TextBox();
            this.CPFRegister = new System.Windows.Forms.TextBox();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.CPFErrorLabel = new System.Windows.Forms.Label();
            this.telefoneErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(403, 162);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Cadastrar";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // emailRegister
            // 
            this.emailRegister.Location = new System.Drawing.Point(8, 101);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(275, 23);
            this.emailRegister.TabIndex = 5;
            // 
            // nameRegister
            // 
            this.nameRegister.Location = new System.Drawing.Point(8, 35);
            this.nameRegister.Name = "nameRegister";
            this.nameRegister.Size = new System.Drawing.Size(275, 23);
            this.nameRegister.TabIndex = 6;
            this.nameRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // telefoneRegister
            // 
            this.telefoneRegister.Location = new System.Drawing.Point(289, 35);
            this.telefoneRegister.Name = "telefoneRegister";
            this.telefoneRegister.Size = new System.Drawing.Size(234, 23);
            this.telefoneRegister.TabIndex = 0;
            // 
            // CPFRegister
            // 
            this.CPFRegister.Location = new System.Drawing.Point(289, 101);
            this.CPFRegister.Name = "CPFRegister";
            this.CPFRegister.Size = new System.Drawing.Size(234, 23);
            this.CPFRegister.TabIndex = 0;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.Location = new System.Drawing.Point(8, 60);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(139, 23);
            this.nameErrorLabel.TabIndex = 0;
            this.nameErrorLabel.Text = "Nome Obrigatório";
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.Location = new System.Drawing.Point(8, 127);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(100, 23);
            this.emailErrorLabel.TabIndex = 0;
            this.emailErrorLabel.Text = "Email Obrigatório";
            // 
            // CPFErrorLabel
            // 
            this.CPFErrorLabel.Location = new System.Drawing.Point(289, 127);
            this.CPFErrorLabel.Name = "CPFErrorLabel";
            this.CPFErrorLabel.Size = new System.Drawing.Size(136, 23);
            this.CPFErrorLabel.TabIndex = 0;
            this.CPFErrorLabel.Text = "CPF Obrigatório";
            // 
            // telefoneErrorLabel
            // 
            this.telefoneErrorLabel.Location = new System.Drawing.Point(289, 60);
            this.telefoneErrorLabel.Name = "telefoneErrorLabel";
            this.telefoneErrorLabel.Size = new System.Drawing.Size(149, 23);
            this.telefoneErrorLabel.TabIndex = 0;
            this.telefoneErrorLabel.Text = "Telefone Obrigatório";
            // 
            // RegisterNewUser
            // 
            this.ClientSize = new System.Drawing.Size(534, 197);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.telefoneRegister);
            this.Controls.Add(this.CPFRegister);
            this.Controls.Add(this.nameRegister);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.telefoneErrorLabel);
            this.Controls.Add(this.CPFErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Name = "RegisterNewUser";
            this.Text = "Registro de novo usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox emailRegister;
        private TextBox nameRegister;
        private TextBox telefoneRegister;
        private TextBox CPFRegister;
        private Label nameErrorLabel;
        private Label emailErrorLabel;
        private Label CPFErrorLabel;
        private Label telefoneErrorLabel;
    }
}