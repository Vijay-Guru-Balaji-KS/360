using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
using UnityEngine.UI;

//public key : 42a7a8e269c42eb60816ad23f8873a7bc6a2954c2998b7f12d03030bf26c03ea
//secret key : 70e0bccce36cfcadbcea8745d9daa2beb92c1d23f0cb17383fe79641b6d8640dfb3c940e400d19d7471164405e84528a84ef5d02ee11117b411e64c7fae770ff1f5df56a5108364d8b81a420fe04e5ab71318dc85b941eba85b7256b520bc970fb1dc26a59b836dba4076634acfd688b79b3af281877f5880c7be1140d67330d

public class Leaderboard : MonoBehaviour
{
    /*[SerializeField]
    private List<TextMeshProUGUI> Naam;
    [SerializeField]
    private List<TextMeshProUGUI> points;

    public Text test;
    public Text ScoreTest;

    private string publicLeaderKey = "42a7a8e269c42eb60816ad23f8873a7bc6a2954c2998b7f12d03030bf26c03ea";

    private void Start()
    {
        getLeaderBoard();

    }

    private void Awake()
    {
        //test.text = PlayerPrefs.GetString("PlayerName");
        //ScoreTest.text = PlayerPrefs.GetString("LeaderScore");

        //Debug.Log("LeaderBoard la Bloody: " + PlayerPrefs.GetString("BloodyScore") + " Name : " + PlayerPrefs.GetString("PlayerName") + " Leader Score : " + PlayerPrefs.GetString("LeaderScore"));
    }
    public void getLeaderBoard()
    {

        LeaderboardCreator.GetLeaderboard(publicLeaderKey, (msg) =>
        {
            int loolen = (msg.Length < Naam.Count) ? msg.Length : Naam.Count;
            for (int i = 0; i < loolen; i++)
            {
                Naam[i].text = msg[i].Username;
                points[i].text = msg[i].Score.ToString();
            }
        });
    }

    public void SetLeaderBoardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderKey, username, score, ((msg) =>
        {
            getLeaderBoard();
        }));
    }*/

    
    
}
