﻿namespace ControleVencimento
{
    partial class JanelaNovoLote
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
            this.pnlNovoLote = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNovoLote = new System.Windows.Forms.Label();
            this.lstNovosLotes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.pnlNovoLote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNovoLote
            // 
            this.pnlNovoLote.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNovoLote.Controls.Add(this.dtpData2);
            this.pnlNovoLote.Controls.Add(this.dtpData1);
            this.pnlNovoLote.Controls.Add(this.label2);
            this.pnlNovoLote.Controls.Add(this.label1);
            this.pnlNovoLote.Controls.Add(this.lstNovosLotes);
            this.pnlNovoLote.Controls.Add(this.lblNovoLote);
            this.pnlNovoLote.Controls.Add(this.lblTotal);
            this.pnlNovoLote.Controls.Add(this.btnCancelar);
            this.pnlNovoLote.Controls.Add(this.btnSalvar);
            this.pnlNovoLote.Controls.Add(this.btnAcrescentar);
            this.pnlNovoLote.Controls.Add(this.nudQuantidade);
            this.pnlNovoLote.Controls.Add(this.txtNome);
            this.pnlNovoLote.Controls.Add(this.txtCodigo);
            this.pnlNovoLote.Controls.Add(this.lstProdutos);
            this.pnlNovoLote.Controls.Add(this.lblQuantidade);
            this.pnlNovoLote.Controls.Add(this.lblNome);
            this.pnlNovoLote.Controls.Add(this.lblCodigo);
            this.pnlNovoLote.Controls.Add(this.lblProduto);
            this.pnlNovoLote.Location = new System.Drawing.Point(-2, -3);
            this.pnlNovoLote.Name = "pnlNovoLote";
            this.pnlNovoLote.Size = new System.Drawing.Size(633, 330);
            this.pnlNovoLote.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(283, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 24);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total: R$ ---";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCancelar.Location = new System.Drawing.Point(472, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSalvar.Location = new System.Drawing.Point(558, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 31);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcrescentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcrescentar.Enabled = false;
            this.btnAcrescentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrescentar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnAcrescentar.Location = new System.Drawing.Point(168, 288);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(102, 31);
            this.btnAcrescentar.TabIndex = 24;
            this.btnAcrescentar.Text = "ACRESCENTAR";
            this.btnAcrescentar.UseVisualStyleBackColor = false;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BackColor = System.Drawing.Color.LightCyan;
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudQuantidade.Location = new System.Drawing.Point(104, 193);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(166, 26);
            this.nudQuantidade.TabIndex = 23;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightCyan;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(68, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 26);
            this.txtNome.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightCyan;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Location = new System.Drawing.Point(68, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 26);
            this.txtCodigo.TabIndex = 21;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.Color.LightCyan;
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 20;
            this.lstProdutos.Location = new System.Drawing.Point(9, 103);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(261, 84);
            this.lstProdutos.TabIndex = 20;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantidade.Location = new System.Drawing.Point(5, 196);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(5, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Location = new System.Drawing.Point(5, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProduto.Location = new System.Drawing.Point(6, 9);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(87, 25);
            this.lblProduto.TabIndex = 14;
            this.lblProduto.Text = "Produto";
            // 
            // lblNovoLote
            // 
            this.lblNovoLote.AutoSize = true;
            this.lblNovoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNovoLote.Location = new System.Drawing.Point(296, 11);
            this.lblNovoLote.Name = "lblNovoLote";
            this.lblNovoLote.Size = new System.Drawing.Size(132, 25);
            this.lblNovoLote.TabIndex = 28;
            this.lblNovoLote.Text = "Novos Lotes";
            // 
            // lstNovosLotes
            // 
            this.lstNovosLotes.BackColor = System.Drawing.Color.LightCyan;
            this.lstNovosLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovosLotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstNovosLotes.FormattingEnabled = true;
            this.lstNovosLotes.ItemHeight = 20;
            this.lstNovosLotes.Location = new System.Drawing.Point(287, 39);
            this.lstNovosLotes.Name = "lstNovosLotes";
            this.lstNovosLotes.Size = new System.Drawing.Size(335, 204);
            this.lstNovosLotes.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data da Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(5, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data de Vencimento: ";
            // 
            // dtpData2
            // 
            this.dtpData2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Location = new System.Drawing.Point(166, 260);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(104, 22);
            this.dtpData2.TabIndex = 33;
            // 
            // dtpData1
            // 
            this.dtpData1.CalendarForeColor = System.Drawing.Color.PaleTurquoise;
            this.dtpData1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpData1.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.dtpData1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Location = new System.Drawing.Point(136, 231);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(134, 22);
            this.dtpData1.TabIndex = 32;
            // 
            // JanelaNovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 325);
            this.Controls.Add(this.pnlNovoLote);
            this.Name = "JanelaNovoLote";
            this.Text = "Novo Lote";
            this.pnlNovoLote.ResumeLayout(false);
            this.pnlNovoLote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNovoLote;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListBox lstNovosLotes;
        private System.Windows.Forms.Label lblNovoLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
    }
}