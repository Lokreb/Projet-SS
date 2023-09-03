using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    // Vous pouvez ajouter des propriétés spécifiques à la carte ici (nom, image, etc.)

    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = FindObjectOfType<InventoryManager>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Ajoute la carte à l'inventaire lors d'un clic
        inventoryManager.AddToInventory(this);
        //Masquer la carte
        gameObject.SetActive(false);
    }
}