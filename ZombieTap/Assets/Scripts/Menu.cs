using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    //public GameObject numberLevel;
    public GameObject[] backMenuList;
    GameObject backMenu;
    GameManager game;

    private void Start()
    {
        game = FindObjectOfType<GameManager>();
    }
    public void Activo()
    {
        Time.timeScale = 0;
        game.isPause = true;
    }
    public void InActivo()
    {
        Time.timeScale = 1;
        game.isPause = false;
    }
    public void SetBackMenu()
    {
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
        backMenu.SetActive(true);
    }

    public void NextLevel()
    {
        game.levelFactor += 1;
    }

    public void ChooseLevel()
    {
        int.TryParse(EventSystem.current.currentSelectedGameObject.name, out game.levelFactor);
        game.LevelStart();
    }
}
