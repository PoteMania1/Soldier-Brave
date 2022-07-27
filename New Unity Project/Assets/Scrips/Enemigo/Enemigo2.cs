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
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.forward, out hit)){
            float distancia = hit.distance;
            
            if(hit.transform.tag =="Jugador"){
                Debug.Log("El jugador esta a " + distancia + " unidades ");
            }
        }

        LookAtJugador();
    }

    void LookAtJugador(){

        Vector3 posaMirar = transformJugador.position - transform.position;
        Quaternion rotationDeseada = Quaternion.LookRotation(posaMirar);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotationDeseada, enemiSpeedRot*Time.deltaTime);
    }
}
