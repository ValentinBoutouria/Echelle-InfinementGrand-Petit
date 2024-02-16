using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Distance : MonoBehaviour
{
    public GameObject objetA;
    public GameObject objetB;
    public float distance;

    public string texteAvant;
    public string texteApres;
    public TextMeshProUGUI zoneTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        afficherDistance();
    }

    float calculerDistance() //une unité = un metre
    {
        distance = Vector3.Distance(objetA.transform.position, objetB.transform.position);
        return distance;
    }

    void afficherDistance()
    {
        int dist = (int)calculerDistance();
        zoneTxt.text = texteAvant +  dist + texteApres;
    }

}
