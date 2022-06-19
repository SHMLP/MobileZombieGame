using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDuration : MonoBehaviour
{
    [SerializeField] float VelocityBallY;
    public Transform iLevelDuration, fLevelDuration;
    float sumaTiempo;
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * VelocityBallY * Time.deltaTime);
        sumaTiempo += Time.deltaTime;
        if (sumaTiempo >= (Vector3.Distance(fLevelDuration.position, iLevelDuration.position)) / VelocityBallY)
        {
            //print("Nivel2" + ((Vector3.Distance(fLevelDuration.position, iLevelDuration.position)) / VelocityBallY));
            //tiempoAparicion = 1;
            transform.position = iLevelDuration.position;
            sumaTiempo = 0;
        }


    }


}
