using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#nullable enable

public class Card : MonoBehaviour {
//private sprite CardSprite;
private int Id;
private string CardName;
private string CardDescription;
private int[]? MoveDistance;
private int[]? AttackDistance;
private int[]? SpecialDistance;
private int SpecialValue;
private int Cost;
private int Health;
private int Attack;

//constructors && destructor

public Card()
{
    MoveDistance = new int[2];
    AttackDistance = new int[2];
    SpecialDistance = new int[2];
    SpecialValue = 0;
    Cost = 1;
    Health = 20;
    Attack = 5;
    Id = 1;
    CardName = "Test";
    CardDescription = "Basic constructor";
}

public Card(int[] MoveDistance, int[] AttackDistance, int[] SpecialDistance, int SpecialValue, int Cost, int Health, int Attack, int Id, string CardName, string CardDescription)
{
    this.MoveDistance = MoveDistance;
    this.AttackDistance = AttackDistance;
    this.SpecialDistance = SpecialDistance;
    this.SpecialValue = SpecialValue;
    this.Cost = Cost;
    this.Health = Health;
    this.Attack = Attack;
    this.Id = Id;
    this.CardName = CardName;
    this.CardDescription = CardDescription;
}
        
public Card(Card card) {
    MoveDistance = card.MoveDistance;
    AttackDistance = card.AttackDistance;
    SpecialDistance = card.SpecialDistance;
    SpecialValue = card.SpecialValue;
    Cost = card.Cost;
    Health = card.Health;
    Attack = card.Attack;
    Id = card.Id;
    CardName = card.CardName;
    CardDescription = card.CardDescription;
}
        
~Card()
{
    MoveDistance = null;
    AttackDistance = null;
    SpecialDistance = null;
}

//getters && setters

public int id
{
    get => Id;
    set => Id = value;
}
public string cardName
{
    get => CardName;
    set => CardName = value;
}
public string cardDescription
{
    get => CardDescription; 
    set => CardDescription = value;
}
public int[]? moveDistance
    {
    get => MoveDistance;
    set => MoveDistance = value;
}
public int[]? attackDistance
{
    get => AttackDistance; 
    set => AttackDistance = value;
}
public int[]? specialDistance
{
    get => SpecialDistance;
    set => SpecialDistance = value;
}
public int specialValue
{
    get => SpecialValue;
    set => SpecialValue = value;
}
public int cost
{
    get => Cost;
    set => Cost = value;
}
public int health
{
    get => Health; 
    set => Health = value;
}
public int attack
{
    get => Attack; 
    set => Attack = value;
}
}