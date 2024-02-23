using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class neutrinos : MonoBehaviour
{

    public InputActionReference button;
    public TextMeshPro TMP;
    public Transform cam;
    public GameObject vide;

    private Transform _tf;
    private bool isActive = false;
    private bool isTimer = false;
    private double cal;

    private double delTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        _tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        button.action.started += Pressed;
        if(isTimer) 
        {
            delTime += Time.deltaTime;
        }
        else
        {
            cal += delTime * 65 * 17000;
            Display();
            delTime = 0;
        }
        
        if(isActive) 
        {
            delTime += Time.deltaTime;
            if(delTime > 10)
            {
                vide.SetActive(false);
                isActive = false;
            }
        }

    }

    public void Pressed(InputAction.CallbackContext context)
    {
        isTimer = !isTimer;
    }

    public void Display()
    {
        TMP.text = "En " + delTime + " secondes, " + cal + " Milliards de particules nommées neutrinos ont traversé votre coprs.\n C'est beaucoup? Oui et c'est normal mais surtout absolument innofenssif.";
        vide.SetActive(true);
        isActive = true;
    }
}
