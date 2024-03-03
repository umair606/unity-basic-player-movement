using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    public bool over = false;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        int result =cal(number);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
      if(over==true){ 
            GameOver();
        }  
    }
    void GameOver(){
        print("Game Over");
        Destroy(gameObject);
    }


    int cal(int n){
        int mul=n*n;
        return mul;
    }
}
