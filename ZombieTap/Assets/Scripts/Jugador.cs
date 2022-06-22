using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    int contCombo, vidaTotal = 3;
    public Transform life;
    public List<Transform> hearts; 

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
            life.gameObject.SetActive(false);
        }
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
