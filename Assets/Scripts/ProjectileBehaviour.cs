using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float aliveTime = 5;
  
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > aliveTime) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Enemy>())
        {
            // Aqui invocaria los metodos de HIT, ya que el HIT tiene que ver con los golpes y este es un triger enter, si entra en la zona del enemigo le hace daño
        }
    }
}