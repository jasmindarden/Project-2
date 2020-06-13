using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager instance;
    public GameObject Player;
    public int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.LogWarning("[GameManager] Attempted to create a second game manager:" + this.gameObject.name);
        }
    }
}

