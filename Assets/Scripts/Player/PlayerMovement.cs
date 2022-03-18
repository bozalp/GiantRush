using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float swipeSpeed, movementLimitValue;
        private Vector3 inputDrag, preMousePos;

        private void Update()
        {
            if(!GameManager.instance.isFinish && GameManager.instance.isStart)
            {
                Swipe();
                MoveHorizontal();
                SwipeOnKeyboard();
            }
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
        private void SwipeOnKeyboard()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.localPosition += new Vector3(-swipeSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.localPosition += new Vector3(swipeSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
}
