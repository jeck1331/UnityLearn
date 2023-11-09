using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private TMP_Text PlayersCount;

    void Start()
    {
        PlayersCount = GameObject.FindGameObjectWithTag("PlayerCounter").GetComponent<TMP_Text>();
    }

    void Update()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        if (players != null && PlayersCount.text != players.Length.ToString())
        {
            PlayersCount.text = players.Length.ToString();
        }
        if (players == null )
        {
            if (PlayersCount.text != "0")
                PlayersCount.text = "0";
        }
    }
}
