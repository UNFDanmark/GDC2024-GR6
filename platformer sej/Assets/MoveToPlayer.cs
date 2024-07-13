using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

    public Transform player;

    void Update() {
        transform.position = player.transform.position;
    }
}