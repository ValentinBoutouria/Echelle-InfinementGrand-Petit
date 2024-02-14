using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Changementdetexte : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI obj1;
    void Start()
    {
        obj1=GetComponentInChildren<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Changementobj()
    {
        obj1 = GetComponentInChildren<TextMeshProUGUI>();

    }
}
