using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelDuration : MonoBehaviour
{
    [SerializeField] float VelocityBallY;
    GameManager game;
    
    private void Start()
    {
        game = FindObjectOfType<GameManager>();
        game.spawnPosition.enabled = true;
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * VelocityBallY * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        game.isPause = true;
        Time.timeScale = 0;
        //VelocityBallY = 0;
        game.levelFinish.transform.Find("Continue").gameObject.SetActive(false);
        game.levelFinish.transform.Find("YourScore").GetComponent<TextMeshProUGUI>().text = "Your Score is: " + game.score.text;
        game.levelFinish.transform.Find("YourScore").gameObject.SetActive(true);
        game.levelFinish.transform.Find("Next").gameObject.SetActive(true);
        game.levelFinish.SetActive(true);

    }
}
