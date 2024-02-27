using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Radius : MonoBehaviour
{
    public string texteAvant;
    public string texteApres;
    public TextMeshProUGUI zoneTxt;
    private float radiusActuel;
    private float radiusMax;
    private float radiusFinal;
    public float radTerre;
    public GameObject terre;

    // Start is called before the first frame update
    void Start()
    {
        radiusMax = terre.GetComponent<SphereCollider>().radius*Mathf.Max(terre.transform.lossyScale.x,terre.transform.lossyScale.y,terre.transform.lossyScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        AfficherRadius();
    }

    float calculerRadiusTerre()
    {
        radiusActuel = terre.GetComponent<SphereCollider>().radius*Mathf.Max(terre.transform.lossyScale.x,terre.transform.lossyScale.y,terre.transform.lossyScale.z);
        radiusFinal = radTerre * radiusActuel / radiusMax;
        return radiusFinal;
    }

    void AfficherRadius()
    {
        int rad = (int)calculerRadiusTerre();
        zoneTxt.text = texteAvant +  rad + texteApres;
    }
}
