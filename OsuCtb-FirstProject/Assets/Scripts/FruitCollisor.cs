using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollisor : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;

    // Update is called once per frame
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.name == "Player")
       {
            Destroy(gameObject);
            logic.addScore(1);
       }
       if(other.gameObject.name == "DeadEnd")
       {
            logic.errorAndGameOver();
       }
        
    }
}
