using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // この行も追加が必要なので注意

public class ObjClickSample : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}