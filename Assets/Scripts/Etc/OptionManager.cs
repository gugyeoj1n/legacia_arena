using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [Header ( "Graphic" )]
    public bool fullScreen;
    public bool displayFPS;

    [Header( "Sound" )]
    public float masterVolume;
    public float backgroundVolume;
    public float effectVolume;

    [Header("Key Binding")]
    public KeyCode attackKey;
    public KeyCode rollKey;
    public KeyCode skill1Key;
    public KeyCode skill2Key;
    public KeyCode skill3Key;
    public KeyCode item1Key;
    public KeyCode item2Key;
    public KeyCode item3Key;
    public KeyCode item4Key;
    public KeyCode item5Key;
    public KeyCode pingKey;

    void Start()
    {
        
    }

    public void GenerateOptions()
    {
        // bool -> int 0 = false / 1 = true
        // KeyCode -> string / (KeyCode) System.Enum.Parse(typeof(KeyCode), “string”, true) 
        
        // Graphic
        PlayerPrefs.SetInt("fullScreen", 1);
        PlayerPrefs.SetInt("displayFPS", 0);
        
        // Sound
        PlayerPrefs.SetFloat("masterVolume", 1f);
        PlayerPrefs.SetFloat("backgroundVolume", 1f);
        PlayerPrefs.SetFloat("effectVolume", 1f);
        
        // Key Bindings
        PlayerPrefs.SetString("attackKey", "");
    }

    public void LoadOptions()
    {
        
    }

    public void SaveOptions()
    {
        
    }
}
