using UnityEngine;
using UnityEngine.UI;

public class CombineButton : MonoBehaviour
{
    public CombinationSlot[] combinationSlots;

    public void CombineMonsters()
    {
        // Vérifiez les emplacements de combinaison pour confirmer la combinaison
        foreach (CombinationSlot slot in combinationSlots)
        {
            slot.CombineIngredients();
        }
    }
}