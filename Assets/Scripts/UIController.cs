using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject startPanel;
    public Image stickmanImage;
    [SerializeField]
    private TextMeshProUGUI stickmanCountTxt, coinTxt;
    private int _stickmanCount, _coinCount;

    public int StickmanCount 
    { 
        get
        {
            return _stickmanCount;
        }
        set
        {
            _stickmanCount = value;
            stickmanCountTxt.text = _stickmanCount.ToString();
        }
    }
    public int CoinCount 
    { 
        get
        {
            return _coinCount;
        }
        set
        {
            _coinCount = value;
            coinTxt.text = _coinCount.ToString();
        }
    }

    public void StartPanelVisible()
    {
        startPanel.SetActive(false);
    }
}
