using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class transitionEchelle : MonoBehaviour
{
    public InputActionReference toggle;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public float scaleCoef = 100f;
    public GameObject _mainDroite;

    public bool t = false;


    // Start is called before the first frame update
    void Start()
    {
        _mainDroite = GameObject.Find("Right Controller");
        obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj1.GetComponent<Transform>().localScale = 0.01f * Vector3.one;
        obj1.GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
        obj1.GetComponent<Transform>().localPosition = new Vector3(0, -0.3f, 0);
        obj2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj2.GetComponent<Transform>().localScale = scaleCoef * Vector3.one;
        obj2.GetComponent<Transform>().localPosition = new Vector3(0, 50, 150);

        obj3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj3.GetComponent<Transform>().localScale = 100f * Vector3.one;
        obj3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        toggle.action.started += Toggle;
        if(t)
        {
            obj2.GetComponent<Transform>().position = Vector3.MoveTowards(obj2.transform.position, _mainDroite.GetComponent<Transform>().position, 5f);
            if(scaleCoef > 0.1)
            {
                scaleCoef /= 1.2f;
                obj2.GetComponent<Transform>().localScale = scaleCoef * Vector3.one;
            }
        }
    }

    public void Toggle(InputAction.CallbackContext context)
    {
        Destroy(obj1);
        t = true;
        obj2.GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
        obj2.GetComponent<MeshRenderer>().material.color = Color.red;
    }

}