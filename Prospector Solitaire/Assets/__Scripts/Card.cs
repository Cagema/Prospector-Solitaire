using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [Header("Set Dynamically")]
    public string suit; // Масть C, H, D, S
    public int rank; // Достоинство 1-13
    public Color color = Color.black;
    public string colS = "Black";
    public List<GameObject> decoGOs = new List<GameObject>();
    public List<GameObject> pipGOs = new List<GameObject>();
    public GameObject back;
    public CardDefinition def;

    public bool faceUp
    {
        get
        {
            return !back.activeSelf;
        }
        set
        {
            back.SetActive(!value);
        }
    }

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
