namespace Palworld_Breed.pages
{
    partial class page_AZV_parents
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_parent1 = new System.Windows.Forms.PictureBox();
            this.pb_parent2 = new System.Windows.Forms.PictureBox();
            this.pb_child = new System.Windows.Forms.PictureBox();
            this.cb_parent1 = new System.Windows.Forms.ComboBox();
            this.cb_parent2 = new System.Windows.Forms.ComboBox();
            this.lbl_cr_parent1 = new System.Windows.Forms.Label();
            this.lb_cr_parent2 = new System.Windows.Forms.Label();
            this.lbl_crvalue2 = new System.Windows.Forms.Label();
            this.lbl_crvalue1 = new System.Windows.Forms.Label();
            this.lbl_child = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_parent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_parent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_child)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_parent1
            // 
            this.pb_parent1.Location = new System.Drawing.Point(102, 84);
            this.pb_parent1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_parent1.Name = "pb_parent1";
            this.pb_parent1.Size = new System.Drawing.Size(197, 164);
            this.pb_parent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_parent1.TabIndex = 0;
            this.pb_parent1.TabStop = false;
            // 
            // pb_parent2
            // 
            this.pb_parent2.Location = new System.Drawing.Point(514, 84);
            this.pb_parent2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_parent2.Name = "pb_parent2";
            this.pb_parent2.Size = new System.Drawing.Size(197, 164);
            this.pb_parent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_parent2.TabIndex = 0;
            this.pb_parent2.TabStop = false;
            // 
            // pb_child
            // 
            this.pb_child.Location = new System.Drawing.Point(308, 345);
            this.pb_child.Margin = new System.Windows.Forms.Padding(4);
            this.pb_child.Name = "pb_child";
            this.pb_child.Size = new System.Drawing.Size(197, 164);
            this.pb_child.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_child.TabIndex = 0;
            this.pb_child.TabStop = false;
            // 
            // cb_parent1
            // 
            this.cb_parent1.DisplayMember = "Name";
            this.cb_parent1.FormattingEnabled = true;
            this.cb_parent1.Location = new System.Drawing.Point(102, 256);
            this.cb_parent1.Margin = new System.Windows.Forms.Padding(4);
            this.cb_parent1.Name = "cb_parent1";
            this.cb_parent1.Size = new System.Drawing.Size(196, 24);
            this.cb_parent1.TabIndex = 1;
            this.cb_parent1.ValueMember = "ID";
            this.cb_parent1.SelectedIndexChanged += new System.EventHandler(this.Cb_Parent1_SelectedIndexChanged);
            // 
            // cb_parent2
            // 
            this.cb_parent2.DisplayMember = "Name";
            this.cb_parent2.FormattingEnabled = true;
            this.cb_parent2.Location = new System.Drawing.Point(515, 256);
            this.cb_parent2.Margin = new System.Windows.Forms.Padding(4);
            this.cb_parent2.Name = "cb_parent2";
            this.cb_parent2.Size = new System.Drawing.Size(196, 24);
            this.cb_parent2.TabIndex = 1;
            this.cb_parent2.ValueMember = "ID";
            this.cb_parent2.SelectedIndexChanged += new System.EventHandler(this.Cb_Parent2_SelectedIndexChanged);
            // 
            // lbl_cr_parent1
            // 
            this.lbl_cr_parent1.AutoSize = true;
            this.lbl_cr_parent1.Location = new System.Drawing.Point(102, 288);
            this.lbl_cr_parent1.Name = "lbl_cr_parent1";
            this.lbl_cr_parent1.Size = new System.Drawing.Size(82, 16);
            this.lbl_cr_parent1.TabIndex = 2;
            this.lbl_cr_parent1.Text = "Combi-Rank";
            // 
            // lb_cr_parent2
            // 
            this.lb_cr_parent2.AutoSize = true;
            this.lb_cr_parent2.Location = new System.Drawing.Point(512, 288);
            this.lb_cr_parent2.Name = "lb_cr_parent2";
            this.lb_cr_parent2.Size = new System.Drawing.Size(82, 16);
            this.lb_cr_parent2.TabIndex = 2;
            this.lb_cr_parent2.Text = "Combi-Rank";
            // 
            // lbl_crvalue2
            // 
            this.lbl_crvalue2.AutoSize = true;
            this.lbl_crvalue2.Location = new System.Drawing.Point(600, 288);
            this.lbl_crvalue2.Name = "lbl_crvalue2";
            this.lbl_crvalue2.Size = new System.Drawing.Size(44, 16);
            this.lbl_crvalue2.TabIndex = 2;
            this.lbl_crvalue2.Text = "label1";
            // 
            // lbl_crvalue1
            // 
            this.lbl_crvalue1.AutoSize = true;
            this.lbl_crvalue1.Location = new System.Drawing.Point(190, 288);
            this.lbl_crvalue1.Name = "lbl_crvalue1";
            this.lbl_crvalue1.Size = new System.Drawing.Size(44, 16);
            this.lbl_crvalue1.TabIndex = 2;
            this.lbl_crvalue1.Text = "label1";
            // 
            // lbl_child
            // 
            this.lbl_child.AutoSize = true;
            this.lbl_child.Location = new System.Drawing.Point(305, 522);
            this.lbl_child.Name = "lbl_child";
            this.lbl_child.Size = new System.Drawing.Size(0, 16);
            this.lbl_child.TabIndex = 2;
            // 
            // page_AZV_parents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_crvalue1);
            this.Controls.Add(this.lbl_crvalue2);
            this.Controls.Add(this.lbl_child);
            this.Controls.Add(this.lb_cr_parent2);
            this.Controls.Add(this.lbl_cr_parent1);
            this.Controls.Add(this.cb_parent2);
            this.Controls.Add(this.cb_parent1);
            this.Controls.Add(this.pb_child);
            this.Controls.Add(this.pb_parent2);
            this.Controls.Add(this.pb_parent1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "page_AZV_parents";
            this.Size = new System.Drawing.Size(816, 660);
            ((System.ComponentModel.ISupportInitialize)(this.pb_parent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_parent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_child)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_parent1;
        private System.Windows.Forms.PictureBox pb_parent2;
        private System.Windows.Forms.PictureBox pb_child;
        private System.Windows.Forms.ComboBox cb_parent1;
        private System.Windows.Forms.ComboBox cb_parent2;
        private System.Windows.Forms.Label lbl_cr_parent1;
        private System.Windows.Forms.Label lb_cr_parent2;
        private System.Windows.Forms.Label lbl_crvalue2;
        private System.Windows.Forms.Label lbl_crvalue1;
        private System.Windows.Forms.Label lbl_child;
    }
}
