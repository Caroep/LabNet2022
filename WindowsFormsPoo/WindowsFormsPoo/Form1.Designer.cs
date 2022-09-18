namespace WindowsFormsPoo
{
    partial class Form1
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
            this.lbn1 = new System.Windows.Forms.Label();
            this.lbnO = new System.Windows.Forms.Label();
            this.lbnT = new System.Windows.Forms.Label();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.btnO = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbn1
            // 
            this.lbn1.AutoSize = true;
            this.lbn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn1.Location = new System.Drawing.Point(197, 18);
            this.lbn1.Name = "lbn1";
            this.lbn1.Size = new System.Drawing.Size(456, 24);
            this.lbn1.TabIndex = 0;
            this.lbn1.Text = "INGRESO DE PASAJEROS EN TRANSPORTES";
            // 
            // lbnO
            // 
            this.lbnO.AutoSize = true;
            this.lbnO.Location = new System.Drawing.Point(12, 73);
            this.lbnO.Name = "lbnO";
            this.lbnO.Size = new System.Drawing.Size(225, 13);
            this.lbnO.TabIndex = 1;
            this.lbnO.Text = "INGRESO DE PASAJEROS A UN OMNIBUS:";
            // 
            // lbnT
            // 
            this.lbnT.AutoSize = true;
            this.lbnT.Location = new System.Drawing.Point(12, 109);
            this.lbnT.Name = "lbnT";
            this.lbnT.Size = new System.Drawing.Size(199, 13);
            this.lbnT.TabIndex = 2;
            this.lbnT.Text = "INGRESO DE PASAJEROS A UN TAXI:";
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(260, 66);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(100, 20);
            this.txtO.TabIndex = 3;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(260, 109);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 4;
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(412, 64);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(126, 23);
            this.btnO.TabIndex = 5;
            this.btnO.Text = "Agregar a omnibus";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(119, 206);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 23);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "Mostrar";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(698, 279);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 7;
            this.btnS.Text = "Salir";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(412, 109);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(126, 23);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "Agregar a taxi";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // listb
            // 
            this.listb.FormattingEnabled = true;
            this.listb.Location = new System.Drawing.Point(251, 169);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(340, 95);
            this.listb.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.lbnT);
            this.Controls.Add(this.lbnO);
            this.Controls.Add(this.lbn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbn1;
        private System.Windows.Forms.Label lbnO;
        private System.Windows.Forms.Label lbnT;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.ListBox listb;
    }
}

