using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class molecule : MonoBehaviour
{
    // declaration du gameobject molecule
    [SerializeField] private GameObject Molecule;

    public void OnCollisionEnter(Collision collision)
    {
        // verifier si il ya eu une collision
        if(collision.gameObject.tag == "Player")
        {

            Molecule.transform.position = gameObject.transform.position;// le gameobject recupere les coordonnees du gameobject sphere
            Molecule.SetActive(true); // activation
            gameObject.SetActive(false); // desactivation du gameobject sphere
            collision.gameObject.SetActive(false);// destruction de la collision

        }
    }

    









}
