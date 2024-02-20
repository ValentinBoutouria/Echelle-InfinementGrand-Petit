using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melangeenfants : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Appeler la fonction pour mélanger les enfants au démarrage
       // ShuffleChildrenOrder(transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShuffleChildrenOrder(Transform parent)
    {
        // Liste temporaire pour stocker les enfants
        List<Transform> children = new List<Transform>();

        // Parcourir tous les enfants et les ajouter à la liste temporaire
        foreach (Transform child in parent)
        {
            children.Add(child);
        }

        // Mélanger la liste temporaire
        for (int i = 0; i < children.Count; i++)
        {
            Transform temp = children[i];
            int randomIndex = Random.Range(i, children.Count);
            children[i] = children[randomIndex];
            children[randomIndex] = temp;
        }

        // Réorganiser les enfants dans l'ordre aléatoire
        foreach (Transform child in children)
        {
            child.SetAsLastSibling();
        }
    }
}
