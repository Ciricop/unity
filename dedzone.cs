using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killerplatform : MonoBehaviour
{

    // Start is called before the first frame update


    // Update is called once per frame;
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other) //���� � ������ �����
    {
       
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//����� ������ SceneManger ����������� ������� �����. ��� ������ ����� ������ ������� ��������� using UnityEngine.SceneManagement;
  
    }
}