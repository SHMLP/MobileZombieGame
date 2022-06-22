using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jugador : MonoBehaviour
{
    int contCombo, vidaTotal = 3;
    public Transform life;
    public List<Transform> hearts;
    GameManager game;

    // Start is called before the first frame update
    void Start()
    {
        
        EnemyState.manejoDeVida += Vida;
        for (int i = 0; i < life.childCount ; i++)
        {
            hearts.Add(life.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        //print(vidaTotal);
    }

    public void Vida(int numero)
    {
        
        vidaTotal -= numero;
        foreach (Transform item in hearts)
        {
            if (item.gameObject.activeInHierarchy==true)
            {
                item.gameObject.SetActive(false);
                break;
            }
        }
        if (vidaTotal<=0)
        {
            print("perdio");
            life.gameObject.SetActive(false);

            //game.levelFinish.transform.Find("Continue").gameObject.SetActive(false);
            //game.levelFinish.transform.Find("YourScore").GetComponent<TextMeshProUGUI>().text = "Your Score is: " + game.score.text;
            //game.levelFinish.transform.Find("YourScore").gameObject.SetActive(true);
            //game.levelFinish.transform.Find("Again").gameObject.SetActive(true);
            game.levelFinish.SetActive(true);
        }
        //for (int i = 0; i < ; i++)
        //{

        //}
    }

    public void Combo(int enemyCont)
    {
        if (enemyCont==1)
        {
            contCombo += enemyCont;
        }else
        {

            contCombo = enemyCont;
        }
        switch (contCombo)
        {
            case 2:
                print("ComboX2");
                break;
            case 3:
                print("ComboX3");
                break;
        }
    }
}
