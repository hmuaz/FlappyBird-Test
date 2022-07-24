using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject yenidenBasla;
    public PipeCreat pc;
    public Player player;
    public GameObject Menu;
    public Text skorText;
    private int score;
    void Start()
    {
        
    }

    void Update()
    {
        if (player.transform.position.y < -10)
        {
            yenidenBasla.SetActive(true);
        }

        skorText.text = score.ToString();
    }

    public void GameOver()
    {
        
            player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            player.GetComponent<Rigidbody2D>().gravityScale = 5f;

            


    }

    public void SkoruArttir()
    {
        score++;
    }

    public void BaslatTusu()
    {
        player.enabled = true;
        pc.enabled = true;
        Menu.SetActive(false);
    }

    public void YenidenBaslaButonu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Menu.SetActive(false);
    }

    
}
