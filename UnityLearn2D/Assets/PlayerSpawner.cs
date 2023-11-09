using TMPro;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private TMP_Text PlayersCount;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        PlayersCount = GameObject.FindGameObjectWithTag("PlayerCounter").GetComponent<TMP_Text>();
        if (player != null)
        {
            GeneratePlayer();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            GeneratePlayer();
        }
    }

    private void GeneratePlayer()
    {
        var position = new Vector2(Random.Range(-9f, 9f), Random.Range(5.5f, 9f));
        char t = (char)Random.Range(0, 150);
        player.name = $"player_{Random.Range(0, 1000)}_{t}";
        Instantiate(player, position, Quaternion.identity);

        int playerCount = 0;
        if (int.TryParse(PlayersCount.text, out playerCount))
        {
            playerCount++;
            PlayersCount.text = playerCount.ToString();
        }
    }
}
