using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDrop : MonoBehaviour
{
    public float moveSpeed;
    public float timer = 10f;
    public LogicScript logic;

    void Update()
    { 
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
    
        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        moveSpeed = logic.moveSpeed;
    }
 
}
