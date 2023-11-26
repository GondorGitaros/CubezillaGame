using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindAnyObjectByType<GameManager>().Won();
    }
}
