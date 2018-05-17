namespace Jokenpo
{
    partial class MenuMode
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
            this.ModePlayerVsComp = new System.Windows.Forms.CheckBox();
            this.ModeCompVsComp = new System.Windows.Forms.CheckBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.TextBoxNumRound = new System.Windows.Forms.TextBox();
            this.LabelRound = new System.Windows.Forms.Label();
            this.LabelMovePlayer = new System.Windows.Forms.Label();
            this.LabelVs = new System.Windows.Forms.Label();
            this.LabelMoveComp = new System.Windows.Forms.Label();
            this.StoneButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.NextPVsCButton = new System.Windows.Forms.Button();
            this.ContinuesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LabelScoreboard = new System.Windows.Forms.Label();
            this.LabelWinRound = new System.Windows.Forms.Label();
            this.NextComVsCompButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModePlayerVsComp
            // 
            this.ModePlayerVsComp.AutoSize = true;
            this.ModePlayerVsComp.Location = new System.Drawing.Point(73, 95);
            this.ModePlayerVsComp.Name = "ModePlayerVsComp";
            this.ModePlayerVsComp.Size = new System.Drawing.Size(160, 17);
            this.ModePlayerVsComp.TabIndex = 0;
            this.ModePlayerVsComp.Text = "Modo Player Vs Computador";
            this.ModePlayerVsComp.UseVisualStyleBackColor = true;
            this.ModePlayerVsComp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ModeCompVsComp
            // 
            this.ModeCompVsComp.AutoSize = true;
            this.ModeCompVsComp.Location = new System.Drawing.Point(73, 118);
            this.ModeCompVsComp.Name = "ModeCompVsComp";
            this.ModeCompVsComp.Size = new System.Drawing.Size(188, 17);
            this.ModeCompVsComp.TabIndex = 1;
            this.ModeCompVsComp.Text = "Modo Computador Vs Computador";
            this.ModeCompVsComp.UseVisualStyleBackColor = true;
            this.ModeCompVsComp.CheckedChanged += new System.EventHandler(this.ModeCompVsComp_CheckedChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(121, 232);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Jogar";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtom_Click);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(69, 41);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(170, 13);
            this.LabelDescription.TabIndex = 3;
            this.LabelDescription.Text = "Escolha o modo de jogo desejado!";
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Location = new System.Drawing.Point(54, 267);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 13);
            this.LabelWarning.TabIndex = 4;
            // 
            // TextBoxNumRound
            // 
            this.TextBoxNumRound.Location = new System.Drawing.Point(111, 196);
            this.TextBoxNumRound.Name = "TextBoxNumRound";
            this.TextBoxNumRound.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumRound.TabIndex = 5;
            this.TextBoxNumRound.TextChanged += new System.EventHandler(this.TextBoxNumRound_TextChanged);
            // 
            // LabelRound
            // 
            this.LabelRound.AutoSize = true;
            this.LabelRound.Location = new System.Drawing.Point(54, 165);
            this.LabelRound.Name = "LabelRound";
            this.LabelRound.Size = new System.Drawing.Size(221, 13);
            this.LabelRound.TabIndex = 6;
            this.LabelRound.Text = "Digite o número de rodadas que deseja jogar.";
            // 
            // LabelMovePlayer
            // 
            this.LabelMovePlayer.AutoSize = true;
            this.LabelMovePlayer.Location = new System.Drawing.Point(70, 96);
            this.LabelMovePlayer.Name = "LabelMovePlayer";
            this.LabelMovePlayer.Size = new System.Drawing.Size(13, 13);
            this.LabelMovePlayer.TabIndex = 7;
            this.LabelMovePlayer.Text = "?";
            this.LabelMovePlayer.Visible = false;
            // 
            // LabelVs
            // 
            this.LabelVs.AutoSize = true;
            this.LabelVs.Location = new System.Drawing.Point(144, 96);
            this.LabelVs.Name = "LabelVs";
            this.LabelVs.Size = new System.Drawing.Size(19, 13);
            this.LabelVs.TabIndex = 8;
            this.LabelVs.Text = "Vs";
            this.LabelVs.Visible = false;
            // 
            // LabelMoveComp
            // 
            this.LabelMoveComp.AutoSize = true;
            this.LabelMoveComp.Location = new System.Drawing.Point(226, 96);
            this.LabelMoveComp.Name = "LabelMoveComp";
            this.LabelMoveComp.Size = new System.Drawing.Size(13, 13);
            this.LabelMoveComp.TabIndex = 9;
            this.LabelMoveComp.Text = "?";
            this.LabelMoveComp.Visible = false;
            // 
            // StoneButton
            // 
            this.StoneButton.Location = new System.Drawing.Point(14, 181);
            this.StoneButton.Name = "StoneButton";
            this.StoneButton.Size = new System.Drawing.Size(75, 23);
            this.StoneButton.TabIndex = 10;
            this.StoneButton.Text = "Pedra";
            this.StoneButton.UseVisualStyleBackColor = true;
            this.StoneButton.Visible = false;
            this.StoneButton.Click += new System.EventHandler(this.StoneButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(121, 181);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 11;
            this.PaperButton.Text = "Papel";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Visible = false;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Location = new System.Drawing.Point(229, 181);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorsButton.TabIndex = 12;
            this.ScissorsButton.Text = "Tesoura";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Visible = false;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // NextPVsCButton
            // 
            this.NextPVsCButton.Location = new System.Drawing.Point(99, 232);
            this.NextPVsCButton.Name = "NextPVsCButton";
            this.NextPVsCButton.Size = new System.Drawing.Size(112, 23);
            this.NextPVsCButton.TabIndex = 13;
            this.NextPVsCButton.Text = "Proxima rodada";
            this.NextPVsCButton.UseVisualStyleBackColor = true;
            this.NextPVsCButton.Visible = false;
            this.NextPVsCButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ContinuesButton
            // 
            this.ContinuesButton.Location = new System.Drawing.Point(93, 95);
            this.ContinuesButton.Name = "ContinuesButton";
            this.ContinuesButton.Size = new System.Drawing.Size(118, 22);
            this.ContinuesButton.TabIndex = 14;
            this.ContinuesButton.Text = "Continuar jogando";
            this.ContinuesButton.UseVisualStyleBackColor = true;
            this.ContinuesButton.Visible = false;
            this.ContinuesButton.Click += new System.EventHandler(this.ContinuesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(111, 126);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Sair";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LabelScoreboard
            // 
            this.LabelScoreboard.AutoSize = true;
            this.LabelScoreboard.Location = new System.Drawing.Point(69, 65);
            this.LabelScoreboard.Name = "LabelScoreboard";
            this.LabelScoreboard.Size = new System.Drawing.Size(37, 13);
            this.LabelScoreboard.TabIndex = 16;
            this.LabelScoreboard.Text = "Placar";
            this.LabelScoreboard.Visible = false;
            // 
            // LabelWinRound
            // 
            this.LabelWinRound.AutoSize = true;
            this.LabelWinRound.Location = new System.Drawing.Point(118, 138);
            this.LabelWinRound.Name = "LabelWinRound";
            this.LabelWinRound.Size = new System.Drawing.Size(26, 13);
            this.LabelWinRound.TabIndex = 17;
            this.LabelWinRound.Text = "Win";
            this.LabelWinRound.Visible = false;
            // 
            // NextComVsCompButton
            // 
            this.NextComVsCompButton.Location = new System.Drawing.Point(99, 181);
            this.NextComVsCompButton.Name = "NextComVsCompButton";
            this.NextComVsCompButton.Size = new System.Drawing.Size(118, 23);
            this.NextComVsCompButton.TabIndex = 18;
            this.NextComVsCompButton.Text = "Começar rodada";
            this.NextComVsCompButton.UseVisualStyleBackColor = true;
            this.NextComVsCompButton.Visible = false;
            this.NextComVsCompButton.Click += new System.EventHandler(this.NextComVsCompButton_Click);
            // 
            // MenuMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.Controls.Add(this.NextComVsCompButton);
            this.Controls.Add(this.LabelWinRound);
            this.Controls.Add(this.LabelScoreboard);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ContinuesButton);
            this.Controls.Add(this.NextPVsCButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.StoneButton);
            this.Controls.Add(this.LabelMoveComp);
            this.Controls.Add(this.LabelVs);
            this.Controls.Add(this.LabelMovePlayer);
            this.Controls.Add(this.LabelRound);
            this.Controls.Add(this.TextBoxNumRound);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ModeCompVsComp);
            this.Controls.Add(this.ModePlayerVsComp);
            this.Name = "MenuMode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ModePlayerVsComp;
        private System.Windows.Forms.CheckBox ModeCompVsComp;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.TextBox TextBoxNumRound;
        private System.Windows.Forms.Label LabelRound;
        private System.Windows.Forms.Label LabelMovePlayer;
        private System.Windows.Forms.Label LabelVs;
        private System.Windows.Forms.Label LabelMoveComp;
        private System.Windows.Forms.Button StoneButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button NextPVsCButton;
        private System.Windows.Forms.Button ContinuesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LabelScoreboard;
        private System.Windows.Forms.Label LabelWinRound;
        private System.Windows.Forms.Button NextComVsCompButton;
    }
}

