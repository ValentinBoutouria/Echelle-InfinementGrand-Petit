using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeatelier2 : MonoBehaviour
{
    public GameObject shop2;
    private GameObject[] _arr;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activeshop2()
    {
        shop2.SetActive(true);
        GameObject.Find("scripts").SetActive(true);
        _arr = GameObject.Find("scripts").GetComponent<transitionEchelle>().arr;


    }
    public void Desactiveshop()
    {
        shop2.SetActive(false);
        foreach (var item in _arr) 
        {
            item.SetActive(false);
        }

    }
}
