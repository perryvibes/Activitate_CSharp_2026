using System;

namespace s3
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
            this.grpDateContact = new System.Windows.Forms.GroupBox();
            this.btnAdaugaContact = new System.Windows.Forms.Button();
            this.chkNotificariActive = new System.Windows.Forms.CheckBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lstContacte = new System.Windows.Forms.ListBox();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.grpDateContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDateContact
            // 
            this.grpDateContact.Controls.Add(this.btnAdaugaContact);
            this.grpDateContact.Controls.Add(this.chkNotificariActive);
            this.grpDateContact.Controls.Add(this.txtTelefon);
            this.grpDateContact.Controls.Add(this.lblTelefon);
            this.grpDateContact.Controls.Add(this.txtEmail);
            this.grpDateContact.Controls.Add(this.lblEmail);
            this.grpDateContact.Controls.Add(this.txtNume);
            this.grpDateContact.Controls.Add(this.lblNume);
            this.grpDateContact.Controls.Add(this.txtPrenume);
            this.grpDateContact.Controls.Add(this.lblPrenume);
            this.grpDateContact.Location = new System.Drawing.Point(12, 12);
            this.grpDateContact.Name = "grpDateContact";
            this.grpDateContact.Size = new System.Drawing.Size(270, 437);
            this.grpDateContact.TabIndex = 0;
            this.grpDateContact.TabStop = false;
            this.grpDateContact.Text = "Date Contact";
            this.grpDateContact.UseWaitCursor = true;
            // 
            // btnAdaugaContact
            // 
            this.btnAdaugaContact.Location = new System.Drawing.Point(71, 160);
            this.btnAdaugaContact.Name = "btnAdaugaContact";
            this.btnAdaugaContact.Size = new System.Drawing.Size(183, 23);
            this.btnAdaugaContact.TabIndex = 9;
            this.btnAdaugaContact.Text = "Adauga Contact";
            this.btnAdaugaContact.UseVisualStyleBackColor = true;
            this.btnAdaugaContact.UseWaitCursor = true;
            this.btnAdaugaContact.Click += new System.EventHandler(this.OnBtnAdaugaContactClicked);
            // 
            // chkNotificariActive
            // 
            this.chkNotificariActive.AutoSize = true;
            this.chkNotificariActive.Location = new System.Drawing.Point(71, 137);
            this.chkNotificariActive.Name = "chkNotificariActive";
            this.chkNotificariActive.Size = new System.Drawing.Size(99, 17);
            this.chkNotificariActive.TabIndex = 8;
            this.chkNotificariActive.Text = "Notificari active";
            this.chkNotificariActive.UseVisualStyleBackColor = true;
            this.chkNotificariActive.UseWaitCursor = true;
            this.chkNotificariActive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(71, 85);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(183, 20);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.UseWaitCursor = true;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 92);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon";
            this.lblTelefon.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseWaitCursor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseWaitCursor = true;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(71, 59);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(183, 20);
            this.txtNume.TabIndex = 3;
            this.txtNume.UseWaitCursor = true;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(6, 62);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Nume";
            this.lblNume.UseWaitCursor = true;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(71, 29);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(183, 20);
            this.txtPrenume.TabIndex = 1;
            this.txtPrenume.UseWaitCursor = true;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(6, 36);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 0;
            this.lblPrenume.Text = "Prenume";
            this.lblPrenume.UseWaitCursor = true;
            // 
            // lstContacte
            // 
            this.lstContacte.FormattingEnabled = true;
            this.lstContacte.Location = new System.Drawing.Point(288, 35);
            this.lstContacte.Name = "lstContacte";
            this.lstContacte.Size = new System.Drawing.Size(284, 407);
            this.lstContacte.TabIndex = 1;
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(288, 9);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(284, 20);
            this.txtCautare.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.lstContacte);
            this.Controls.Add(this.grpDateContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.grpDateContact.ResumeLayout(false);
            this.grpDateContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDateContact;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkNotificariActive;
        private System.Windows.Forms.Button btnAdaugaContact;
        private System.Windows.Forms.ListBox lstContacte;
        private System.Windows.Forms.TextBox txtCautare;
    }
}

