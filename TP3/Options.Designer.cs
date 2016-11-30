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
      ((System.ComponentModel.ISupportInitialize)(this.nbLignesOptions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbColonnesOptions)).BeginInit();
      this.SuspendLayout();
      // 
      // nbLignesOptions
      // 
      this.nbLignesOptions.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nbLignesOptions.Location = new System.Drawing.Point(3, 67);
      this.nbLignesOptions.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.nbLignesOptions.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nbLignesOptions.Name = "nbLignesOptions";
      this.nbLignesOptions.Size = new System.Drawing.Size(120, 22);
      this.nbLignesOptions.TabIndex = 0;
      this.nbLignesOptions.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.nbLignesOptions.ValueChanged += new System.EventHandler(this.nbLignes_ValueChanged);
      // 
      // nbColonnesOptions
      // 
      this.nbColonnesOptions.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nbColonnesOptions.Location = new System.Drawing.Point(3, 27);
      this.nbColonnesOptions.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nbColonnesOptions.Name = "nbColonnesOptions";
      this.nbColonnesOptions.Size = new System.Drawing.Size(120, 22);
      this.nbColonnesOptions.TabIndex = 1;
      this.nbColonnesOptions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nbColonnesOptions.ValueChanged += new System.EventHandler(this.nbColonnes_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "nombre de colonne";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(0, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(110, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "nombre de ligne";
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 255);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nbColonnesOptions);
      this.Controls.Add(this.nbLignesOptions);
      this.Name = "Options";
      this.Text = "Form2";
      ((System.ComponentModel.ISupportInitialize)(this.nbLignesOptions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbColonnesOptions)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.NumericUpDown nbLignesOptions;
    public System.Windows.Forms.NumericUpDown nbColonnesOptions;
  }
}