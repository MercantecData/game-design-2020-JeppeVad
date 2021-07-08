﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemyAIMove : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    Rigidbody2D rigib;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rigib = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
        
    }

    void UpdatePath() {

        //if(seeker.IsDone()) 
        
        seeker.StartPath(rigib.position, target.position, OnPathComplete);
        
    }

    void OnPathComplete(Path p) {
        
        if(!p.error) {

            path = p;
            currentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(path == null) {

            return;
        }
        
        if(currentWaypoint >= path.vectorPath.Count) {

            reachedEndOfPath = true;
            return;
        }
        else {

            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rigib.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rigib.AddForce(force);
        
        float distance = Vector2.Distance(rigib.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance) {

            currentWaypoint++;
        }



    }
}
