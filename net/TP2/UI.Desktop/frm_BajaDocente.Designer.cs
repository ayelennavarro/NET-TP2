﻿namespace UI.Desktop
{
    partial class frm_BajaDocente
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
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(159, 329);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(285, 329);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(196, 149);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(153, 20);
            this.txtLegajo.TabIndex = 4;
            // 
            // frm_BajaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLegajo);
            this.Name = "frm_BajaDocente";
            this.Text = "Baja docente";
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
    }
}