using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitShop3 : MonoBehaviour
{

    private GameObject[] _arr;
    // Start is called before the first frame update
    void Start()
    {
        _arr = GameObject.Find("scripts").GetComponent<transitionEchelle>().arr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
