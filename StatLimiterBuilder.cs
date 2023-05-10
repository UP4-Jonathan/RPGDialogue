using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mod Template", menuName = "Tools/Templates/New Stat Limiter Template")]
public class StatLimiterBuilder : ScriptableObject
{
    public LimiterTemplate[] limiters;
}

public class LimiterTemplate
{
    public NameVariable StatName;
    public NameVariable Limiter;
    public LimiterCheck check;

}
