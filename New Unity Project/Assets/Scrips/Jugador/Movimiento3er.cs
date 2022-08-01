using UnityEngine;

public class Movimiento3er : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public float moveSpeed;
    public Rigidbody rb;
    Vector3 inputDir;

    public float rotationSpeed;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;   
    }

    private void Update() {
       Orientacion();
       Inputs();
        
    }

    /*private void FixedUpdate() {
       Movimiento();
        
    }*/

    private void Orientacion(){
        //rotate orientation
        Vector3 viewDir = player.position - new Vector3(transform.position.x ,player.transform.position.y, transform.position.z);
        orientation.forward=viewDir.normalized;
        playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
    }

    private void Inputs(){
        //rotate player object
        float horizontalInput = Input.GetAxis("Horizontal");
        float vecticalInput = Input.GetAxis("Vertical");
        inputDir = orientation.forward * vecticalInput + orientation.right * horizontalInput;
    }

    /*private void Movimiento(){
        if(inputDir != Vector3.zero){

            rb.AddForce(orientation.forward * moveSpeed * 10f, ForceMode.Force);
        }
    }*/

   
}
