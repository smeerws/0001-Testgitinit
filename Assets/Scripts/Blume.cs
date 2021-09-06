using UnityEngine;
using UnityEngine.EventSystems;

public class Blume : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("BLUUUUME OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(GetComponent<RectTransform>().anchoredPosition.x-30f, GetComponent<RectTransform>().anchoredPosition.y + 100f);
        }
    }

   private void Start()
    {
        Debug.Log("Blume awake");    
    }
}
