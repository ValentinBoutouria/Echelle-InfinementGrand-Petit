using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Téléportationatelier : MonoBehaviour
{
    public Transform player;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TpIsland()
    {
        player.position= SpawnPoint.position;
        player.rotation= SpawnPoint.rotation;

    }

}
