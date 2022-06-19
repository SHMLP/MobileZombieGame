using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyCaract : MonoBehaviour
{
    public int vidaEnemigo;
    protected Animator animacion;
    protected float movimientox;
    protected ZombieMovement movement;
    public RuntimeAnimatorController animationController;

    private void Awake()
    {
        movement = GetComponent<ZombieMovement>();
        animacion = GetComponent<Animator>();
    }
    void OnEnable()
    {
       
        
    }

    public abstract void iniciar();
}
