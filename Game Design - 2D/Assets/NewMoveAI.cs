using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoveAI : MonoBehaviour
{
public Transform Player;
    int MovementSpeed = 4;

    private Rigidbody2D rb;
    private Vector2 movement;
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        direction.Normalize();
        movement = direction;       
         */
        transform.position = Vector2.MoveTowards(transform.position, Player.position, MovementSpeed * Time.deltaTime);

    }
}
