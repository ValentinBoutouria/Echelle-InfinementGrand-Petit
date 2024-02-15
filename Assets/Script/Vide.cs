using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using TMPro;



public class Vide : MonoBehaviour
{
    public GameObject dial;
    public float pourcentageDial;
    public float pourcentageRetire;
    float valDial;
    public TextMeshProUGUI txtTauxRetire;
    private Vector3 scale;
    public float differenceX;
    public float differenceY;
    public float differenceZ;
    public GameObject posfinal;
    float posFinaleX;
    float posFinaleY;
    float posFinaleZ;

    Vector3 vecdist;
    // Start is called before the first frame update
    void Start()
    {
        
        differenceX = transform.localScale.x / 10000;
        differenceY = transform.localScale.y / 10000;
        differenceZ = transform.localScale.z / 10000;
        scale = new Vector3(transform.localScale.x - differenceX, transform.localScale.y- differenceY, transform.localScale.z- differenceZ);
        Debug.Log(scale);

        posFinaleX = 0; //posfinal.transform.position.x;
        posFinaleY = 0; //posfinal.transform.position.y;
        posFinaleZ = 0; //posfinal.transform.position.z;

        vecdist = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z) - new Vector3(posFinaleX, posFinaleY, posFinaleZ) ;
    }

    // Update is called once per frame
    void Update()
    {
        retirerVide();
        calculDistance();
    }

    public void retirerVide()
    {
        valDial = dial.GetComponent<XRKnob>().value;
        pourcentageDial = 1 - valDial;
        
        pourcentageRetire = pourcentageDial;
        transform.localScale = new Vector3(scale.x * pourcentageRetire +differenceX, scale.y * pourcentageRetire +differenceY, scale.z * pourcentageRetire +differenceZ);
        majTxt();
    }

    void majTxt()
    {
        txtTauxRetire.text = "Vide retiré : \n" + pourcentageDial*100 + "%";
    }

    void calculDistance()
    {
        transform.localPosition = new Vector3(vecdist.x * pourcentageRetire, vecdist.y * pourcentageRetire, vecdist.z * pourcentageRetire);
    }
}
