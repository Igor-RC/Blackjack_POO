namespace Jogo21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBanca = new System.Windows.Forms.Label();
            this.pnlBanca = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.pnlJogador = new System.Windows.Forms.Panel();
            this.btnPedirCarta = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.tmrBanca = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBanca
            // 
            this.lblBanca.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBanca.ForeColor = System.Drawing.Color.White;
            this.lblBanca.Location = new System.Drawing.Point(20, 12);
            this.lblBanca.Name = "lblBanca";
            this.lblBanca.Size = new System.Drawing.Size(860, 30);
            this.lblBanca.TabIndex = 0;
            this.lblBanca.Text = "";
            this.lblBanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBanca
            // 
            this.pnlBanca.Location = new System.Drawing.Point(20, 46);
            this.pnlBanca.Name = "pnlBanca";
            this.pnlBanca.Size = new System.Drawing.Size(860, 190);
            this.pnlBanca.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(20, 248);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(860, 52);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador
            // 
            this.lblJogador.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblJogador.ForeColor = System.Drawing.Color.White;
            this.lblJogador.Location = new System.Drawing.Point(20, 312);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(860, 30);
            this.lblJogador.TabIndex = 3;
            this.lblJogador.Text = "";
            this.lblJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlJogador
            // 
            this.pnlJogador.Location = new System.Drawing.Point(20, 346);
            this.pnlJogador.Name = "pnlJogador";
            this.pnlJogador.Size = new System.Drawing.Size(860, 190);
            this.pnlJogador.TabIndex = 4;
            // 
            // btnPedirCarta
            // 
            this.btnPedirCarta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPedirCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedirCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirCarta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPedirCarta.ForeColor = System.Drawing.Color.Black;
            this.btnPedirCarta.Location = new System.Drawing.Point(150, 564);
            this.btnPedirCarta.Name = "btnPedirCarta";
            this.btnPedirCarta.Size = new System.Drawing.Size(180, 48);
            this.btnPedirCarta.TabIndex = 5;
            this.btnPedirCarta.Text = "Pedir Carta";
            this.btnPedirCarta.UseVisualStyleBackColor = false;
            this.btnPedirCarta.Click += new System.EventHandler(this.btnPedirCarta_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnParar.ForeColor = System.Drawing.Color.Black;
            this.btnParar.Location = new System.Drawing.Point(360, 564);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(180, 48);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Location = new System.Drawing.Point(570, 564);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(180, 48);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // tmrBanca
            // 
            this.tmrBanca.Interval = 1000;
            this.tmrBanca.Tick += new System.EventHandler(this.tmrBanca_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(900, 632);
            this.Controls.Add(this.lblBanca);
            this.Controls.Add(this.pnlBanca);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.pnlJogador);
            this.Controls.Add(this.btnPedirCarta);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReiniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de 21";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBanca;
        private System.Windows.Forms.Panel pnlBanca;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Panel pnlJogador;
        private System.Windows.Forms.Button btnPedirCarta;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer tmrBanca;
    }
}
