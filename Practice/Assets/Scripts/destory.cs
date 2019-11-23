using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
    [SerializeField] ParticleSystem bullet;
    [SerializeField] ParticleSystem wall;
    [SerializeField] ParticleSystem Obstacle;
    private AudioSource audio;

    public AudioClip BulletSound;
    public AudioClip PopSound;
    public AudioClip WallSound;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            audio.PlayOneShot(BulletSound);
            Destroy(this.gameObject,.2f);
            Instantiate(bullet,transform.position,Quaternion.identity);
            bullet.Play();
            
       } 
        if(collision.gameObject.tag == "wall")
        {
            audio.PlayOneShot(WallSound);
            Destroy(collision.gameObject);
            Instantiate(wall, transform.position, Quaternion.identity);
            wall.Play();
           
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            audio.PlayOneShot(PopSound);
           // Destroy(collision.gameObject);
            Instantiate(Obstacle, transform.position, Quaternion.identity);
            Obstacle.Play();
            
        }
    }
    private void Update()
    {
        Destroy(this.gameObject, 1.5f);
       
    }
}
