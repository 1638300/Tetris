using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

//voir test
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
    PictureBox[,] ImagesBlocAVenir1 = null;
    PictureBox[,] ImagesBlocAVenir2 = null;
    PictureBox[,] ImagesBlocAVenir3 = null;
    PictureBox[,] ImagesBlocAVenir4 = null;
    int nbLignes = 20;
    int nbColonnes = 10;
    int[] positionYRelative = new int[4];
    int[] positionXRelative = new int[4];
    int[] tabComptePieces = new int[7]; //0 = carré, 1 = Ligne, 2 = T, 3 = L, 4 = J, 5 = S, 6 = Z.
    int colonneCourante;
    int ligneCourante;
    Random rnd = new Random();
    TypeBloc[,] tabLogique = new TypeBloc[20, 10];
    TypeBloc bloc;
    TypeBloc[] blocAVenir = new TypeBloc[5];
    Color blocCouleur;
    System.Media.SoundPlayer musique = new System.Media.SoundPlayer("DragonForce_-_Through_the_Fire_and_Flames_HD_Offic.wav");
    bool effetsSonoresActifs = true;
    bool musiqueActive = true;
    mouvement deplacement;
    DateTime timer = new DateTime();
    DateTime tempsDebutProgramme;
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
      tempsDebutProgramme = DateTime.Now;
      ExecuterTestsUnitaires();
      InitialiserSurfaceDeJeu(nbLignes, nbColonnes);
      InitialiserSurfaceBlocAVenir1(4, 4);
      InitialiserSurfaceBlocAVenir2(4, 4);
      InitialiserSurfaceBlocAVenir3(4, 4);
      InitialiserSurfaceBlocAVenir4(4, 4);
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
    private void InitialiserSurfaceBlocAVenir1(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 4 colonnes x 4 lignes
      ImagesBlocAVenir1 = new PictureBox[nbLignes, nbCols];
      tabBlocAVenir1.Controls.Clear();
      tabBlocAVenir1.ColumnCount = ImagesBlocAVenir1.GetLength(1);
      tabBlocAVenir1.RowCount = ImagesBlocAVenir1.GetLength(0);
      for (int i = 0; i < tabBlocAVenir1.RowCount; i++)
      {
        tabBlocAVenir1.RowStyles[i].Height = tabBlocAVenir1.Height / tabBlocAVenir1.RowCount;
        for (int j = 0; j < tabBlocAVenir1.ColumnCount; j++)
        {
          tabBlocAVenir1.ColumnStyles[j].Width = tabBlocAVenir1.Width / tabBlocAVenir1.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tabBlocAVenir1.Width / tabBlocAVenir1.ColumnCount;
          newPictureBox.Height = tabBlocAVenir1.Height / tabBlocAVenir1.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          ImagesBlocAVenir1[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tabBlocAVenir1.Controls.Add(newPictureBox, j, i);
        }
      }
    }
    private void InitialiserSurfaceBlocAVenir2(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 4 colonnes x 4 lignes
      ImagesBlocAVenir2 = new PictureBox[nbLignes, nbCols];
      tabBlocAVenir2.Controls.Clear();
      tabBlocAVenir2.ColumnCount = ImagesBlocAVenir2.GetLength(1);
      tabBlocAVenir2.RowCount = ImagesBlocAVenir2.GetLength(0);
      for (int i = 0; i < tabBlocAVenir2.RowCount; i++)
      {
        tabBlocAVenir2.RowStyles[i].Height = tabBlocAVenir2.Height / tabBlocAVenir2.RowCount;
        for (int j = 0; j < tabBlocAVenir2.ColumnCount; j++)
        {
          tabBlocAVenir2.ColumnStyles[j].Width = tabBlocAVenir2.Width / tabBlocAVenir2.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tabBlocAVenir2.Width / tabBlocAVenir2.ColumnCount;
          newPictureBox.Height = tabBlocAVenir2.Height / tabBlocAVenir2.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          ImagesBlocAVenir2[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tabBlocAVenir2.Controls.Add(newPictureBox, j, i);
        }
      }
    }
    private void InitialiserSurfaceBlocAVenir3(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 4 colonnes x 4 lignes
      ImagesBlocAVenir3 = new PictureBox[nbLignes, nbCols];
      tabBlocAVenir3.Controls.Clear();
      tabBlocAVenir3.ColumnCount = ImagesBlocAVenir3.GetLength(1);
      tabBlocAVenir3.RowCount = ImagesBlocAVenir3.GetLength(0);
      for (int i = 0; i < tabBlocAVenir3.RowCount; i++)
      {
        tabBlocAVenir3.RowStyles[i].Height = tabBlocAVenir3.Height / tabBlocAVenir3.RowCount;
        for (int j = 0; j < tabBlocAVenir3.ColumnCount; j++)
        {
          tabBlocAVenir3.ColumnStyles[j].Width = tabBlocAVenir3.Width / tabBlocAVenir3.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tabBlocAVenir3.Width / tabBlocAVenir3.ColumnCount;
          newPictureBox.Height = tabBlocAVenir3.Height / tabBlocAVenir3.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          ImagesBlocAVenir3[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tabBlocAVenir3.Controls.Add(newPictureBox, j, i);
        }
      }
    }
    private void InitialiserSurfaceBlocAVenir4(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 4 colonnes x 4 lignes
      ImagesBlocAVenir4 = new PictureBox[nbLignes, nbCols];
      tabBlocAVenir4.Controls.Clear();
      tabBlocAVenir4.ColumnCount = ImagesBlocAVenir4.GetLength(1);
      tabBlocAVenir4.RowCount = ImagesBlocAVenir4.GetLength(0);
      for (int i = 0; i < tabBlocAVenir4.RowCount; i++)
      {
        tabBlocAVenir4.RowStyles[i].Height = tabBlocAVenir4.Height / tabBlocAVenir4.RowCount;
        for (int j = 0; j < tabBlocAVenir4.ColumnCount; j++)
        {
          tabBlocAVenir4.ColumnStyles[j].Width = tabBlocAVenir4.Width / tabBlocAVenir4.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tabBlocAVenir4.Width / tabBlocAVenir4.ColumnCount;
          newPictureBox.Height = tabBlocAVenir4.Height / tabBlocAVenir4.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          ImagesBlocAVenir4[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tabBlocAVenir4.Controls.Add(newPictureBox, j, i);
        }
      }
    }
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
      musique.PlayLooping();
      InitialiserTableau();
      InitialiserTabBloc();
      InitialiserBloc();
    }
    void InitialiserBloc()
    {
      GererLigneComplete();
      colonneCourante = tabLogique.GetLength(1) / 2 - 1;
      ligneCourante = 0;
      GererTypeBlocs();
      GererCreationBlocDansJeu();
      timer = DateTime.Now;
      descenteBloc.Enabled = true;
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
        tabComptePieces[0]++;
      }
      if (bloc == TypeBloc.Ligne)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = -1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 2;
        tabComptePieces[1]++;
      }
      if (bloc == TypeBloc.T)
      {
        ligneCourante = 1;
        positionYRelative[0] = -1;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = 0;
        positionXRelative[1] = -1;
        positionXRelative[2] = 0;
        positionXRelative[3] = 1;
        tabComptePieces[2]++;
      }
      if (bloc == TypeBloc.L)
      {
        ligneCourante = 1;
        positionYRelative[0] = -1;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = 1;
        positionXRelative[1] = -1;
        positionXRelative[2] = 0;
        positionXRelative[3] = 1;
        tabComptePieces[3]++;
      }
      if (bloc == TypeBloc.J)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 1;
        positionXRelative[0] = -1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 1;
        tabComptePieces[4]++;
      }
      if (bloc == TypeBloc.S)
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 1;
        positionXRelative[2] = -1;
        positionXRelative[3] = 0;
        tabComptePieces[5]++;
      }
      if (bloc == TypeBloc.Z)
      {
        ligneCourante = 1;
        positionYRelative[0] = -1;
        positionYRelative[1] = -1;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = -1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 0;
        positionXRelative[3] = 1;
        tabComptePieces[6]++;
      }
      bool peutCreerBloc = true;
      for (int i = 0; i < positionXRelative.Length; i++)
      {
        peutCreerBloc = peutCreerBloc && tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] != TypeBloc.Gele;
      }

      if (peutCreerBloc == true)
      {
        MettreAJourPositionBlocDansTabLogique();
        GererCouleurBloc();
        AfficherBloc();
      }
      else
      {
        AfficherEcranFinDePartie();
      }
    }
    void GererTypeBlocs()
    {
      for (int i = 0; i < blocAVenir.Length-1; i++)
      {
        blocAVenir[i] = blocAVenir[i + 1];
      }
      bloc = blocAVenir[0]; //TypeBloc.Carre; 
      blocAVenir[blocAVenir.Length - 1] = (TypeBloc)rnd.Next(2, 9);
      AfficherBlocAVenir1();
      AfficherBlocAVenir2();
      AfficherBlocAVenir3();
      AfficherBlocAVenir4();
    }
    void InitialiserTabBloc()
    {
      for (int i = 0; i < blocAVenir.Length; i++)
      {
      blocAVenir[i] = (TypeBloc)rnd.Next(2, 9);
      }
      AfficherBlocAVenir1();
      AfficherBlocAVenir2();
    }
    void AfficherBlocAVenir1()
    {
      EffacerBlocVenir1();
      TypeBloc blocVenir1 = blocAVenir[1];
      if (blocVenir1 == TypeBloc.Carre)
      {
        ImagesBlocAVenir1[0, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir1[1, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir1[0, 1].BackColor = Color.Yellow;
        ImagesBlocAVenir1[1, 1].BackColor = Color.Yellow;
      }
      if (blocVenir1 == TypeBloc.Ligne)
      {
        ImagesBlocAVenir1[0, 0].BackColor = Color.Turquoise;
        ImagesBlocAVenir1[0, 1].BackColor = Color.Turquoise;
        ImagesBlocAVenir1[0, 2].BackColor = Color.Turquoise;
        ImagesBlocAVenir1[0, 3].BackColor = Color.Turquoise;
      }
      if (blocVenir1 == TypeBloc.T)
      {
        ImagesBlocAVenir1[0, 1].BackColor = Color.Purple;
        ImagesBlocAVenir1[1, 0].BackColor = Color.Purple;
        ImagesBlocAVenir1[1, 1].BackColor = Color.Purple;
        ImagesBlocAVenir1[1, 2].BackColor = Color.Purple;
      }
      if (blocVenir1 == TypeBloc.L)
      {
        ImagesBlocAVenir1[0, 2].BackColor = Color.Orange;
        ImagesBlocAVenir1[1, 0].BackColor = Color.Orange;
        ImagesBlocAVenir1[1, 1].BackColor = Color.Orange;
        ImagesBlocAVenir1[1, 2].BackColor = Color.Orange;
      }
      if (blocVenir1 == TypeBloc.J)
      {
        ImagesBlocAVenir1[0, 0].BackColor = Color.Blue;
        ImagesBlocAVenir1[0, 1].BackColor = Color.Blue;
        ImagesBlocAVenir1[0, 2].BackColor = Color.Blue;
        ImagesBlocAVenir1[1, 2].BackColor = Color.Blue;
      }
      if (blocVenir1 == TypeBloc.S)
      {
        ImagesBlocAVenir1[0, 1].BackColor = Color.Green;
        ImagesBlocAVenir1[0, 2].BackColor = Color.Green;
        ImagesBlocAVenir1[1, 0].BackColor = Color.Green;
        ImagesBlocAVenir1[1, 1].BackColor = Color.Green;
      }
      if (blocVenir1 == TypeBloc.Z)
      {
        ImagesBlocAVenir1[0, 0].BackColor = Color.Red;
        ImagesBlocAVenir1[0, 1].BackColor = Color.Red;
        ImagesBlocAVenir1[1, 1].BackColor = Color.Red;
        ImagesBlocAVenir1[1, 2].BackColor = Color.Red;
      }
    }
    void AfficherBlocAVenir2()
    {
      EffacerBlocVenir2();
      TypeBloc blocVenir1 = blocAVenir[2];
      if (blocVenir1 == TypeBloc.Carre)
      {
        ImagesBlocAVenir2[0, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir2[1, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir2[0, 1].BackColor = Color.Yellow;
        ImagesBlocAVenir2[1, 1].BackColor = Color.Yellow;
      }
      if (blocVenir1 == TypeBloc.Ligne)
      {
        ImagesBlocAVenir2[0, 0].BackColor = Color.Turquoise;
        ImagesBlocAVenir2[0, 1].BackColor = Color.Turquoise;
        ImagesBlocAVenir2[0, 2].BackColor = Color.Turquoise;
        ImagesBlocAVenir2[0, 3].BackColor = Color.Turquoise;
      }
      if (blocVenir1 == TypeBloc.T)
      {
        ImagesBlocAVenir2[0, 1].BackColor = Color.Purple;
        ImagesBlocAVenir2[1, 0].BackColor = Color.Purple;
        ImagesBlocAVenir2[1, 1].BackColor = Color.Purple;
        ImagesBlocAVenir2[1, 2].BackColor = Color.Purple;
      }
      if (blocVenir1 == TypeBloc.L)
      {
        ImagesBlocAVenir2[0, 2].BackColor = Color.Orange;
        ImagesBlocAVenir2[1, 0].BackColor = Color.Orange;
        ImagesBlocAVenir2[1, 1].BackColor = Color.Orange;
        ImagesBlocAVenir2[1, 2].BackColor = Color.Orange;
      }
      if (blocVenir1 == TypeBloc.J)
      {
        ImagesBlocAVenir2[0, 0].BackColor = Color.Blue;
        ImagesBlocAVenir2[0, 1].BackColor = Color.Blue;
        ImagesBlocAVenir2[0, 2].BackColor = Color.Blue;
        ImagesBlocAVenir2[1, 2].BackColor = Color.Blue;
      }
      if (blocVenir1 == TypeBloc.S)
      {
        ImagesBlocAVenir2[0, 1].BackColor = Color.Green;
        ImagesBlocAVenir2[0, 2].BackColor = Color.Green;
        ImagesBlocAVenir2[1, 0].BackColor = Color.Green;
        ImagesBlocAVenir2[1, 1].BackColor = Color.Green;
      }
      if (blocVenir1 == TypeBloc.Z)
      {
        ImagesBlocAVenir2[0, 0].BackColor = Color.Red;
        ImagesBlocAVenir2[0, 1].BackColor = Color.Red;
        ImagesBlocAVenir2[1, 1].BackColor = Color.Red;
        ImagesBlocAVenir2[1, 2].BackColor = Color.Red;
      }
    }
    void AfficherBlocAVenir3()
    {
      EffacerBlocVenir3();
      TypeBloc blocVenir1 = blocAVenir[3];
      if (blocVenir1 == TypeBloc.Carre)
      {
        ImagesBlocAVenir3[0, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir3[1, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir3[0, 1].BackColor = Color.Yellow;
        ImagesBlocAVenir3[1, 1].BackColor = Color.Yellow;
      }
      if (blocVenir1 == TypeBloc.Ligne)
      {
        ImagesBlocAVenir3[0, 0].BackColor = Color.Turquoise;
        ImagesBlocAVenir3[0, 1].BackColor = Color.Turquoise;
        ImagesBlocAVenir3[0, 2].BackColor = Color.Turquoise;
        ImagesBlocAVenir3[0, 3].BackColor = Color.Turquoise;
      }
      if (blocVenir1 == TypeBloc.T)
      {
        ImagesBlocAVenir3[0, 1].BackColor = Color.Purple;
        ImagesBlocAVenir3[1, 0].BackColor = Color.Purple;
        ImagesBlocAVenir3[1, 1].BackColor = Color.Purple;
        ImagesBlocAVenir3[1, 2].BackColor = Color.Purple;
      }
      if (blocVenir1 == TypeBloc.L)
      {
        ImagesBlocAVenir3[0, 2].BackColor = Color.Orange;
        ImagesBlocAVenir3[1, 0].BackColor = Color.Orange;
        ImagesBlocAVenir3[1, 1].BackColor = Color.Orange;
        ImagesBlocAVenir3[1, 2].BackColor = Color.Orange;
      }
      if (blocVenir1 == TypeBloc.J)
      {
        ImagesBlocAVenir3[0, 0].BackColor = Color.Blue;
        ImagesBlocAVenir3[0, 1].BackColor = Color.Blue;
        ImagesBlocAVenir3[0, 2].BackColor = Color.Blue;
        ImagesBlocAVenir3[1, 2].BackColor = Color.Blue;
      }
      if (blocVenir1 == TypeBloc.S)
      {
        ImagesBlocAVenir3[0, 1].BackColor = Color.Green;
        ImagesBlocAVenir3[0, 2].BackColor = Color.Green;
        ImagesBlocAVenir3[1, 0].BackColor = Color.Green;
        ImagesBlocAVenir3[1, 1].BackColor = Color.Green;
      }
      if (blocVenir1 == TypeBloc.Z)
      {
        ImagesBlocAVenir3[0, 0].BackColor = Color.Red;
        ImagesBlocAVenir3[0, 1].BackColor = Color.Red;
        ImagesBlocAVenir3[1, 1].BackColor = Color.Red;
        ImagesBlocAVenir3[1, 2].BackColor = Color.Red;
      }
    }
    void AfficherBlocAVenir4()
    {
      EffacerBlocVenir4();
      TypeBloc blocVenir1 = blocAVenir[1];
      if (blocVenir1 == TypeBloc.Carre)
      {
        ImagesBlocAVenir4[0, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir4[1, 0].BackColor = Color.Yellow;
        ImagesBlocAVenir4[0, 1].BackColor = Color.Yellow;
        ImagesBlocAVenir4[1, 1].BackColor = Color.Yellow;
      }
      if (blocVenir1 == TypeBloc.Ligne)
      {
        ImagesBlocAVenir4[0, 0].BackColor = Color.Turquoise;
        ImagesBlocAVenir4[0, 1].BackColor = Color.Turquoise;
        ImagesBlocAVenir4[0, 2].BackColor = Color.Turquoise;
        ImagesBlocAVenir4[0, 3].BackColor = Color.Turquoise;
      }
      if (blocVenir1 == TypeBloc.T)
      {
        ImagesBlocAVenir4[0, 1].BackColor = Color.Purple;
        ImagesBlocAVenir4[1, 0].BackColor = Color.Purple;
        ImagesBlocAVenir4[1, 1].BackColor = Color.Purple;
        ImagesBlocAVenir4[1, 2].BackColor = Color.Purple;
      }
      if (blocVenir1 == TypeBloc.L)
      {
        ImagesBlocAVenir4[0, 2].BackColor = Color.Orange;
        ImagesBlocAVenir4[1, 0].BackColor = Color.Orange;
        ImagesBlocAVenir4[1, 1].BackColor = Color.Orange;
        ImagesBlocAVenir4[1, 2].BackColor = Color.Orange;
      }
      if (blocVenir1 == TypeBloc.J)
      {
        ImagesBlocAVenir4[0, 0].BackColor = Color.Blue;
        ImagesBlocAVenir4[0, 1].BackColor = Color.Blue;
        ImagesBlocAVenir4[0, 2].BackColor = Color.Blue;
        ImagesBlocAVenir4[1, 2].BackColor = Color.Blue;
      }
      if (blocVenir1 == TypeBloc.S)
      {
        ImagesBlocAVenir4[0, 1].BackColor = Color.Green;
        ImagesBlocAVenir4[0, 2].BackColor = Color.Green;
        ImagesBlocAVenir4[1, 0].BackColor = Color.Green;
        ImagesBlocAVenir4[1, 1].BackColor = Color.Green;
      }
      if (blocVenir1 == TypeBloc.Z)
      {
        ImagesBlocAVenir4[0, 0].BackColor = Color.Red;
        ImagesBlocAVenir4[0, 1].BackColor = Color.Red;
        ImagesBlocAVenir4[1, 1].BackColor = Color.Red;
        ImagesBlocAVenir4[1, 2].BackColor = Color.Red;
      }
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
      else if (deplacement == mouvement.RotationHoraire)
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
        if (bloc != TypeBloc.Carre)
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
          peutBouger = false;
        }
      }
      else
      {
        if (bloc != TypeBloc.Carre )
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
        else
        {
          peutBouger = false;
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
      nbPoints.Text = nbPointsCourant.ToString();
    }
    void AfficherEcranFinDePartie()
    {
      frmFinPartie finPartie = new frmFinPartie();
      descenteBloc.Enabled = false;
      finPartie.SetTempsJeu(lblTempsEcoule.Text);
      musique.Stop();
      finPartie.ShowDialog();

      if (finPartie.DialogResult == DialogResult.Retry)
      {
        descenteBloc.Enabled = true;
        RecommencerPartie();
      }
      else
      {
        Application.Exit();
      }
    }
    void RecommencerPartie()
    {
      //Réinitialisation des données de jeu
      nbPointsCourant = 0;
      nbPoints.Text = "0";
      tempsDebutProgramme = DateTime.Now;

      //Réinitialiser la musique
      musique.PlayLooping();

      //Réinitialiser le tableau
      InitialiserSurfaceDeJeu(nbLignes, nbColonnes);
      run();
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
      else if (e.KeyChar == ' ')
      {
        deplacement = mouvement.Skip;
      }

      if (deplacement != mouvement.Rien && deplacement != mouvement.Skip)
      {
        if (VerifierDeplacementPossible())
        {
          GererDeplacement();
        }        
      }
      else if (deplacement == mouvement.Skip)
      {
        deplacement = mouvement.Bas;
        while (VerifierDeplacementPossible())
        {
          GererDeplacement();
        }
        deplacement = mouvement.Skip;
      }
    }
    void EffacerBlocVenir1()
    {
      for (int i = 0; i < ImagesBlocAVenir1.GetLength(0); i++)
      {
        for (int j = 0; j < ImagesBlocAVenir1.GetLength(1); j++)
        {
          ImagesBlocAVenir1[i,j].BackColor = Color.Black;
        }
      }
    }
    void EffacerBlocVenir2()
    {
      for (int i = 0; i < ImagesBlocAVenir2.GetLength(0); i++)
      {
        for (int j = 0; j < ImagesBlocAVenir2.GetLength(1); j++)
        {
          ImagesBlocAVenir2[i, j].BackColor = Color.Black;
        }
      }
    }
    void EffacerBlocVenir3()
    {
      for (int i = 0; i < ImagesBlocAVenir3.GetLength(0); i++)
      {
        for (int j = 0; j < ImagesBlocAVenir3.GetLength(1); j++)
        {
          ImagesBlocAVenir3[i, j].BackColor = Color.Black;
        }
      }
    }
    void EffacerBlocVenir4()
    {
      for (int i = 0; i < ImagesBlocAVenir4.GetLength(0); i++)
      {
        for (int j = 0; j < ImagesBlocAVenir4.GetLength(1); j++)
        {
          ImagesBlocAVenir4[i, j].BackColor = Color.Black;
        }
      }
    }
    private void descenteBloc_Tick(object sender, EventArgs e)
    {
      TimeSpan tempsEcoule = (DateTime.Now - tempsDebutProgramme);
      lblTempsEcoule.Text = tempsEcoule.ToString("mm\\:ss");
      deplacement = mouvement.Bas;
      if (VerifierDeplacementPossible())
      {
        GererDeplacement();
      }
      else
      {
        bloc = TypeBloc.Gele;
        MettreAJourPositionBlocDansTabLogique();
        InitialiserBloc();
      }
    }

    private void menuItemQuitter_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void menuItemRecommencer_Click(object sender, EventArgs e)
    {
      RecommencerPartie();
    }

    private void menuItemOptions_Click(object sender, EventArgs e)
    {
      Options optionsDialog = new Options();
      optionsDialog.nbColonnesOptions.Value = nbColonnes;
      optionsDialog.nbLignesOptions.Value = nbLignes;
      descenteBloc.Enabled = false;
      optionsDialog.ShowDialog();
      descenteBloc.Enabled = true;
      if (optionsDialog.DialogResult == DialogResult.OK)
      {
        nbLignes = (int)optionsDialog.nbLignesOptions.Value;
        nbColonnes = (int)optionsDialog.nbColonnesOptions.Value;
        musiqueActive = optionsDialog.musiqueOptions;
        effetsSonoresActifs = optionsDialog.effetsOptions;
      }
      RecommencerPartie();
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
  Bas,
  Skip
  }
}
