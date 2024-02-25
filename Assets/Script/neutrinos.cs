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
    public bool isTimer = false;
    private double cal;

    private DateTime deb = DateTime.Now;
    private DateTime fin;

    private float _currentTimer = 0f;

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
            _currentTimer += Time.deltaTime;
        }

        
        if(isActive) 
        {
            _currentTimer += Time.deltaTime;
            if(_currentTimer > 10)
            {
                vide.SetActive(false);
                isActive = false;
            }
        }

    }

    public void Pressed(InputAction.CallbackContext context)
    {
        isTimer = !isTimer;
        if(!isTimer)
        {
            cal = _currentTimer * 65 * 17000 / 1000;
            Display();
        }
        else
        {
            _currentTimer = 0f;
        }

    }

    public void Display()
    {
        _tf.position = cam.transform.position;
        _tf.rotation = cam.transform.rotation;
        TMP.text = "En " + (cal*1000/65/17000).ToString("#0.00") + " secondes, " + cal.ToString("#.00") + " Milliards de particules nommées neutrinos ont traversé votre coprs.\n C'est beaucoup? Oui et c'est normal mais surtout absolument innofenssif.";
        vide.SetActive(true);
        _currentTimer = 0f;
        isActive = true;
    }
}
