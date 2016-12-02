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
      this.SuspendLayout();
      // 
      // btnRestart
      // 
      this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Retry;
      this.btnRestart.Location = new System.Drawing.Point(38, 215);
      this.btnRestart.Name = "btnRestart";
      this.btnRestart.Size = new System.Drawing.Size(86, 34);
      this.btnRestart.TabIndex = 0;
      this.btnRestart.Text = "Restart";
      this.btnRestart.UseVisualStyleBackColor = true;
      // 
      // btnQuit
      // 
      this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Abort;
      this.btnQuit.Location = new System.Drawing.Point(160, 215);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(86, 34);
      this.btnQuit.TabIndex = 1;
      this.btnQuit.Text = "Quit";
      this.btnQuit.UseVisualStyleBackColor = true;
      // 
      // lblTextFinPartie
      // 
      this.lblTextFinPartie.AutoSize = true;
      this.lblTextFinPartie.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTextFinPartie.Location = new System.Drawing.Point(5, 6);
      this.lblTextFinPartie.Name = "lblTextFinPartie";
      this.lblTextFinPartie.Size = new System.Drawing.Size(276, 35);
      this.lblTextFinPartie.TabIndex = 2;
      this.lblTextFinPartie.Text = "Fin de partie !";
      // 
      // frmFinPartie
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.ControlBox = false;
      this.Controls.Add(this.lblTextFinPartie);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnRestart);
      this.Name = "frmFinPartie";
      this.Text = "Fin de partie";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label lblTextFinPartie;
  }
}