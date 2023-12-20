using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Cinemachine;

public class CameraScroll : MonoBehaviour
{
    private CinemachineVirtualCamera cam;
    public float zoomSpeed     = 5f;
    public float minZoom       = 5f;
    public float maxZoom       = 10f;
    
    void Start()
    {
        cam = GetComponent<CinemachineVirtualCamera>( );
    }

    void Update()
    {
        if(IsMouseOverUI( ))
            return;
        
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        float currentSize = cam.m_Lens.OrthographicSize;
        float newSize = Mathf.Clamp(currentSize - scroll * zoomSpeed, minZoom, maxZoom);
        cam.m_Lens.OrthographicSize = newSize;
    }
    
    private bool IsMouseOverUI()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;

        var raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);
        
        foreach (var result in raycastResults)
        {
            if (result.gameObject.name == "Chat Background")
                return true;
        }

        return false;
    }
}
