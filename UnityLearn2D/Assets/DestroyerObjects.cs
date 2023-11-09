using TMPro;
using UnityEngine;

public class DestroyerObjects : MonoBehaviour
{
    private TMP_Text DestroyCounter;
    private void Start()
    {
        DestroyCounter = GameObject.FindGameObjectWithTag("DestroyCounter").GetComponent<TMP_Text>();
    }
    void Update()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");

        if (players != null)
        {
            if (players.Length > 0)
            {
                foreach (var player in players)
                {
                    if (player.transform.position.y < -5.6f)
                    {
                        Destroy(player);

                        int destroyedCount = 0;
                        if (int.TryParse(DestroyCounter.text, out destroyedCount))
                        {
                            destroyedCount++;
                            DestroyCounter.text = destroyedCount.ToString();
                        }
                    }
                }
            }
        }
    }
}
