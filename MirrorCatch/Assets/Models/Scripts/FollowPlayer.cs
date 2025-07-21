using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, -6); // Distance above and behind

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
