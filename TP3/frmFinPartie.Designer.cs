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
      this.layoutStats = new System.Windows.Forms.TableLayoutPanel();
      this.layoutNbPiece = new System.Windows.Forms.TableLayoutPanel();
      this.layoutPctPiece = new System.Windows.Forms.TableLayoutPanel();
      this.lblTemps = new System.Windows.Forms.Label();
      this.lblNbCarre = new System.Windows.Forms.Label();
      this.lblNbLigne = new System.Windows.Forms.Label();
      this.lblNbT = new System.Windows.Forms.Label();
      this.lblNbL = new System.Windows.Forms.Label();
      this.lblNbJ = new System.Windows.Forms.Label();
      this.lblNbS = new System.Windows.Forms.Label();
      this.lblNbZ = new System.Windows.Forms.Label();
      this.lblPctCarre = new System.Windows.Forms.Label();
      this.lblPctLigne = new System.Windows.Forms.Label();
      this.lblPctT = new System.Windows.Forms.Label();
      this.lblPctL = new System.Windows.Forms.Label();
      this.lblPctJ = new System.Windows.Forms.Label();
      this.lblPctS = new System.Windows.Forms.Label();
      this.lblPctZ = new System.Windows.Forms.Label();
      this.nbCarre = new System.Windows.Forms.Label();
      this.nbLigne = new System.Windows.Forms.Label();
      this.nbT = new System.Windows.Forms.Label();
      this.nbL = new System.Windows.Forms.Label();
      this.nbJ = new System.Windows.Forms.Label();
      this.nbS = new System.Windows.Forms.Label();
      this.nbZ = new System.Windows.Forms.Label();
      this.pctCarre = new System.Windows.Forms.Label();
      this.pctLigne = new System.Windows.Forms.Label();
      this.pctT = new System.Windows.Forms.Label();
      this.pctL = new System.Windows.Forms.Label();
      this.pctJ = new System.Windows.Forms.Label();
      this.pctS = new System.Windows.Forms.Label();
      this.pctZ = new System.Windows.Forms.Label();
      this.layoutStats.SuspendLayout();
      this.layoutNbPiece.SuspendLayout();
      this.layoutPctPiece.SuspendLayout();
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
      this.lblTempsJeu.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTempsJeu.AutoSize = true;
      this.lblTempsJeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTempsJeu.Location = new System.Drawing.Point(14, 55);
      this.lblTempsJeu.Name = "lblTempsJeu";
      this.lblTempsJeu.Size = new System.Drawing.Size(84, 25);
      this.lblTempsJeu.TabIndex = 3;
      this.lblTempsJeu.Text = "Temps :";
      // 
      // lblPctPieces
      // 
      this.lblPctPieces.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctPieces.AutoSize = true;
      this.lblPctPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPctPieces.Location = new System.Drawing.Point(4, 328);
      this.lblPctPieces.Name = "lblPctPieces";
      this.lblPctPieces.Size = new System.Drawing.Size(103, 25);
      this.lblPctPieces.TabIndex = 4;
      this.lblPctPieces.Text = "% pièces :";
      // 
      // lblNbPieces
      // 
      this.lblNbPieces.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbPieces.AutoSize = true;
      this.lblNbPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNbPieces.Location = new System.Drawing.Point(8, 191);
      this.lblNbPieces.Name = "lblNbPieces";
      this.lblNbPieces.Size = new System.Drawing.Size(96, 25);
      this.lblNbPieces.TabIndex = 5;
      this.lblNbPieces.Text = "# pièces :";
      // 
      // layoutStats
      // 
      this.layoutStats.ColumnCount = 2;
      this.layoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.layoutStats.Controls.Add(this.lblTempsJeu, 0, 0);
      this.layoutStats.Controls.Add(this.lblPctPieces, 0, 2);
      this.layoutStats.Controls.Add(this.lblNbPieces, 0, 1);
      this.layoutStats.Controls.Add(this.layoutNbPiece, 1, 1);
      this.layoutStats.Controls.Add(this.layoutPctPiece, 1, 2);
      this.layoutStats.Controls.Add(this.lblTemps, 1, 0);
      this.layoutStats.Location = new System.Drawing.Point(12, 89);
      this.layoutStats.Name = "layoutStats";
      this.layoutStats.RowCount = 3;
      this.layoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.layoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.layoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.layoutStats.Size = new System.Drawing.Size(560, 409);
      this.layoutStats.TabIndex = 6;
      // 
      // layoutNbPiece
      // 
      this.layoutNbPiece.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.layoutNbPiece.ColumnCount = 7;
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutNbPiece.Controls.Add(this.nbZ, 6, 1);
      this.layoutNbPiece.Controls.Add(this.nbS, 5, 1);
      this.layoutNbPiece.Controls.Add(this.nbJ, 4, 1);
      this.layoutNbPiece.Controls.Add(this.nbL, 3, 1);
      this.layoutNbPiece.Controls.Add(this.nbT, 2, 1);
      this.layoutNbPiece.Controls.Add(this.nbLigne, 1, 1);
      this.layoutNbPiece.Controls.Add(this.lblNbCarre, 0, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbLigne, 1, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbT, 2, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbL, 3, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbJ, 4, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbS, 5, 0);
      this.layoutNbPiece.Controls.Add(this.lblNbZ, 6, 0);
      this.layoutNbPiece.Controls.Add(this.nbCarre, 0, 1);
      this.layoutNbPiece.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutNbPiece.Location = new System.Drawing.Point(115, 139);
      this.layoutNbPiece.Name = "layoutNbPiece";
      this.layoutNbPiece.RowCount = 2;
      this.layoutNbPiece.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutNbPiece.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutNbPiece.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.layoutNbPiece.Size = new System.Drawing.Size(442, 130);
      this.layoutNbPiece.TabIndex = 7;
      // 
      // layoutPctPiece
      // 
      this.layoutPctPiece.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.layoutPctPiece.ColumnCount = 7;
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.layoutPctPiece.Controls.Add(this.pctZ, 6, 1);
      this.layoutPctPiece.Controls.Add(this.pctS, 5, 1);
      this.layoutPctPiece.Controls.Add(this.pctJ, 4, 1);
      this.layoutPctPiece.Controls.Add(this.pctL, 3, 1);
      this.layoutPctPiece.Controls.Add(this.pctT, 2, 1);
      this.layoutPctPiece.Controls.Add(this.pctLigne, 1, 1);
      this.layoutPctPiece.Controls.Add(this.pctCarre, 0, 1);
      this.layoutPctPiece.Controls.Add(this.lblPctCarre, 0, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctLigne, 1, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctT, 2, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctL, 3, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctJ, 4, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctS, 5, 0);
      this.layoutPctPiece.Controls.Add(this.lblPctZ, 6, 0);
      this.layoutPctPiece.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutPctPiece.Location = new System.Drawing.Point(115, 275);
      this.layoutPctPiece.Name = "layoutPctPiece";
      this.layoutPctPiece.RowCount = 2;
      this.layoutPctPiece.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutPctPiece.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutPctPiece.Size = new System.Drawing.Size(442, 131);
      this.layoutPctPiece.TabIndex = 8;
      // 
      // lblTemps
      // 
      this.lblTemps.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTemps.AutoSize = true;
      this.lblTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTemps.Location = new System.Drawing.Point(239, 31);
      this.lblTemps.Name = "lblTemps";
      this.lblTemps.Size = new System.Drawing.Size(194, 73);
      this.lblTemps.TabIndex = 6;
      this.lblTemps.Text = "00:00";
      // 
      // lblNbCarre
      // 
      this.lblNbCarre.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbCarre.AutoSize = true;
      this.lblNbCarre.Location = new System.Drawing.Point(15, 26);
      this.lblNbCarre.Name = "lblNbCarre";
      this.lblNbCarre.Size = new System.Drawing.Size(32, 13);
      this.lblNbCarre.TabIndex = 0;
      this.lblNbCarre.Text = "Carré";
      // 
      // lblNbLigne
      // 
      this.lblNbLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbLigne.AutoSize = true;
      this.lblNbLigne.Location = new System.Drawing.Point(77, 26);
      this.lblNbLigne.Name = "lblNbLigne";
      this.lblNbLigne.Size = new System.Drawing.Size(33, 13);
      this.lblNbLigne.TabIndex = 1;
      this.lblNbLigne.Text = "Ligne";
      // 
      // lblNbT
      // 
      this.lblNbT.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbT.AutoSize = true;
      this.lblNbT.Location = new System.Drawing.Point(148, 26);
      this.lblNbT.Name = "lblNbT";
      this.lblNbT.Size = new System.Drawing.Size(14, 13);
      this.lblNbT.TabIndex = 2;
      this.lblNbT.Text = "T";
      // 
      // lblNbL
      // 
      this.lblNbL.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbL.AutoSize = true;
      this.lblNbL.Location = new System.Drawing.Point(211, 26);
      this.lblNbL.Name = "lblNbL";
      this.lblNbL.Size = new System.Drawing.Size(13, 13);
      this.lblNbL.TabIndex = 3;
      this.lblNbL.Text = "L";
      // 
      // lblNbJ
      // 
      this.lblNbJ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbJ.AutoSize = true;
      this.lblNbJ.Location = new System.Drawing.Point(273, 26);
      this.lblNbJ.Name = "lblNbJ";
      this.lblNbJ.Size = new System.Drawing.Size(12, 13);
      this.lblNbJ.TabIndex = 4;
      this.lblNbJ.Text = "J";
      // 
      // lblNbS
      // 
      this.lblNbS.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbS.AutoSize = true;
      this.lblNbS.Location = new System.Drawing.Point(334, 26);
      this.lblNbS.Name = "lblNbS";
      this.lblNbS.Size = new System.Drawing.Size(14, 13);
      this.lblNbS.TabIndex = 5;
      this.lblNbS.Text = "S";
      // 
      // lblNbZ
      // 
      this.lblNbZ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNbZ.AutoSize = true;
      this.lblNbZ.Location = new System.Drawing.Point(400, 26);
      this.lblNbZ.Name = "lblNbZ";
      this.lblNbZ.Size = new System.Drawing.Size(14, 13);
      this.lblNbZ.TabIndex = 6;
      this.lblNbZ.Text = "Z";
      // 
      // lblPctCarre
      // 
      this.lblPctCarre.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctCarre.AutoSize = true;
      this.lblPctCarre.Location = new System.Drawing.Point(15, 26);
      this.lblPctCarre.Name = "lblPctCarre";
      this.lblPctCarre.Size = new System.Drawing.Size(32, 13);
      this.lblPctCarre.TabIndex = 0;
      this.lblPctCarre.Text = "Carré";
      // 
      // lblPctLigne
      // 
      this.lblPctLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctLigne.AutoSize = true;
      this.lblPctLigne.Location = new System.Drawing.Point(77, 26);
      this.lblPctLigne.Name = "lblPctLigne";
      this.lblPctLigne.Size = new System.Drawing.Size(33, 13);
      this.lblPctLigne.TabIndex = 1;
      this.lblPctLigne.Text = "Ligne";
      // 
      // lblPctT
      // 
      this.lblPctT.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctT.AutoSize = true;
      this.lblPctT.Location = new System.Drawing.Point(148, 26);
      this.lblPctT.Name = "lblPctT";
      this.lblPctT.Size = new System.Drawing.Size(14, 13);
      this.lblPctT.TabIndex = 2;
      this.lblPctT.Text = "T";
      // 
      // lblPctL
      // 
      this.lblPctL.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctL.AutoSize = true;
      this.lblPctL.Location = new System.Drawing.Point(211, 26);
      this.lblPctL.Name = "lblPctL";
      this.lblPctL.Size = new System.Drawing.Size(13, 13);
      this.lblPctL.TabIndex = 3;
      this.lblPctL.Text = "L";
      // 
      // lblPctJ
      // 
      this.lblPctJ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctJ.AutoSize = true;
      this.lblPctJ.Location = new System.Drawing.Point(273, 26);
      this.lblPctJ.Name = "lblPctJ";
      this.lblPctJ.Size = new System.Drawing.Size(12, 13);
      this.lblPctJ.TabIndex = 4;
      this.lblPctJ.Text = "J";
      // 
      // lblPctS
      // 
      this.lblPctS.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctS.AutoSize = true;
      this.lblPctS.Location = new System.Drawing.Point(334, 26);
      this.lblPctS.Name = "lblPctS";
      this.lblPctS.Size = new System.Drawing.Size(14, 13);
      this.lblPctS.TabIndex = 5;
      this.lblPctS.Text = "S";
      // 
      // lblPctZ
      // 
      this.lblPctZ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblPctZ.AutoSize = true;
      this.lblPctZ.Location = new System.Drawing.Point(400, 26);
      this.lblPctZ.Name = "lblPctZ";
      this.lblPctZ.Size = new System.Drawing.Size(14, 13);
      this.lblPctZ.TabIndex = 6;
      this.lblPctZ.Text = "Z";
      // 
      // nbCarre
      // 
      this.nbCarre.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbCarre.AutoSize = true;
      this.nbCarre.Location = new System.Drawing.Point(25, 90);
      this.nbCarre.Name = "nbCarre";
      this.nbCarre.Size = new System.Drawing.Size(13, 13);
      this.nbCarre.TabIndex = 7;
      this.nbCarre.Text = "0";
      // 
      // nbLigne
      // 
      this.nbLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbLigne.AutoSize = true;
      this.nbLigne.Location = new System.Drawing.Point(87, 90);
      this.nbLigne.Name = "nbLigne";
      this.nbLigne.Size = new System.Drawing.Size(13, 13);
      this.nbLigne.TabIndex = 8;
      this.nbLigne.Text = "0";
      // 
      // nbT
      // 
      this.nbT.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbT.AutoSize = true;
      this.nbT.Location = new System.Drawing.Point(149, 90);
      this.nbT.Name = "nbT";
      this.nbT.Size = new System.Drawing.Size(13, 13);
      this.nbT.TabIndex = 9;
      this.nbT.Text = "0";
      // 
      // nbL
      // 
      this.nbL.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbL.AutoSize = true;
      this.nbL.Location = new System.Drawing.Point(211, 90);
      this.nbL.Name = "nbL";
      this.nbL.Size = new System.Drawing.Size(13, 13);
      this.nbL.TabIndex = 10;
      this.nbL.Text = "0";
      // 
      // nbJ
      // 
      this.nbJ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbJ.AutoSize = true;
      this.nbJ.Location = new System.Drawing.Point(273, 90);
      this.nbJ.Name = "nbJ";
      this.nbJ.Size = new System.Drawing.Size(13, 13);
      this.nbJ.TabIndex = 11;
      this.nbJ.Text = "0";
      // 
      // nbS
      // 
      this.nbS.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbS.AutoSize = true;
      this.nbS.Location = new System.Drawing.Point(335, 90);
      this.nbS.Name = "nbS";
      this.nbS.Size = new System.Drawing.Size(13, 13);
      this.nbS.TabIndex = 12;
      this.nbS.Text = "0";
      // 
      // nbZ
      // 
      this.nbZ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbZ.AutoSize = true;
      this.nbZ.Location = new System.Drawing.Point(400, 90);
      this.nbZ.Name = "nbZ";
      this.nbZ.Size = new System.Drawing.Size(13, 13);
      this.nbZ.TabIndex = 13;
      this.nbZ.Text = "0";
      // 
      // pctCarre
      // 
      this.pctCarre.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctCarre.AutoSize = true;
      this.pctCarre.Location = new System.Drawing.Point(25, 91);
      this.pctCarre.Name = "pctCarre";
      this.pctCarre.Size = new System.Drawing.Size(13, 13);
      this.pctCarre.TabIndex = 8;
      this.pctCarre.Text = "0";
      // 
      // pctLigne
      // 
      this.pctLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctLigne.AutoSize = true;
      this.pctLigne.Location = new System.Drawing.Point(87, 91);
      this.pctLigne.Name = "pctLigne";
      this.pctLigne.Size = new System.Drawing.Size(13, 13);
      this.pctLigne.TabIndex = 9;
      this.pctLigne.Text = "0";
      // 
      // pctT
      // 
      this.pctT.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctT.AutoSize = true;
      this.pctT.Location = new System.Drawing.Point(149, 91);
      this.pctT.Name = "pctT";
      this.pctT.Size = new System.Drawing.Size(13, 13);
      this.pctT.TabIndex = 10;
      this.pctT.Text = "0";
      // 
      // pctL
      // 
      this.pctL.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctL.AutoSize = true;
      this.pctL.Location = new System.Drawing.Point(211, 91);
      this.pctL.Name = "pctL";
      this.pctL.Size = new System.Drawing.Size(13, 13);
      this.pctL.TabIndex = 11;
      this.pctL.Text = "0";
      // 
      // pctJ
      // 
      this.pctJ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctJ.AutoSize = true;
      this.pctJ.Location = new System.Drawing.Point(273, 91);
      this.pctJ.Name = "pctJ";
      this.pctJ.Size = new System.Drawing.Size(13, 13);
      this.pctJ.TabIndex = 12;
      this.pctJ.Text = "0";
      // 
      // pctS
      // 
      this.pctS.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctS.AutoSize = true;
      this.pctS.Location = new System.Drawing.Point(335, 91);
      this.pctS.Name = "pctS";
      this.pctS.Size = new System.Drawing.Size(13, 13);
      this.pctS.TabIndex = 13;
      this.pctS.Text = "0";
      // 
      // pctZ
      // 
      this.pctZ.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pctZ.AutoSize = true;
      this.pctZ.Location = new System.Drawing.Point(400, 91);
      this.pctZ.Name = "pctZ";
      this.pctZ.Size = new System.Drawing.Size(13, 13);
      this.pctZ.TabIndex = 14;
      this.pctZ.Text = "0";
      // 
      // frmFinPartie
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 561);
      this.ControlBox = false;
      this.Controls.Add(this.layoutStats);
      this.Controls.Add(this.lblTextFinPartie);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnRestart);
      this.MaximumSize = new System.Drawing.Size(600, 600);
      this.MinimumSize = new System.Drawing.Size(600, 600);
      this.Name = "frmFinPartie";
      this.Text = "Fin de partie";
      this.layoutStats.ResumeLayout(false);
      this.layoutStats.PerformLayout();
      this.layoutNbPiece.ResumeLayout(false);
      this.layoutNbPiece.PerformLayout();
      this.layoutPctPiece.ResumeLayout(false);
      this.layoutPctPiece.PerformLayout();
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
    private System.Windows.Forms.TableLayoutPanel layoutStats;
    private System.Windows.Forms.Label lblTemps;
    private System.Windows.Forms.TableLayoutPanel layoutNbPiece;
    private System.Windows.Forms.TableLayoutPanel layoutPctPiece;
    private System.Windows.Forms.Label lblNbCarre;
    private System.Windows.Forms.Label lblNbLigne;
    private System.Windows.Forms.Label lblNbT;
    private System.Windows.Forms.Label lblNbL;
    private System.Windows.Forms.Label lblNbJ;
    private System.Windows.Forms.Label lblNbS;
    private System.Windows.Forms.Label lblNbZ;
    private System.Windows.Forms.Label lblPctCarre;
    private System.Windows.Forms.Label lblPctLigne;
    private System.Windows.Forms.Label lblPctT;
    private System.Windows.Forms.Label lblPctL;
    private System.Windows.Forms.Label lblPctJ;
    private System.Windows.Forms.Label lblPctS;
    private System.Windows.Forms.Label lblPctZ;
    private System.Windows.Forms.Label nbZ;
    private System.Windows.Forms.Label nbS;
    private System.Windows.Forms.Label nbJ;
    private System.Windows.Forms.Label nbL;
    private System.Windows.Forms.Label nbT;
    private System.Windows.Forms.Label nbLigne;
    private System.Windows.Forms.Label nbCarre;
    private System.Windows.Forms.Label pctZ;
    private System.Windows.Forms.Label pctS;
    private System.Windows.Forms.Label pctJ;
    private System.Windows.Forms.Label pctL;
    private System.Windows.Forms.Label pctT;
    private System.Windows.Forms.Label pctLigne;
    private System.Windows.Forms.Label pctCarre;
  }
}