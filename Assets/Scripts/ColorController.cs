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
    private GameObject enemyBody;
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
        ChangeBodyColor(colorType);
    }

    public void ChangeBodyColor(ColorTypes colorType)
    {
        switch (colorType)
        {
            case ColorTypes.Red:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor[0];
                break;
            case ColorTypes.Green:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor[1];
                break;
            case ColorTypes.Blue:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor[2];
                break;
            default:
                break;
        }
    }
}
