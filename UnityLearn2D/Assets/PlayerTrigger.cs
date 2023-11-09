using TMPro;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private TMP_Text _gameCount;
    private TMP_Text _playerCount;

    private void Start()
    {
        _gameCount = GameObject.FindGameObjectWithTag("GameCounter").GetComponent<TMP_Text>();
        _playerCount = GameObject.FindGameObjectWithTag("PlayerCounter").GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int count = 0;
            if (int.TryParse(_gameCount.text, out count))
            {
                count++;
                _gameCount.text = count.ToString();
            }

            Destroy(collision.gameObject);
            int playerCount = 0;
            if (int.TryParse(_playerCount.text, out playerCount))
            {
                playerCount--;
                _playerCount.text = playerCount.ToString();
            }
        }
    }
}
