using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public float maxDist;
    public float minDist;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(Vector3.Distance(transform.position, player.position) <= minDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if(Vector3.Distance(transform.position, player.position) >= maxDist)
        {
            rb.velocity = Vector3.zero;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position -= transform.forward * moveSpeed;
        }
    }
}
