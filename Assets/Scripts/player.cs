using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
   
{

    Rigidbody rb;

    float xMove;
    float zMove;

    public float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         xMove = Input.GetAxis("Horizontal");
         zMove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        float xvelocity = xMove * moveSpeed;
        float zvelocity = zMove * moveSpeed;

        rb.velocity = new Vector3(xvelocity,rb.velocity.y, zvelocity);

    }


}

