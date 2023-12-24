using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Consumable,
        Legacy,
        Material
    }

    public enum ItemTier
    {
        Common,
        Rare,
        Secret,
        History,
        Creation
    }
    
    public string itemName;
    public string description;
    public Sprite icon;
    public ItemType itemType;
    public ItemTier itemTier;
    public string itemCode;

    public bool isConsumable;
    public bool isEquipable;
    public int maxStack;
}

[CreateAssetMenu( fileName = "Weapon", menuName = "Items/Weapon" )]
public class Weapon : Item
{
    public enum AttackType
    {
        Melee,
        Ranged
    }

    public float damage;
    public float speed;
    public float range;

    public AttackType attackType;
    public Skill skill;

    public Weapon( )
    {
        isEquipable     = true;
        isConsumable    = false;
        maxStack        = 1;
    }
}

[CreateAssetMenu( fileName = "Consumable", menuName = "Items/Consumable" )]
public class Consumable : Item
{
    public enum ConsumableType
    {
        Buff,
        Throwable
    }

    public ConsumableType consumableType;

    public Consumable( )
    {
        isEquipable      = false;
        isConsumable     = true;
        maxStack         = 99;
    }
}

[CreateAssetMenu( fileName = "Legacy", menuName = "Items/Legacy" )]
public class Legacy : Item
{
    public Skill skill;
}

[CreateAssetMenu( fileName = "Material", menuName = "Items/Material" )]
public class Material : Item
{
    
}