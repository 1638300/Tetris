﻿using System;
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

    public void SetTempsJeu(string temps)
    {
      lblTemps.Text = temps;
    }
  }
}