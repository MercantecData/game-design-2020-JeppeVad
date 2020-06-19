/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private string currentState = "Patrol";
    public Transform wavepoint1;
    public Transform wavepoint2;
    public float speed = 5;
    private Transform nextWavepoint;
    // Start is called before the first frame update
    public float range = 15;
    public LayerMask mask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentState == "Patrol") {
            
            Vector2 nextPosition = Vector2.MoveTowards(transform.position, nextWavepoint.position, Time.deltaTime*speed);
            transform.position = nextPosition;
/*
            if(transform.position == wavepoint1.position) {


            }
            
            //transform.position += Vector3.up*5*Time.deltaTime;
            if(TargetAq()) {
                currentState = "Attack";
            }
        }
        else if (currentState == "Attack") {

            print("Shoot");

            if(!TargetAq()) {
                currentState = "Partrol";
            }
        }
    }

    bool TargetAq() 
    {
        GameObject targetGO = GameObject.FindGameObjectWithTag("Player");
        bool inRange = false;
        bool inVision = false;

        if(Vector2.Distance(targetGO.transform.position, transform.position) < range) {
            inRange = true;
        }

        var linecast = Physics2D.Linecast(transform.position, targetGO.transform.position, mask);
        if(linecast.transform == null) {
            inVision = true;
        }
        return inRange && inVision;
    }
}
*/