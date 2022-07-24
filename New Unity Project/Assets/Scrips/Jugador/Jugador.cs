using UnityEngine;

[RequireComponent(typeof(Animaciones))]

public class Jugador : MonoBehaviour
{

    public float speed = 8f;
    public float _speedRotacion = 720f;
    
    public Rigidbody rb;
    bool _estoyAtacando;

    void Awake()
    {
        _estoyAtacando=GetComponent<Animaciones>().GetAtaque();
    }

    void FixedUpdate()
    {
        if(!_estoyAtacando){
            Move();
        }
    }

    void Update()
    {
       
    }

    void Move()
    {
        float hor = Input.GetAxisRaw("Horizontal") * _speedRotacion * Time.deltaTime;
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 inputJugador = new Vector3(-hor,0,-ver);
        inputJugador.Normalize();

        rb.AddForce(inputJugador * speed, ForceMode.Impulse);

        if(inputJugador != Vector3.zero){
            //transform.forward = inputJugador;
            Quaternion toRotation = Quaternion.LookRotation(inputJugador,Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _speedRotacion * Time.deltaTime);
        }

        
    }

 
}
