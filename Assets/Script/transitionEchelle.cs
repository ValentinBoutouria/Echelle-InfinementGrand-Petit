using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class transitionEchelle : MonoBehaviour
{
    public InputActionReference toggle;

    public GameObject[] arr = new GameObject[3];


    public float scaleCoef = 100f;
    public GameObject _mainDroite;

    public bool t = false;


    // Start is called before the first frame update
    void Start()
    {
        _mainDroite = GameObject.Find("Right Controller");
        arr[0].GetComponent<Transform>().localScale = 0.01f * Vector3.one;
        arr[0].GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
        arr[0].GetComponent<Transform>().localPosition = new Vector3(0, -0.3f, 0);

        arr[1] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        arr[1].GetComponent<Transform>().localScale = scaleCoef * Vector3.one;
        arr[1].GetComponent<Transform>().localPosition = new Vector3(0, 50, 150);

        arr[2] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        arr[2].GetComponent<Transform>().localScale = 100f * Vector3.one;
        arr[2].SetActive(false);
   
    }

    // Update is called once per frame
    void Update()
    {
        
        toggle.action.started += Toggle;
        if(t)
        {
            arr[1].GetComponent<Transform>().position = Vector3.MoveTowards(arr[1].transform.position, _mainDroite.GetComponent<Transform>().position, 5f);
            if(scaleCoef > 0.1)
            {
                scaleCoef /= 1.2f;
                arr[1].GetComponent<Transform>().localScale = scaleCoef * Vector3.one;
            }
        }
        
    }

    public void Toggle(InputAction.CallbackContext context)
    {
        
        Destroy(arr[0]);
        t = true;
        arr[1].GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
        arr[1].GetComponent<MeshRenderer>().material.color = Color.red;
        
    }

}