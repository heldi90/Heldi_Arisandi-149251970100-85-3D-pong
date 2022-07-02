using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed;

    [Header("Input Settings Player 1")]
    public KeyCode UP_P1;
    public KeyCode DOWN_P1;

    [Header("Input Settings Player 2")]
    public KeyCode UP_P2;
    public KeyCode DOWN_P2;
    [Header("Input Settings Player 3")]
    public KeyCode UP_P3;
    public KeyCode DOWN_P3;
    [Header("Input Settings Player 4")]
    public KeyCode UP_P4;
    public KeyCode DOWN_P4;

    public Rigidbody[] rb;
    public Transform[] tr;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ControllPaddle(0, "Player1", UP_P1, DOWN_P1);
        batasMovePaddle(0);
        ControllPaddle(1, "Player2", UP_P2, DOWN_P2);
        batasMovePaddle(1);
        ControllPaddleUpDown(2, "Player3", UP_P3, DOWN_P3);
        batasMovePaddleUpDown(2);
        ControllPaddleUpDown(3, "Player4", UP_P4, DOWN_P4);
        batasMovePaddleUpDown(3);

        // ControllPaddle(1, "Player2", UP_p2, DOWN_p2);
        // batasMovePaddle(1);











    }


    void batasMovePaddle(int index)
    {
        if (tr[index].transform.position.y <= -1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, -1.29f);
        }

        if (tr[index].transform.position.y >= 1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, 1.29f);
        }

    }

    void batasMovePaddleUpDown(int index)
    {
        if (tr[index].transform.position.y <= -1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, -1.29f);
        }

        if (tr[index].transform.position.y >= 1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, 1.29f);
        }
    }

    void ControllPaddle(int index, string name, KeyCode UP, KeyCode DOWN)
    {
        if (Input.GetKey(UP))
        {
            rb[index].velocity = Vector3.left * speed;
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else if (Input.GetKey(DOWN))
        {
            rb[index].velocity = Vector3.right * speed;
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else
        {
            rb[index].velocity = Vector3.zero;
            print($"tes debug Movement Paddle {name} {rb[index].velocity}");
        }





    }
    void ControllPaddleUpDown(int index, string name, KeyCode UP, KeyCode DOWN)
    {
        if (Input.GetKey(UP))
        {
            rb[index].velocity = new Vector3(rb[index].velocity.x, rb[index].velocity.y, 1f * speed);
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else if (Input.GetKey(DOWN))
        {
            rb[index].velocity = new Vector3(rb[index].velocity.x, rb[index].velocity.y, -1f * speed);
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else
        {
            rb[index].velocity = Vector3.zero;
            print($"tes debug Movement Paddle {name} {rb[index].velocity}");
        }





    }








}
