using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] backMenuList;
    GameObject backMenu;
    public void SetBackMenu()
    {
        foreach (GameObject item in backMenuList)
        {
            if (item.activeInHierarchy==true)
            {
                backMenu = item;
                print(backMenu);
            }
        }
    }
    public void back()
    {
        backMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
