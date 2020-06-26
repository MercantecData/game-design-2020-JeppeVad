using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPre;
    public float bulletSpeed = 20f;
    public AudioClip clip1;
    private AudioSource ShotAudio;
    
    int coolDownTimer = 1;
    bool coolingDown = true;


    // Update is called once per frame
    void Start() {

        /*
        GetComponentInChildren<AudioSource>().Play();
        var clip = GetComponentInChildren<AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, Vector2.zero);
        */
        ShotAudio = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        
        
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
            ShotAudio.Play();
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPre, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);

    }
}
