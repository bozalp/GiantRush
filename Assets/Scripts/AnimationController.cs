using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public static AnimationController instance;

    #region Methods
    private void Singleton()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    private void Awake()
    {
        Singleton();
    }
    public void StartRunAnimation()
    {
        animator.SetTrigger("Run");
    }
    public void StartShotAnimation()
    {
        animator.SetTrigger("Shot");
    }
    #endregion
}
