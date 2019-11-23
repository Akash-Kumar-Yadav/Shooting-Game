using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float hitdistance;
     GameObject Player;
    public float speed = 150f;
    public float movespeed = 10f;

    private Vector3 inputs;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray CameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane planeup = new Plane(Vector3.up,Vector3.zero);
        //moving

        inputs = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position = transform.position + inputs.normalized * movespeed * Time.deltaTime;

        if (planeup.Raycast(CameraRay, out hitdistance))
        {
            
            Vector3 hitpoint = CameraRay.GetPoint(hitdistance);
           
            Vector3 lookat = new Vector3(hitpoint.x, transform.position.y, hitpoint.z);
            //   Quaternion targetRotation = Quaternion.LookRotation(lookat - transform.position);
            //   transform.rotation = Quaternion.Slerp(Player.transform.rotation, targetRotation, Time.deltaTime * speed);
            // transform.LookAt(new Vector3(hitpoint.x, transform.position.y, hitpoint.z));
            transform.LookAt(lookat);
            
        }
    }
    
      


}
