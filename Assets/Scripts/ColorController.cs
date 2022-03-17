using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public enum ColorTypes
{
    Red,
    Green,
    Blue
}

public class ColorController : MonoBehaviour
{
    [SerializeField]
    private ColorTypes colorType;
    [SerializeField]
    private bool isGate;

    [SerializeField]
    private Color32[] bodyColor;    //red-0     green-1     blue-2
    [SerializeField]
    private GameObject body;

    private UIController UIController;
    public ColorTypes ColorType
    {
        get
        {
            return colorType;
        }
        set
        {
            colorType = value;
        }
    }
    public bool IsGate
    {
        get
        {
            return isGate;
        }
    }

    private void Start()
    {
        UIController = GameObject.FindObjectOfType<UIController>();
        ChangeBodyColor(colorType);
    }

    public void ChangeBodyColor(ColorTypes colorType)
    {
        switch (colorType)
        {
            case ColorTypes.Red:
                body.GetComponent<Renderer>().material.color = bodyColor[0];
                UIController.stickmanImage.color = new Color32(bodyColor[0].r, bodyColor[0].g, bodyColor[0].b, 255);
                break;
            case ColorTypes.Green:
                body.GetComponent<Renderer>().material.color = bodyColor[1];
                UIController.stickmanImage.color = new Color32(bodyColor[1].r, bodyColor[1].g, bodyColor[1].b, 255);
                break;
            case ColorTypes.Blue:
                body.GetComponent<Renderer>().material.color = bodyColor[2];
                UIController.stickmanImage.color = new Color32(bodyColor[2].r, bodyColor[2].g, bodyColor[2].b, 255);
                break;
            default:
                break;
        }
    }
}
