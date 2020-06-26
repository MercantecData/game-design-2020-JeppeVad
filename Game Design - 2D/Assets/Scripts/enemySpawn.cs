using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float randx;
    float randy;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    int spawnPlaceNumb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn) {

            spawnPlaceNumb = Random.Range(1, 3);

            switch(spawnPlaceNumb) {

                case 1:
                    randx = Random.Range(-55f, -77f);
                    randy = Random.Range(23f, 30f);
                    break;
                case 2:
                    randx = Random.Range(-60f, -70f);
                    randy = Random.Range(80f, 70f);
                    break;
                case 3:
                    randx = Random.Range(-15f, -30f);
                    randy = Random.Range(47f, 40f);
                    break;                              
            }

            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector3(randx, randy, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
