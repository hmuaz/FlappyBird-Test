using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text skorText;
    private int score;
    void Start()
    {
        
    }

    void Update()
    {
        skorText.text = score.ToString();
    }

    public void GameOver()
    {
        Debug.Log("Yandýn");
    }

    public void SkoruArttir()
    {
        score++;
    }

    
}
