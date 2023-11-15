﻿namespace Warehouse.Forms.Package
{
    partial class CreatePackage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.input_cliente = new System.Windows.Forms.ComboBox();
            this.input_dir_envio = new System.Windows.Forms.TextBox();
            this.input_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_dir_envio = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.input_peso = new System.Windows.Forms.TextBox();
            this.lbl_id_almacen = new System.Windows.Forms.Label();
            this.lbl_id_externo = new System.Windows.Forms.Label();
            this.input_id_externo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 65);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Crear paquete";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 338);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.input_cliente);
            this.panel3.Controls.Add(this.input_dir_envio);
            this.panel3.Controls.Add(this.input_estado);
            this.panel3.Controls.Add(this.lbl_estado);
            this.panel3.Controls.Add(this.lbl_dir_envio);
            this.panel3.Controls.Add(this.lbl_peso);
            this.panel3.Controls.Add(this.input_peso);
            this.panel3.Controls.Add(this.lbl_id_almacen);
            this.panel3.Controls.Add(this.lbl_id_externo);
            this.panel3.Controls.Add(this.input_id_externo);
            this.panel3.Location = new System.Drawing.Point(23, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 290);
            this.panel3.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(6, 245);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(285, 38);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Crear paquete";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // input_cliente
            // 
            this.input_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_cliente.FormattingEnabled = true;
            this.input_cliente.Location = new System.Drawing.Point(5, 64);
            this.input_cliente.Name = "input_cliente";
            this.input_cliente.Size = new System.Drawing.Size(285, 21);
            this.input_cliente.TabIndex = 17;
            // 
            // input_dir_envio
            // 
            this.input_dir_envio.Location = new System.Drawing.Point(3, 160);
            this.input_dir_envio.Name = "input_dir_envio";
            this.input_dir_envio.Size = new System.Drawing.Size(288, 20);
            this.input_dir_envio.TabIndex = 16;
            // 
            // input_estado
            // 
            this.input_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_estado.FormattingEnabled = true;
            this.input_estado.Location = new System.Drawing.Point(6, 209);
            this.input_estado.Name = "input_estado";
            this.input_estado.Size = new System.Drawing.Size(285, 21);
            this.input_estado.TabIndex = 14;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(3, 193);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 13;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_dir_envio
            // 
            this.lbl_dir_envio.AutoSize = true;
            this.lbl_dir_envio.Location = new System.Drawing.Point(3, 144);
            this.lbl_dir_envio.Name = "lbl_dir_envio";
            this.lbl_dir_envio.Size = new System.Drawing.Size(83, 13);
            this.lbl_dir_envio.TabIndex = 12;
            this.lbl_dir_envio.Text = "Dirección envío";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(3, 96);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 8;
            this.lbl_peso.Text = "Peso";
            // 
            // input_peso
            // 
            this.input_peso.Location = new System.Drawing.Point(3, 112);
            this.input_peso.Name = "input_peso";
            this.input_peso.Size = new System.Drawing.Size(288, 20);
            this.input_peso.TabIndex = 7;
            // 
            // lbl_id_almacen
            // 
            this.lbl_id_almacen.AutoSize = true;
            this.lbl_id_almacen.Location = new System.Drawing.Point(3, 48);
            this.lbl_id_almacen.Name = "lbl_id_almacen";
            this.lbl_id_almacen.Size = new System.Drawing.Size(39, 13);
            this.lbl_id_almacen.TabIndex = 6;
            this.lbl_id_almacen.Text = "Cliente";
            // 
            // lbl_id_externo
            // 
            this.lbl_id_externo.AutoSize = true;
            this.lbl_id_externo.Location = new System.Drawing.Point(3, 1);
            this.lbl_id_externo.Name = "lbl_id_externo";
            this.lbl_id_externo.Size = new System.Drawing.Size(57, 13);
            this.lbl_id_externo.TabIndex = 3;
            this.lbl_id_externo.Text = "ID Externo";
            // 
            // input_id_externo
            // 
            this.input_id_externo.Location = new System.Drawing.Point(3, 17);
            this.input_id_externo.Name = "input_id_externo";
            this.input_id_externo.Size = new System.Drawing.Size(288, 20);
            this.input_id_externo.TabIndex = 2;
            // 
            // CreatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(385, 460);
            this.MinimumSize = new System.Drawing.Size(385, 460);
            this.Name = "CreatePackage";
            this.Text = "CreatePackage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox input_cliente;
        private System.Windows.Forms.TextBox input_dir_envio;
        private System.Windows.Forms.ComboBox input_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_dir_envio;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox input_peso;
        private System.Windows.Forms.Label lbl_id_almacen;
        private System.Windows.Forms.Label lbl_id_externo;
        private System.Windows.Forms.TextBox input_id_externo;
    }
}