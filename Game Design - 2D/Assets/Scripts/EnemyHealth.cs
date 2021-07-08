using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            
    }
    
    void OnTriggerEnter2D(Collider2D col) {

        HealthBarScript.health -= 10f;
    }

    void OnCollisionEnter2D (Collision2D col) {

        if(col.gameObject.tag.Equals("Bullet")) {
            Destroy(col.gameObject);
            Destroy(gameObject);
            pointCounter.scoreValue += 10;
        }
        
    }

}
