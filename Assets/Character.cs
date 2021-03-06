using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public int maxHp = 1000;
    public int currentHp = 1000;
    [SerializeField] StatusBar hpBar;

    private void Start() {
        hpBar.SetState(currentHp, maxHp);
    }

    public void TakeDamage(int damage) {
        currentHp -=damage;

        if(currentHp <= 0) {
            Debug.Log("DEAD GAME OVER");
            SceneManager.LoadScene("GameOver");
        }


        hpBar.SetState(currentHp, maxHp);
     }

     public void Heal(int amount) {
         if (currentHp <= 0) {
             return;
         }

         currentHp += amount;
         if (currentHp > maxHp) {
             currentHp = maxHp;
         }
        hpBar.SetState(currentHp, maxHp);


     }
}
