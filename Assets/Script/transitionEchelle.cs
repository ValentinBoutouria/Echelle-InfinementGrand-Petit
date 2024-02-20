using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class transitionEchelle : MonoBehaviour
{
    public InputActionReference next;
    public InputActionReference prev;

    public GameObject[] arr = new GameObject[10];

    public GameObject _mainDroite;

    private int i = 0;

    public bool t = false;
    public bool t1 = false;

    private Vector3 vectGros = new Vector3(0, 50, -100);
    private Vector3 vectGrosStade = new Vector3(0, -30, -140);
    private Vector3 vectGrosSys = new Vector3(0, 50, -300);



    // Start is called before the first frame update
    void Start()
    {
        _mainDroite = GameObject.Find("Right Controller");
        for (int j = 0; j< arr.Length; j++)
        {
            arr[j].SetActive(false);
            arr[j].GetComponent<Transform>().localPosition = vectGros;
            arr[j].GetComponent<Transform>().localScale = 100f * Vector3.one;
            //Debug.Log("AAAAAAAAAAAAA :          " + j);
            if (arr[j].name == "stade")
            {
                arr[j].GetComponent<Transform>().localPosition = vectGrosStade;
                arr[j].GetComponent<Transform>().Rotate(0, 210, 0);
            }
            if (arr[j].name == "sysSol")
            {
                arr[j].GetComponent<Transform>().localPosition = vectGrosSys;
            }
        }
        arr[0].GetComponent<Transform>().localScale = 0.01f * Vector3.one;
        arr[0].GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
        arr[0].GetComponent<Transform>().localPosition = new Vector3(0, -0.1f, 0);
        arr[0].SetActive(true); 
        
        arr[1].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        next.action.started += Next;
        prev.action.started += Previous;

        if (t)
        {
            arr[i].GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
            arr[i].GetComponent<Transform>().position = Vector3.MoveTowards(arr[i].transform.position, _mainDroite.GetComponent<Transform>().position, 2f);
            if (arr[i].GetComponent<Transform>().localScale.x > 0.1)
            {
                arr[i].GetComponent<Transform>().localScale /= 1.2f;
            }
            else 
            {
                arr[i+1].SetActive(true);
                arr[i+1].GetComponent<Transform>().position = vectGros;
                if (arr[i+1].name == "stade")
                {
                    arr[i+1].GetComponent<Transform>().localPosition = vectGrosStade;
                }
                if (arr[i + 1].name == "sysSol")
                {
                    arr[i + 1].GetComponent<Transform>().localPosition = vectGrosSys;
                }

            }
            if(arr[i].GetComponent<Transform>().localScale.x > 0.1 && arr[i].GetComponent<Transform>().position == _mainDroite.GetComponent<Transform>().position)
            {
                t = false;
            }
        }
        if (t1)
        {
            if (arr[i+1].name != "stade")
            {
                arr[i+1].GetComponent<Transform>().position = Vector3.MoveTowards(arr[i+1].transform.position, vectGros, 10f);
                arr[i + 1].GetComponent<Transform>().rotation = Quaternion.identity;
            }
            else
            {
                arr[i+1].GetComponent<Transform>().position = Vector3.MoveTowards(arr[i + 1].transform.position, vectGrosStade, 10f); ;
            }
            if (arr[i+1].GetComponent<Transform>().localScale.x < 100f)
            {
                arr[i+1].GetComponent<Transform>().localScale *= 1.2f;
            }
            else
            {
                arr[i].SetActive(true);
                arr[i].GetComponent<Transform>().SetParent(_mainDroite.GetComponent<Transform>());
                t1 = false;
            }
        }
    }

    public void Next(InputAction.CallbackContext context)
    {
        arr[i].SetActive(false);
        t = true;
        i++;
    }

    public void Previous(InputAction.CallbackContext context)
    {
        arr[i].GetComponent<Transform>().SetParent(null);
        arr[i+1].SetActive(false);
        t1 = true;
        i--;
    }

}