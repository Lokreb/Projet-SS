using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class CardFusionManager : MonoBehaviour
{
    public GameObject osCardPrefab; // L'objet préfabriqué de la carte "os"
    public GameObject squeletteCardPrefab; // L'objet préfabriqué de la carte "squelette"
    public Transform fusionSlot; // L'emplacement où la fusion se produit
    public Button fusionButton; // Le bouton pour déclencher la fusion
    public GameObject uiPanel; // Référence au panneau d'UI où vous souhaitez afficher la carte fusionnée
    public Transform canvas;

    private void Start()
    {
        fusionButton.onClick.AddListener(FusionnerCartes);
    }

    public void FusionnerCartes()
    {
        // Vérifiez si le slot de fusion contient une carte "os"
        if (fusionSlot.childCount == 1)
        {
            Transform slotChild = fusionSlot.GetChild(0);
            Image osCardImage = slotChild.GetComponent<Image>();

            // Vérifiez si la carte "os" est dans le slot de fusion
            if (osCardImage != null && osCardImage.sprite != null && osCardImage.sprite.name == "os")
            {
                // Détruisez la carte "os" dans le slot de fusion
                Destroy(slotChild.gameObject);

                // Créez une nouvelle carte "squelette"
                GameObject squeletteCard = Instantiate(squeletteCardPrefab);

                // Placez la carte "squelette" dans le panneau d'UI
                squeletteCard.transform.SetParent(uiPanel.transform, false);

                // Assurez-vous que l'image de la carte "squelette" est définie sur celle de la carte "squelette"
                Image squeletteCardImage = squeletteCard.GetComponent<Image>();
                squeletteCardImage.sprite = squeletteCardPrefab.GetComponent<Image>().sprite;
                squeletteCard.transform.localPosition += new Vector3(-950f, 200f, 0f);
            }
        }
    }
}*/

public class CardFusionManager : MonoBehaviour
{
    public GameObject osCardPrefab; // Le préfabriqué de la carte "os"
    public GameObject squeletteCardPrefab; // Le préfabriqué de la carte "squelette"
    public Transform fusionSlot; // L'emplacement où la fusion se produit
    public Button fusionButton; // Le bouton pour déclencher la fusion
    public GameObject uiPanel; // Référence au panneau d'UI où vous souhaitez afficher la carte fusionnée
    public GameObject canvas; // Le canvas de votre jeu

    private void Start()
    {
        fusionButton.onClick.AddListener(FusionnerCartes);
    }

    public void FusionnerCartes()
    {
        // Vérifiez si le slot de fusion contient une carte "os"
        if (fusionSlot.childCount == 1)
        {
            Transform slotChild = fusionSlot.GetChild(0);
            Image osCardImage = slotChild.GetComponent<Image>();

            // Vérifiez si la carte "os" est dans le slot de fusion
            if (osCardImage != null && osCardImage.sprite != null && osCardImage.sprite.name == "os")
            {
                // Détruisez la carte "os" dans le slot de fusion
                Destroy(slotChild.gameObject);

                // Créez une nouvelle carte "os" et positionnez-la à (-250, -36)
                GameObject newOsCard = Instantiate(osCardPrefab, canvas.transform);
                RectTransform newOsCardTransform = newOsCard.GetComponent<RectTransform>();
                newOsCardTransform.anchoredPosition = new Vector2(-250f, -36f);

                // Assurez-vous que l'image de la nouvelle carte "os" est définie sur celle de la carte "os"
                Image newOsCardImage = newOsCard.GetComponent<Image>();
                newOsCardImage.sprite = osCardPrefab.GetComponent<Image>().sprite;

                newOsCardImage.enabled = true;
                newOsCard.GetComponent<DragDrop>().enabled = true;

                // Créez une nouvelle carte "squelette"
                GameObject squeletteCard = Instantiate(squeletteCardPrefab);

                // Placez la carte "squelette" dans le panneau d'UI
                squeletteCard.transform.SetParent(uiPanel.transform, false);

                // Assurez-vous que l'image de la carte "squelette" est définie sur celle de la carte "squelette"
                Image squeletteCardImage = squeletteCard.GetComponent<Image>();
                squeletteCardImage.sprite = squeletteCardPrefab.GetComponent<Image>().sprite;
                squeletteCard.transform.localPosition += new Vector3(-950f, 200f, 0f);
            }
        }
    }
}