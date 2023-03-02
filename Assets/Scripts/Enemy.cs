using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{

    public void TakeDamage()
    {
        Player player = GetComponent<Player>();
        player.speed -= 1;
        if (player.speed <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable PlayerHealth = collision.GetComponent<IDamageable>();
        Player player = GetComponent<Player>();
        if (PlayerHealth != null)
        {
            PlayerHealth.TakeDamage();
        }
    }
}
