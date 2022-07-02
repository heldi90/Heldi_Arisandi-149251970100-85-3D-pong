using UnityEngine;
using UnityEngine.Events;

public class BallHancur : MonoBehaviour
{
    public string TagObject;

    public GameObject tagBall;

    public UnityEvent TriggerEventEnter;

    // Start is called before the first frame update
    public void InvokeTrigger()
    {

        TriggerEventEnter?.Invoke();





    }
    void Update()
    {


    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == TagObject)
        {


            print("hancur");
            Destroy(tagBall);







            TriggerEventEnter?.Invoke();



        }
    }
}
