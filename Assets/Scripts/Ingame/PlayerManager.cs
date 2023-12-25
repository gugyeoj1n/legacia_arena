using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<Consumable> inventory;
    
    void Start()
    {
        inventory = new List<Consumable>( );

        Test( );
    }

    public void Test( )
    {
        List<string> codes = new List<string>( );
        codes.Add( "con_0" );
        
        GenerateInventory( codes );
    }
    
    private void GenerateInventory( List<string> itemCodes )
    {
        foreach ( string itemCode in itemCodes )
            AddItem( itemCode );
    }

    private void AddItem( string itemCode )
    {
        Consumable targetItem = ScriptableObject.CreateInstance<Consumable>( );
        Consumable standardItem = Resources.Load<Consumable>( "ItemCodes/" + itemCode );
    }

    void Update()
    {
        
    }
}
