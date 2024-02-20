using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melangeenfants : MonoBehaviour
{

    // Tableau d'images que vous souhaitez assigner aux enfants (assurez-vous de les assigner dans l'inspecteur Unity)
    public Sprite[] images;
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
    public void RandomizeImages()
    {
        // Parcourir tous les enfants de l'objet
        foreach (Transform child in transform)
        {
            // Obtenir le composant Image de l'enfant
            Image imageComponent = child.GetComponent<Image>();

            // S'assurer que l'enfant a un composant Image
            if (imageComponent != null)
            {
                // Choisir une image aléatoire du tableau
                Sprite randomImage = images[Random.Range(0, images.Length)];

                // Assigner l'image aléatoire au composant Image de l'enfant
                imageComponent.sprite = randomImage;
            }
        }
    }
}
