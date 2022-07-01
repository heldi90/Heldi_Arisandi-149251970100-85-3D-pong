using UnityEngine;

public class BallManager : MonoBehaviour
{

    public Vector3 speed;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed.x, speed.y, speed.z);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
