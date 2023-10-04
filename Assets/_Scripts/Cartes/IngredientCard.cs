using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "IngredientCard")]
public class IngredientCard : ScriptableObject
{
    public string cardName;
    public Rarity rarity;
    public Sprite cardArt; 

    public enum Rarity
    {
        Common,
        Rare,
        Legendary
    }
}