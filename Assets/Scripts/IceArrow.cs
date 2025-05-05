using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArrow : Projectile
{
    public IceArrow(Sprite sprite) : base(10, 15, Resources.Load<Sprite>("icearrow"))
    {

    }

    public override void Move(Vector2 dir)
    {
        dir = new Vector2(3 * Mathf.Sin(Time.time), 5) * Time.deltaTime;
    }

    public override GameObject Hit(GameObject reciver)
    {
        return reciver;
    }
}