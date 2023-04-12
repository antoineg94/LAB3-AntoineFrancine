using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps;
    [SerializeField] private GameObject _menuPause = default;
    private bool _enPause;
    private GestionJeu _gestionJeu;
    float temps;

    float currentTime;
    bool _keyDown = false;
    
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtAccrochages.text = _gestionJeu.GetPointage().ToString();
        
        _enPause = false;
        currentTime = 0;
        
    }

    
    
    private void FixedUpdate()
    {
        gestionTemps();
        if (_keyDown == true)
        {

            currentTime += Time.deltaTime;
            _txtTemps.text = currentTime.ToString("f2");

        }

        GestionPause();
    }

    public void gestionTemps()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            _keyDown = true;

        }
    }


    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }

    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }
   
}
