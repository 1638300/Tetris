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
      this.tableauJeu = new System.Windows.Forms.TableLayoutPanel();
      this.descenteBloc = new System.Windows.Forms.Timer(this.components);
      this.nbPoints = new System.Windows.Forms.Label();
      this.options = new System.Windows.Forms.Button();
      this.tabBlocAVenir1 = new System.Windows.Forms.TableLayoutPanel();
      this.tabBlocAVenir2 = new System.Windows.Forms.TableLayoutPanel();
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
      this.tableauJeu.Location = new System.Drawing.Point(231, 52);
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
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableauJeu.Size = new System.Drawing.Size(296, 543);
      this.tableauJeu.TabIndex = 1;
      // 
      // descenteBloc
      // 
      this.descenteBloc.Interval = 1000;
      this.descenteBloc.Tick += new System.EventHandler(this.descenteBloc_Tick);
      // 
      // nbPoints
      // 
      this.nbPoints.AutoSize = true;
      this.nbPoints.Location = new System.Drawing.Point(129, 75);
      this.nbPoints.Name = "nbPoints";
      this.nbPoints.Size = new System.Drawing.Size(51, 17);
      this.nbPoints.TabIndex = 2;
      this.nbPoints.Text = "0 point";
      // 
      // options
      // 
      this.options.Location = new System.Drawing.Point(616, 75);
      this.options.Name = "options";
      this.options.Size = new System.Drawing.Size(75, 23);
      this.options.TabIndex = 3;
      this.options.TabStop = false;
      this.options.Text = "options";
      this.options.UseVisualStyleBackColor = true;
      this.options.Click += new System.EventHandler(this.options_Click);
      // 
      // tabBlocAVenir1
      // 
      this.tabBlocAVenir1.ColumnCount = 4;
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.Location = new System.Drawing.Point(602, 164);
      this.tabBlocAVenir1.Name = "tabBlocAVenir1";
      this.tabBlocAVenir1.RowCount = 4;
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir1.Size = new System.Drawing.Size(121, 103);
      this.tabBlocAVenir1.TabIndex = 4;
      // 
      // tabBlocAVenir2
      // 
      this.tabBlocAVenir2.ColumnCount = 4;
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.Location = new System.Drawing.Point(602, 348);
      this.tabBlocAVenir2.Name = "tabBlocAVenir2";
      this.tabBlocAVenir2.RowCount = 4;
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tabBlocAVenir2.Size = new System.Drawing.Size(121, 103);
      this.tabBlocAVenir2.TabIndex = 5;
      // 
      // Tetris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(771, 955);
      this.Controls.Add(this.tabBlocAVenir2);
      this.Controls.Add(this.tabBlocAVenir1);
      this.Controls.Add(this.options);
      this.Controls.Add(this.nbPoints);
      this.Controls.Add(this.tableauJeu);
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Tetris";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmLoad);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableauJeu;
    private System.Windows.Forms.Timer descenteBloc;
    private System.Windows.Forms.Label nbPoints;
    private System.Windows.Forms.Button options;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir1;
    private System.Windows.Forms.TableLayoutPanel tabBlocAVenir2;
  }
}

