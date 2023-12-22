using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement Movement;
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Barrier")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
