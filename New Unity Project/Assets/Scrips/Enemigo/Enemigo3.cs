using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    public enum Estado{
        Mirando,
        Siguiendo
    };
    public Transform transformJugador;
    public Estado _estadoActual;
    [SerializeField]
    private float enemiSpeed=8f;
    public float enemiSpeedRot=250f;
    
    void Start()
    {
        _estadoActual=Estado.Mirando;
    }

    
    void Update() 
    {
        //Estado Siguiendo
        if(_estadoActual==Estado.Siguiendo){

            LookAt();
            if(ChequearDistanciaConElJugador()>2){

                SeguirAlJugador();
            }
        }
        //Estado Mirando
        if(_estadoActual==Estado.Mirando){

            LookAtJugador();
        }
    }

    //Estado Siguiendo
    float ChequearDistanciaConElJugador(){

        float dist = Vector3.Distance(transform.position,transformJugador.position);

        return dist;
    }
    
    void LookAt(){

        transform.LookAt(transformJugador);
    }

    void SeguirAlJugador(){

        transform.position = Vector3.MoveTowards(transform.position, transformJugador.position , enemiSpeed * Time.deltaTime);
    }

    //Estado Mirando
    void LookAtJugador(){

        Vector3 posaMirar = transformJugador.position - transform.position;
        Quaternion rotationDeseada = Quaternion.LookRotation(posaMirar);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotationDeseada, enemiSpeedRot*Time.deltaTime);
    }

}
