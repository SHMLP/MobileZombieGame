using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    int contCombo,vidaTotal=3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyState.manejoDeVida += Vida;
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(vidaTotal);
    }

    public void Vida(int numero)
    {
        
        vidaTotal -= numero;
        if (vidaTotal<=0)
        {
            print("Pierde");

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
