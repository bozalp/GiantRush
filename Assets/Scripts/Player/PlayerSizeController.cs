using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Player
{
    public class PlayerSizeController : MonoBehaviour
    {
        [SerializeField]
        private float sizeValue;
        private Vector3 bodyScale;
        private UIController UIController;

        private void Start()
        {
            DOTween.Init();
            UIController = GameObject.FindObjectOfType<UIController>();
            bodyScale = transform.localScale;
        }

        private void OnTriggerEnter(Collider other)
        {

            if (other.transform.GetComponent<ColorController>())//I checked if the triggered object has <ColorController>
            {
                if (!other.transform.GetComponent<ColorController>().IsGate)
                {
                    if (transform.GetComponent<ColorController>().ColorType == other.transform.GetComponent<ColorController>().ColorType)
                    {
                        SizeUp();
                        UIController.StickmanCount += 1;
                        Destroy(other.gameObject);
                    }
                    if (transform.GetComponent<ColorController>().ColorType != other.transform.GetComponent<ColorController>().ColorType)
                    {
                        if (UIController.StickmanCount >= 1)
                        {
                            UIController.StickmanCount -= 1;
                            SizeDown();
                        }
                        Destroy(other.gameObject);
                    }
                }
                else
                {
                    transform.GetComponent<ColorController>().ColorType = other.transform.GetComponent<ColorController>().ColorType;
                    transform.GetComponent<ColorController>().ChangeBodyColor(other.transform.GetComponent<ColorController>().ColorType);
                }
            }
            if (other.transform.CompareTag("Coin"))
            {
                UIController.CoinCount += 1;
                Destroy(other.gameObject);
            }
            if (other.transform.CompareTag("Finish"))
            {
                GameManager.instance.isFinish = true;
            }

        }
        public void SizeUp()
        {
            transform.localScale += Vector3.one * sizeValue;
            //bodyScale = new Vector3(bodyScale.x + sizeValue, bodyScale.y + sizeValue, bodyScale.z + sizeValue);
            
            //transform.DOScale(bodyScale, .1f);
            ////transform.localScale = new Vector3(bodyScale.x + sizeValue, bodyScale.y + sizeValue, bodyScale.z + sizeValue);
            //bodyScale = transform.localScale;
        }
        public void SizeDown()
        {
            transform.localScale -= Vector3.one * sizeValue;
           // bodyScale = transform.localScale;
        }
    }
}