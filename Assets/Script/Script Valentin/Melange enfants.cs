using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melangeenfants : MonoBehaviour
{

    // Tableau d'images que vous souhaitez assigner aux enfants (assurez-vous de les assigner dans l'inspecteur Unity)
    public Sprite[] images;
    private int index;
    void Start()
    {
        // Appeler la fonction pour m�langer les enfants au d�marrage
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

        // Parcourir tous les enfants et les ajouter � la liste temporaire
        foreach (Transform child in parent)
        {
            children.Add(child);
        }

        // M�langer la liste temporaire
        for (int i = 0; i < children.Count; i++)
        {
            Transform temp = children[i];
            int randomIndex = Random.Range(i, children.Count);
            children[i] = children[randomIndex];
            children[randomIndex] = temp;
        }

        // R�organiser les enfants dans l'ordre al�atoire
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
                // Choisir une image al�atoire du tableau
                index = Random.Range(0, images.Length);
                Sprite randomImage = images[index];
                //remove
                RemoveSpriteAt(index);

                // Assigner l'image al�atoire au composant Image de l'enfant
                imageComponent.sprite = randomImage;
            }
        }
    }
    void RemoveSpriteAt(int index)
    {
        // S'assurer que l'indice est valide
        if (index >= 0 && index < images.Length)
        {
            // Convertir le tableau en une liste pour faciliter la suppression
            var spriteList = new System.Collections.Generic.List<Sprite>(images);

            // Supprimer l'�l�ment � l'indice sp�cifi�
            spriteList.RemoveAt(index);

            // Mettre � jour le tableau avec la nouvelle liste
            images = spriteList.ToArray();
        }
    }
}
