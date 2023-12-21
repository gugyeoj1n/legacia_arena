using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class WindowManager : MonoBehaviour
{
    [Header( "Windows" )]
    public GameObject SettingWindow;

    [Header( "Variables" )]
    private bool settingOpened = false;
    
    void Update( )
    {
        if(Input.GetKeyDown( KeyCode.Escape ))
            SettingManage(  );
    }

    public void SettingManage( )
    {
        settingOpened = !settingOpened;
        SettingWindow.SetActive( settingOpened );
    }
}
