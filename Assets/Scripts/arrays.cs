using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour

{
   string[] names={"ali","ahmed"};
   public int[] arr;
    // Start is called before the first frame update
    void Start()
    {
        //print an array
        print(names[0]);
        print(names[1]);

        //print an array using for loop
        for(int i=0; i<arr.Length ; i++){
            print(arr[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
