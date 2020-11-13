using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    
}

[System.Serializable]
public class Decorator
{
    // Этот класс хранит информацию из DeckXML о каждом значке на карте
    public string type;
    public Vector3 loc;
    public bool flip = false;
    public float scale = 1f;
}

[System.Serializable]
public class CardDefinition
{
    // Этот класс хранит информацию о достоинстве карты
    public string face; // Спрайт лицевой стороны карты
    public int rank; // Достоинство карты (1-13)
    public List<Decorator> pips = new List<Decorator>(); // Значки
}
