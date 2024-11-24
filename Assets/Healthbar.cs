using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Healthbar : MonoBehaviour
{
    public int maxHealth = 100;
    public Image bar;

    public UnityEvent onDeath;

    private int currentHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage) {

        currentHealth -= damage;
        //currentHealth = Mathf.Max(0, currentHealth);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        bar.transform.localScale = new Vector3((float)currentHealth / maxHealth, 1, 1);

        if (currentHealth == 0) {
            onDeath.Invoke();
        }
    }
}
