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
    public TextMeshProUGUI R�ponse;

    public TextMeshProUGUI boutonR�ponse;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Changementobj()
    {
        para.paragraphe.text = "Imaginons qu�un " + obj1.text + " fasse la taille d�une POMME, qu�elle serait la taille de "+ obj2.text + " ?";
        boutonR�ponse.text = R�ponse.text;

    }
}
