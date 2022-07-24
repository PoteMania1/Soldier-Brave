using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject _bala;
    public float _cooldown=1f;
    public float _restaurarCooldown =1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _cooldown-=Time.deltaTime;
        Disparar();
    }

    void Disparar(){
        if(_cooldown<=0){
            Instantiate(_bala,transform.position,transform.rotation);
            _cooldown=_restaurarCooldown;
        }
    }
}
