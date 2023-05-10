using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Min Value Limiter",menuName = "Tools/Effects/Limiters/Min Stat Value Limiter")]
public class MinValueLimiter : LimiterCheck
{
    public override int CheckValue(int value, int limit)
    {
        if (value < limit)
            return limit - value;
        else
            return 0;
    }
}
