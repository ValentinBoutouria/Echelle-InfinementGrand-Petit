using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParagrapheQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI paragraphe;
    public Changementdetexte changement;

    void Start()
    {

        paragraphe.text = "Imaginons qu’un" + changement.obj1 + "fasse la taille d’une POMME, qu’elle serait la taille de son NOYAU ?"; //obj1 = electron



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
