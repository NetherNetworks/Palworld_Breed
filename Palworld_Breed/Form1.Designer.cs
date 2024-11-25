namespace Palworld_Breed
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_breed = new System.Windows.Forms.Button();
            this.btn_paldex = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_breed);
            this.panel1.Controls.Add(this.btn_paldex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 913);
            this.panel1.TabIndex = 0;
            // 
            // btn_breed
            // 
            this.btn_breed.Location = new System.Drawing.Point(35, 183);
            this.btn_breed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_breed.Name = "btn_breed";
            this.btn_breed.Size = new System.Drawing.Size(100, 28);
            this.btn_breed.TabIndex = 0;
            this.btn_breed.Text = "Breed";
            this.btn_breed.UseVisualStyleBackColor = true;
            this.btn_breed.Click += new System.EventHandler(this.btn_breed_Click);
            // 
            // btn_paldex
            // 
            this.btn_paldex.Location = new System.Drawing.Point(35, 138);
            this.btn_paldex.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paldex.Name = "btn_paldex";
            this.btn_paldex.Size = new System.Drawing.Size(100, 28);
            this.btn_paldex.TabIndex = 0;
            this.btn_paldex.Text = "Paldex";
            this.btn_paldex.UseVisualStyleBackColor = true;
            this.btn_paldex.Click += new System.EventHandler(this.btn_paldex_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 86);
            this.panel2.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 86);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1225, 827);
            this.panel_main.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 913);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_breed;
        private System.Windows.Forms.Button btn_paldex;
    }
}

