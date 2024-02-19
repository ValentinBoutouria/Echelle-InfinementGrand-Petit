using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;


public class Vide : MonoBehaviour
{
    public GameObject dial;
    public float pourcentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        retirerVide();
    }

    public void retirerVide()
    {
        pourcentage = dial.GetComponent<XRKnob>().value;
        transform.localScale = new Vector3(1 * pourcentage, 1 * pourcentage, 1 * pourcentage );
    }
}
