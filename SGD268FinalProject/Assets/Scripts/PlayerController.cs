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
    public int health = 1000;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(joystick.Horizontal * speed, rb.velocity.y, joystick.Vertical * speed);
        if(health < 0)
            GameManager.gm.MainMenu();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            TakeDamage(15);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        GameManager.gm.PlayerHit();
    }
}
