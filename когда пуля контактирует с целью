using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcolision : MonoBehaviour
{
     
    private void OnTriggerEnter(Collider other)
    {
    
        
        if (other.CompareTag("Animals"))
        {
             Destroy(other.gameObject);
             Destroy(gameObject);
        }
    }
}
