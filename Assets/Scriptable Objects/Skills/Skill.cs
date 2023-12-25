using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = ("Skills/Skill"))]
public class Skill : ScriptableObject
{
    public enum Effect
    {
        Sequence,
        Trigger
    }

    public string skillName;
    public string description;
    public Effect effect;
    public Sprite icon;
}

[CreateAssetMenu( fileName = "Sequence", menuName = "Skills/Sequence" )]
public class Sequence : Skill
{
    public Sequence( )
    {
        effect = Effect.Sequence;
    }
}

[CreateAssetMenu( fileName = "Trigger", menuName = "Skills/Trigger" )]
public class Trigger : Skill
{
    public Trigger( )
    {
        effect = Effect.Trigger;
    }
}