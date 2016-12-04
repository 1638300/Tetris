namespace TP3
{
  partial class Options
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
      this.nbLignesOptions = new System.Windows.Forms.NumericUpDown();
      this.nbColonnesOptions = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.OK = new System.Windows.Forms.Button();
      this.Cancel = new System.Windows.Forms.Button();
      this.musique = new System.Windows.Forms.CheckBox();
      this.effetsSonores = new System.Windows.Forms.CheckBox();
      this.grpGrille = new System.Windows.Forms.GroupBox();
      this.grpSon = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.nbLignesOptions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbColonnesOptions)).BeginInit();
      this.grpGrille.SuspendLayout();
      this.grpSon.SuspendLayout();
      this.SuspendLayout();
      // 
      // nbLignesOptions
      // 
      this.nbLignesOptions.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nbLignesOptions.Location = new System.Drawing.Point(111, 45);
      this.nbLignesOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.nbLignesOptions.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.nbLignesOptions.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nbLignesOptions.Name = "nbLignesOptions";
      this.nbLignesOptions.Size = new System.Drawing.Size(90, 20);
      this.nbLignesOptions.TabIndex = 0;
      this.nbLignesOptions.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // nbColonnesOptions
      // 
      this.nbColonnesOptions.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nbColonnesOptions.Location = new System.Drawing.Point(4, 45);
      this.nbColonnesOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.nbColonnesOptions.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this.nbColonnesOptions.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nbColonnesOptions.Name = "nbColonnesOptions";
      this.nbColonnesOptions.Size = new System.Drawing.Size(90, 20);
      this.nbColonnesOptions.TabIndex = 1;
      this.nbColonnesOptions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 28);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "nombre de colonne";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(112, 28);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "nombre de ligne";
      // 
      // OK
      // 
      this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OK.Location = new System.Drawing.Point(19, 179);
      this.OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.OK.Name = "OK";
      this.OK.Size = new System.Drawing.Size(56, 19);
      this.OK.TabIndex = 4;
      this.OK.Text = "OK";
      this.OK.UseVisualStyleBackColor = true;
      // 
      // Cancel
      // 
      this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Cancel.Location = new System.Drawing.Point(136, 179);
      this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(56, 19);
      this.Cancel.TabIndex = 5;
      this.Cancel.Text = "Cancel";
      this.Cancel.UseVisualStyleBackColor = true;
      // 
      // musique
      // 
      this.musique.AutoSize = true;
      this.musique.Checked = true;
      this.musique.CheckState = System.Windows.Forms.CheckState.Checked;
      this.musique.Location = new System.Drawing.Point(0, 41);
      this.musique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.musique.Name = "musique";
      this.musique.Size = new System.Drawing.Size(65, 17);
      this.musique.TabIndex = 6;
      this.musique.Text = "musique";
      this.musique.UseVisualStyleBackColor = true;
      this.musique.CheckedChanged += new System.EventHandler(this.musique_CheckedChanged);
      // 
      // effetsSonores
      // 
      this.effetsSonores.AutoSize = true;
      this.effetsSonores.Checked = true;
      this.effetsSonores.CheckState = System.Windows.Forms.CheckState.Checked;
      this.effetsSonores.Location = new System.Drawing.Point(0, 20);
      this.effetsSonores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.effetsSonores.Name = "effetsSonores";
      this.effetsSonores.Size = new System.Drawing.Size(92, 17);
      this.effetsSonores.TabIndex = 7;
      this.effetsSonores.Text = "effets sonores";
      this.effetsSonores.UseVisualStyleBackColor = true;
      this.effetsSonores.CheckedChanged += new System.EventHandler(this.effetsSonores_CheckedChanged);
      // 
      // grpGrille
      // 
      this.grpGrille.Controls.Add(this.nbLignesOptions);
      this.grpGrille.Controls.Add(this.label1);
      this.grpGrille.Controls.Add(this.label2);
      this.grpGrille.Controls.Add(this.nbColonnesOptions);
      this.grpGrille.Location = new System.Drawing.Point(-3, 0);
      this.grpGrille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpGrille.Name = "grpGrille";
      this.grpGrille.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpGrille.Size = new System.Drawing.Size(206, 68);
      this.grpGrille.TabIndex = 8;
      this.grpGrille.TabStop = false;
      this.grpGrille.Text = "Grille de jeu";
      // 
      // grpSon
      // 
      this.grpSon.Controls.Add(this.effetsSonores);
      this.grpSon.Controls.Add(this.musique);
      this.grpSon.Location = new System.Drawing.Point(5, 89);
      this.grpSon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpSon.Name = "grpSon";
      this.grpSon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpSon.Size = new System.Drawing.Size(106, 66);
      this.grpSon.TabIndex = 9;
      this.grpSon.TabStop = false;
      this.grpSon.Text = "Musique et Son";
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(212, 207);
      this.ControlBox = false;
      this.Controls.Add(this.grpSon);
      this.Controls.Add(this.grpGrille);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.OK);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Options";
      this.Text = "Options";
      ((System.ComponentModel.ISupportInitialize)(this.nbLignesOptions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbColonnesOptions)).EndInit();
      this.grpGrille.ResumeLayout(false);
      this.grpGrille.PerformLayout();
      this.grpSon.ResumeLayout(false);
      this.grpSon.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.NumericUpDown nbLignesOptions;
    public System.Windows.Forms.NumericUpDown nbColonnesOptions;
    private System.Windows.Forms.Button OK;
    private System.Windows.Forms.Button Cancel;
    private System.Windows.Forms.CheckBox musique;
    private System.Windows.Forms.CheckBox effetsSonores;
    private System.Windows.Forms.GroupBox grpGrille;
    private System.Windows.Forms.GroupBox grpSon;
  }
}