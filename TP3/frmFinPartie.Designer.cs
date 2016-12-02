namespace TP3
{
  partial class frmFinPartie
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
      this.btnRestart = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.lblTextFinPartie = new System.Windows.Forms.Label();
      this.lblTempsJeu = new System.Windows.Forms.Label();
      this.lblPctPieces = new System.Windows.Forms.Label();
      this.lblNbPieces = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblTemps = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnRestart
      // 
      this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Retry;
      this.btnRestart.Location = new System.Drawing.Point(127, 504);
      this.btnRestart.Name = "btnRestart";
      this.btnRestart.Size = new System.Drawing.Size(165, 45);
      this.btnRestart.TabIndex = 0;
      this.btnRestart.Text = "Restart";
      this.btnRestart.UseVisualStyleBackColor = true;
      // 
      // btnQuit
      // 
      this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Abort;
      this.btnQuit.Location = new System.Drawing.Point(334, 504);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(165, 45);
      this.btnQuit.TabIndex = 1;
      this.btnQuit.Text = "Quit";
      this.btnQuit.UseVisualStyleBackColor = true;
      // 
      // lblTextFinPartie
      // 
      this.lblTextFinPartie.AutoSize = true;
      this.lblTextFinPartie.Font = new System.Drawing.Font("Castellar", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTextFinPartie.Location = new System.Drawing.Point(5, 9);
      this.lblTextFinPartie.Name = "lblTextFinPartie";
      this.lblTextFinPartie.Size = new System.Drawing.Size(578, 77);
      this.lblTextFinPartie.TabIndex = 2;
      this.lblTextFinPartie.Text = "Fin de partie !";
      // 
      // lblTempsJeu
      // 
      this.lblTempsJeu.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblTempsJeu.AutoSize = true;
      this.lblTempsJeu.Location = new System.Drawing.Point(3, 61);
      this.lblTempsJeu.Name = "lblTempsJeu";
      this.lblTempsJeu.Size = new System.Drawing.Size(77, 13);
      this.lblTempsJeu.TabIndex = 3;
      this.lblTempsJeu.Text = "Temps de jeu :";
      // 
      // lblPctPieces
      // 
      this.lblPctPieces.AutoSize = true;
      this.lblPctPieces.Location = new System.Drawing.Point(3, 272);
      this.lblPctPieces.Name = "lblPctPieces";
      this.lblPctPieces.Size = new System.Drawing.Size(55, 13);
      this.lblPctPieces.TabIndex = 4;
      this.lblPctPieces.Text = "% pièces :";
      // 
      // lblNbPieces
      // 
      this.lblNbPieces.AutoSize = true;
      this.lblNbPieces.Location = new System.Drawing.Point(3, 136);
      this.lblNbPieces.Name = "lblNbPieces";
      this.lblNbPieces.Size = new System.Drawing.Size(54, 13);
      this.lblNbPieces.TabIndex = 5;
      this.lblNbPieces.Text = "# pièces :";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tableLayoutPanel1.Controls.Add(this.lblTempsJeu, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblPctPieces, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblNbPieces, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblTemps, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 89);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 409);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // lblTemps
      // 
      this.lblTemps.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTemps.AutoSize = true;
      this.lblTemps.Location = new System.Drawing.Point(319, 61);
      this.lblTemps.Name = "lblTemps";
      this.lblTemps.Size = new System.Drawing.Size(34, 13);
      this.lblTemps.TabIndex = 6;
      this.lblTemps.Text = "00:00";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(115, 139);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 130);
      this.tableLayoutPanel2.TabIndex = 7;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(115, 275);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(442, 131);
      this.tableLayoutPanel3.TabIndex = 8;
      // 
      // frmFinPartie
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 561);
      this.ControlBox = false;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.lblTextFinPartie);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnRestart);
      this.MaximumSize = new System.Drawing.Size(600, 600);
      this.MinimumSize = new System.Drawing.Size(600, 600);
      this.Name = "frmFinPartie";
      this.Text = "Fin de partie";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label lblTextFinPartie;
    private System.Windows.Forms.Label lblTempsJeu;
    private System.Windows.Forms.Label lblPctPieces;
    private System.Windows.Forms.Label lblNbPieces;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTemps;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
  }
}