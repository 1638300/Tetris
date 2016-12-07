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
  /// <summary>
  /// Formulaire contenant les options modifiables suivantes : jouer la musique ou non,
  /// jouer les effets sonores ou non, le nombre de lignes de la grille de jeu et
  /// le nombre de colonnes de la grille de jeu
  /// </summary>
  public partial class Options : Form
  {
    public Options()
    {
      InitializeComponent();
    }
    // Détermine si la musique est active ou non
    public bool musiqueOptions = true;
    // Détermine si les effets sonores sont actifs ou non
    public bool effetsOptions = true;
    /// <summary>
    /// Si l'état de la chekbox musique est changé, changer la valeur du booléen musiqueOptions en conséquent
    /// </summary>
    private void musique_CheckedChanged(object sender, EventArgs e)
    {
      if (musique.Checked == true)
      {
        musiqueOptions = true;
      }
      else
      {
        musiqueOptions = false;
      }
    }
    /// <summary>
    /// Si l'état de la chekbox effetsSonores est changé, changer la valeur du booléen effetsOptions en conséquent
    /// </summary>
    private void effetsSonores_CheckedChanged(object sender, EventArgs e)
    {
      if (effetsSonores.Checked == true)
      {
        effetsOptions = true;
      }
      else
      {
        effetsOptions = false;
      }
    }
  }
}
