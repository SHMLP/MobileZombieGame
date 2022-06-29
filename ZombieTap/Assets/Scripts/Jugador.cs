using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jugador : MonoBehaviour
{
    public int numHeartInactive,contCombo, vidaTotal = 3;
    GameManager game;

    void Start()
    {
        game = FindObjectOfType<GameManager>();
    }
    public void Vida(int numero)
    {
        vidaTotal -= numero;
        while (numero>0 && numHeartInactive < game.canvas.transform.Find("InGame").Find("Life").childCount)
        {
            if (game.hearts[numHeartInactive].gameObject.activeInHierarchy == true)
            {
                game.hearts[numHeartInactive].gameObject.SetActive(false);
            }
            numHeartInactive += 1;
            numero -= 1;
        }

        //foreach (Transform item in game.hearts)
        //{
        //    if (item.gameObject.activeInHierarchy == true)
        //    {
        //        item.gameObject.SetActive(false);
        //        if (numero==1)
        //        {
        //            break;
        //        }
        //    }
        //}
        if (vidaTotal <= 0)
        {
            game.LevelFinish("Again");
        }
    }

    public void Score(int numerocombo)
    {
        int score;
        int.TryParse(game.score.text, out score);
        score += 25 * game.jugador.Combo(numerocombo);
        game.score.text = score.ToString();
    }
    public int Combo(int enemyCont)
    {
        int combo=1;
        if (enemyCont==1)
            contCombo += enemyCont;
        else
            contCombo = enemyCont;
        switch (contCombo)
        {
            case 2:
                combo = 2;
                break;
            case 3:
                combo = 3;
                contCombo = 2;
                break;
        }
        return combo;

    }
}
