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
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
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
            "Au niveau 1: il faut contourner la spirale en échappant aux différents obstacles aller chercher la potion magique qui va ouvrir" +
            " la porte et enfin récuperer le sandwich pour accéder au niveau supérieur.Il faut eviter le plus possible de contact avec les différents " +
            "obstacles du jeu.Il y'en a qui valent pour un et d'autres pour deux collisions alors faites attention!" +
            "Au niveau 2: ici le terrain glacial nous complexifie la tâche le principe est le même mis à part la spirale" +
            "Au niveau 3: Dans ce niveau on est en plein milieu de nulle part avec des arbres et l'objectif est le même atteindre le sandwich ";
    }

}
