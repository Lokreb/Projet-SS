using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Card> inventory = new List<Card>();

    // Ajouter une carte à l'inventaire
    public void AddToInventory(Card card)
    {
        inventory.Add(card);
    }

    // Retirer une carte de l'inventaire
    public void RemoveFromInventory(Card card)
    {
        inventory.Remove(card);
    }
}