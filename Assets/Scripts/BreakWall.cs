using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    private Rigidbody[] stones;

    private void Start()
    {
        stones = gameObject.GetComponentsInChildren<Rigidbody>();
    }

    public void BreakAllWall()
    {
        for (int i = 0; i < stones.Length; i++)
        {
            stones[i].GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-15f, 15f), Random.Range(5f, 15f), Random.Range(2,5)), ForceMode.Impulse);
            stones[i].GetComponent<Rigidbody>().useGravity = true;            
        }
    }
}
