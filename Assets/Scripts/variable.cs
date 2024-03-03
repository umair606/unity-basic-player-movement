using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int score = 5;
    float postion = 2.5f;
    public string playerName = "Umair Ahmed";
    public float destoryTime;
    void Start()
    {
        print(score);
        print(playerName);

        Destroy(gameObject,destoryTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
