using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
    // Start is called before the first frame update

    public bool gameOver;
    public int power;
    void Start()
    {/*
        if(transform.position.x > 5f){
            Destroy(gameObject);
        }else{
            print("you safe");
        }
*/
        //Boolean Conditions...
        /*
        if(gameOver == true){
            //print("Game is over");
            Destroy(gameObject);   
            }else{
            print("Keep playing");
        }*/


        if(power >=2 && power<5){
            print("Super power");
        }else if(power >=5 && power<=10){
            print("Ultra power");
        }else{
            print("Normal power");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* if(gameOver == true){
            //print("Game is over");
            Destroy(gameObject);   
            }else{
            print("Keep playing");
        }*/
    }
}
