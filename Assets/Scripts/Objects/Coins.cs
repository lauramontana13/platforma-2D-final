using System;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinScore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UIManager.Instance.UpdateScore(coinScore);
            Debug.Log(PlayerStats.score);
            Destroy(gameObject);
        }
    }
}