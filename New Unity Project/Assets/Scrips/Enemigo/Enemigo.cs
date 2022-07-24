using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform transformJugador;
    [SerializeField]
    private float enemiSpeed=8f;
    int _random=0;
    
    void Start()
    {
        _random=Random.Range(0,20);
    }

    
    void Update() 
    {
      LookAt();
      if(ChequearDistanciaConElJugador()>8){
        SeguirAlJugador();
      }
    }

    float ChequearDistanciaConElJugador()
    {
        float dist = Vector3.Distance(transform.position,transformJugador.position);  

        return dist;
    }
    
    void LookAt()
    {
        transform.LookAt(transformJugador);
    }

    void SeguirAlJugador(){
        transform.position = Vector3.MoveTowards(transform.position, transformJugador.position , enemiSpeed * Time.deltaTime);
    }
}


