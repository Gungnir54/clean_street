using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] int healAmount;
    private void OnTriggerEnter2D(Collider2D collision) {
            Debug.Log("TOUCHED");

        Character c = collision.GetComponent<Character>();
        if (c != null) {
            c.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
