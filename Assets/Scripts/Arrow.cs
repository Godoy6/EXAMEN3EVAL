using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Arrow : Projectile
{
    public Arrow(Sprite sprite) : base(25, 30 , Resources.Load<Sprite>("arrow")) 
    { 
    
    }

    public override void Move(Vector2 dir)
    {
        dir = new Vector2(0, speed * Time.deltaTime);
    }
}

// LA FLECHA SE INSTANCIA EN EL PLAYER SHOOT

// GameObject arrow = GameObject.Instantiate(sprite, reciver.transform.position, Quaternion.identity);
// arrow.GetComponent<Projectile>().SetDir(Vector2.up);
// arrow.GetComponent<Projectile>().speed = speed;