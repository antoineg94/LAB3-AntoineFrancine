using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    [SerializeField] private TMP_Text _Principe_jeu = default;
    public void ChangerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // R�cup�re l'index de la sc�ne en cours
        SceneManager.LoadScene(noScene + 1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(1);
    }
    public void infos()
    {

        _Principe_jeu.text = "L'objectif du jeu est d'atteindre le sandwich afin de passer de niveaux en niveaux. " +
            "Au niveau 1: il faut contourner la spirale en �chappant aux diff�rents obstacles aller chercher la potion magique qui va ouvrir" +
            " la porte et enfin r�cuperer le sandwich pour acc�der au niveau sup�rieur.Il faut eviter le plus possible de contact avec les diff�rents " +
            "obstacles du jeu.Il y'en a qui valent pour un et d'autres pour deux collisions alors faites attention!" +
            "Au niveau 2: ici le terrain glacial nous complexifie la t�che le principe est le m�me mis � part la spirale" +
            "Au niveau 3: Dans ce niveau on est en plein milieu de nulle part avec des arbres et l'objectif est le m�me atteindre le sandwich ";
    }

}
