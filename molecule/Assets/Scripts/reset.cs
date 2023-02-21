using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reset : MonoBehaviour
{
    [SerializeField] private GameObject sphere1;
    [SerializeField] private GameObject sphere2;
    [SerializeField] private GameObject molecule;
    [SerializeField] private Button resetbutton;

    private GameObject sphere1vector;
    private GameObject sphere2vector;
    void Start()
    {
        resetbutton.onClick.AddListener(taskOnclick);
    }

    void taskOnclick()
    {
        molecule.SetActive(false);
        sphere1.transform.position = new Vector3((float)2.5, 1, 0);
        sphere2.transform.position = new Vector3((float)-2.5, 1, 0);
        sphere1.SetActive(true);
        sphere2.SetActive(true);
    }
}
