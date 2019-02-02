using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClickTarget : NetworkBehaviour, IInputClickHandler {
    [SyncVar] private Color color;
    private Material mat;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        ChangeColor();
    }

    private void Update()
    {
        mat.color = color;
    }

    private void ChangeColor()
    {
        color = UnityEngine.Random.ColorHSV();
        mat.color = color;
    }

}
