
namespace LeitorPDF
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ler = new System.Windows.Forms.Button();
            this.parar = new System.Windows.Forms.Button();
            this.continuar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.termina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enderecoPDF = new System.Windows.Forms.TextBox();
            this.buscarPDF = new System.Windows.Forms.Button();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // ler
            // 
            this.ler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ler.Location = new System.Drawing.Point(369, 143);
            this.ler.Name = "ler";
            this.ler.Size = new System.Drawing.Size(75, 28);
            this.ler.TabIndex = 3;
            this.ler.Text = "Ler";
            this.ler.UseVisualStyleBackColor = true;
            this.ler.Click += new System.EventHandler(this.ler_Click);
            // 
            // parar
            // 
            this.parar.Enabled = false;
            this.parar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parar.Location = new System.Drawing.Point(450, 143);
            this.parar.Name = "parar";
            this.parar.Size = new System.Drawing.Size(75, 28);
            this.parar.TabIndex = 4;
            this.parar.Text = "Pausar";
            this.parar.UseVisualStyleBackColor = true;
            this.parar.Click += new System.EventHandler(this.parar_Click);
            // 
            // continuar
            // 
            this.continuar.Enabled = false;
            this.continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.Location = new System.Drawing.Point(531, 143);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(90, 28);
            this.continuar.TabIndex = 9;
            this.continuar.Text = "Retomar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 177);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(800, 433);
            this.axAcroPDF1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Leitor de PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iniciar leitura em:";
            // 
            // inicio
            // 
            this.inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.Location = new System.Drawing.Point(208, 94);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(183, 26);
            this.inicio.TabIndex = 5;
            this.inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inicio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Terminar leitura em:";
            // 
            // termina
            // 
            this.termina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termina.Location = new System.Drawing.Point(551, 94);
            this.termina.Name = "termina";
            this.termina.Size = new System.Drawing.Size(166, 26);
            this.termina.TabIndex = 10;
            this.termina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termina_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço do PDF:";
            // 
            // enderecoPDF
            // 
            this.enderecoPDF.Enabled = false;
            this.enderecoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoPDF.Location = new System.Drawing.Point(208, 62);
            this.enderecoPDF.Name = "enderecoPDF";
            this.enderecoPDF.Size = new System.Drawing.Size(427, 26);
            this.enderecoPDF.TabIndex = 0;
            // 
            // buscarPDF
            // 
            this.buscarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPDF.Location = new System.Drawing.Point(642, 62);
            this.buscarPDF.Name = "buscarPDF";
            this.buscarPDF.Size = new System.Drawing.Size(75, 26);
            this.buscarPDF.TabIndex = 2;
            this.buscarPDF.Text = "Buscar";
            this.buscarPDF.UseVisualStyleBackColor = true;
            this.buscarPDF.Click += new System.EventHandler(this.buscarPDF_Click);
            // 
            // comboIdioma
            // 
            this.comboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Items.AddRange(new object[] {
            "Pt-BR",
            "En-US"});
            this.comboIdioma.Location = new System.Drawing.Point(208, 143);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(155, 28);
            this.comboIdioma.TabIndex = 15;
            this.comboIdioma.Text = "Selec. Idioma";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.termina);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.parar);
            this.Controls.Add(this.ler);
            this.Controls.Add(this.buscarPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enderecoPDF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Speaker";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ler;
        private System.Windows.Forms.Button parar;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button button1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox termina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enderecoPDF;
        private System.Windows.Forms.Button buscarPDF;
        private System.Windows.Forms.ComboBox comboIdioma;
    }
}

