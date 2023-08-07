using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private bool canDash;

    

    // Update is called once per frame
    void Update()
    {
        // Este código permite a movimentação do personagem sem aceleração, para poder acelera-lo, 
        // basta usar um rigidbody velocity ou usar GetAxis sem o raw
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += movement * speed * Time.deltaTime;

        //Executando a função do dash
        Dash();
        
    }


    public void Dash()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 50f;

        } 
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 20f;
        }
    }

    
}