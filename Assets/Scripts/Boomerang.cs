using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn;
    private float currentTime;

    private Transform returnTransform;

    public Boomerang(Sprite sprite, float timeToReturn): base(8, 10, Resources.Load<Sprite>("boomerang"))
    {
        this.timeToReturn = timeToReturn;
    }

    public override void Move(Vector2 dir)
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToReturn)
        {
            Vector2 directionToReturn = returnTransform.position - rb.transform.position;
            rb.velocity = directionToReturn.normalized * speed;
        }
        else 
        { 
            rb.velocity = dir * speed;
        }
    }
}