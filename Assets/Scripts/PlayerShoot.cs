using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public ProjectileType ProjectileType;
    private Projectile Projectile;

    public float timeToShoot = 0.4f;
    public GameObject projectile;

    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
           
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeProjectile();
        }
    }

    void ChangeProjectile() 
    {
        ProjectileType++;
        if (ProjectileType > ProjectileType.ARROW) 
        { 
        
        }
    }

    void InstanceProjectile() 
    {
        switch (ProjectileType)
        { 
            case ProjectileType.ARROW:
                Projectile = new Arrow();
                break;
            case ProjectileType.ICEARROW:
                Projectile = new IceArrow();
                break;
            case ProjectileType.BOOMERANG:
                Projectile = new Boomerang();
                break;
        }
    }
}