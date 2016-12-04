namespace TP3
{
  partial class Tetris
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
      this.tableauJeu = new System.Windows.Forms.TableLayoutPanel();
      this.descenteBloc = new System.Windows.Forms.Timer(this.components);
      this.nbPoints = new System.Windows.Forms.Label();
      this.tabBlocAVenir1 = new System.Windows.Forms.TableLayoutPanel();
      this.tabBlocAVenir2 = new System.Windows.Forms.TableLayoutPanel();
      this.menuJeu = new System.Windows.Forms.MenuStrip();
      this.menuItemJeu = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemRecommencer = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuItemQuitter = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.lblTempsEcoule = new System.Windows.Forms.Label();
      this.boxTemps = new System.Windows.Forms.GroupBox();
      this.boxPoints = new System.Windows.Forms.GroupBox();
      this.groupNextBloc = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tabBlocAVenir3 = new System.Windows.Forms.TableLayoutPanel();
      this.tabBlocAVenir4 = new System.Windows.Forms.TableLayoutPanel();
      this.timerDestroyLine = new System.Windows.Forms.Timer(this.components);
      this.imgMascot = new System.Windows.Forms.PictureBox();
      this.menuJeu.SuspendLayout();
      this.boxTemps.SuspendLayout();
      this.boxPoints.SuspendLayout();
      this.groupNextBloc.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgMascot)).BeginInit();
      this.SuspendLayout();
      // 
      // tableauJeu
      // 
      this.tableauJeu.ColumnCount = 20;
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63538F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.220217F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
      this.tableauJeu.Location = new System.Drawing.Point(347, 52);
      this.tableauJeu.Margin = new System.Windows.Forms.Padding(0);
      this.tableauJeu.Name = "tableauJeu";
      this.tableauJeu.RowCount = 30;
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.628941F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.350646F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.Size = new System.Drawing.Size(222, 441);
      this.tableauJeu.TabIndex = 1;
      // 
      // descenteBloc
      // 
      this.descenteBloc.Interval = 1000;
      this.descenteBloc.Tick += new System.EventHandler(this.descenteBloc_Tick);
      // 
      // nbPoints
      // 
      this.nbPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nbPoints.AutoSize = true;
      this.nbPoints.Location = new System.Drawing.Point(51, 25);
      this.nbPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.nbPoints.Name = "nbPoints";
      this.nbPoints.Size = new System.Drawing.Size(13, 13);
      this.nbPoints.TabIndex = 2;
      this.nbPoints.Text = "0";
      // 
      // tabBlocAVenir1
      // 
      this.tabBlocAVenir1.ColumnCount = 4;
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.Location = new System.Drawing.Point(3, 3);
      this.tabBlocAVenir1.Name = "tabBlocAVenir1";
      this.tabBlocAVenir1.RowCount = 4;
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.Size = new System.Drawing.Size(121, 99);
      this.tabBlocAVenir1.TabIndex = 4;
      // 
      // tabBlocAVenir2
      // 
      this.tabBlocAVenir2.ColumnCount = 4;
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.Location = new System.Drawing.Point(3, 108);
      this.tabBlocAVenir2.Name = "tabBlocAVenir2";
      this.tabBlocAVenir2.RowCount = 4;
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.Size = new System.Drawing.Size(121, 99);
      this.tabBlocAVenir2.TabIndex = 5;
      // 
      // menuJeu
      // 
      this.menuJeu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemJeu,
            this.menuItemOptions});
      this.menuJeu.Location = new System.Drawing.Point(0, 0);
      this.menuJeu.Name = "menuJeu";
      this.menuJeu.Size = new System.Drawing.Size(741, 24);
      this.menuJeu.TabIndex = 6;
      this.menuJeu.Text = "menuStrip1";
      // 
      // menuItemJeu
      // 
      this.menuItemJeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRecommencer,
            this.toolStripSeparator1,
            this.menuItemQuitter});
      this.menuItemJeu.Name = "menuItemJeu";
      this.menuItemJeu.Size = new System.Drawing.Size(36, 20);
      this.menuItemJeu.Text = "Jeu";
      // 
      // menuItemRecommencer
      // 
      this.menuItemRecommencer.Name = "menuItemRecommencer";
      this.menuItemRecommencer.Size = new System.Drawing.Size(151, 22);
      this.menuItemRecommencer.Text = "Recommencer";
      this.menuItemRecommencer.Click += new System.EventHandler(this.menuItemRecommencer_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
      // 
      // menuItemQuitter
      // 
      this.menuItemQuitter.Name = "menuItemQuitter";
      this.menuItemQuitter.Size = new System.Drawing.Size(151, 22);
      this.menuItemQuitter.Text = "Quitter";
      this.menuItemQuitter.Click += new System.EventHandler(this.menuItemQuitter_Click);
      // 
      // menuItemOptions
      // 
      this.menuItemOptions.Name = "menuItemOptions";
      this.menuItemOptions.Size = new System.Drawing.Size(61, 20);
      this.menuItemOptions.Text = "Options";
      this.menuItemOptions.Click += new System.EventHandler(this.menuItemOptions_Click);
      // 
      // lblTempsEcoule
      // 
      this.lblTempsEcoule.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTempsEcoule.AutoSize = true;
      this.lblTempsEcoule.Location = new System.Drawing.Point(41, 28);
      this.lblTempsEcoule.Name = "lblTempsEcoule";
      this.lblTempsEcoule.Size = new System.Drawing.Size(34, 13);
      this.lblTempsEcoule.TabIndex = 7;
      this.lblTempsEcoule.Text = "00:00";
      // 
      // boxTemps
      // 
      this.boxTemps.Controls.Add(this.lblTempsEcoule);
      this.boxTemps.Location = new System.Drawing.Point(23, 52);
      this.boxTemps.Name = "boxTemps";
      this.boxTemps.Size = new System.Drawing.Size(121, 59);
      this.boxTemps.TabIndex = 8;
      this.boxTemps.TabStop = false;
      this.boxTemps.Text = "Temps écoulé";
      // 
      // boxPoints
      // 
      this.boxPoints.Controls.Add(this.nbPoints);
      this.boxPoints.Location = new System.Drawing.Point(203, 52);
      this.boxPoints.Name = "boxPoints";
      this.boxPoints.Size = new System.Drawing.Size(121, 59);
      this.boxPoints.TabIndex = 9;
      this.boxPoints.TabStop = false;
      this.boxPoints.Text = "Pointage";
      // 
      // groupNextBloc
      // 
      this.groupNextBloc.Controls.Add(this.tableLayoutPanel1);
      this.groupNextBloc.Location = new System.Drawing.Point(587, 52);
      this.groupNextBloc.Name = "groupNextBloc";
      this.groupNextBloc.Size = new System.Drawing.Size(142, 441);
      this.groupNextBloc.TabIndex = 10;
      this.groupNextBloc.TabStop = false;
      this.groupNextBloc.Text = "Next";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tabBlocAVenir3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tabBlocAVenir4, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tabBlocAVenir1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tabBlocAVenir2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 422);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tabBlocAVenir3
      // 
      this.tabBlocAVenir3.ColumnCount = 4;
      this.tabBlocAVenir3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir3.Location = new System.Drawing.Point(3, 213);
      this.tabBlocAVenir3.Name = "tabBlocAVenir3";
      this.tabBlocAVenir3.RowCount = 4;
      this.tabBlocAVenir3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir3.Size = new System.Drawing.Size(121, 99);
      this.tabBlocAVenir3.TabIndex = 5;
      // 
      // tabBlocAVenir4
      // 
      this.tabBlocAVenir4.ColumnCount = 4;
      this.tabBlocAVenir4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir4.Location = new System.Drawing.Point(3, 318);
      this.tabBlocAVenir4.Name = "tabBlocAVenir4";
      this.tabBlocAVenir4.RowCount = 4;
      this.tabBlocAVenir4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir4.Size = new System.Drawing.Size(121, 99);
      this.tabBlocAVenir4.TabIndex = 6;
      // 
      // timerDestroyLine
      // 
      this.timerDestroyLine.Interval = 1000;
      this.timerDestroyLine.Tick += new System.EventHandler(this.timerDestroyLine_Tick);
      // 
      // imgMascot
      // 
      this.imgMascot.Image = global::TP3.Properties.Resources.ChocoForTetris;
      this.imgMascot.Location = new System.Drawing.Point(23, 142);
      this.imgMascot.Name = "imgMascot";
      this.imgMascot.Size = new System.Drawing.Size(301, 351);
      this.imgMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.imgMascot.TabIndex = 9;
      this.imgMascot.TabStop = false;
      // 
      // Tetris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(741, 514);
      this.Controls.Add(this.groupNextBloc);
      this.Controls.Add(this.boxPoints);
      this.Controls.Add(this.imgMascot);
      this.Controls.Add(this.boxTemps);
      this.Controls.Add(this.tableauJeu);
      this.Controls.Add(this.menuJeu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuJeu;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Tetris";
      this.Text = "Tetris";
      this.Load += new System.EventHandler(this.frmLoad);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
      this.menuJeu.ResumeLayout(false);
      this.menuJeu.PerformLayout();
      this.boxTemps.ResumeLayout(false);
      this.boxTemps.PerformLayout();
      this.boxPoints.ResumeLayout(false);
      this.boxPoints.PerformLayout();
      this.groupNextBloc.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imgMascot)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableauJeu;
    private System.Windows.Forms.Timer descenteBloc;
    private System.Windows.Forms.Label nbPoints;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir1;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir2;
    private System.Windows.Forms.MenuStrip menuJeu;
    private System.Windows.Forms.ToolStripMenuItem menuItemJeu;
    private System.Windows.Forms.ToolStripMenuItem menuItemRecommencer;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuItemQuitter;
    private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
    private System.Windows.Forms.Label lblTempsEcoule;
    private System.Windows.Forms.GroupBox boxTemps;
    private System.Windows.Forms.PictureBox imgMascot;
    private System.Windows.Forms.GroupBox boxPoints;
    private System.Windows.Forms.GroupBox groupNextBloc;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir3;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir4;
    private System.Windows.Forms.Timer timerDestroyLine;
  }
}

