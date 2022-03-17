using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startCamera, runningCamera;
    [SerializeField]
    private UIController UIController;
    private void Update()
    {
        ChangeCamera();
    }
    private void ChangeCamera()
    {
        if (!GameManager.instance.isStart && Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameManager.instance.isStart = true;
            AnimationController.instance.StartRunAnimation();
            UIController.StartPanelVisible();
            startCamera.SetActive(false);
            runningCamera.SetActive(true);
        }
    }
}
