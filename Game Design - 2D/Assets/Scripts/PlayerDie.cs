using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverText, restartButton;
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag.Equals("Enemy")) {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
