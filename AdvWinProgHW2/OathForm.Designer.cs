﻿namespace AdvWinProgHW2
{
    partial class OathForm
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
            this.userControlOath1 = new WpfControlLibrary1.UserControlOath();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlOath1);
            this.panel1.Size = new System.Drawing.Size(399, 248);
            // 
            // userControlOath1
            // 
            this.userControlOath1.Location = new System.Drawing.Point(34, 85);
            this.userControlOath1.Name = "userControlOath1";
            this.userControlOath1.Size = new System.Drawing.Size(470, 212);
            this.userControlOath1.TabIndex = 0;
            // 
            // OathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdvWinProgHW2.Properties.Resources.Avatar_Icon;
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathForm";
            this.ShowIcon = false;
            this.Text = "OathForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WpfControlLibrary1.UserControlOath userControlOath1;
    }
}