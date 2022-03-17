using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSizeController : MonoBehaviour
{
    [SerializeField]
    private float sizeValue;
    private Vector3 bodyScale;

    private void Start()
    {
        bodyScale = transform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(transform.GetComponent<ColorController>().ColorType == other.transform.GetComponent<ColorController>().ColorType)
        {
            SizeUp();
            Destroy(other.gameObject);
        }
        if (transform.GetComponent<ColorController>().ColorType != other.transform.GetComponent<ColorController>().ColorType)
        {
            SizeDown();
            Destroy(other.gameObject);
        }
    }
    public void SizeUp()
    {
        transform.localScale = new Vector3(bodyScale.x + sizeValue, bodyScale.y + sizeValue, bodyScale.z + sizeValue);
        bodyScale = transform.localScale;
    } 
    public void SizeDown()
    {
        transform.localScale = new Vector3(bodyScale.x - sizeValue, bodyScale.y - sizeValue, bodyScale.z - sizeValue);
        bodyScale = transform.localScale;
    }
}
