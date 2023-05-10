using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatLimiter
{
    public int Value { get; set; }

    public LimiterCheck Constraint;

    public StatLimiter(LimiterCheck check)
    {
        Value = 0;
        Constraint = check;
    }
}
