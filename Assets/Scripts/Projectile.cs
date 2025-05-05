using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProjectileType{ARROW, ICEARROW, BOOMERANG}

public abstract class Projectile
{
    protected float speed;
    protected float damage;
    protected Rigidbody2D rb;
    private Sprite sprite;

    public Projectile(float damage, float speed, Sprite sprite) 
    {
        this.damage = damage;
        this.speed = speed;
        this.sprite = sprite;
    }

    public Sprite GetSprite()
    { 
        return sprite; 
    }

    public abstract void Move(Vector2 dir);

    public virtual GameObject Hit(GameObject reciver) 
    {
        return reciver;
    }
}