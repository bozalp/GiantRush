using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject startPanel;
    public Image stickmanImage;

    public void StartPanelVisible()
    {
        startPanel.SetActive(false);
    }
}
