using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        VelocityBallY = 0;
        print("Fin1");
    }
}
