using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public RectTransform[] slots;
    public GameObject[] gears;
    public RectTransform[] originalSlots;

    public TextMeshProUGUI nuggetText;

    private List<Vector2> slotsRT = new List<Vector2>();
    private List<Vector2> gearsRT = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(gears[0].GetComponent<CanvasGroup>().alpha == 0.9f &&
           gears[1].GetComponent<CanvasGroup>().alpha == 0.9f &&
           gears[2].GetComponent<CanvasGroup>().alpha == 0.9f &&
           gears[3].GetComponent<CanvasGroup>().alpha == 0.9f &&
           gears[4].GetComponent<CanvasGroup>().alpha == 0.9f)
        {
            nuggetText.text = "YAY, PARABÉNS. TASK CONCLUÍDA!";

            foreach(GameObject go in gears)
            {
                go.GetComponent<GearDrag>().girando = true;

                if(go.GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
                   go.GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition)
                {
                    go.GetComponent<GearDrag>().antiHorario = true;
                }
                else
                {
                    go.GetComponent<GearDrag>().antiHorario = false;
                }
            }
        }
        else
        {
            nuggetText.text = "ENCAIXE AS ENGRENAGENS EM QUALQUER ORDEM!";
            foreach (GameObject go in gears)
            {
                go.GetComponent<GearDrag>().girando = false;
            }
        }

        if (gears[0].GetComponent<RectTransform>().anchoredPosition == slots[0].anchoredPosition ||
            gears[0].GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
            gears[0].GetComponent<RectTransform>().anchoredPosition == slots[2].anchoredPosition ||
            gears[0].GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition ||
            gears[0].GetComponent<RectTransform>().anchoredPosition == slots[4].anchoredPosition)
        {
            gears[0].GetComponent<CanvasGroup>().alpha = 0.9f;
        }
        else
        {
            gears[0].GetComponent<CanvasGroup>().alpha = 1f;
        }

        if (gears[1].GetComponent<RectTransform>().anchoredPosition == slots[0].anchoredPosition ||
            gears[1].GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
            gears[1].GetComponent<RectTransform>().anchoredPosition == slots[2].anchoredPosition ||
            gears[1].GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition ||
            gears[1].GetComponent<RectTransform>().anchoredPosition == slots[4].anchoredPosition)
        {
            gears[1].GetComponent<CanvasGroup>().alpha = 0.9f;
        }
        else
        {
            gears[1].GetComponent<CanvasGroup>().alpha = 1f;
        }

        if (gears[2].GetComponent<RectTransform>().anchoredPosition == slots[0].anchoredPosition ||
            gears[2].GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
            gears[2].GetComponent<RectTransform>().anchoredPosition == slots[2].anchoredPosition ||
            gears[2].GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition ||
            gears[2].GetComponent<RectTransform>().anchoredPosition == slots[4].anchoredPosition)
        {
            gears[2].GetComponent<CanvasGroup>().alpha = 0.9f;
        }
        else
        {
            gears[2].GetComponent<CanvasGroup>().alpha = 1f;
        }

        if (gears[3].GetComponent<RectTransform>().anchoredPosition == slots[0].anchoredPosition ||
            gears[3].GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
            gears[3].GetComponent<RectTransform>().anchoredPosition == slots[2].anchoredPosition ||
            gears[3].GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition ||
            gears[3].GetComponent<RectTransform>().anchoredPosition == slots[4].anchoredPosition)
        {
            gears[3].GetComponent<CanvasGroup>().alpha = 0.9f;
        }
        else
        {
            gears[3].GetComponent<CanvasGroup>().alpha = 1f;
        }

        if (gears[4].GetComponent<RectTransform>().anchoredPosition == slots[0].anchoredPosition ||
            gears[4].GetComponent<RectTransform>().anchoredPosition == slots[1].anchoredPosition ||
            gears[4].GetComponent<RectTransform>().anchoredPosition == slots[2].anchoredPosition ||
            gears[4].GetComponent<RectTransform>().anchoredPosition == slots[3].anchoredPosition ||
            gears[4].GetComponent<RectTransform>().anchoredPosition == slots[4].anchoredPosition)
        {
            gears[4].GetComponent<CanvasGroup>().alpha = 0.9f;
        }
        else
        {
            gears[4].GetComponent<CanvasGroup>().alpha = 1f;
        }
    }

    public void ResetPositions()
    {
        gears[0].GetComponent<RectTransform>().anchoredPosition = originalSlots[0].anchoredPosition;
        gears[1].GetComponent<RectTransform>().anchoredPosition = originalSlots[1].anchoredPosition;
        gears[2].GetComponent<RectTransform>().anchoredPosition = originalSlots[2].anchoredPosition;
        gears[3].GetComponent<RectTransform>().anchoredPosition = originalSlots[3].anchoredPosition;
        gears[4].GetComponent<RectTransform>().anchoredPosition = originalSlots[4].anchoredPosition;
    }
}
