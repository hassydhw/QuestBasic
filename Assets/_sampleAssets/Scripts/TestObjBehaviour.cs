using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjBehaviour : MonoBehaviour
{

    public Material normal;
    public Material hovered;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = normal;
    }

    public void OnPointerEnter()
    {
        rend.material = hovered;
    }

    public void OnPointerExit()
    {
        rend.material = normal;
    }
}