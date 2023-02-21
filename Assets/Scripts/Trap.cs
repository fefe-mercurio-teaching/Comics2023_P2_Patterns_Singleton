using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        // Debug.Log("Giocatore tocca trappola");
        GameManager.Instance.Health--;
    }
}
