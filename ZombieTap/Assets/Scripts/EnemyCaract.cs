using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCaract : MonoBehaviour
{
    protected int vidaEnemigo;
    protected Animator animacion;
    public RuntimeAnimatorController animationController;

    // Start is called before the first frame update
    void OnEnable()
    {
        animacion = GetComponent<Animator>();
    }
   

    // Update is called once per frame
    void Update()
    {
 
    }
}
