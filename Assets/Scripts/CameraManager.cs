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
        if (GameManager.instance.gameStates != GameStates.Started && Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameManager.instance.gameStates = GameStates.Started;
            AnimationController.instance.StartRunAnimation();
            UIController.StartPanelVisible();
            startCamera.SetActive(false);
            runningCamera.SetActive(true);
        }
    }
}
