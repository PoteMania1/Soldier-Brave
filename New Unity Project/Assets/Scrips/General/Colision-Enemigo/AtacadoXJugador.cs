using UnityEngine;

public class AtacadoXJugador : MonoBehaviour
{
    bool cambio=false;
    int multiplicador=2;
    public Animator anim;
    //public Transform jugador;

    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Espada"){
            if(anim != null){
                anim.Play("Daño");
            }
            Debug.Log("ella");
        }
    }
}
