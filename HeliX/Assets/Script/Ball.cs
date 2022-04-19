using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float velocity;
    [HideInInspector] public Rigidbody rb;
    [HideInInspector] public GameManager gm;
    private SpawnManager sm;

      void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        sm = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Red")
        {
            gm.RestartGame();
        }else if(collision.collider.tag == "White")
        {
            rb.AddForce(Vector3.up*velocity);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spawn"))
        {
            sm.SpawnCylinder();
            Destroy(other.gameObject);
            sm.canSpawn = true;
        }
    }
}
