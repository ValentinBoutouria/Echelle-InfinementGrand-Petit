using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Score _script;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ajoutScore()
    {
        _script._score += 100;
      
    }
}
