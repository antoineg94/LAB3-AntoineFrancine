﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ReactivationCollision : MonoBehaviour
{
    // ***** Attributs *****
    private GestionJeu _gestionJeu;  
    private bool _touche;  // Bool�en qui permet de d�tecter si l'objet a �t� touch�
    [SerializeField] GameObject _ring;
    


    // ***** M�thodes priv�es *****
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();  // lie la variable au gameObject GestionJeu de la sc�ne
        _touche = false;  // initialise le bool�en � faux au d�but de la sc�ne
        _ring.SetActive(false);//désactive la potion
    }



    /* 
     * R�le : M�thode qui se d�clenche quand une collision se produit avec l'objet
     * Entr�e : un objet de type Collision qui repr�sente l'objet avec qui la collision s'est produite
     */
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Player" && !_touche)  // Si l'objet avec la collision s'est produite est le joueur et qu'il n'a pas d�j� et� touch�
        if (!_touche)
        {
            Debug.Log("Allo");
            _ring.SetActive(true);//désactive la potion
            _gestionJeu.AugmenterPointage();  // Appelle la m�thode publique dans GestionJeu pour augmenter le pointage
            _touche = true;  // change le bool�en � vrai pour indiqu� que l'objet a �t� touch�
            GetComponent<MeshRenderer>().material.color = Color.red;  //change la couleur du mat�riel � rouge
          
            Invoke("ColorDefault", 4);

        }



    }
   
    private void ColorDefault()
    {

        _ring.SetActive(false);//désactive la potion
        GetComponent<MeshRenderer>().material.color = default;
        _touche = false;
    }
}