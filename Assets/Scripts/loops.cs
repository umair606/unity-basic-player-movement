using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{
    // Start is called before the first frame update

    public bool GameOver =false;
    void Start()
    {
       /* for(int i=0; i<=10; i++){
            print(i + " Raja");
        }

        int j=0;
        while(j<=5){
            print(j +" Abdullah");
            j++;
        }
*/

        while(true) {
            if(GameOver == true){
                return;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
