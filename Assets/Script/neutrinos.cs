using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class neutrinos : MonoBehaviour
{

    public InputActionReference button;
    public TextMeshProUGUI TMP;
    public Transform cam;
    public GameObject vide;

    private Transform _tf;
    public bool isActive = false;
    public bool isTimer = true;
    private double cal;

    private DateTime deb = DateTime.Now;
    private DateTime fin;

    // Start is called before the first frame update
    void Start()
    {
        vide.SetActive(false);
        _tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        button.action.started += Pressed;
        if(isTimer) 
        {
            fin = DateTime.Now;
        }
        else
        {
            cal += (fin-deb).Milliseconds * 65 * 17000 / 1000;
            Display();
            //delTime = 0;
            deb = DateTime.Now;
        }
        
        if(isActive) 
        {
            //delTime += Time.deltaTime;
            fin = DateTime.Now;
            if((fin-deb).Seconds > 10)
            {
                vide.SetActive(false);
                isActive = false;
            }
        }

    }

    public void Pressed(InputAction.CallbackContext context)
    {
        isTimer = !isTimer;
        fin = DateTime.Now;
    }

    public void Display()
    {
        _tf.position = cam.transform.position + new Vector3(0,0, 1.5f);
        _tf.rotation = cam.transform.rotation;
        TMP.text = "En " + cal*1000/65/17000 + " secondes, " + cal + " Milliards de particules nommées neutrinos ont traversé votre coprs.\n C'est beaucoup? Oui et c'est normal mais surtout absolument innofenssif.";
        vide.SetActive(true);
        isActive = true;
    }
}
