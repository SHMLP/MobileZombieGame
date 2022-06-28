using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Menu : MonoBehaviour
{
    public GameObject[] backMenuList;
    GameObject backMenu;
    GameManager game;

    private void Start()
    {
        game = FindObjectOfType<GameManager>();
    }

    public void ButtonSound()
    {
        game.sounds.PlayOneShot(game.button);
    }

    public void Quit()
    {
        ButtonSound();
        Application.Quit();
    }
    public void Activo()
    {
        ButtonSound();
        Time.timeScale = 0;
        game.isPause = true;
    }
    public void InActivo()
    {
        ButtonSound();
        Time.timeScale = 1;
        game.isPause = false;
    }
    public void SetBackMenu()
    {
        ButtonSound();
        foreach (GameObject item in backMenuList)
        {
            if (item.activeInHierarchy==true)
            {
                backMenu = item;
            }
        }

    }
    public void back()
    {
        ButtonSound();
        backMenu.SetActive(true);
    }


    public void PreviousLevel()
    {
        ButtonSound();
        game.levelFactor -= 1;
        game.velocidadEnemigoY -= 1;
        if (game.jugador.vidaTotal == 0)
            Again();
        else
            game.LevelStart();
    }
    public void NextLevel()
    {
        ButtonSound();
        game.levelFactor += 1;
        game.velocidadEnemigoY += 1;
        if (game.jugador.vidaTotal == 0)
            Again();
        else
            game.LevelStart();
    }

    public void ChooseLevel()
    {
        ButtonSound();
        float velocidady;
        game.score.text = "0";
        int.TryParse(EventSystem.current.currentSelectedGameObject.name, out game.levelFactor);
        float.TryParse(EventSystem.current.currentSelectedGameObject.name, out velocidady);
        game.velocidadEnemigoY = velocidady;
        if (game.jugador.vidaTotal==0)
            Again();
        else
            game.LevelStart();
    }

    public void Clear()
    {
        ButtonSound();
        game.LimpiarElementosDeLaPantalla();
    }

    public void Again()
    {
        ButtonSound();
        game.jugador.vidaTotal = 3;
        foreach (Transform item in game.hearts)
        {
            item.gameObject.SetActive(true);
        }
        game.LevelStart();
    }
}
