/*
 * But de l'application :
 * Il s'agit d'un jeu de tetris en fenêtre Windows Form.
 * Cette page contient le code du fichier Tetris.cs, qui regroupe l'ensemble des fonctions liées au formulaire principal du jeu de Tetris.
 * Indiquez aussi qui est (sont) l' (les) auteur(s).
 * Auteurs: Alek Savard et Yannick Gibeau
 * */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using WMPLib;
//voir test
namespace TP3
{
  public partial class Tetris : Form
  {
    public Tetris()
    {
      InitializeComponent();
    }

    #region Variables du projet

    // Représentation visuelles du jeu en mémoire. Ajouter.

    //Variables pictureBox
    PictureBox[,] toutesImagesVisuelles = null; //Tous les blocs à l'affichage

    //<Yannick>
    PictureBox[,] ImagesBlocAVenir1 = null; //Affichage du prochain bloc 
    PictureBox[,] ImagesBlocAVenir2 = null; //Affichage du bloc après le prochain bloc
    PictureBox[,] ImagesBlocAVenir3 = null; //Affichage du bloc après le prochain bloc
    PictureBox[,] ImagesBlocAVenir4 = null; //Affichage du bloc après le prochain bloc

    //Tableaux d'entiers
    int[] positionYRelative = new int[4]; //Les positions en y des blocs actifs par rapport au point de rotation
    int[] positionXRelative = new int[4]; //Les positions en x des blocs actifs par rapport au point de rotation
    int[] tabComptePieces = new int[7]; //0 = carré, 1 = Ligne, 2 = T, 3 = L, 4 = J, 5 = S, 6 = Z.

    //Variables entières
    int nbLignes = 20; //Nombre de lignes de la grille de jeu et d'affichage
    int nbColonnes = 10; //Nombre de colonnes de la grille de jeu et d'affichage
    int colonneCourante; //La position en x du point de rotation
    int ligneCourante; //La position en y du point de rotation

    //Variables de type TypeBloc
    TypeBloc[,] tabLogique = new TypeBloc[20, 10]; //Le tableau logique du jeu de Tetris contenant les types de bloc de la partie en cours
    TypeBloc[] blocAVenir = new TypeBloc[5];
    TypeBloc bloc; //Le type de bloc en cours du bloc joué

    //Données sonores du jeu
    System.Media.SoundPlayer musique = new System.Media.SoundPlayer("Resources//DragonForce_-_Through_the_Fire_and_Flames_HD_Offic.wav"); //La musique du jeu
    WindowsMediaPlayer explosion = new WindowsMediaPlayer(); //Effet sonore de placement de bloc
    WindowsMediaPlayer ligneDetruite = new WindowsMediaPlayer(); //Effet sonor de destruction de ligne et début de partie
    //</Yannick>

    //Variables booléennes
    //</Alek>
    bool jeuDangeureux = false; //Détermine la zone pour laquelle le jeu est considéré dangeureux (Change le visage de la mascotte)
    //</Alek>

    //<Yannick>
    bool effetsSonoresActifs = true; //Indique si les effets sonores sont actifs ou non
    bool musiqueActive = true; //Indique si la musique est active ou non

    //Reste des données qui n'ont pas de groupe
    Random rnd = new Random(); //Nombre aléatoire pour déterminer la prochaine pièce
    Color blocCouleur; //La couleur du bloc courant
    mouvement deplacement; //Mouvement que le joueur fait
    DateTime timer = new DateTime(); //Gère les évènements de tick du jeu, notamment la descente des blocs
    double nbPointsCourant = 0; //Indique le nombre de points que le joueur a fait depuis le début d'une partie
    //</Yannick>

    //<Alek>
    DateTime tempsDebutProgramme; //Détermine le temps écoulé depuis le début du programme
    //</Alek>
    #endregion

    #region Phase d'initialisation du jeu
    /* Partie Alek
    <Alek>
    //J'ai mis en place l'esthétisme du jeu, qui est codée dans la fenêtre alors il n'y a pas de code dans les .cs
    //Le titre et l'option quitter aussi c'est moi.
    //Initialiser bloc le visage à umi et la partie dangeureuse
    </Alek>
    */

    //<Yannick>
    //Initialisation primaire
    /// <summary>
    /// Gestionnaire de l'événement se produisant lors du premier affichage 
    /// du formulaire principal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmLoad(object sender, EventArgs e)
    {
      tempsDebutProgramme = DateTime.Now; //Initialise le temps de la partie à maintenant
      ExecuterTestsUnitaires(); //Exécute les tests unitaires avant la partie
      InitialiserSurfaceDeJeu(nbLignes, nbColonnes); //Initialise la surface de jeu de la grandeur souhaitée
      InitialiserSurfaceBlocAVenir1(4, 4); //Initialise l'espace disponible pour l'affichage du bloc à venir
      InitialiserSurfaceBlocAVenir2(4, 4); //Initialise l'espace disponible pour l'affichage du bloc à venir
      InitialiserSurfaceBlocAVenir3(4, 4); //Initialise l'espace disponible pour l'affichage du bloc à venir
      InitialiserSurfaceBlocAVenir4(4, 4); //Initialise l'espace disponible pour l'affichage du bloc à venir
      Run(); //Appelle la fonction de départ du jeu
    }
    /// <summary>
    /// Cette fonction s'occupe de faire jouer la musique du jeu au départ ainsi qu'à appeler diverses fonctions qui servent à initialiser les tableaux et le jeu
    /// </summary>
    void Run()
    {

      if (musiqueActive) //Si la musique est considérée active
      {
        musique.PlayLooping(); //Joue la musique
      }
      InitialiserTableau(); //Initialise la logique du tableau de jeu avec des blocs vides (None)
      InitialiserTabBloc(); //Initialise le tableau des blocs à venir
      InitialiserBloc(); //Initialise le visage de la mascotte au début, puis procèse à appeler les fonctions nécessaires à la création d'un bloc dans le jeu
    }
    /// <summary>
    /// La fonction initialise le tableau de jeu de tetris avec des carrés noir, soit l'arrière plan
    /// </summary>
    /// <param name="nbLignes">Nombre de lignes de la surface de jeu</param>
    /// <param name="nbCols">Nombre de colonnes de la surface de jeu</param>
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
    
    //Les blocs à venir
    /// <summary>
    /// Cette fonction initialise la surface pour l'affichage d'un bloc à venir
    /// </summary>
    /// <param name="nbLignes">Nombre de lignes de la surface de l'affichage du bloc à venir</param>
    /// <param name="nbCols">Nombre de colonnes de la surface de l'affichage du bloc à venir</param>
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
    } //Source : TP3 code fourni
    /// <summary>
    /// Cette fonction initialise la surface pour l'affichage d'un bloc à venir
    /// </summary>
    /// <param name="nbLignes">Nombre de lignes de la surface de l'affichage du bloc à venir</param>
    /// <param name="nbCols">Nombre de colonnes de la surface de l'affichage du bloc à venir</param>
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
    } //Source : TP3 code fourni

    //<Alek>
    /// <summary>
    /// Cette fonction initialise la surface pour l'affichage d'un bloc à venir
    /// </summary>
    /// <param name="nbLignes">Nombre de lignes de la surface de l'affichage du bloc à venir</param>
    /// <param name="nbCols">Nombre de colonnes de la surface de l'affichage du bloc à venir</param>
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
    } //Source : TP3 code fourni
    /// <summary>
    /// Cette fonction initialise la surface pour l'affichage d'un bloc à venir
    /// </summary>
    /// <param name="nbLignes">Nombre de lignes de la surface de l'affichage du bloc à venir</param>
    /// <param name="nbCols">Nombre de colonnes de la surface de l'affichage du bloc à venir</param>
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
    } //Source : TP3 code fourni
    //</Alek>

    //Initialiser les éléments dans la surface de jeu
    /// <summary>
    /// Cette fonction initialisera le tableau du jeu de tetris au vide
    /// </summary>
    void InitialiserTableau()
    {
      //Pour la grandeur du tableau en entier
      for (int i = 0; i < tabLogique.GetLength(0); i++) 
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          tabLogique[i, j] = TypeBloc.None; //Initialise les valeurs au vide (None)
        }
      }
    }
    /// <summary>
    /// Cette fonction initialise les tableaux d'affichage des blocs à venir
    /// </summary>
    void InitialiserTabBloc()
    {
      for (int i = 0; i < blocAVenir.Length; i++) //Pour tous les blocs à venir
      {
      blocAVenir[i] = (TypeBloc)rnd.Next(2, 9); //choisir un bloc au hasard
      }
    }

    //<Alek + Yannick>
    /// <summary>
    /// Fonction qui choisi le visage de la mascotte et qui appelle les fonctions pour créer un bloc dans le jeu
    /// </summary>
    void InitialiserBloc()
    {
      //<Alek>
      //Changement de visage, si il y a lieu au début
      jeuDangeureux = false;
      for (int i = 0; i < 8; i++) //Du haut du jeu jusqu'à la limite du "jeu dangeureux"
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++) //Pour tout la largeur du jeu
        {
          jeuDangeureux = jeuDangeureux || tabLogique[i, j] == TypeBloc.Gele; //Vérifier si il y a un bloc gelé dans la zone
        }
      }
      if (jeuDangeureux == true) //Si le jeu est dangeureux
      {
        imgMascot.Image = Properties.Resources.ChocoUmiForTetris; //Le visage de la mascotte devient celui de Umi (Elle a peur)
      }
      else
      {
        imgMascot.Image = Properties.Resources.ChocoForTetris; //Sinon c'est le visage de Chaika (Elle est contente)
      }
      //</Alek>

      //Gérer ensuite la création d'un bloc
      GererLigneComplete(); //Effectuer la mise à jour de la surface si une ligne doit être détruite
      colonneCourante = tabLogique.GetLength(1) / 2 - 1; //Initialiser la colonne au milieu de la surface
      ligneCourante = 0; //Et la ligne en haut de la surface
      GererTypeBlocs(); //Gérer quel type de bloc devra être généré
      GererCreationBlocDansJeu(); //Créer le bloc dans le jeu
      timer = DateTime.Now; //Initialiser le timer du jeu au temps présent
      descenteBloc.Enabled = true; //Activer le timer qui gère la descente des blocs
    }
    //</Alek + Yannick>

    //</Yannick>

    #endregion

    #region Gestion de la logique

    //<Yannick>
    /// <summary>
    /// Faire tous les actions s'apportant à la destruction d'une ligne dans le jeu: 
    /// vérifier la completion d'une ligne en appellant la fonction GererLigneCompleteAffichage et la fonction GererLigneCompleteLogique,
    /// s'occuper des effets visuels et audios d'une completion de ligne,
    /// changer le pointage en appellant la fonction GererPointage et
    /// s'occuper de l'effet sonore de la création d'un bloc (car cette fonction ce fait appeller au début du procéssus de création de bloc)
    /// </summary>
    void GererLigneComplete()
    {
      GererLigneCompleteAffichage(); //Gérer l'affichage si une ligne est à détruire
      int nbLigneDetruite = GererLigneCompleteLogique(); //Déterminer le nombre de lignes à détruire
      if (nbLigneDetruite > 0) //Si le nombre de lignes à détruire est plus grand que 0
      {
        imgMascot.Image = Properties.Resources.ChocoDioForTetris; //Le visage de la mascotte devient Dio (Méchant)
        timerDestroyLine.Enabled = true; //Activer le timer pour le temps que le visage de Dio reste
        GererPointage(nbLigneDetruite); //Ajouter des points au score
        if (effetsSonoresActifs) //Si les effets sonores sont activés
        {
          //Jouer le son de détruire une ligne
          ligneDetruite.URL = "Resources//Anime WOW Sound Effect.mp3";
          ligneDetruite.controls.play();
        }
      }
      if (effetsSonoresActifs) //Si les effets sonores sont activés
      {
        //Jouer le son de détruire une ligne
        explosion.URL = "Resources//Blast-SoundBible.com-2068539061.mp3";
        explosion.controls.play();
      }
    } //done
    /// <summary>
    /// Gerer la vérification de la completion d'une ligne dans le tableau tabLogique ainsi 
    /// que d'appeler la fonction qui s'occupe de la destrucion des lignes (DetruireLigneCompleteLogique) et 
    /// la fonction qui s'occupe du décalage des lignes (DecalerLigneLogique)
    /// </summary>
    /// <returns>Un entier représentant le nombre de lignes qui a été détruit</returns>
    int GererLigneCompleteLogique()
    {
      int nbLigneDetruite = 0; //Le nombre de lignes à détruire est 0 au départ
      bool ligneComplete = true; //Une ligne est complète tant qu'il ne s'y trouve pas un bloc non gelé
      for (int i = 0; i < tabLogique.GetLength(0); i++) //Pour la grandeur du tableau
      {
        ligneComplete = true;
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          if (tabLogique[i, j] != TypeBloc.Gele) //Si un bloc n'est pas gelé
          {
            ligneComplete = false; //La ligne n'est pas complète
          }
        }
        if (ligneComplete) //Si une ligne est complète
        {
          DetruireLigneCompleteLogique(i); //On détuit la ligne
          DecalerLigneLogique(i); //On la décale
          nbLigneDetruite++; //On ajoute une ligne détruite au compteur
        }
      }
      return nbLigneDetruite;
    } //done
    /// <summary>
    /// Calculer et changer le pointage de la partie
    /// </summary>
    void GererPointage(int nbLigneDetruite)
    {
      nbPointsCourant += Math.Pow(5, nbLigneDetruite); //le pointage est un calcul simple de 5^nbLigneDetruite
      nbPoints.Text = nbPointsCourant.ToString(); //Mettre le pointage dans le label de pointage
    } //done
    /// <summary>
    /// Jouer la musique si musiqueActive est true
    /// </summary>
    void GererSon()
    {
      if (musiqueActive) //Si la musique est activée dans les options
      {
      musique.PlayLooping(); //Jouer la musique
      }
      else //Sinon
      {
      musique.Stop(); //Arrêter la musique
      }
    } //done
    /// <summary>
    /// La fonction détermine la couleur à dessiner dans le tableau par rapport au type de bloc choisi
    /// </summary>
    void GererCouleurBloc()
    {
      //Liste des couleurs des blocs par rapport au au type choisi
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
    } //done

    //<Alek + Yannick>
    /// <summary>
    /// Détermine quel bloc doit être créer et set les positions relatives au point de rotation de chaque pièce
    /// En accord avec le type choisi
    /// Détermine si la partie est terminée ou non
    /// </summary>
    void GererCreationBlocDansJeu()
    {
      if (bloc == TypeBloc.Carre) //Si c'est un carré
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 1;
        positionYRelative[2] = 0;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 1;
        tabComptePieces[0]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.Ligne) //Si c'est une ligne
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 0;
        positionXRelative[0] = -1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 2;
        tabComptePieces[1]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.T) //Si c'est un T
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
        tabComptePieces[2]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.L) //Si c'est un L
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
        tabComptePieces[3]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.J) //Si c'est un J
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 0;
        positionYRelative[3] = 1;
        positionXRelative[0] = -1;
        positionXRelative[1] = 0;
        positionXRelative[2] = 1;
        positionXRelative[3] = 1;
        tabComptePieces[4]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.S) //Si c'est un S
      {
        positionYRelative[0] = 0;
        positionYRelative[1] = 0;
        positionYRelative[2] = 1;
        positionYRelative[3] = 1;
        positionXRelative[0] = 0;
        positionXRelative[1] = 1;
        positionXRelative[2] = -1;
        positionXRelative[3] = 0;
        tabComptePieces[5]++; //Augmenter le nombre de piece de ce type
      }
      if (bloc == TypeBloc.Z) //Si c'est un Z
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
        tabComptePieces[6]++; //Augmenter le nombre de piece de ce type
      }
      //<Alek>
      bool peutCreerBloc = DeterminerSiPartieTerminee(); //On peut créer un bloc si la partie n'est pas considérée terminée

      if (peutCreerBloc == true)
      {
        //<Yannick>
        MettreAJourPositionBlocDansTabLogique();
        GererCouleurBloc();
        AfficherBloc();
        //</Yannick>
      }
      else
      {
        AfficherEcranFinDePartie();
      }
      //</Alek>
    } //done
    //</Alek + Yannick>

    /// <summary>
    /// Gestion des blocs à venir et de leur affichage
    /// </summary>
    void GererTypeBlocs()
    {
      for (int i = 0; i < blocAVenir.Length-1; i++) //Pour le nombre de blocs à venir
      {
        blocAVenir[i] = blocAVenir[i + 1];//Afficher le bloc suivant
      }
      //Recréer un nouveau bloc à venir et afficher la nouvelle séquence
      bloc = blocAVenir[0]; 
      blocAVenir[blocAVenir.Length - 1] = (TypeBloc)rnd.Next(2, 9);
      AfficherBlocAVenir1();
      AfficherBlocAVenir2();
      //<Alek>
      AfficherBlocAVenir3();
      AfficherBlocAVenir4();
      //</Alek>
    } //done
    /// <summary>
    /// Détermine le mouvement entré par le joueur
    /// Détruit l'ancienne pièce
    /// La replace dans le tableau par rapport au mouvement
    /// L'affiche à nouveau, dans son nouvel emplacement
    /// </summary>
    void GererDeplacement()
    {
      if (deplacement == mouvement.Droite) //Si mouvement à droite
      {
        //Effectuer le mouvement 
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        colonneCourante++;
      }
      else if (deplacement == mouvement.Gauche)//Si mouvement à gauche
      {
        //Effectuer le mouvement 
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        colonneCourante--;
      }
      else if (deplacement == mouvement.Bas) //Si mouvement vers le bas
      {
        //Effectuer le mouvement 
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        ligneCourante++;
      }
      //<Alek en aide par Yannick>
      else if (deplacement == mouvement.RotationAntihoraire) //Si roatation antihoraire
      {
        //Effectuer le mouvement 
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        GererPositionRelativeAntiHoraire();
      }
      else if (deplacement == mouvement.RotationHoraire)//Si roatation horaire
      {
        //Effectuer le mouvement 
        DetruireBlocCourant();
        MettreAJourAffichageCourant();
        GererPositionRelativeHoraire();
      }
      //</Alek en aide par Yannick>

      //Afficher le bloc après le mouvement
      MettreAJourPositionBlocDansTabLogique();
      AfficherBloc();

    } //done

    //<Alek en aide par Yannick>
    /// <summary>
    /// Gestion des nouvelles positions relatives d'une pièce lors d'une rotation antihoraire
    /// </summary>
    void GererPositionRelativeAntiHoraire()
    {
      int temp = 0;
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties de la pièce à rotater
      {
        //Effectuer la rotation, X devient Y et Y devient -X
        temp = -positionXRelative[i];
        positionXRelative[i] = positionYRelative[i];
        positionYRelative[i] = temp;
      }
    } //done
    /// <summary>
    /// Gestion des nouvelles positions relatives d'une pièce lors d'une rotation horaire
    /// </summary>
    void GererPositionRelativeHoraire()
    {
      int temp = 0;
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties de la pièce à rotater
      {
        //Effectuer la rotation, Y devient X et X devient -Y
        temp = -positionYRelative[i];
        positionYRelative[i] = positionXRelative[i];
        positionXRelative[i] = temp;
      }
    } //done
    //</Alek en aide par Yannick>

    /// <summary>
    /// Met à jour la position de la pièce dans le jeu dans le tableau de jeu à chaque seconde ou commande
    /// </summary>
    void MettreAJourPositionBlocDansTabLogique()
    {
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties du type de bloc
      {
        tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] = bloc; //Donner au tableau le type de bloc à l'endroit approprié
      }
    } //done
    /// <summary>
    /// Met à jour l'affichage de la surface de jeu lors d'une commande
    /// </summary>
    void MettreAJourAffichageCourant()
    {
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties du type de bloc
      {
        toutesImagesVisuelles[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]].BackColor = Color.Black; //Colorier les parties en noir
      }
    } //done
    /// <summary>
    /// La fonction vérifie si un déplacement ou une rotation est possible lorsque le joueur entre une commande
    /// Elle vérifie s'il y a un mur ou si il y a une pièce gelé dans le chemin du déplacement
    /// </summary>
    /// <returns>La fonction retourne un booléen à savoir si le déplacement est possible</returns>
    bool VerifierDeplacementPossible()
    {
      bool peutBouger = true;
      if (deplacement == mouvement.Gauche) //Si le mouvement est à gauche
      {
        //Vérifier si une des parties de la pièce entre en colision avec un obstacle à sa gauche
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
      else if (deplacement == mouvement.Droite) //Si le mouvement est à droite
      {
        //Vérifier si une des parties de la pièce entre en colision avec un obstacle à sa droite
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
      else if (deplacement == mouvement.Bas) //Si le mouvement est en bas
      {
        //Vérifier si une des parties de la pièce entre en colision avec un obstacle en bas de celui-ci
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
      else if (deplacement == mouvement.RotationAntihoraire) //Si le mouvement est une rotation antihoraire
      {
        if (bloc != TypeBloc.Carre) //Si ce n'est pas un carré
        {
          //Vérifier si une des parties de la pièce entre en colision avec un obstacle dans sa rotation
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
      else //Sinon
      {
        if (bloc != TypeBloc.Carre) //Si ce n'est pas un carré
        {
          //Vérifier si une des parties de la pièce entre en colision avec un obstacle dans sa rotation
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
    } //done

    //<Alek>
    /// <summary>
    /// La fonction détermine si un bloc peut apparaître sur la surface de jeu
    /// Si c'est possible, la partie continue
    /// Sinon, c'est la fin
    /// </summary>
    /// <returns>Retourne un booléen à savoir si la partie est terminée ou non</returns>
    bool DeterminerSiPartieTerminee()
    {
      bool peutCreerBloc = true;
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties du bloc
      {
        //Vérifier si une d'elle entre en colision avec un bloc gelé lors de sa création
        peutCreerBloc = peutCreerBloc && tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] != TypeBloc.Gele;
      }

      return peutCreerBloc;
    } //done
    //</Alek>

    /// <summary>
    /// Fonction qui change les valeurs d'un bloc au vide pour l'effacer dans le tableau du jeu
    /// </summary>
    void DetruireBlocCourant()
    {
      for (int i = 0; i < positionXRelative.Length; i++) //pour toutes les parties du bloc
      {
        //Détruire celui-ci
        tabLogique[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]] = TypeBloc.None;
      }
    }//done
    /// <summary>dans le tableau tabLogique
    /// Remplace tous les valeurs en x d'une ligne donnée (en y) par la valeur TypeBLoc None dans le tableau tabLogique
    /// </summary>
    /// <param name="positionLigne"> Un entier qui représente une ligne en y du tableau tabLogique </param>
    void DetruireLigneCompleteLogique(int positionLigne)
    {
      for (int j = 0; j < tabLogique.GetLength(1); j++) //Pour les éléments de la ligne à détruire
      {
        //Détruire la ligne
        tabLogique[positionLigne, j] = TypeBloc.None;
      }
    } //done
    /// <summary>
    /// Décaler les valeurs contenues de toutes les lignes dans le tableau tabLogique qui se situent en haut de la ligne indiqué en paramètre de une ligne vers le bas 
    /// et remplace tous les valeurs de la ligne en haut du tableau (le y à 0) pour TypeBloc None
    /// </summary>
    /// <param name="positionLigne">Un entier qui représente une ligne en y du tableau tabLogique</param>
    void DecalerLigneLogique(int positionLigne)
    {
      for (int i = positionLigne; i > 0; i--) //Pour les éléments à décaler
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          tabLogique[i, j] = tabLogique[i - 1, j]; //Les décaler vers le bas
        }
      }
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[0, j] = TypeBloc.None; //Les initialiser au vide (none)
      }
    } //done

    //<Alek>
    /// <summary>
    /// Fonction qui réinitialise les données de jeu aux valeurs de départ pour permettre une nouvelle partie
    /// </summary>
    void RecommencerPartie()
    {
      //Réinitialisation des données de jeu
      for (int i = 0; i < tabComptePieces.Length; i++)
      {
        tabComptePieces[i] = 0;
      }
      nbPointsCourant = 0;
      nbPoints.Text = "0";
      tempsDebutProgramme = DateTime.Now;
      //Réinitialiser le tableau
      InitialiserSurfaceDeJeu(nbLignes, nbColonnes);
      //Recommencer la partie
      Run();
    }//done
    //</Alek>

    #endregion

    #region Gestion de l'affichage

    //<Yannick>
    /// <summary>
    /// Afficher un bloc avec la bonne couleur
    /// </summary>
    void AfficherBloc()
    {
      for (int i = 0; i < positionXRelative.Length; i++) //Pour toutes les parties du bloc
      {
        //Afficher ses couleurs relatives au bons endroits
        toutesImagesVisuelles[ligneCourante + positionYRelative[i], colonneCourante + positionXRelative[i]].BackColor = blocCouleur;
      }
    }
    /// <summary>
    ///  Afficher le bloc à venir dans son tableau
    /// </summary>
    void AfficherBlocAVenir1()
    {
      ///Effacer l'ancien bloc
      EffacerBlocVenir1();
      //Afficher le nouveau bloc avec les bonnes couleurs
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
    /// <summary>
    ///  Afficher le bloc à venir dans son tableau
    /// </summary>
    void AfficherBlocAVenir2()
    {
      //Effacer l'ancien bloc
      EffacerBlocVenir2();
      //Afficher le nouveau bloc avec les bonnes couleurs
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
    //</Yannick>

    //<Alek>
    /// <summary>
    ///  Afficher le bloc à venir dans son tableau
    /// </summary>
    void AfficherBlocAVenir3()
    {
      //Effacer l'ancien bloc
      EffacerBlocVenir3();
      //Afficher le nouveau bloc avec les bonnes couleurs
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
    /// <summary>
    ///  Afficher le bloc à venir dans son tableau
    /// </summary>
    void AfficherBlocAVenir4()
    {
      //Effacer l'ancien bloc
      EffacerBlocVenir4();
      //Afficher le nouveau bloc avec les bonnes couleurs
      TypeBloc blocVenir1 = blocAVenir[4];
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
    //</Alek>

    //<Yannick>
    /// <summary>
    /// Gerer la vérification de la completion d'une ligne dans le tableau toutesImagesVisuelles ainsi 
    /// que d'appeler la fonction qui s'occupe de la destrucion des lignes (DetruireLigneCompleteAffichage) et 
    /// la fonction qui s'occupe du décalage des lignes (DecalerLigneAffichage)
    /// </summary>
    void GererLigneCompleteAffichage()
    {
      bool ligneComplete = true;
      for (int i = 0; i < tabLogique.GetLength(0); i++) //Pour la longueur du tableau
      {
        ligneComplete = true;
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          if (tabLogique[i, j] != TypeBloc.Gele) //Si un bloc n'est pas gelé
          {
            ligneComplete = false; //La ligne n'est pas complète
          }
        }
        if (ligneComplete) //Si la ligne est complète
        {
          DetruireLigneCompleteAffichage(i); //On affiche la ligne détruite
          DecalerLigneAffichage(i); //On décale la ligne
        }
      }
    }
    /// <summary>
    /// Décaler les couleurs dans toutes les lignes dans le tableau tabLogique qui se situent en haut de la ligne indiqué en paramètre de une ligne vers le bas 
    /// et remplace tous les couleurs de la ligne en haut du tableau (le y à 0) pour la couleur noire
    /// </summary>
    /// <param name="positionLigne">Un entier qui représente une ligne en y du tableau tabLogique</param>
    void DecalerLigneAffichage(int positionLigne)
    {
      for (int i = positionLigne; i > 0; i--) //Pour la longueur du tableau
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          toutesImagesVisuelles[i, j].BackColor = toutesImagesVisuelles[i - 1, j].BackColor; //Colorier la nouvelle ligne de tableau décalée
        }
      }
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        toutesImagesVisuelles[0, j].BackColor = Color.Black; //Recolorier les anciennes cases en noir
      }
    }
    /// <summary>
    /// Remplace tous les couleurs de fonds des picturesBox en x d'une ligne donnée (y) par la couleur noire dans le tableau de picturesBox toutesImagesVisuelles
    /// </summary>
    /// <param name="positionLigne"> Un entier qui représente une ligne en y du tableau toutesImagesVisuelles </param>
    void DetruireLigneCompleteAffichage(int positionLigne)
    {
      for (int j = 0; j < tabLogique.GetLength(1); j++) //Pour les lignes à détruire
      {
        toutesImagesVisuelles[positionLigne, j].BackColor = Color.Black; //Colorier les lignes en noir
      }
    }
    //</Yannick>
    
    //<Alek>
    /// <summary>
    /// Afficher l'écran de fin de partie, avec ses statistiques, en arrêtant la partie présente
    /// </summary>
    void AfficherEcranFinDePartie()
    {
      //Créer la fenêtre de fin de partie avec ses données aux bonnes valeurs
      //Arrêter la musique et le temps
      frmFinPartie finPartie = new frmFinPartie();
      descenteBloc.Enabled = false;
      finPartie.SetStats(lblTempsEcoule.Text, tabComptePieces);
      musique.Stop();
      finPartie.ShowDialog();

      if (finPartie.DialogResult == DialogResult.Retry) //Si le joueur souhaite recommencer
      {
        descenteBloc.Enabled = true; //Recommencer le temps
        RecommencerPartie(); //Recommencer la partie
      }
      else //Sinon
      {
        Application.Exit(); //Quitter
      }
    }
    //</Alek>

    //<Yannick>
    /// <summary>
    /// Effacer le bloc du tableau de bloc à venir pour le remplacer
    /// </summary>
    void EffacerBlocVenir1()
    {
      for (int i = 0; i < ImagesBlocAVenir1.GetLength(0); i++) //Pour le tableau du bloc à afficher
      {
        for (int j = 0; j < ImagesBlocAVenir1.GetLength(1); j++)
        {
          ImagesBlocAVenir1[i, j].BackColor = Color.Black; //Recolorier en noir
        }
      }
    }
    /// <summary>
    /// Effacer le bloc du tableau de bloc à venir pour le remplacer
    /// </summary>
    void EffacerBlocVenir2()
    {
      for (int i = 0; i < ImagesBlocAVenir2.GetLength(0); i++) //Pour le tableau du bloc à afficher
      {
        for (int j = 0; j < ImagesBlocAVenir2.GetLength(1); j++)
        {
          ImagesBlocAVenir2[i, j].BackColor = Color.Black; //Recolorier en noir
        }
      }
    }
    //</Yannick>

    //<Alek>
    /// <summary>
    /// Effacer le bloc du tableau de bloc à venir pour le remplacer
    /// </summary>
    void EffacerBlocVenir3()
    {
      for (int i = 0; i < ImagesBlocAVenir3.GetLength(0); i++) //Pour le tableau du bloc à afficher
      {
        for (int j = 0; j < ImagesBlocAVenir3.GetLength(1); j++)
        {
          ImagesBlocAVenir3[i, j].BackColor = Color.Black; //Recolorier en noir
        }
      }
    }
    /// <summary>
    /// Effacer le bloc du tableau de bloc à venir pour le remplacer
    /// </summary>
    void EffacerBlocVenir4()
    {
      for (int i = 0; i < ImagesBlocAVenir4.GetLength(0); i++) //Pour le tableau du bloc à afficher
      {
        for (int j = 0; j < ImagesBlocAVenir4.GetLength(1); j++)
        {
          ImagesBlocAVenir4[i, j].BackColor = Color.Black; //Recolorier en noir
        }
      }
    }
    //</Alek>
    #endregion

    #region Évènements dans les formulaires

    //<Yannick>
    /// <summary>
    /// Fonction qui s'occupe de gérer l'évènement lié à l'entrée d'une touche sur le clavier
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Tetris_KeyPress(object sender, KeyPressEventArgs e)
    {
      deplacement = mouvement.Rien;
      //Détermine quelle touche a été entrée et l'associe au mouvement à engendrer
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
    /// <summary>
    /// Gère les évènement lié au tick du timer à chaque seconde, donc la descente du bloc sur le jeu et l'affichage
    /// et la gestion si un bloc ne peut plus descendre, donc le geler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void descenteBloc_Tick(object sender, EventArgs e)
    {
      //<Alek>
      //Gérer l'affichage du temps à chaque tick
      TimeSpan tempsEcoule = (DateTime.Now - tempsDebutProgramme);
      lblTempsEcoule.Text = tempsEcoule.ToString("mm\\:ss");
      //</Alek>

      //Effectuer un mouvement vers le bas si c'est possible, sinon geler le bloc en place
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
    /// <summary>
    /// Si cliqué, ouvrir une fenêtre de dialog Options et enregistrer les données qui y sont entrées si le DialogResult de celle-ci est OK
    /// </summary>
    private void menuItemOptions_Click(object sender, EventArgs e)
    {
      //Créer une nouvelle fenetre d'options avec les bonnes valeures à l'intérieur
      //Arrêter le temps de jeu et le jeu
      Options optionsDialog = new Options();
      optionsDialog.nbColonnesOptions.Value = nbColonnes;
      optionsDialog.nbLignesOptions.Value = nbLignes;
      descenteBloc.Enabled = false;
      optionsDialog.ShowDialog();
      descenteBloc.Enabled = true;
      if (optionsDialog.DialogResult == DialogResult.OK) //Si le résultat sorti est OK
      {
        //Appliquer les changements et recommencer la partie
        nbLignes = (int)optionsDialog.nbLignesOptions.Value;
        nbColonnes = (int)optionsDialog.nbColonnesOptions.Value;
        musiqueActive = optionsDialog.musiqueOptions;
        effetsSonoresActifs = optionsDialog.effetsOptions;
        tabLogique = new TypeBloc[nbLignes, nbColonnes];
        GererSon();
        RecommencerPartie();
      }

    }
    //</Yannick>

    //<Alek>
    /// <summary>
    /// Ferme le jeu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void menuItemQuitter_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    /// <summary>
    /// Recommence la partie
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void menuItemRecommencer_Click(object sender, EventArgs e)
    {
      RecommencerPartie();
    }
    /// <summary>
    /// Gestion du visage de la mascotte lors de la destruction d'une ligne
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timerDestroyLine_Tick(object sender, EventArgs e)
    {
      jeuDangeureux = false;
      for (int i = 0; i < 8; i++) //Pour la zone dangeureuse
      {
        for (int j = 0; j < tabLogique.GetLength(1); j++)
        {
          jeuDangeureux = jeuDangeureux || tabLogique[i, j] == TypeBloc.Gele; //Est-ce qu'il y a une pièce gelé dedans
        }
      }
      if (jeuDangeureux == true) //Si le jeu est dangeureux
      {
        imgMascot.Image = Properties.Resources.ChocoUmiForTetris; //Mascotte = visage de peur
      }
      else //Sinon
      {
        imgMascot.Image = Properties.Resources.ChocoForTetris; //Mascotte = visage content
      }
      timerDestroyLine.Enabled = false;
    }
    //</Alek>
    #endregion
    
    #region Tests unitaires
    /// <summary>
        /// Faites ici les appels requis pour vos tests unitaires.
        /// </summary>
    void ExecuterTestsUnitaires()
    {
      //<Yannick>
      ExecuterTestRetraitLigneSeul();
      ExecuterTestRetraitLigneSeulEtDecalage();
      ExecuterTestRetrait2LignesConsecutives();
      ExecuterTestRetrait2LignesNonConsecutives();
      ExecuterTestRetrait3Lignes();
      ExecuterTestRetrait4Lignes();
      //</Yannick>

      //<Alek>
      ExecuterTestRotationCentre();
      ExecuterTestRotationGauche();
      ExecuterTestRotationDroite();
      ExecuterTestRotationAvecBlocsGeles();
      ExecuterTestPartieTerminee();
      ExecuterTestPartieNonTerminee();
      //</Alek>
    }

    //<Yannick>
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
    //</Yannick>

    //<Alek>
    void ExecuterTestRotationCentre()
    {
      //-----Initialiser les données de test-----

      //Initialiser la position dans le tableau
      colonneCourante = tabLogique.GetLength(1) / 2 - 1;
      ligneCourante = tabLogique.GetLength(0) / 2 - 1;

      //Initialiser mouvement
      deplacement = mouvement.RotationAntihoraire;

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 0;
      positionXRelative[0] = -1;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = 0;
      positionXRelative[2] = 1;
      positionYRelative[3] = 0;
      positionXRelative[3] = 2;

      //-----Fin initialiser données de test-----

      //Effectuer les fonctions du test
      if (VerifierDeplacementPossible())
        GererPositionRelativeAntiHoraire();

      //Validation des résultats (X devient Y, Y devient -X)
      Debug.Assert(positionYRelative[0] == 1);
      Debug.Assert(positionXRelative[0] == 0);
      Debug.Assert(positionYRelative[1] == 0);
      Debug.Assert(positionXRelative[1] == 0);
      Debug.Assert(positionYRelative[2] == -1);
      Debug.Assert(positionXRelative[2] == 0);
      Debug.Assert(positionYRelative[3] == -2);
      Debug.Assert(positionXRelative[3] == 0);

      //Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRotationGauche()
    {
      //-----Initialiser les données de test-----

      //Initialiser la position dans le tableau
      colonneCourante = 0;
      ligneCourante = tabLogique.GetLength(0) / 2 - 1;

      //Initialiser mouvement
      deplacement = mouvement.RotationAntihoraire;

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 1;
      positionXRelative[0] = 0;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = -1;
      positionXRelative[2] = 0;
      positionYRelative[3] = -2;
      positionXRelative[3] = 0;

      //-----Fin initialiser données de test-----

      //Effectuer les fonctions du test
      if (VerifierDeplacementPossible())
        GererPositionRelativeAntiHoraire();

      //Validation des résultats (X devient Y, Y devient -X)
      Debug.Assert(positionYRelative[0] == 1);
      Debug.Assert(positionXRelative[0] == 0);
      Debug.Assert(positionYRelative[1] == 0);
      Debug.Assert(positionXRelative[1] == 0);
      Debug.Assert(positionYRelative[2] == -1);
      Debug.Assert(positionXRelative[2] == 0);
      Debug.Assert(positionYRelative[3] == -2);
      Debug.Assert(positionXRelative[3] == 0);

      //Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRotationDroite()
    {
      //-----Initialiser les données de test-----

      //Initialiser la position dans le tableau
      colonneCourante = tabLogique.GetLength(1) - 1;
      ligneCourante = tabLogique.GetLength(0) / 2 - 1;

      //Initialiser mouvement
      deplacement = mouvement.RotationAntihoraire;

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 1;
      positionXRelative[0] = 0;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = -1;
      positionXRelative[2] = 0;
      positionYRelative[3] = -2;
      positionXRelative[3] = 0;

      //-----Fin initialiser données de test-----

      //Effectuer les fonctions du test
      if (VerifierDeplacementPossible())
        GererPositionRelativeAntiHoraire();

      //Validation des résultats (X devient Y, Y devient -X)
      Debug.Assert(positionYRelative[0] == 1);
      Debug.Assert(positionXRelative[0] == 0);
      Debug.Assert(positionYRelative[1] == 0);
      Debug.Assert(positionXRelative[1] == 0);
      Debug.Assert(positionYRelative[2] == -1);
      Debug.Assert(positionXRelative[2] == 0);
      Debug.Assert(positionYRelative[3] == -2);
      Debug.Assert(positionXRelative[3] == 0);

      //Clean-up
      InitialiserTableau();
    }
    void ExecuterTestRotationAvecBlocsGeles()
    {
      //-----Initialiser les données de test-----

      //Initialiser la position dans le tableau
      colonneCourante = tabLogique.GetLength(1) - 1;
      ligneCourante = tabLogique.GetLength(0) / 2 - 1;

      //Initialiser le tableau de blocs gelés
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[0, j] = TypeBloc.Gele;
        if (j > 0 + 1)
        {
          tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        }
      }

      //Initialiser mouvement
      deplacement = mouvement.RotationAntihoraire;

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 1;
      positionXRelative[0] = 0;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = -1;
      positionXRelative[2] = 0;
      positionYRelative[3] = -2;
      positionXRelative[3] = 0;

      //-----Fin initialiser données de test-----

      //Effectuer les fonctions du test
      if (VerifierDeplacementPossible())
        GererPositionRelativeAntiHoraire();

      //Validation des résultats (X devient Y, Y devient -X)
      Debug.Assert(positionYRelative[0] == 1);
      Debug.Assert(positionXRelative[0] == 0);
      Debug.Assert(positionYRelative[1] == 0);
      Debug.Assert(positionXRelative[1] == 0);
      Debug.Assert(positionYRelative[2] == -1);
      Debug.Assert(positionXRelative[2] == 0);
      Debug.Assert(positionYRelative[3] == -2);
      Debug.Assert(positionXRelative[3] == 0);

      //Clean-up
      InitialiserTableau();
    }
    void ExecuterTestPartieTerminee()
    {
      //Initialiser les données de test

      //Initialiser la position dans tableau
      colonneCourante = tabLogique.GetLength(1) / 2 - 1;
      ligneCourante = 2;

      //Initialiser le tableau de blocs gelés
      for (int j = 0; j < tabLogique.GetLength(1); j++)
      {
        tabLogique[0, j] = TypeBloc.Gele;
        if (j > 0 + 1)
        {
          tabLogique[tabLogique.GetLength(0) - 2, j] = TypeBloc.Gele;
        }
      }

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 1;
      positionXRelative[0] = 0;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = -1;
      positionXRelative[2] = 0;
      positionYRelative[3] = -2;
      positionXRelative[3] = 0;

      //Exécuter la fonction à tester
      bool testPeutContinuer = DeterminerSiPartieTerminee();

      //Effectuer les vérifications
      Debug.Assert(testPeutContinuer == false);

      //Clean-up
      InitialiserTableau();
    }
    void ExecuterTestPartieNonTerminee()
    {
      //Initialiser les données de test
      colonneCourante = tabLogique.GetLength(1) / 2 - 1;
      ligneCourante = 2;

      //Création d'un bloc (Type Ligne Verticale)
      bloc = TypeBloc.Ligne;
      positionYRelative[0] = 1;
      positionXRelative[0] = 0;
      positionYRelative[1] = 0;
      positionXRelative[1] = 0;
      positionYRelative[2] = -1;
      positionXRelative[2] = 0;
      positionYRelative[3] = -2;
      positionXRelative[3] = 0;

      //Exécuter la fonction à tester
      bool testPeutContinuer = DeterminerSiPartieTerminee();

      //Effectuer les vérifications
      Debug.Assert(testPeutContinuer == true);

      //Clean-up
      InitialiserTableau();
    }
    //</Alek>

    #endregion

  }

  #region Variables enum
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
  #endregion
}
