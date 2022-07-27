using UnityEngine;

public class ManagerSonido : MonoBehaviour
{
    public static ManagerSonido unicaInstancia;

    void Awake()
    {
        if(ManagerSonido.unicaInstancia == null){
            ManagerSonido.unicaInstancia=this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        
    }
}
