using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // この行も追加が必要なので注意

public class ObjClickSample : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler//必要なインターフェースを実装
    //このサンプルの場合、Enter/Exit/Clickイベントに対しての処理を記述している
{
    public void OnPointerClick(PointerEventData pointerEventData)//クリックの場合はここに記述
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnPointerEnter(PointerEventData pointerEventData)//エンターの場合はここに記述
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnPointerExit(PointerEventData pointerEventData)//Exitの場合はここに記述
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}