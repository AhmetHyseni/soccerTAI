using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TMP_Text player1;
    public TMP_Text player2;
    public int player1Score;
    public int player2Score;
    public BoxCollider2D goalLeft;
    public BoxCollider2D goalRight;
    public int maxGoal;
    public AudioSource audioSource;
    public AudioClip fireworksSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayerPrefs.GetInt("player1Score", player1Score);
        PlayerPrefs.GetInt("player2Score", player2Score);
    }

    void Update()
    {
        scoreCount();
        if (PlayerPrefs.GetInt("player1Score", player1Score) == maxGoal)
        {
            PauseGame();
            PlayerPrefs.DeleteAll();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void scoreCount()
    {
        if (goalLeft.IsTouchingLayers(LayerMask.GetMask("Ball")))
        {
            PlayerPrefs.SetInt("player2Score", player2Score + 1);
            player2Score++;
            player2.text = player2Score.ToString();
            PlayFireworksSound();
            StartCoroutine(Reset());
        }
        else if (goalRight.IsTouchingLayers(LayerMask.GetMask("Ball")))
        {
            PlayerPrefs.SetInt("player1Score", player1Score + 1);
            player1Score++;
            player1.text = player1Score.ToString();
            PlayFireworksSound();
            StartCoroutine(Reset());
        }
    }

    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("PvP",LoadSceneMode.Single);
    }

    private void PlayFireworksSound()
    {
        audioSource.PlayOneShot(fireworksSound);
    }
}

