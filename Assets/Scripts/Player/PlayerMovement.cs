using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float swipeSpeed, movementLimitValue;
    private Vector3 inputDrag, preMousePos;

    private void Update()
    {
        Swipe();
        MoveHorizontal();
    }
    private void MoveHorizontal()
    {
        var dragPos = Vector3.right * inputDrag.x * swipeSpeed * Time.deltaTime;

        if (transform.localPosition.x > movementLimitValue)
        {
            transform.localPosition = new Vector3(movementLimitValue - .02f, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.x < -movementLimitValue)
        {
            transform.localPosition = new Vector3(-movementLimitValue + .02f, transform.localPosition.y, transform.localPosition.z);
        }
        else
        {
            transform.localPosition += dragPos;
        }
    }
    private void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            preMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            var deltaMouse = Input.mousePosition - preMousePos;
            inputDrag = deltaMouse;
            preMousePos = Input.mousePosition;
        }
        else
        {
            inputDrag = Vector3.zero;
        }
    }
}
