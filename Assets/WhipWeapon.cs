using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipWeapon : MonoBehaviour
{
    [SerializeField] 
   float timeToAttack = 4f;
    float timer;

    [SerializeField] GameObject leftWhipObject;
    [SerializeField] GameObject rightWhipObject;

    playerMove playerMove;

    private void Awake() {
        playerMove = GetComponentInParent<playerMove>();
    }

    // Update is called once per frame
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f) {
            Attack();
        }
    }

    private void Attack() {
        timer = timeToAttack;

        if (playerMove.lastHorizontalVector > 0) {
            rightWhipObject.SetActive(true);
        } else {
            leftWhipObject.SetActive(true);
        }
    }
}
