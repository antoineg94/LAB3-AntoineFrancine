using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GestionJeu : MonoBehaviour
{
    // ***** Attributs *****

    private int _pointage = 0;  // Attribut qui conserve le nombre d'accrochages
    private float _tempsFinal = 0;
    private float _tempsDepart = 0;
    private Rigidbody _rb;
  
    //private int _accrochageNiveau1 = 0;  // Atribut qui conserve le nombre d'accrochage pour le niveau 1
    //private float _tempsNiveau1 = 0.0f;  // Attribut qui conserve le temps pour le niveau 1

    // ***** Méthodes privées *****
    private void Awake()
    {
        // Vérifie si un gameObject GestionJeu est déjà présent sur la scène si oui
        // on détruit celui qui vient d'être ajouté. Sinon on le conserve pour le 
        // scène suivante.
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    //Vector3 departnv1 = new Vector3(0f, 0.1f, 0f);
    private void Start()
    {
        _tempsDepart = Time.time;



        /*
         * 
            private Vector3 position = transform.position;



                if (SceneManager.GetActiveScene().name == "Niveau1")
                {
                    transform.position = new Vector3(0f, 0.1f, 0f);
                    if (transform.hasChanged)
                    {
                        _tempsDepart = Time.time;
                    }
                    else
                    {
                        _tempsDepart = 0;
                    }
                }


                /*
                        if( (SceneManager.GetActiveScene().name == "Niveau1") &&(gameObject.transform.position == departnv1))
                        {
                            _tempsDepart = 0; 
                        }
                        else if((SceneManager.GetActiveScene().name == "Niveau1") && (gameObject.transform.position != departnv1))
                        { _tempsDepart = Time.time;
                        }*/
        /*if (SceneManager.GetActiveScene().name == "Niveau2")
        {
            transform.position = new Vector3(-40f, 0.1f, -40f);
        }
        if (SceneManager.GetActiveScene().name == "Niveau3")
        {
            transform.position = new Vector3(40f, 0.1f, -40f);
        }
        _tempsDepart = Time.time;
        _rb = GetComponent<Rigidbody>();*/

        /*   float positionX = Input.GetAxis("Horizontal");
           float positionZ = Input.GetAxis("Vertical");
        */



        /*   CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
            _tempsDepart = Time.time;
        } 
        else _tempsDepart = 0;*/






        /*   if (Input.GetKeyDown(   ("Horizontal") != 0 || Input.GetAxis("vertical") != 0)

           {
               _tempsDepart = Time.time;

           }
           else _tempsDepart = 0;
          */
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    // ***** Méthodes publiques ******

    /*
     * Méthode publique qui permet d'augmenter le pointage de 1
     */
    public void AugmenterPointage()
    {
        _pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }

    // Accesseur qui retourne la valeur de l'attribut pointage
    public int GetPointage()
    {
        return _pointage;
    }

    public float GetTempsDepart()
    {
        return _tempsDepart;
    }


    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - _tempsDepart;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }


    /******************************************************
    // Accesseur qui retourne le temps pour le niveau 1
    public float GetTempsNiv1()
    {
        return _tempsNiveau1;
    }

    // Accesseur qui retourne le nombre d'accrochages pour le niveau 1
    public int GetAccrochagesNiv1()
    {
        return _accrochageNiveau1;
    }

    // Méthode qui reçoit les valeurs pour le niveau 1 et qui modifie les attributs respectifs
    public void SetNiveau1(int accrochages, float tempsNiv1)
    {
        _accrochageNiveau1 = accrochages;
        _tempsNiveau1 = tempsNiv1;
    }
    ********************************************************/

}
