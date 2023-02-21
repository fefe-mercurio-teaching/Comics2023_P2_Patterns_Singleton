using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private int health;

    private bool _alive;

    public int Health
    {
        get => health;
        set => health = Mathf.Min(value, 100);
    }

    // public int HealthConGraffe
    // {
    //     get
    //     {
    //         return health;
    //     }
    //
    //     set
    //     {
    //         health = value;
    //     }
    // }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int value)
    {
        health = value;
    }

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        Health = 500;
    }
}
