using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public EnemyCaract[] enemysTypeList;
    public SpawnPosition spawnPosition;
    public Transform levelDuration;
    public TextMeshProUGUI score;
    public GameObject levelFinish;

    public Transform enemigos;
    public List<Transform> listaEnemigos;

    public bool isPause;
    public int levelFactor;
    private void Awake()
    {
        enemysTypeList = enemyPrefab.GetComponents<EnemyCaract>();

    }
    private void Start()
    {
        for (int i = 0; i < enemigos.childCount; i++)
        {
            listaEnemigos.Add(enemigos.GetChild(i));
        }
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

    public void LevelStart()
    {
        isPause = false;
        Time.timeScale = 1;

        foreach (EnemyCaract item in enemysTypeList)
        {
            EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
            if (choose.enabled==true)
            {
                choose.enabled = false;
            }
        }
        levelDuration.Find("Duration").position = levelDuration.Find("Inicio").position;
        spawnPosition.enabled = true;
        levelDuration.Find("Duration").GetComponent<LevelDuration>().enabled = true;
    }
}
