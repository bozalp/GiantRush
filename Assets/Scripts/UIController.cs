using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject startPanel;

    public void StartPanelVisible()
    {
        startPanel.SetActive(false);
    }
}
