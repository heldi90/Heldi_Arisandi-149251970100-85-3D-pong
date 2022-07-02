using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text p1;
    public int scoreP1;
    public TMP_Text p2;
    public int scoreP2;
    public TMP_Text p3;
    public int scoreP3;
    public TMP_Text p4;
    public int scoreP4;


    public GameObject wallP1;
    public GameObject wallP2;
    public GameObject wallP3;
    public GameObject wallP4;


    public int kalah;
    public TMP_Text gameOver;
    bool gkMenangP1;
    bool gkMenangP2;
    bool gkMenangP3;
    bool gkMenangP4;

    public GameObject panel1;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        gkMenangP1 = false;
        gkMenangP2 = false;
        gkMenangP3 = false;
        gkMenangP4 = false;

        panel1.SetActive(false);
        panel2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        p1.text = $"P1 = {scoreP1}";
        p2.text = $"P2 = {scoreP2}";
        p3.text = $"P3 = {scoreP3}";
        p4.text = $"P4 = {scoreP4}";

        if (kalah >= 3)
        {
            kalah = 3;
            if (kalah == 3)
            {
                if (!gkMenangP1)
                {
                    gameOver.text = $"P1 Menang!";
                    panel1.SetActive(true);
                    panel2.SetActive(true);

                }
                else if (!gkMenangP2)
                {
                    gameOver.text = $"P2 Menang!";
                    panel1.SetActive(true);
                    panel2.SetActive(true);
                }
                else if (!gkMenangP3)
                {
                    gameOver.text = $"P3 Menang!";
                    panel1.SetActive(true);
                    panel2.SetActive(true);
                }
                else if (!gkMenangP4)
                {
                    gameOver.text = $"P4 Menang!";
                    panel1.SetActive(true);
                    panel2.SetActive(true);
                }
                ManagerGame.Instance.muncul = 999999;
            }
        }


    }

    public void ScroreP1()
    {
        scoreP1 = scoreP1 + 1;
        if (scoreP1 > 15)
        {
            scoreP1 = 15;
            if (!gkMenangP1)
            {

                if (scoreP1 == 15)
                {
                    kalah += 1;
                    gkMenangP1 = true;
                    wallP1.SetActive(true);
                }

            }





        }
    }
    public void ScroreP2()
    {
        scoreP2 = scoreP2 + 1;
        if (scoreP2 > 15)
        {
            scoreP2 = 15;
            if (!gkMenangP2)
            {

                if (scoreP2 == 15)
                {
                    kalah += 1;
                    gkMenangP2 = true;
                    wallP2.SetActive(true);
                }

            }
        }
    }
    public void ScroreP3()
    {
        scoreP3 = scoreP3 + 1;
        if (scoreP3 > 15)
        {
            scoreP3 = 15;

            if (!gkMenangP3)
            {

                if (scoreP3 == 15)
                {
                    kalah += 1;
                    gkMenangP3 = true;
                    wallP3.SetActive(true);
                }

            }
        }
    }
    public void ScroreP4()
    {
        scoreP4 = scoreP4 + 1;
        if (scoreP4 > 15)
        {
            scoreP4 = 15;

            if (!gkMenangP4)
            {

                if (scoreP4 == 15)
                {
                    kalah += 1;
                    gkMenangP4 = true;
                    wallP4.SetActive(true);
                }

            }
        }
    }

}
