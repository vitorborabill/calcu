namespace calcu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.op1 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.sinal = new System.Windows.Forms.Label();
            this.mais = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wow = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usarresp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wow)).BeginInit();
            this.SuspendLayout();
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.op1.Location = new System.Drawing.Point(22, 133);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(42, 22);
            this.op1.TabIndex = 0;
            this.op1.Text = "Op1";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.op2.Location = new System.Drawing.Point(224, 133);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(47, 22);
            this.op2.TabIndex = 1;
            this.op2.Text = "Op2";
            // 
            // sinal
            // 
            this.sinal.AutoSize = true;
            this.sinal.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sinal.Location = new System.Drawing.Point(173, 160);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(28, 22);
            this.sinal.TabIndex = 2;
            this.sinal.Text = "...";
            // 
            // mais
            // 
            this.mais.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mais.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mais.Location = new System.Drawing.Point(26, 201);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(75, 32);
            this.mais.TabIndex = 3;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.igual.Enabled = false;
            this.igual.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.igual.Location = new System.Drawing.Point(147, 259);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 32);
            this.igual.TabIndex = 4;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mult.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mult.Location = new System.Drawing.Point(188, 201);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 32);
            this.mult.TabIndex = 5;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menos.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menos.Location = new System.Drawing.Point(107, 201);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(75, 32);
            this.menos.TabIndex = 6;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ControlLight;
            this.div.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.div.Location = new System.Drawing.Point(273, 201);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 32);
            this.div.TabIndex = 7;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Location = new System.Drawing.Point(-4, 327);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(368, 83);
            this.result.TabIndex = 8;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 2;
            this.num1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num1.Location = new System.Drawing.Point(26, 158);
            this.num1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 28);
            this.num1.TabIndex = 9;
            this.num1.ThousandsSeparator = true;
            this.num1.ValueChanged += new System.EventHandler(this.num1_ValueChanged);
            // 
            // num2
            // 
            this.num2.DecimalPlaces = 2;
            this.num2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num2.Location = new System.Drawing.Point(228, 158);
            this.num2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 28);
            this.num2.TabIndex = 10;
            this.num2.ThousandsSeparator = true;
            this.num2.ValueChanged += new System.EventHandler(this.num2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // wow
            // 
            this.wow.Image = ((System.Drawing.Image)(resources.GetObject("wow.Image")));
            this.wow.Location = new System.Drawing.Point(-7, -2);
            this.wow.Name = "wow";
            this.wow.Size = new System.Drawing.Size(371, 132);
            this.wow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wow.TabIndex = 14;
            this.wow.TabStop = false;
            this.wow.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // usarresp
            // 
            this.usarresp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usarresp.Enabled = false;
            this.usarresp.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usarresp.Location = new System.Drawing.Point(26, 297);
            this.usarresp.Name = "usarresp";
            this.usarresp.Size = new System.Drawing.Size(153, 57);
            this.usarresp.TabIndex = 15;
            this.usarresp.Text = "Usar resposta como operando 1";
            this.usarresp.UseVisualStyleBackColor = false;
            this.usarresp.Click += new System.EventHandler(this.usarresp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(198, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(360, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usarresp);
            this.Controls.Add(this.wow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.div);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.sinal);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ALEX MURALHA CALKS";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox wow;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button usarresp;
        private System.Windows.Forms.Button button1;
    }
}

