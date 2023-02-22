using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public AudioSource Music; // 새가 점프할 때 나오는 효과음
    public static float jumpPower = 4; // 새가 점프하는 높이
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Music = GetComponent<AudioSource>();
            Music.Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1)
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.BestScore){
            Score.BestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
