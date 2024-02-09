using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparaison : MonoBehaviour
{
    public int tailleA1; //= 1*Mathf.Pow(10, -22); // électron 10-22 m
    public int tailleB1; // = 8*Mathf.Pow(10, -2); // pomme 8*10-2 m 
    public int tailleA2; // = 1*Mathf.Pow(10, -15); // noyaux 10-15 m
    public int tailleB2; // astéroide 8*10.5 m
    public GameObject objA1;
    public GameObject objA2;
    public GameObject objB1;
    public GameObject objB2;
    int dif1;
    int dif2;
    public bool isOk = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculerTaille();
    }

    public void RecuperartionTaille()
    {
        tailleA1 = objA1.GetComponent<Caracteristique>().puissance;
        tailleA2 = objA2.GetComponent<Caracteristique>().puissance;
        tailleB1 = objB1.GetComponent<Caracteristique>().puissance;
        tailleB2 = objB2.GetComponent<Caracteristique>().puissance;
    }

    public void VerificationTaille(ref int A1, ref int A2)
    {   
        if(A1 < 0 && A2 < 0) // A1 neg et A2 neg
        {                               // A1 doit etre plus petit que A2
            if(A1 > A2) // A1 plus grand que A2
            {
                int temp = A1;
                A1 = A2;
                A2 = temp;
            } 
            //else A1 plus petit que A2 on ne change rien
        }
        else if(A1 < 0 && A2 > 0)
        {
            
        }
        else if(A1 > 0 && A2 < 0)
        {
           int temp = A1;
            A1 = A2;
            A2 = temp;
        }
        else if(A1 > 0 && A2 > 0)// A1 pos et A2 pos
        {
             if(A1 < A2) // A1 plus petit que A2
            {
                int temp = A1;
                A1 = A2;
                A2 = temp;
            } 
            //else A1 plus grand que A2 on ne change rien
        }
        else 
            Debug.Log("AAAAAAAAAAA");
    }

    public void CalculerTaille()
    {
        RecuperartionTaille();
        VerificationTaille(ref tailleA1, ref tailleA2);
        VerificationTaille(ref tailleB1, ref tailleB2);
        dif1 = tailleA1 - tailleA2;
        dif2 = tailleB1 - tailleB2;
        if(dif1 == dif2)
            isOk = true;
        else 
            isOk = false;
    }
}
