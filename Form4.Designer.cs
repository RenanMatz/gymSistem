
namespace gymSistem
{
    partial class Form4
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
            this.dgvEquipamento = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbGuarantee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.painel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).BeginInit();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máquinas";
            // 
            // dgvEquipamento
            // 
            this.dgvEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEquipamento.Location = new System.Drawing.Point(81, 87);
            this.dgvEquipamento.Name = "dgvEquipamento";
            this.dgvEquipamento.Size = new System.Drawing.Size(636, 204);
            this.dgvEquipamento.TabIndex = 0;
            this.dgvEquipamento.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEquipamento_CellMouseDoubleClick);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(31, 58);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(119, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(235, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 20);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id  máquina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label3.Location = new System.Drawing.Point(230, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(433, 58);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(119, 20);
            this.tbType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label4.Location = new System.Drawing.Point(428, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Treino";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(31, 148);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(119, 20);
            this.tbStatus.TabIndex = 7;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(235, 148);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(119, 20);
            this.tbColor.TabIndex = 8;
            // 
            // tbGuarantee
            // 
            this.tbGuarantee.Location = new System.Drawing.Point(433, 148);
            this.tbGuarantee.Name = "tbGuarantee";
            this.tbGuarantee.Size = new System.Drawing.Size(119, 20);
            this.tbGuarantee.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label5.Location = new System.Drawing.Point(26, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label6.Location = new System.Drawing.Point(230, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label7.Location = new System.Drawing.Point(428, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Garantia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(618, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // painel
            // 
            this.painel.Controls.Add(this.button2);
            this.painel.Controls.Add(this.tbId);
            this.painel.Controls.Add(this.button1);
            this.painel.Controls.Add(this.label2);
            this.painel.Controls.Add(this.label7);
            this.painel.Controls.Add(this.tbStatus);
            this.painel.Controls.Add(this.tbGuarantee);
            this.painel.Controls.Add(this.label6);
            this.painel.Controls.Add(this.label4);
            this.painel.Controls.Add(this.label5);
            this.painel.Controls.Add(this.tbType);
            this.painel.Controls.Add(this.tbName);
            this.painel.Controls.Add(this.tbColor);
            this.painel.Controls.Add(this.label3);
            this.painel.Enabled = false;
            this.painel.Location = new System.Drawing.Point(23, 306);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(754, 186);
            this.painel.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(618, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.dgvEquipamento);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "maquinas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).EndInit();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipamento;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbGuarantee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Button button2;
    }
}