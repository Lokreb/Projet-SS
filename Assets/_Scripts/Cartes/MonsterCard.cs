using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Monster")]
public class MonsterCard : ScriptableObject
{
    public string cardName;
    public string description;
    public Rarity rarity;
    public Sprite cardArt;

    public enum Rarity
    {
        Common,
        Rare,
        Legendary
    }
}