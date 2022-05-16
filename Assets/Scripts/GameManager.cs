using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates
{
    Waiting,
    Started,
    Won,
    Failed
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameStates gameStates;
    private void Singleton()
    {
        if(instance != null)
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
}
