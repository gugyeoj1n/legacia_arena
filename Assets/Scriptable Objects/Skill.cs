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