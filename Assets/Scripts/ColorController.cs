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
    private Color32 bodyColor;
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
    private void Start()
    {
        ChangeBodyColor();
    }

    private void ChangeBodyColor()
    {
        switch (ColorType)
        {
            case ColorTypes.Red:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor;
                break;
            case ColorTypes.Green:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor;
                break;
            case ColorTypes.Blue:
                enemyBody.GetComponent<Renderer>().material.color = bodyColor;
                break;
            default:
                break;
        }
    }
}
