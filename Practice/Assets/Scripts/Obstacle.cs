using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Obstacle : MonoBehaviour
{
    [SerializeField] NavMeshAgent NavMeshAgent;
    [SerializeField] GameObject player;
    private AudioSource audio;
    public AudioClip PopSound;
   
   
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        NavMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent.SetDestination(player.transform.position);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            audio.PlayOneShot(PopSound);
            Destroy(this.gameObject,.3f);
           
        }
    }

}
