using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GearDrag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    public bool antiHorario;
    public bool girando;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eData)
    {
        Debug.Log("COMEÇOU A ARRASTAR HEIN");
        canvasGroup.alpha = 0.5f;
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eData)
    {
        Debug.Log("ESTOU ARRASTANDO NO MOMENTO");
        rectTransform.anchoredPosition += eData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eData)
    {
        Debug.Log("TERMINOU DE ARRASTAR HEIN");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eData)
   {
        Debug.Log("ME CLICOU HEIN");
   }

    void Update()
    {
        if(girando)
        {
            if(antiHorario)
            {
                rectTransform.Rotate(new Vector3(0, 0, 2));
            }
            else
            {
                rectTransform.Rotate(new Vector3(0, 0, -2));
            }
        }

    }
}
