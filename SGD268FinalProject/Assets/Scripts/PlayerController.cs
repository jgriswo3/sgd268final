using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected Joystick joystick;
    //protected JoyButton joybutton;
    public Rigidbody rb;
    public int speed;
    bool shoot;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        //joybutton = FindObjectOfType<JoyButton>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(joystick.Horizontal * speed, rb.velocity.y, joystick.Vertical * speed);
        /*if(!jump && joybutton.Pressed)
        {
            if(transform.position.y <= 40000f)
            {
                rb.AddForce(Vector3.up * jumpForce);
                jump = true;
            }
        }
        if(jump && !joybutton.Pressed)
        {
            jump = false;
        }*/
    }
}
