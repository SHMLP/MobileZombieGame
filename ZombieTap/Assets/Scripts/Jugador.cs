using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jugador : MonoBehaviour
{
    int contCombo,vidaTotal = 3;
    public Transform life;
    public List<Transform> hearts;
    GameManager game;

    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<GameManager>();
        for (int i = 0; i < life.childCount ; i++)
        {
            hearts.Add(life.GetChild(i));
        }
    }
    public void Vida(int numero)
    {
        vidaTotal -= numero;
        foreach (Transform item in hearts)
        {
            if (item.gameObject.activeInHierarchy == true)
            {
                item.gameObject.SetActive(false);
                if (numero==1)
                {
                    break;
                }
            }
        }
        if (vidaTotal<=0)
        {
            game.LevelFinish("Again");
        }
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
