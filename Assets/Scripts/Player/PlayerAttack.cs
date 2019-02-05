using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public float coolDownTimer;
    public float coolDown;

    public Transform attackPos;
    public LayerMask enemy;
    public float attackRange;
    public int dmg;

    public Animation anim;

    void Update()
    {
        if (coolDownTimer <= 0)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                anim.Play("jaw_swing_legacy");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(dmg);
                }
                coolDownTimer = coolDown;
            }
        }
        else
        {
            coolDownTimer -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}