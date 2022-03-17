using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startCamera, runningCamera;
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
            startCamera.SetActive(false);
            runningCamera.SetActive(true);
        }
    }
}
