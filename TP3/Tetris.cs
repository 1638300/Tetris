using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;


namespace TP3
{
  public partial class Tetris : Form
  {
    public Tetris()
    {
      InitializeComponent();
    }

    #region Code fourni

    // Représentation visuelles du jeu en mémoire.
    PictureBox[,] toutesImagesVisuelles = null;
    int nbLignes = 20;
    int nbColonnes = 10;
    int[] positionYRelative = new int[4];
    int[] positionXRelative = new int[4];
    int colonneCourante;
    int ligneCourante;
    Random rnd = new Random();
    TypeBloc[,] tabLogique = new TypeBloc[20, 10];
    TypeBloc bloc;
    Color blocCouleur;
    SoundPlayer musique = new SoundPlayer();
    bool effetsSonoresActifs = true;
    bool musiqueActive = true;
    mouvement deplacement;
    DateTime timer = new DateTime();
    double nbPointsCourant = 0;


    /// <summary>
    /// Gestionnaire de l'événement se produisant lors du premier affichage 
    /// du formulaire principal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmLoad(object sender, EventArgs e)
    {
      // Ne pas oublier de mettre en place les valeurs nécessaires à une partie.
      ExecuterTestsUnitaires();
      InitialiserSurfaceDeJeu(nbLignes, nbColonnes);
      run();
    }

    private void InitialiserSurfaceDeJeu(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 10 colonnes x 20 lignes
      toutesImagesVisuelles = new PictureBox[nbLignes, nbCols];
      tableauJeu.Controls.Clear();
      tableauJeu.ColumnCount = toutesImagesVisuelles.GetLength(1);
      tableauJeu.RowCount = toutesImagesVisuelles.GetLength(0);
      for (int i = 0; i < tableauJeu.RowCount; i++)
      {
        tableauJeu.RowStyles[i].Height = tableauJeu.Height / tableauJeu.RowCount;
        for (int j = 0; j < tableauJeu.ColumnCount; j++)
        {
          tableauJeu.ColumnStyles[j].Width = tableauJeu.Width / tableauJeu.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tableauJeu.Width / tableauJeu.ColumnCount;
          newPictureBox.Height = tableauJeu.Height / tableauJeu.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          toutesImagesVisuelles[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tableauJeu.Controls.Add(newPictureBox, j, i);
        }
      }
    }
    #endregion

    void InitialiserTableau()
    {
      for (int i = 0; i < tabLogique.GetLength(0); i++)
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          tabLogique[i, j] = TypeBloc.None;
        }
      }
    }

    void run()
    {
      InitialiserTableau();
      InitialiserPartie();
    }
    void InitialiserPartie()
    {
      GererLigneComplete();
      colonneCourante = tabLogique.GetLength(1) / 2 - 1;
      ligneCourante = 0;
      GererTypeBlocs();
      GererCreationBlocDansJeu();
      timer = DateTime.Now;
      descenteBloc.Enabled = true;
      int ay;
    }
    void MettreAJourPositionBlocDansTabLogique()
    {
      for (int i = 0; i < positionXRelative.Length; i++)
      {
        tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] = bloc;
      }
    }
    void DetruireBlocCourant()
    {
      for (int i = 0; i < positionXRelative.Length; i++)
      {
        tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] = TypeBloc.None;
      }
    }
    void MettreAJourAffichageCourant()
    {
      for (int i = 0; i < positionXRelative.Length; i++)
      {
        toutesImagesVisuelles[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]].BackColor = Color.Black;
      }
    }
    void AfficherBloc()
    {
      for (int i = 0; i < positionXRelative.Length; i++)
      {
        toutesImagesVisuelles[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]].BackColor = blocCouleur;
      }
    }
    void GererCouleurBloc()
    {

      //Optimiser sans utiliser une variable.
      if (bloc == TypeBloc.Carre)
      {
        blocCouleur = Color.Yellow;
      }
      else if (bloc == TypeBloc.Ligne)
      {
        blocCouleur = Color.Turquoise;
      }
      else if (bloc == TypeBloc.T)
      {
        blocCouleur = Color.Purple;
      }
      else if (bloc == TypeBloc.L)
      {
        blocCouleur = Color.Orange;
      }
      else if (bloc == TypeBloc.J)
      {
        blocCouleur = Color.Blue;
      }
      else if (bloc == TypeBloc.S)
      {
        blocCouleur = Color.Green;
      }
      else if (bloc == TypeBloc.Z)
      {
        blocCouleur = Color.Red;
      }
    }
    void GererCreationBlocDansJeu()
    {
      if (bloc == TypeBloc.Carre)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 1;
        positionYRelative[2] = 0;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 1;
      }
      if (bloc == TypeBloc.Ligne)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = 0;
        positionXRelative[1] = 1;
        positionXRelative[2] = 2;
        positionXRelative[3] = 3;
      }
      if (bloc == TypeBloc.T)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 1;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 2;
      }
      if (bloc == TypeBloc.L)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 1;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 2;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 2;
      }
      if (bloc == TypeBloc.J)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 1;
        positionXRelative[2] = 2;
        positionXRelative[3] = 2;
      }
      if (bloc == TypeBloc.S)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 1;
        positionXRelative[1] = 2;
        positionXRelative[2] = 0;
        positionXRelative[3] = 1;
      }
      if (bloc == TypeBloc.Z)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 1;
        positionXRelative[2] = 1;
        positionXRelative[3] = 2;
      }
      MettreAJourPositionBlocDansTabLogique();
      GererCouleurBloc();
      AfficherBloc();
    }
    void GererTypeBlocs()
    {
      bloc = (TypeBloc)rnd.Next(2, 9);  //TypeBloc.Carre; //
    }
    void GererDeplacement()
    {
      if (deplacement == mouvement.Droite)
      {
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        colonneCourante++;
      }
      else if (deplacement == mouvement.Gauche)
      {
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        colonneCourante--;
      }
      else if (deplacement == mouvement.Bas)
      {
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        ligneCourante++;
      }
      else if (deplacement == mouvement.RotationAntihoraire)
      {
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        int temp = 0;
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          temp = -positionXRelative[i];
          positionXRelative[i] = positionYRelative[i];
          positionYRelative[i] = temp;
        }
      }
      else
      {
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        int temp = 0;
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          temp = -positionYRelative[i];
          positionYRelative[i] = positionXRelative[i];
          positionXRelative[i] = temp;
        }
      }

      MettreAJourPositionBlocDansTabLogique();
      AfficherBloc();
    }
    bool VerifierDeplacementPossible()
    {
      bool peutBouger = true;
      if (deplacement == mouvement.Gauche)
      {
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          if (colonneCourante - 1 + positionXRelative[i] < 0)
          {
            peutBouger = false;
          }
          else if (tabLogique[ligneCourante + positionYRelative[i], colonneCourante - 1 + positionXRelative[i]] == TypeBloc.Gele)
          {
            peutBouger = false;
          }
        }
      }
      else if (deplacement == mouvement.Droite)
      {
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          if (colonneCourante + 1 + positionXRelative[i] > tabLogique.GetLength(1) - 1)
          {
            peutBouger = false;
          }
          else if (tabLogique[ligneCourante + positionYRelative[i], colonneCourante + 1 + positionXRelative[i]] == TypeBloc.Gele)
          {
            peutBouger = false;
          }
        }
      }
      else if (deplacement == mouvement.Bas)
      {
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          if (ligneCourante + 1 + positionYRelative[i] > tabLogique.GetLength(0) - 1)
          {
            peutBouger = false;
          }
          else if (tabLogique[ligneCourante + 1 + positionYRelative[i], colonneCourante + positionXRelative[i]] == TypeBloc.Gele)
          {
            peutBouger = false;
          }
        }
      }
      else if (deplacement == mouvement.RotationAntihoraire)
      {
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          if (colonneCourante + positionYRelative[i] > tabLogique.GetLength(1) - 1 || colonneCourante + positionYRelative[i] < 0 || ligneCourante - positionXRelative[i] > tabLogique.GetLength(0) - 1 || ligneCourante - positionXRelative[i] < 0)
          {
            peutBouger = false;
          }
          else if (tabLogique[ligneCourante - positionXRelative[i], colonneCourante + positionYRelative[i]] == TypeBloc.Gele)
          {
            peutBouger = false;
          }
        }
      }
      else
      {
        for (int i = 0; i < positionXRelative.Length; i++)
        {
          if (colonneCourante - positionYRelative[i] > tabLogique.GetLength(1) - 1 || colonneCourante - positionYRelative[i] < 0 || ligneCourante + positionXRelative[i] > tabLogique.GetLength(0) - 1 || ligneCourante + positionXRelative[i] < 0)
          {
            peutBouger = false;
          }
          else if (tabLogique[ligneCourante + positionXRelative[i], colonneCourante - positionYRelative[i]] == TypeBloc.Gele)
          {
            peutBouger = false;
          }
        }
      }
      return peutBouger;
    }
    void DetruireLigneCompleteLogique(int positionLigne)
    {
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[positionLigne, j] = TypeBloc.None;
      }
    }
    void DetruireLigneCompleteAffichage(int positionLigne)
    {
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        toutesImagesVisuelles[positionLigne, j].BackColor = Color.Black;
      }
    }
    void DecalerLigneLogique(int positionLigne)
    {
      for (int i = positionLigne; i > 0; i--)
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          tabLogique[i, j] = tabLogique[i - 1, j];
        }
      }
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[0, j] = TypeBloc.None;
      }
    }
    void DecalerLigneAffichage(int positionLigne)
    {
      for (int i = positionLigne; i > 0; i--)
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          toutesImagesVisuelles[i, j].BackColor = toutesImagesVisuelles[i - 1, j].BackColor;
        }
      }
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        toutesImagesVisuelles[0, j].BackColor = Color.Black;
      }
    }
    void GererLigneComplete()
    {
      GererLigneCompleteAffichage();
      int nbLigneDetruite = GererLigneCompleteLogique();
      if (nbLigneDetruite > 0)
      {
        GererPointage(nbLigneDetruite);
      }
    }
    int GererLigneCompleteLogique()
    {
      int nbLigneDetruite = 0;
      bool ligneComplete = true;
      for (int i = 0; i < tabLogique.GetLength(0); i++)
      {
        ligneComplete = true;
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          if (tabLogique[i, j] != TypeBloc.Gele)
          {
            ligneComplete = false;
          }
        }
        if (ligneComplete)
        {
          DetruireLigneCompleteLogique(i);
          DecalerLigneLogique(i);
          nbLigneDetruite++;
        }
      }
      return nbLigneDetruite;
    }
    void GererLigneCompleteAffichage()
    {
      bool ligneComplete = true;
      for (int i = 0; i < tabLogique.GetLength(0); i++)
      {
        ligneComplete = true;
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          if (tabLogique[i, j] != TypeBloc.Gele)
          {
            ligneComplete = false;
          }
        }
        if (ligneComplete)
        {
          DetruireLigneCompleteAffichage(i);
          DecalerLigneAffichage(i);
        }
      }
    }
    void GererPointage(int nbLigneDetruite)
    {
      nbPointsCourant += Math.Pow(5, nbLigneDetruite);
      nbPoints.Text = nbPointsCourant + "points";
    }
    #region Code à développer
    /// <summary>
    /// Faites ici les appels requis pour vos tests unitaires.
    /// </summary>
    void ExecuterTestsUnitaires()
    {
      ExecuterTestRetraitLigneSeul();
      ExecuterTestRetraitLigneSeulEtDecalage();
      ExecuterTestRetrait2LignesConsecutives();
      ExecuterTestRetrait2LignesNonConsecutives();
      ExecuterTestRetrait3Lignes();
      ExecuterTestRetrait4Lignes();
      // A compléter...
    }

    // A renommer et commenter!
    void ExecuterTestRetraitLigneSeul()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.None);
      }
      // Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRetraitLigneSeulEtDecalage()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
        if (j < tabLogique.GetLength(1) - 1)
        {
          tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        }
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 2, j] == TypeBloc.None);
        if (j < tabLogique.GetLength(1) - 1)
        {
          Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.Gele);
        }
      }
      // Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRetrait2LignesConsecutives()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {     
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        if (j < tabLogique.GetLength(1) - 1)
        {
          tabLogique[tabLogique.GetLength(0) - 3, j] = TypeBloc.Gele;
          tabLogique[0, j] = TypeBloc.Gele;
        }
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 4, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 3, j] == TypeBloc.None);
        if (j < tabLogique.GetLength(1) - 1)
        {
          Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.Gele);
          Debug.Assert(tabLogique[2, j] == TypeBloc.Gele);
        }
      }
      // Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRetrait2LignesNonConsecutives()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
        tabLogique[0, j] = TypeBloc.Gele;
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.None);
        Debug.Assert(tabLogique[0, j] == TypeBloc.None);
        // Clean-up
      }
      InitialiserTableau();
    }
    void ExecuterTestRetrait3Lignes()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 3, j] = TypeBloc.Gele;
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 2, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 3, j] == TypeBloc.None);
      }
      // Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRetrait4Lignes()
    {
      // Mise en place des données du test
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[tabLogique.GetLength(0) - 1, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 3, j] = TypeBloc.Gele;
        tabLogique[tabLogique.GetLength(0) - 4, j] = TypeBloc.Gele;
      }
      // Exécuter de la méthode à tester
      GererLigneCompleteLogique();
      // Validation des résultats
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 1, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 2, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 3, j] == TypeBloc.None);
        Debug.Assert(tabLogique[tabLogique.GetLength(0) - 4, j] == TypeBloc.None);
      }
      // Clean-up
      InitialiserTableau();
    }

    #endregion

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      deplacement = mouvement.Rien;
      if (e.KeyChar == 's')
      {
        deplacement = mouvement.Bas;
      }
      else if (e.KeyChar == 'd')
      {
        deplacement = mouvement.Droite;
      }
      else if (e.KeyChar == 'a')
      {
        deplacement = mouvement.Gauche;
      }
      else if (e.KeyChar == 'n')
      {
        deplacement = mouvement.RotationAntihoraire;
      }
      else if (e.KeyChar == 'm')
      {
        deplacement = mouvement.RotationHoraire;
      }

      if(deplacement != mouvement.Rien)
      {
        if (VerifierDeplacementPossible())
        {
          GererDeplacement();
        }        
      }
    }

    private void descenteBloc_Tick(object sender, EventArgs e)
    {
      deplacement = mouvement.Bas;
      if (VerifierDeplacementPossible())
      {
        GererDeplacement();
      }
      else
      {
        bloc = TypeBloc.Gele;
        MettreAJourPositionBlocDansTabLogique();
        InitialiserPartie();
      }
    }

    private void options_Click(object sender, EventArgs e)
    {
      Options optionsDialog = new Options();
      optionsDialog.nbColonnesOptions.Value = nbColonnes;
      optionsDialog.nbLignesOptions.Value = nbLignes;
      descenteBloc.Enabled = false; 
      optionsDialog.ShowDialog();
      if (optionsDialog.DialogResult == DialogResult.OK)
      {
        nbLignes = (int)optionsDialog.nbLignesOptions.Value;
        nbColonnes = (int)optionsDialog.nbColonnesOptions.Value;
        musiqueActive = optionsDialog.musiqueOptions;
        effetsSonoresActifs = optionsDialog.effetsOptions;
      }
      //RecommencerPartie();
    }
  }
  enum TypeBloc
  {
  None,
  Gele,
  Carre, 
  Ligne, 
  T, 
  L, 
  J, 
  S, 
  Z
  }
  enum mouvement
  {
  Rien,
  RotationAntihoraire,
  RotationHoraire,
  Gauche,
  Droite,
  Bas
  }
}
