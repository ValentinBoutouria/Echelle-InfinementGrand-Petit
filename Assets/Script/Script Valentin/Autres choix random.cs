using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Autreschoixrandom : MonoBehaviour
{
    // Start is called before the first frame update
    // Tableau de textes que vous souhaitez assigner aux objets (assurez-vous de les assigner dans l'inspecteur Unity)
    public string[] texts;

    // Objets contenant le composant Text
    public TextMeshProUGUI object1Text;
    public TextMeshProUGUI object2Text;
    public TextMeshProUGUI object3Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizeTexts()
    {
        // S'assurer que le tableau de textes a �t� assign� et contient au moins 3 �l�ments
        if (texts != null && texts.Length >= 3)
        {
            // Choisir trois indices distincts al�atoires du tableau
            int index1, index2, index3;
            do
            {
                index1 = Random.Range(0, texts.Length);
                index2 = Random.Range(0, texts.Length);
                index3 = Random.Range(0, texts.Length);
            } while (index1 == index2 || index1 == index3 || index2 == index3);

            // Assigner les textes al�atoires aux objets
            object1Text.text = texts[index1];
            object2Text.text = texts[index2];
            object3Text.text = texts[index3];
            Debug.Log("ahhhhhhh");
        }
        else
        {
            Debug.LogError("Veuillez assigner un tableau de textes avec au moins 3 �l�ments dans l'inspecteur Unity.");
        }
    }
}
