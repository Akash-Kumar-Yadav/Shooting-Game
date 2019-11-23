using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform Player;
    public Transform waypoints;
  
   [SerializeField] float timepassed;
    private float waittime;
   public float minx, maxX, minY, maxY,minZ,maxZ;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        waittime = timepassed;
        waypoints.position = new Vector3(Random.Range(minx, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoints.position) < .2)
        {
            
            if (waittime <= 0)
            {
                waypoints.position = new Vector3(Random.Range(minx, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
                waittime = timepassed;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
       
    }
}
