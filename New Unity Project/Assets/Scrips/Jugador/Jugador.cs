using UnityEngine;

[RequireComponent(typeof(Animaciones))]

public class Jugador : MonoBehaviour
{

    public float moveSpeed = 8f;
    public float _speedRotacion = 720f;
    public float airMultiplier;
    public Transform orientation;
    
    public Rigidbody rb;
    bool _estoyAtacando;
    Vector3 moveDirection;

    //public float playerHeight;
    //public LayerMask whatIsGround;
    bool grounded;

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
        grounded = Physics.Raycast(transform.position, Vector3.down, 10f * 0.5f + 0.3f);
        Debug.Log(grounded);
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.forward, out hit)){
            float distancia = hit.distance;
            string tag= hit.collider.gameObject.tag;
            if(tag=="Pared"){
                Debug.Log("Obj= " + tag + " a " + distancia + " de distancia");
            }
        }
       
    }

    void Move()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        //Vector3 inputJugador = new Vector3(-hor,0,-ver);
        //inputJugador.Normalize();

        //rb.AddForce(inputJugador * speed, ForceMode.Impulse);

        /*if(inputJugador != Vector3.zero){
            //transform.forward = inputJugador;
            Quaternion toRotation = Quaternion.LookRotation(inputJugador,Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _speedRotacion * Time.deltaTime);
        }*/

        moveDirection = orientation.forward * ver + orientation.right * hor;

        // on ground
        //if(grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        // in air
        //else if(!grounded)
            //rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
    
    }

 
}
