﻿namespace TP3
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
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
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
      this.options.Text = "options";
      this.options.UseVisualStyleBackColor = true;
      this.options.Click += new System.EventHandler(this.options_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(771, 955);
      this.Controls.Add(this.options);
      this.Controls.Add(this.nbPoints);
      this.Controls.Add(this.tableauJeu);
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Main";
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
  }
}

