using UnityEngine;

public class DestruirBala : MonoBehaviour
{
    public float _destruccion =2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Destroy(gameObject,_destruccion);
    }
}
