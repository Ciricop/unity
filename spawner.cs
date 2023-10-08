using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public List<GameObject> Objects;
    // Start is called before the first frame update
    void RandomSpawner()
    {
        Instantiate(Objects[Random.Range(0, Objects.Count)],
                   new Vector3(Random.Range(-16, 16), 0, 25),
                   Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("RandomSpawner", 1f, 1f);
    }
}
