using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    public static ManagerGame Instance;
    public Transform KananAtas;
    public Transform KananBawah;
    public Transform KiriAtas;
    public Transform KiriBawah;
    public GameObject BallKananAtas;
    public GameObject BallKananBawah;
    public GameObject BallKiriAtas;
    public GameObject BallKiriBawah;
    public GameObject[] clone;
    // BallManager bola;
    public BallManager[] bola;
    public float muncul;
    public int jmlBola;

    public int iya;
    public float kecepatanPantulan;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        muncul = 3;
        jmlBola = 1;
    }

    // Update is called once per frame
    void Update()
    {
        kecepatanPantulan -= Time.deltaTime;
        clone = GameObject.FindGameObjectsWithTag("Ball");
        if (clone.Length == 0)
        {

        }
        else
        {
            iya = clone.Length;

            bola[iya - 1] = clone[iya - 1].GetComponent<BallManager>();

        }

        clones();
        aktif();
        muncul -= Time.deltaTime;
        if (muncul < 0)
        {
            if (jmlBola == 1)
            {
                Memunculkan(BallKananAtas, KananAtas);


                muncul = 2;

            }
            else if (jmlBola == 2)
            {
                Memunculkan(BallKananBawah, KananBawah);

                muncul = 2;

            }
            else if (jmlBola == 3)
            {
                Memunculkan(BallKiriAtas, KiriAtas);

                muncul = 2;

            }
            else if (jmlBola == 4)
            {
                Memunculkan(BallKiriBawah, KiriBawah);

                muncul = 2;

            }
            else if (jmlBola == 5)
            {
                Memunculkan(BallKananAtas, KananAtas);

                muncul = 2;

            }

        }


    }


    void Memunculkan(GameObject prefab, Transform posisi)
    {
        Instantiate(prefab, new Vector3(posisi.position.x, posisi.position.y, posisi.position.z), Quaternion.identity);



    }


    void clones()
    {




        if (clone.Length >= 5)
        {
            jmlBola = 0;
        }
        else if (clone.Length <= 5)
        {
            jmlBola = Random.Range(1, 5);
        }
    }


    public void kencang()
    {
        kecepatanPantulan = 2;
        for (int i = 0; i < clone.Length; i++)
        {





            if (kecepatanPantulan < 0)
            {
                bola[i].rb.velocity = bola[i].rb.velocity * 1.5f;



                print("kencang Aktif");
            }




        }
    }

    void aktif()
    {
        for (int i = 0; i < clone.Length; i++)
        {




            if (kecepatanPantulan < 0)
            {
                if (bola[i] == clone[i])
                {

                    bola[i].rb.velocity = bola[i].rb.velocity;


                }
            }



        }
    }
}