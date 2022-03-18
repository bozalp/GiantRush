using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotating : MonoBehaviour
{
    [SerializeField]
    private float rotateValue;
    void Update()
    {
        RotateCoin();
    }
    private void RotateCoin()
    {
        transform.Rotate(new Vector3(0, rotateValue * Time.deltaTime, 0));
    }
}
