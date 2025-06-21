using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDash : MonoBehaviour
{
    PlayerMovement moveScript;
    Collision collision;
    public float dashSpeed;
    public float dashTime;
    float dashCD = 0;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<PlayerMovement>();
        collision = GetComponent<Collision>();
    }

    // Update is called once per frame
    void Update()
    {
        dashCD -= Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if(dashCD <= 0)
            {
                StartCoroutine(Dash());
            }
           
            

        }
    }

    IEnumerator Dash()
    {
        float startTime = Time.time;
        while (Time.time < startTime + dashTime)
        {
            collision.pushPower = 25;
            moveScript.velocity.y = 0;
            moveScript.controller.Move(moveScript.moveDir * dashSpeed * Time.deltaTime);
            dashCD = 1.5f;
            yield return null;
        }
        collision.pushPower = 6;
    }



}

