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
    public bool musiqueOptions;
    public bool effetsOptions;

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
