using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

    public Transform player;

    void Update() {
        //attatcher camera to player
        transform.position = player.transform.position;
    }
}