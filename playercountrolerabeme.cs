using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

public class playercountrolerabeme : MonoBehaviour
{   float horizontalInput;
    float verticalInput;    
    public float speed = 100f;
    public GameObject pizza;
    public float varticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");
     transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
     verticalInput = Input.GetAxis("Vertical");
     transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(pizza, transform.position, transform.rotation);
        }
        if (transform.position.z >= 100 || transform.position.z <= -100)
        {
            Destroy(gameObject);
            Debug.Log("��� �������� ���� �� ������");
        }
    }
}
