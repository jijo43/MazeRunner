
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y > 0)
        {
            scoreText.text = (player.position.z + 46).ToString("0");
        }
           
    }
}
