/*
 * But de l'application :
 * Il s'agit d'un jeu de tetris en fenêtre Windows Form.
 * Cette page contient le code du fichier frmFinPartie.cs, qui regroupe l'ensemble des fonctions liées au formulaire sur la fin de la partie.
 * Indiquez aussi qui est (sont) l' (les) auteur(s).
 * Auteurs: Alek Savard et Yannick Gibeau
 * */
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="temps">Temps de jeu total depuis le début d'une partie</param>
    /// <param name="NbChaquePieces">Tableau qui contient le nombre de piece de chaque type jouées lors de la partie</param>
    public void SetStats(string temps, int[] NbChaquePieces)
    {
      //Déclarer les variables des statistiques
      float[] pctChaquePieces = new float[NbChaquePieces.Length];
      int NbPiecesTotal = 0;

      //Afficher le temps
      lblTemps.Text = temps;

      for (int i = 0; i < NbChaquePieces.Length; i++) //Pour le nombre de piece différentes
      {
        pctChaquePieces[i] = 0.00f;
        NbPiecesTotal = NbPiecesTotal + NbChaquePieces[i]; //Ajouter au nombre total de pièces en jeu
      }

      for (int i = 0; i < pctChaquePieces.Length; i++) //Pour le nombre de pieces à calculer le pourcentage total
      {
        if(NbChaquePieces[i] > 0) //Si le nombre de pièce est plus grand que 0
        {
          pctChaquePieces[i] = ((float)NbChaquePieces[i] / NbPiecesTotal) * 100; //Caluler son pourcentage de jeu
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
