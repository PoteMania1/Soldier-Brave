using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public Transform transformJugador;
    public float enemiSpeedRot=250f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtJugador();
    }

    void LookAtJugador(){

        Vector3 posaMirar = transformJugador.position - transform.position;
        Quaternion rotationDeseada = Quaternion.LookRotation(posaMirar);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotationDeseada, enemiSpeedRot*Time.deltaTime);
    }
}
