using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{

    public Transform player;
    public int speed = 4;
    public int maxDist = 10;
    public int minDist = 5;
    private int dist;
    private bool faceRight = false;

    void Update()
    {
        /* chase player */
        transform.position = Vector2.MoveTowards(transform.position, (Vector2)player.position, speed * Time.deltaTime);

        /* check if facing wrong way */
        if (faceRight == false && player.position.x > transform.position.x)
        {
            faceRight = true;
            flipSprite();
        }
        else if (faceRight == true && player.position.x < transform.position.x)
        {
            faceRight = false;
            flipSprite();
        }
    }

    void flipSprite()
    {
        transform.Rotate(new Vector3(0, 180, 0));
    }
}