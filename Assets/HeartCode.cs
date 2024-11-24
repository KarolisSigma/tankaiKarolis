using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCode : MonoBehaviour
{
    private Canvas canvas;
     void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
    }

}
