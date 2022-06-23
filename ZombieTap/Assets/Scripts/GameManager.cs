using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public EnemyCaract[] enemysTypeList;
    public SpawnPosition spawnPosition;
    public LevelDuration levelDuration;
    public TextMeshProUGUI score;
    public GameObject levelFinish;
    public bool isPause;
    public int levelFactor;
    private void Awake()
    {
        enemysTypeList = enemyPrefab.GetComponents<EnemyCaract>();
    }
    public void LevelFinish(string boton)
    {
        isPause = true;
        Time.timeScale = 0;
        levelFinish.transform.Find("Continue").gameObject.SetActive(false);
        levelFinish.transform.Find("YourScore").GetComponent<TextMeshProUGUI>().text = "Your Score is: " + score.text;
        levelFinish.transform.Find("YourScore").gameObject.SetActive(true);
        levelFinish.transform.Find(boton).gameObject.SetActive(true);
        levelFinish.SetActive(true);
    }
}
