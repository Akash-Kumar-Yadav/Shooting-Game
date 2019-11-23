using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    [SerializeField] Transform Enemy;

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    void Spawn()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }

}
