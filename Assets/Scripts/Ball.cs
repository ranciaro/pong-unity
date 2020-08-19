using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Iniciar()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = GetStartDirection();
    }

    public Vector3 GetStartDirection()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        return new Vector3(Speed * sx, 0f, Speed * sy);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
