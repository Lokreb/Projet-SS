using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDatabase")]
public class CardDatabase : ScriptableObject
{
    public List<IngredientCard> ingredientCards = new List<IngredientCard>();
    public List<MonsterCard> monsterCards = new List<MonsterCard>();
}