using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3;

    public void TakeDamage(int dmg)
    {
        Debug.Log("Damage");
        health -= dmg;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}