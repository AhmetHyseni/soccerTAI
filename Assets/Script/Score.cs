using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;





public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text player1;
    public TMP_Text player2;

    public int player1Score;
    public int player2Score;

    public BoxCollider2D goalLeft;
    public BoxCollider2D goalRight;
    public int maxGoal;
    void Start()
    {
        PlayerPrefs.GetInt("player1Score", player1Score);
        PlayerPrefs.GetInt("player2Score", player2Score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount();
        if (PlayerPrefs.GetInt("player1Score", player1Score) == maxGoal)
        {
            PlayerPrefs.DeleteAll();
        }
    }
    public void scoreCount()
    {
        player1.text = PlayerPrefs.GetInt("player1Score", player1Score).ToString();
        player2.text = PlayerPrefs.GetInt("player2Score", player2Score).ToString();
    }

    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }

}
