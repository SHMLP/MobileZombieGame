using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public EnemyCaract[] enemysTypeList;


    public Transform enemigos;
    public List<Transform> listaEnemigos;


    public SpawnPosition spawnPosition;


    public Jugador jugador;

    [Header("Canvas")]
    public Canvas canvas;
    public TextMeshProUGUI score;
    public Transform levelFinish;
    public List<Transform> hearts;

    public bool isPause;
    public bool entre;
    public int levelFactor;
    public float velocidadEnemigoY;

    [Header("Sounds")]
    public AudioSource music;
    public AudioSource sounds;
    public AudioClip button;
    public AudioClip menuMusic;
    public AudioClip[] inGameMusic;
    public AudioClip[] zombieBorn;
    public AudioClip[] zombieDied;

    private void Awake()
    {
        enemysTypeList = enemyPrefab.GetComponents<EnemyCaract>();
        jugador = FindObjectOfType<Jugador>();
        canvas = FindObjectOfType<Canvas>();
        score = canvas.transform.Find("InGame").Find("Score").GetComponent<TextMeshProUGUI>();
        levelFinish = canvas.transform.Find("Level");
        music = Camera.main.transform.Find("Music").GetComponent<AudioSource>();
        sounds = Camera.main.transform.Find("Sounds").GetComponent<AudioSource>();
    }
    private void Start()
    {
        GetChilds(enemigos, listaEnemigos);
        GetChilds(canvas.transform.Find("InGame").Find("Life"), hearts);
        isPause = true;
        Time.timeScale = 0;

    }

    private void Update()
    {
        if (isPause == true && entre==false)
        {
            music.clip = menuMusic;
            music.Play(0);
            entre = true;
        } 
        else if(isPause == false && entre == true)
        {
            StartCoroutine(InGameMusicDelay(0));
            entre = false;
        }
    }

    IEnumerator InGameMusicDelay(float wait)
    {
        yield return new WaitForSeconds(wait);
        if (isPause == false)
        {
            StartCoroutine(InGameMusicDelay(Random.Range(30, 60)));
            int numero = Random.Range(0, inGameMusic.Length);
            music.clip = inGameMusic[numero];
            music.Play();
        }
    }
    public void LevelFinish(string boton)
    {
        isPause = true;
        Time.timeScale = 0;
        canvas.transform.Find("InGame").Find("Menu").GetComponent<Button>().interactable = false;
        levelFinish.Find("Continue").gameObject.SetActive(false);
        levelFinish.Find("YourScore").GetComponent<TextMeshProUGUI>().text = "Your Score is: " + score.text;
        levelFinish.Find("YourScore").gameObject.SetActive(true);


        NextLevelCheck();
        if (levelFactor < 9)
        {
            levelFinish.Find(boton).gameObject.SetActive(true);
        }
        else
        {
            if (jugador.vidaTotal>0)
            {
                canvas.transform.Find("MainMenu").Find("Won").gameObject.SetActive(true);
                levelFinish.Find("Options").Find("Youwin").gameObject.SetActive(true);
            }
            else
            {
                levelFinish.Find(boton).gameObject.SetActive(true);
            }
        }
        levelFinish.gameObject.SetActive(true);
    }

    public void LevelStart()
    {
        isPause = false;
        Time.timeScale = 1;
        LimpiarElementosDeLaPantalla();
        jugador.Combo(0);
        jugador.numHeartInactive = 0;
        score.text = "0";
        string levelNumber = levelFactor.ToString();
        canvas.transform.Find("InGame").Find("Levelnumber").GetComponent<TextMeshProUGUI>().text = "Level " + levelNumber;
        NextLevelCheck();

        if (levelFactor>1)
            levelFinish.Find("Interaction").Find("Previous").gameObject.SetActive(true); 
        else
            levelFinish.Find("Interaction").Find("Previous").gameObject.SetActive(false);

        canvas.transform.Find("InGame").Find("Menu").GetComponent<Button>().interactable = true;
        levelFinish.Find("Options").Find("Youwin").gameObject.SetActive(false);
        levelFinish.Find("Again").gameObject.SetActive(false);
        levelFinish.Find("Next").gameObject.SetActive(false);
        levelFinish.Find("Continue").gameObject.SetActive(true);

        canvas.transform.Find("InGame").Find("LevelDuration").Find("Duration").position = canvas.transform.Find("InGame").Find("LevelDuration").Find("Inicio").position;
        canvas.transform.Find("InGame").Find("LevelDuration").Find("Duration").GetComponent<LevelDuration>().enabled = true;
        spawnPosition.enabled = true;

    }

    public void LimpiarElementosDeLaPantalla()
    {
        foreach (Transform i in listaEnemigos)
        {
            if (i.gameObject.activeInHierarchy == true)
            {
                foreach (EnemyCaract j in enemysTypeList)
                {
                    EnemyCaract choose = i.GetComponent(j.GetType()) as EnemyCaract;
                    if (choose.enabled == true)
                    {
                        choose.enabled = false;
                    }
                }
                i.gameObject.SetActive(false);
            }
        }
    }

    public void GetChilds(Transform parent, List<Transform> childs)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            childs.Add(parent.GetChild(i));
        }
    }

    public void NextLevelCheck()
    {
        if (levelFactor < 9)
        {
            levelFinish.Find("Interaction").Find("Next").gameObject.SetActive(true);
            string levelName = (levelFactor + 1).ToString();
            if (canvas.transform.Find("Levels").Find("Niveles").Find(levelName).GetComponent<Button>().interactable == true)
                levelFinish.Find("Interaction").Find("Next").GetComponent<Button>().interactable = true;
            else
                levelFinish.Find("Interaction").Find("Next").GetComponent<Button>().interactable = false;
        }
        else
        {
            levelFinish.Find("Interaction").Find("Next").gameObject.SetActive(false);
        }
    }
}
