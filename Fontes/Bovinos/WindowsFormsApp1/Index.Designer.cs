namespace WindowsFormsApp1
{
    partial class TelaIndex
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
            this.buttonCadastrarAnimal = new System.Windows.Forms.Button();
            this.buttonListarAnimais = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.LogoIndexRerum = new System.Windows.Forms.PictureBox();
            this.LogoHeaderIndexTouro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIndexRerum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHeaderIndexTouro)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrarAnimal
            // 
            this.buttonCadastrarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCadastrarAnimal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarAnimal.Location = new System.Drawing.Point(162, 324);
            this.buttonCadastrarAnimal.Name = "buttonCadastrarAnimal";
            this.buttonCadastrarAnimal.Size = new System.Drawing.Size(176, 55);
            this.buttonCadastrarAnimal.TabIndex = 1;
            this.buttonCadastrarAnimal.Text = "Cadastrar Animal";
            this.buttonCadastrarAnimal.UseVisualStyleBackColor = true;
            this.buttonCadastrarAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonListarAnimais
            // 
            this.buttonListarAnimais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonListarAnimais.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarAnimais.Location = new System.Drawing.Point(447, 324);
            this.buttonListarAnimais.Name = "buttonListarAnimais";
            this.buttonListarAnimais.Size = new System.Drawing.Size(176, 55);
            this.buttonListarAnimais.TabIndex = 2;
            this.buttonListarAnimais.Text = "Listar Animal";
            this.buttonListarAnimais.UseVisualStyleBackColor = true;
            this.buttonListarAnimais.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(297, 427);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(176, 55);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(297, 488);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(176, 55);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // LogoIndexRerum
            // 
            this.LogoIndexRerum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LogoIndexRerum.Image = global::WindowsFormsApp1.Properties.Resources.logo_rerum_home_final;
            this.LogoIndexRerum.Location = new System.Drawing.Point(12, 19);
            this.LogoIndexRerum.Name = "LogoIndexRerum";
            this.LogoIndexRerum.Size = new System.Drawing.Size(162, 65);
            this.LogoIndexRerum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIndexRerum.TabIndex = 5;
            this.LogoIndexRerum.TabStop = false;
            this.LogoIndexRerum.Click += new System.EventHandler(this.LogoIndexRerum_Click);
            // 
            // LogoHeaderIndexTouro
            // 
            this.LogoHeaderIndexTouro.Image = global::WindowsFormsApp1.Properties.Resources.depositphotos_101785396_stock_illustration_sketch_silhouette_of_a_bull_removebg;
            this.LogoHeaderIndexTouro.Location = new System.Drawing.Point(258, 50);
            this.LogoHeaderIndexTouro.Name = "LogoHeaderIndexTouro";
            this.LogoHeaderIndexTouro.Size = new System.Drawing.Size(276, 205);
            this.LogoHeaderIndexTouro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoHeaderIndexTouro.TabIndex = 0;
            this.LogoHeaderIndexTouro.TabStop = false;
            this.LogoHeaderIndexTouro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(770, 562);
            this.Controls.Add(this.LogoIndexRerum);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonListarAnimais);
            this.Controls.Add(this.buttonCadastrarAnimal);
            this.Controls.Add(this.LogoHeaderIndexTouro);
            this.Name = "TelaIndex";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LogoIndexRerum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHeaderIndexTouro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoHeaderIndexTouro;
        private System.Windows.Forms.Button buttonCadastrarAnimal;
        private System.Windows.Forms.Button buttonListarAnimais;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox LogoIndexRerum;
    }
}

