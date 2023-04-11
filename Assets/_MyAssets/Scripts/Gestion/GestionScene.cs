using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
        [SerializeField] private GameObject _menuInfo = default;
         private bool _enInfo;

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
     public void GestionInfo()
    {
            _menuInfo.SetActive(true);
            _enInfo = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
