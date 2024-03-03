using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    public GameObject text;

    float xInput ,zInput;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 700);
        }
        /*  if(Input.GetKeyDown(KeyCode.Space)){
              //   Destroy(gameObject);
              //rb.AddForce(Vector3.up*300);
          }
          //  rb.velocity = Vector3.forward * 5f;
          if (Input.GetKeyDown(KeyCode.R))
          {
             // SceneManager.LoadScene("level_2");
          }*/
        // rb.velocity = Vector3.forward * 10f;
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        rb.AddForce(xInput * speed, 0, zInput * speed);
    }

   /* private void OnMouseDown(){
        Destroy(gameObject);
    }*/
    /*  private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.tag == "Enemy")
          {
             // Destroy(gameObject);
                Destroy(collision.gameObject);
              text.SetActive(true);
          }
      }*/

    private void OnMouseDrag()
    {
        Destroy(gameObject);
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            text.SetActive(true);
        }
    }*/
   
}
