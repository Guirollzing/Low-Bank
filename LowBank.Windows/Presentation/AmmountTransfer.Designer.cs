namespace LowBank.Windows.Presentation
{
    partial class AmmountTransfer
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
            this.ammountLabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.transferValue = new System.Windows.Forms.Label();
            this.transferValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ammountLabel2
            // 
            this.ammountLabel2.AutoSize = true;
            this.ammountLabel2.Location = new System.Drawing.Point(109, 9);
            this.ammountLabel2.Name = "ammountLabel2";
            this.ammountLabel2.Size = new System.Drawing.Size(89, 15);
            this.ammountLabel2.TabIndex = 0;
            this.ammountLabel2.Text = "Valor em conta:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(109, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // transferValue
            // 
            this.transferValue.AutoSize = true;
            this.transferValue.Location = new System.Drawing.Point(109, 62);
            this.transferValue.Name = "transferValue";
            this.transferValue.Size = new System.Drawing.Size(95, 15);
            this.transferValue.TabIndex = 3;
            this.transferValue.Text = "Valor a transferir:";
            // 
            // transferValueButton
            // 
            this.transferValueButton.Location = new System.Drawing.Point(109, 112);
            this.transferValueButton.Name = "transferValueButton";
            this.transferValueButton.Size = new System.Drawing.Size(117, 23);
            this.transferValueButton.TabIndex = 4;
            this.transferValueButton.Text = "Tranferir";
            this.transferValueButton.UseVisualStyleBackColor = true;
            // 
            // AmmountTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 147);
            this.Controls.Add(this.transferValueButton);
            this.Controls.Add(this.transferValue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ammountLabel2);
            this.Name = "AmmountTransfer";
            this.Text = "AmmountTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ammountLabel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label transferValue;
        private Button transferValueButton;
    }
}