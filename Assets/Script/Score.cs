using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;





public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text player1;
    public TMP_Text player2;

    public int player1Score;
    public int player2Score;

    public BoxCollider2D goalLeft;
    public BoxCollider2D goalRight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount();
    }
    public void scoreCount()
    {
        player1.text = player1Score.ToString();
        player2.text = player2Score.ToString();
    }



}
