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
    void OnTriggerEnter2D(Collider2D other) //есле в тригер вошли
    {
       
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//метод класса SceneManger загружающий текущую сцену. Для работы нужно вверху скрипта прописать using UnityEngine.SceneManagement;
  
    }
}