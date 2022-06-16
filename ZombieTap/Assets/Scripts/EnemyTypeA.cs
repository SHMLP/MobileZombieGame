using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeA : EnemyCaract
{
    //public RuntimeAnimatorController animacionA;

    private void Update()
    {
        
    }
    public void inicar()
    {
        //print("Hola");

        animacion.runtimeAnimatorController = animationController ;

    }
}
