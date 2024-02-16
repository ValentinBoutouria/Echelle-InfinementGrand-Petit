using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject objetA;
    public GameObject objetB;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("distance " + calculerDistance());
    }

    float calculerDistance() //une unité = un metre
    {
        distance = Vector3.Distance(objetA.transform.position, objetB.transform.position);
        return distance;
    }

}
