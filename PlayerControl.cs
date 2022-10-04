using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{      
    bool a = false ;
    
    int i = 1;
    // Update is called once per frame
    void Update()
    {
      switch(i)
      {
        case 1 :
          transform.position = transform.position + new Vector3(1,0);
          i = 2;
          break;
        case 2 :
          transform.position = transform.position + new Vector3(0,1);
          i = 3;
          break;
        case 3 :
          transform.position = transform.position + new Vector3(-1,0);
          i = 4;
          break;
        case 4 :
          transform.position = transform.position + new Vector3(0,-1);
          i = 1;
          break;
      }
    }
    // Start is called before the first frame update
    void Start()
    {
        

      
     }
}
