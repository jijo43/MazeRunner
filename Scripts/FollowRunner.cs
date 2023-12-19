
using UnityEngine;

public class FollowRunner : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
  

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        
    }
}
