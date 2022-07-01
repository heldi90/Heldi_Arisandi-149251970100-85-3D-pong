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
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        p1.text = $"P1 = {scoreP1}";
        p2.text = $"P2 = {scoreP2}";
        p3.text = $"P3 = {scoreP3}";
        p4.text = $"P4 = {scoreP4}";
    }

    public void ScroreP1()
    {
        scoreP1 = scoreP1 + 1;
        if (scoreP1 > 15)
        {
            scoreP1 = 15;
            wallP1.SetActive(true);
        }
    }
    public void ScroreP2()
    {
        scoreP2 = scoreP2 + 1;
        if (scoreP2 > 15)
        {
            scoreP2 = 15;
            wallP2.SetActive(true);
        }
    }
    public void ScroreP3()
    {
        scoreP3 = scoreP3 + 1;
        if (scoreP3 > 15)
        {
            scoreP3 = 15;
            wallP3.SetActive(true);
        }
    }
    public void ScroreP4()
    {
        scoreP4 = scoreP4 + 1;
        if (scoreP4 > 15)
        {
            scoreP4 = 15;
            wallP4.SetActive(true);
        }
    }

}
