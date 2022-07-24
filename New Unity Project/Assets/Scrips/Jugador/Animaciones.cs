using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{

    public Animator anim;
    public bool _estoyAtacando;

    void Update()
    {
        AnimacionCorrer();
        AnimacionAtaque();
    }

    //Animaciones para cuando el jugador Corre
    void AnimacionCorrer(){

        float ver = Input.GetAxisRaw("Vertical");
        float hor = Input.GetAxisRaw("Horizontal");

        if(ver!=0||hor!=0){
                anim.SetBool("Corre",true);
        }
        else{
                anim.SetBool("Corre",false);
        }
    }

    //Animaciones para cuando el jugador Ataca
    void AnimacionAtaque(){
        if(Input.GetKeyDown(KeyCode.Space) && !_estoyAtacando){
            anim.SetTrigger("Ataque");
            _estoyAtacando = true;
        }
        
    }

    public bool GetAtaque(){
        return _estoyAtacando;
    }

    public void DejeDeAtacar(){
        _estoyAtacando = false;
    }
}
