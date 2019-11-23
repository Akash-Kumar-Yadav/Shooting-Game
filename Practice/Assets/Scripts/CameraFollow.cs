using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().transform;
        offset = transform.position - Player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.position + offset;
    }
}
