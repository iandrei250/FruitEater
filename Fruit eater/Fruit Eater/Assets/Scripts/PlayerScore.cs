using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
  private Text scoreText;
  private int score;
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb"){
           transform.position = new Vector2 (0, 100);
          target.gameObject.SetActive(false);
          StartCoroutine(RestartGame());
        }
        if(target.tag == "Fruit"){
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator RestartGame(){
      yield return new WaitForSecondsRealtime(2f);

      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}//class
