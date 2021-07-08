using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody2D PlayerBody;
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var LeftRight = Input.GetAxis("Horizontal");
        var UpDown = Input.GetAxis("Vertical");
    

        Vector2 position = transform.position;
        position.x += speed * Time.deltaTime * LeftRight;       
        position.y += speed * Time.deltaTime * UpDown;

        //transform.position = position;
        PlayerBody.MovePosition(position);
    }
}
