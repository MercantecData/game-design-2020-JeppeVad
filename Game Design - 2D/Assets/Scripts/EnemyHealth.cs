﻿using System.Collections;
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
    
    void OnCollisionEnter2D (Collision2D col) {

        if(col.gameObject.tag.Equals("Bullet")) {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
