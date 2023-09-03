using UnityEngine;
using UnityEngine.EventSystems;

public class CombinationSlot : MonoBehaviour, IDropHandler
{
    public GameObject combinedMonsterPrefab; // Le prefab du monstre résultant

    public void OnDrop(PointerEventData eventData)
    {
        // Vérifiez si le contenu glissé est un ingrédient valide
        IngredientCard ingredient = eventData.pointerDrag.GetComponent<IngredientCard>();
        if (ingredient != null)
        {
            // Ajoutez l'ingrédient à l'emplacement de combinaison
            ingredient.transform.SetParent(transform);
        }
    }

    public void CombineIngredients()
    {
        // Vérifiez les ingrédients dans les emplacements de combinaison
        // En fonction des ingrédients, instanciez le monstre approprié
        Instantiate(combinedMonsterPrefab, transform.position, Quaternion.identity);

        // Réinitialisez les emplacements de combinaison
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}