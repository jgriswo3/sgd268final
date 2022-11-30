using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    //The following region are sound effects.
    #region
    public AudioClip startGame;
    public AudioClip playerGun;
    public AudioClip selectItem;
    public AudioClip getCoin;
    public AudioClip playerBomb;
    public AudioClip playerHit;
    public AudioClip enemyExplosion;
    public AudioClip dryTimer;
    #endregion
    void Awake()
    {
        if(!gm)
            gm = this;
        else
            Destroy(this);
    }
    public Text scoreText;
    //The following region contains functions for playing audio clips.
    #region
    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
        AudioSource.PlayClipAtPoint(startGame, Camera.main.transform.position);
    }
    public void PlayerGun()
    {
        AudioSource.PlayClipAtPoint(playerGun, Camera.main.transform.position);
    }
    public void SelectItem()
    {
        AudioSource.PlayClipAtPoint(selectItem, Camera.main.transform.position);
    }
    public void PlayerBomb()
    {
        AudioSource.PlayClipAtPoint(playerBomb, Camera.main.transform.position);
    }
    public void PlayerHit()
    {
        AudioSource.PlayClipAtPoint(playerHit, Camera.main.transform.position);
    }
    public void EnemyExplosion()
    {
        AudioSource.PlayClipAtPoint(enemyExplosion, Camera.main.transform.position);
    }
    public void DryTimer()
    {
        AudioSource.PlayClipAtPoint(dryTimer, Camera.main.transform.position);
    }
    public void GetCoin()
    {
        AudioSource.PlayClipAtPoint(getCoin, Camera.main.transform.position);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    #endregion
}
