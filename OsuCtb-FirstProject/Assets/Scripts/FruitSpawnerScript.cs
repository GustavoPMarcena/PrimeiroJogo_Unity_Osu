using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawnerScript : MonoBehaviour
{
    public GameObject Fruit;
    public float spawnRate = 1;
    public float timer = 0;

    void Start()
    {
        spawFruit();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
           spawFruit();
           timer = 0;
        }
        
    }

    public void spawFruit()
    {
        Instantiate(Fruit, new Vector3(Random.Range(-17, 17), transform.position.y), transform.rotation); 

    }
}
