using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LimiterCheck : ScriptableObject
{
    /*[SerializeField] private NameVariable statName;
    public NameVariable StatName { get { return statName; } }
    [SerializeField] private NameVariable actorName;
    public NameVariable Limiter { get { return actorName; } }
    public int Value { get; set; }*/
       
    public abstract int CheckValue(int value, int limit);

}

