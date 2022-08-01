using UnityEngine;

public class AtacadoXJugador : MonoBehaviour
{
    public Animator anim;
        
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Espada"){
            if(anim != null){
                anim.Play("Daño");
            }
            Debug.Log("ella");
        }
    }
}
