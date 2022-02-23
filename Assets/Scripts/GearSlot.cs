using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GearSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eData)
    {
        Debug.Log("Largaram aqui em mim hein...");
        if(eData.pointerDrag != null)
        {
            eData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
