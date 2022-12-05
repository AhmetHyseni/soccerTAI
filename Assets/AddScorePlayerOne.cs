using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScorePlayerOne : MonoBehaviour
{
    Score score;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Score>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            PlayerPrefs.SetInt("player2Score", PlayerPrefs.GetInt("player2Score", score.player2Score)+1);
            StartCoroutine(score.Reset());
        }
    }
    IEnumerator resetGame()
    {
        yield return new WaitForSeconds(0.5f);

    }
}

