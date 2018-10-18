namespace TpFenetreMereFille
{
    partial class FFille
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(116, 12);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 0;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(222, 10);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 1;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Je change de nom :";
            // 
            // btnMere
            // 
            this.btnMere.Location = new System.Drawing.Point(141, 61);
            this.btnMere.Name = "btnMere";
            this.btnMere.Size = new System.Drawing.Size(75, 23);
            this.btnMere.TabIndex = 3;
            this.btnMere.Text = "Ma Mere";
            this.btnMere.UseVisualStyleBackColor = true;
            this.btnMere.Click += new System.EventHandler(this.btnMere_Click);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 96);
            this.Controls.Add(this.btnMere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.tbNom);
            this.Name = "FFille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMere;
    }
}