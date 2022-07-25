using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    public BoxCollider _armaBoxCol;

    void Start() {
        _armaBoxCol.enabled = false;
    }

    public void ActivarColiderArma(){
        if(!_armaBoxCol.enabled){
            _armaBoxCol.enabled = true;
        }
        else{
            _armaBoxCol.enabled = false;
        }
    }

}
