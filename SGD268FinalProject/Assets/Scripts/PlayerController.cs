using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected Joystick joystick;
    //protected JoyButton joybutton;
    public Rigidbody rb;
    public int speed;
    int seconds;
    int idle;
    public int coins;
    public int speedCoins;
    public int healthCoins;
    public int health = 1000;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.gm.StartGame();
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(joystick.Horizontal * speed, rb.velocity.y, joystick.Vertical * speed);
        if(health < 0)
        {
            GameManager.gm.GameOver();
        }
        seconds += 1;
        if (seconds > 750)
        {
            seconds = 0;
            coins += 1;
            GameManager.gm.ScoreUp();
            if (GameManager.gm.score > 990 || health < 200)
            {
                GameManager.gm.DryTimer();
            }
            else
            {
                GameManager.gm.GetCoin();
            }
        }
        if (GameManager.gm.score == 1000)
        {
            GameManager.gm.GameOver();
        }
        if (coins > 20)
        {
            coins -= 20;
            speedCoins += 5;
            healthCoins += 15;
            GameManager.gm.GetCoin();
        }
        if (speedCoins > 20)
        {
            speedCoins -= 20;
            speed += 1;
            GameManager.gm.SelectItem();
        }
        if (healthCoins > 75)
        {
            healthCoins -= 75;
            health += 65;
            GameManager.gm.SelectItem();
        }
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
