using UnityEngine;

public class MoveBala : MonoBehaviour
{
    public Vector3 _mov=new Vector3(0,0,0.1f);
    public float _speed=10;

    // Update is called once per frame
    void Start () {
    }

    void Update()
    {
        transform.Translate(_mov * _speed * Time.deltaTime);   
    }
}
