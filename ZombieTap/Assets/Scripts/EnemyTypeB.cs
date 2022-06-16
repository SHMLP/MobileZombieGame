using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeB : EnemyCaract
{
    
    //public RuntimeAnimatorController animacionB;
    public void inicar()
    {
        //print("Adios");
        
        animacion.runtimeAnimatorController = animationController;
    }
}
