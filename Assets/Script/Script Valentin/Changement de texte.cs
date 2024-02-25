using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Changementdetexte : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI obj1;
    public ParagrapheQuestion para;
    public TextMeshProUGUI obj2;
    public TextMeshProUGUI Réponse;

    public TextMeshProUGUI boutonRéponse;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Changementobj()
    {
        // para.paragraphe.text = "Imaginons qu’un " + obj1.text + " fasse la taille d’une POMME, qu’elle serait la taille de "+ obj2.text + " ?";
        boutonRéponse.text = Réponse.text;
        switch (obj1.text)
        {
            case "ELECTRON":
                para.paragraphe.text = "Imaginons qu’un ELECTRON fasse la taille d'une POMME, quelle serait la taille du ";
                break;
            case "SOLEIL":
                para.paragraphe.text = "Imaginons que le SOLEIL fasse la taille d'une POMME, quelle serait la taille ";
                break;
            case "FRANCE":
                para.paragraphe.text = "Imaginons que la FRANCE fasse la taille d'une POMME, quelle serait la taille de ";
                break;
            case "VIRUS":
                para.paragraphe.text = "Imaginons qu’un VIRUS fasse la taille d'une POMME, quelle serait la taille d'une ";
                break;
            case "AIGUILLE":
                para.paragraphe.text = "Imaginons qu’une AIGUILLE fasse la taille d'une POMME, quelle serait la taille d'une ";
                break;
            default:
                break;
        }
        para.paragraphe.text += obj2.text;
        para.paragraphe.text += " ?";

    }
}
