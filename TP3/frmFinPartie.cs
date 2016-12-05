using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
  public partial class frmFinPartie : Form
  {
    public frmFinPartie()
    {
      InitializeComponent();
    }

    public void SetStats(string temps, int[] NbChaquePieces)
    {
      float[] pctChaquePieces = new float[NbChaquePieces.Length];
      int NbPiecesTotal = 0;
      lblTemps.Text = temps;

      for (int i = 0; i < NbChaquePieces.Length; i++)
      {
        pctChaquePieces[i] = 0.00f;
        NbPiecesTotal = NbPiecesTotal + NbChaquePieces[i];
      }

      for (int i = 0; i < pctChaquePieces.Length; i++)
      {
        if(NbChaquePieces[i] > 0)
        {
          pctChaquePieces[i] = ((float)NbChaquePieces[i] / NbPiecesTotal) * 100;
        }
      }

      //Affichage
      //Nombre Chaques Pièces
      nbCarre.Text = NbChaquePieces[0].ToString();
      nbLigne.Text = NbChaquePieces[1].ToString();
      nbT.Text = NbChaquePieces[2].ToString();
      nbL.Text = NbChaquePieces[3].ToString();
      nbJ.Text = NbChaquePieces[4].ToString();
      nbS.Text = NbChaquePieces[5].ToString();
      nbZ.Text = NbChaquePieces[6].ToString();

      //Pourcentage Chaques Pièces
      pctCarre.Text = pctChaquePieces[0].ToString("0.##") + "%";
      pctLigne.Text = pctChaquePieces[1].ToString("0.##") + "%";
      pctT.Text = pctChaquePieces[2].ToString("0.##") + "%";
      pctL.Text = pctChaquePieces[3].ToString("0.##") + "%";
      pctJ.Text = pctChaquePieces[4].ToString("0.##") + "%";
      pctS.Text = pctChaquePieces[5].ToString("0.##") + "%";
      pctZ.Text = pctChaquePieces[6].ToString("0.##") + "%";
    }
  }
}
