using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnpoint;
    //variables of random postions
    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        //how we spawn ball in repeaditly position....
        InvokeRepeating("spawnBall", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //spawn ball using space button.....
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnBall();
        }

        //how to spawn ball using mouse button......
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ball,spawnPos,Quaternion.identity);
        }
    }
    void spawnBall() 
    {
        //how we spawn random balls in our game......

        float RandomX = Random.Range(-maxX,maxX);
        float RandomZ = Random.Range(-maxZ, maxZ);

        Vector3 RandomSpawnPos = new Vector3(RandomX, 10f, RandomZ);
        Instantiate(ball, RandomSpawnPos, Quaternion.identity );
      //  Instantiate(ball, spawnpoint.position, Quaternion.identity);
    }
}
