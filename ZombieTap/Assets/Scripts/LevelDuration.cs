using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDuration : MonoBehaviour
{
    [SerializeField] float VelocityBallY;
    GameManager game;
    
    private void Start()
    {
        game = FindObjectOfType<GameManager>();
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * VelocityBallY * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (game.levelFactor<9)
        {
            string levelName = (game.levelFactor+1).ToString();
            game.canvas.transform.Find("Levels").Find("Niveles").Find(levelName).GetComponent<Button>().interactable = true;
            game.LevelFinish("Next");
        }
        else
        {
            game.LevelFinish("Again");
        }
    }
}
