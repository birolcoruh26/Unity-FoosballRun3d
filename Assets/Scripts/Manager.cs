using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class Manager : MonoBehaviour
{
    public static bool gameOver;
    public static bool isPlayerDead;
    public GameObject gameOverPanel;
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
    public static bool isGameStarted;
    public GameObject startingText;
    public GameObject completeLevelUI;
    public GameObject sliderPanel;
    public GameObject scorePanel;
    public GameObject tıkla;
    public GameObject setting;
    public TextMeshProUGUI scoreOnEnding;
    public TextMeshProUGUI scoreOnGameover;
    

    [SerializeField] GameObject Player;



    void Start()
    {
        startingText.SetActive(true);
        gameOver = false;
        Time.timeScale = 1;
        numberOfCoins = 0;
        isGameStarted = false;
        tıkla.SetActive(true);
        setting.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            scoreOnGameover.text = "Score:" + numberOfCoins;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            sliderPanel.SetActive(false);
            scorePanel.SetActive(false);
        }
        //coinsText.text = "Score:" + numberOfCoins;
        if (Input.GetMouseButtonDown(0))
        {

            isGameStarted = true;
            Destroy(startingText);
            Destroy(tıkla);
            Destroy(setting);

            Player.gameObject.GetComponent<CharacterAnimation>().Idle(false);
            Player.gameObject.GetComponent<CharacterAnimation>().Run(true);
            

        }
        


        //if(PlayerPrefs.GetFloat("Highscore") < numberOfCoins)
        //{
          //  PlayerPrefs.SetFloat("Highscore", numberOfCoins);
        //}
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
