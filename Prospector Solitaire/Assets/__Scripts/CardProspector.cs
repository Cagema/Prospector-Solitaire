using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum eCardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardProspector : Card
{
    [Header("Set Denamically: CardProspector")]
    public eCardState state = eCardState.drawpile;
    public List<CardProspector> hiddenBy = new List<CardProspector>();
    public int layoutID; // Ряд 
    public SlotDef slotDef;
}
