using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoveryeeeeeeeet : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z >= 100 || transform.position.z <= -50)
        {
            Debug.Log("�� �� ����� � ���� �������� ��� ���� ������� ���������������������������������������������");
        }
        if (transform.position.z >= 80 || transform.position.z <= -80)
        {
           Invoke("Reloadlevel", 1);
        }
         
    }void Reloadlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//����� ������ SceneManger ����������� ������� �����. ��� ������ ����� ������ ������� ��������� using UnityEngine.SceneManagement;
    }
}
