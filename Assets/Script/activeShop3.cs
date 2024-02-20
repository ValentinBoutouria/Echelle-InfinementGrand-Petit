using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeShop3 : MonoBehaviour
{

    public GameObject oui;
    public GameObject shop2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Main Camera")
        {
            oui.SetActive(true);
            Debug.Log("test");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Main Camera")
        {
            oui.SetActive(false);
            shop2.SetActive(false);



        }
        Debug.Log("ahhhhhhhy");
    }
}
