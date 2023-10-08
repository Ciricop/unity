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
            Debug.Log("ÄÀ ÒÛ ÄÅÁÈÊ Ó ÒÅÁß ÆÅÂÎÒÍÎÅ ÂÑÅ ÑÅÍÎ ÑÎÆÐÀËÎ ÁËßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßßß");
        }
        if (transform.position.z >= 80 || transform.position.z <= -80)
        {
           Invoke("Reloadlevel", 1);
        }
         
    }void Reloadlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//ìåòîä êëàññà SceneManger çàãðóæàþùèé òåêóùóþ ñöåíó. Äëÿ ðàáîòû íóæíî ââåðõó ñêðèïòà ïðîïèñàòü using UnityEngine.SceneManagement;
    }
}
