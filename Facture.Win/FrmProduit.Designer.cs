namespace Facture.Win
{
    partial class Products
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
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbReference = new System.Windows.Forms.TextBox();
            this.Reference = new System.Windows.Forms.Label();
            this.txtbPrixU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tctbQuantite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacture = new Facture.Win.RptBouton();
            this.btnAjout = new Facture.Win.RptBouton();
            this.btnAnnuler = new Facture.Win.RptBouton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(15, 60);
            this.txtbNom.Margin = new System.Windows.Forms.Padding(6);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(342, 30);
            this.txtbNom.TabIndex = 1;
            // 
            // txtbReference
            // 
            this.txtbReference.Location = new System.Drawing.Point(15, 133);
            this.txtbReference.Margin = new System.Windows.Forms.Padding(6);
            this.txtbReference.Name = "txtbReference";
            this.txtbReference.Size = new System.Drawing.Size(342, 30);
            this.txtbReference.TabIndex = 3;
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reference.Location = new System.Drawing.Point(10, 102);
            this.Reference.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(100, 24);
            this.Reference.TabIndex = 2;
            this.Reference.Text = "Reference";
            // 
            // txtbPrixU
            // 
            this.txtbPrixU.Location = new System.Drawing.Point(15, 284);
            this.txtbPrixU.Margin = new System.Windows.Forms.Padding(6);
            this.txtbPrixU.Name = "txtbPrixU";
            this.txtbPrixU.Size = new System.Drawing.Size(342, 30);
            this.txtbPrixU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix unitaire";
            // 
            // tctbQuantite
            // 
            this.tctbQuantite.Location = new System.Drawing.Point(15, 206);
            this.tctbQuantite.Margin = new System.Windows.Forms.Padding(6);
            this.tctbQuantite.Name = "tctbQuantite";
            this.tctbQuantite.Size = new System.Drawing.Size(342, 30);
            this.tctbQuantite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite";
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.Lime;
            this.btnFacture.BackgroundColor = System.Drawing.Color.Lime;
            this.btnFacture.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFacture.BorderRadius = 40;
            this.btnFacture.BorderSize = 0;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacture.ForeColor = System.Drawing.Color.White;
            this.btnFacture.Location = new System.Drawing.Point(249, 345);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(108, 40);
            this.btnFacture.TabIndex = 17;
            this.btnFacture.Text = "FACTURE";
            this.btnFacture.TextColor = System.Drawing.Color.White;
            this.btnFacture.UseVisualStyleBackColor = false;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAjout.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAjout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAjout.BorderRadius = 40;
            this.btnAjout.BorderSize = 0;
            this.btnAjout.FlatAppearance.BorderSize = 0;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.Color.White;
            this.btnAjout.Location = new System.Drawing.Point(15, 345);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(108, 40);
            this.btnAjout.TabIndex = 16;
            this.btnAjout.Text = "AJOUTER";
            this.btnAjout.TextColor = System.Drawing.Color.White;
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Red;
            this.btnAnnuler.BackgroundColor = System.Drawing.Color.Red;
            this.btnAnnuler.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnnuler.BorderRadius = 40;
            this.btnAnnuler.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(138, 345);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 40);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.TextColor = System.Drawing.Color.White;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 401);
            this.Controls.Add(this.btnFacture);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tctbQuantite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbPrixU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbReference);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.TextBox txtbReference;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.TextBox txtbPrixU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tctbQuantite;
        private System.Windows.Forms.Label label4;
        private RptBouton btnAnnuler;
        private RptBouton btnAjout;
        private RptBouton btnFacture;
    }
}

