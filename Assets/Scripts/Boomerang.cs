using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn;
    private float currentTime;

    public Boomerang(Sprite sprite, float timeToRetur): base(8, 10, Resources.Load<Sprite>("boomerang"))
    {
        this.timeToReturn = timeToReturn;
    }

    public override void Move()
    {

    }
}