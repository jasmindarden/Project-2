using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public GameObject Player;
    public List<GameObject> enemyList;

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

    void Start()
    {
        enemyList = new List<GameObject>();
    }

}

