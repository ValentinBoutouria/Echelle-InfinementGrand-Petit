using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lancementscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChargerMenu()
    {
        // Charger la scène avec le nom "NomDeVotreAutreScene"
        SceneManager.LoadScene("Menu");
    }
    public void ChargerGame()
    {
        // Charger la scène avec le nom "NomDeVotreAutreScene"
        SceneManager.LoadScene("Valentin");
    }

}
