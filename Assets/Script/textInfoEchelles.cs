using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textInfoEchelles : MonoBehaviour
{

    public TextMeshProUGUI textMeshPro1;
    public TextMeshProUGUI textMeshPro2;

    private int i;
    private string[] s = { "Quarks : \nLorem Ipsum 1",
                           "Noyau Atomique : \nLorem Ipsum 2",
                           "Atome :\nLorem Ipsum 3",
                           "Brouillard : \nLorem Ipsum 4",
                           "Bille : \nLorem Ipsum 5",
                           "Stade : \nLorem Ipsum 6",
                           "Lune : \nLorem Ipsum 7",
                           "Etoile : \nLorem Ipsum 8",
                           "Système Solaire :\nLorem Ipsum 9",
                           "Distance inter-solaire :\nLorem Ipsum 10",
                           "Galaxy : \nLorem Ipsum 11"
                         };

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        i = GetComponent<transitionEchelle>().i;
        textMeshPro1.text = s[i];
        textMeshPro2.text = s[i+1];
    }
}
