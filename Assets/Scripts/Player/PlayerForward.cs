using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForward : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        if (GameManager.instance.gameStates == GameStates.Started && GameManager.instance.gameStates != GameStates.Won && GameManager.instance.gameStates != GameStates.Failed)
            GoForward();
    }

    private void GoForward()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
}
