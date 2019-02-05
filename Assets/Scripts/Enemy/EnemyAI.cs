using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{

    public Transform player;
    public int speed = 4;
    public int maxDist = 10;
    public int minDist = 1;
    private float dist;
    private bool faceRight = false;

    void Update()
    {
        dist = transform.position.x - player.position.x;
        /* chase player */
        if (Mathf.Abs(dist) > minDist && Mathf.Abs(dist) < maxDist)
        transform.position = Vector2.MoveTowards(transform.position, (Vector2)player.position, speed * Time.deltaTime);

        /* check if facing wrong way */
        if (faceRight == false && dist < 0)
        {
            faceRight = true;
            flipSprite();
        }
        else if (faceRight == true && dist > 0)
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