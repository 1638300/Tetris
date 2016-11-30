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
  public partial class Options : Form
  {
    public Options()
    {
      InitializeComponent();
    }
    public int nbColonnesChanger;
    public int nbLignesChanger;
    public void nbColonnes_ValueChanged(object sender, EventArgs e)
    {
      nbColonnesChanger = (int)nbColonnesOptions.Value; 
    }

    public void nbLignes_ValueChanged(object sender, EventArgs e)
    {
      nbLignesChanger = (int)nbLignesOptions.Value;
    }
  }
}
