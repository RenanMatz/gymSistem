
namespace gymSistem
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnNoCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(99, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(104, 161);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(211, 20);
            this.tbUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label2.Location = new System.Drawing.Point(299, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faça Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(99, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(104, 267);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Sienna;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnEnter.ForeColor = System.Drawing.Color.Snow;
            this.btnEnter.Location = new System.Drawing.Point(453, 199);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(122, 43);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Entrar";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnNoCount
            // 
            this.btnNoCount.FlatAppearance.BorderSize = 0;
            this.btnNoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoCount.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.btnNoCount.Location = new System.Drawing.Point(511, 377);
            this.btnNoCount.Name = "btnNoCount";
            this.btnNoCount.Size = new System.Drawing.Size(167, 30);
            this.btnNoCount.TabIndex = 6;
            this.btnNoCount.Text = "Não possui uma conta?";
            this.btnNoCount.UseVisualStyleBackColor = true;
            this.btnNoCount.Click += new System.EventHandler(this.btnNoCount_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoCount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNoCount;
    }
}