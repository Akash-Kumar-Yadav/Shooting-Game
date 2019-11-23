using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bullets;
    public GameObject spawnpoint;
    public float TimeBetweenShots;
    public float speed;
    public AudioClip BulletSound;
    float FireRate;


    private void Start()
    {
      
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(BulletSound);
           GameObject bullet =  Instantiate(bullets,spawnpoint. transform.position, Quaternion.identity) as GameObject;

            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
           
        }

    }
}
