using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public GameObject HitEffect;
    public GameObject Enemy;
    void OnCollisionEnter2D(Collision2D collision) {

        GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
        DestroyImmediate(Enemy, true);

        
        
        

    }

}
