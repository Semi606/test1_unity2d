using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    private GameManager scriptGM;
    public Transform PlayerStartPoint;
    public Slider healthSlider;
    public Text healthText;
    

    void Start()
    {
        currentHealth = maxHealth;
        scriptGM = FindObjectOfType<GameManager>();
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();
        Debug.Log("Damage taken!");

        // Викликаємо метод обробки смерті, якщо здоров'я опускається до нуля або менше
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeMedicine(int damage)
    {
        currentHealth += damage;
        UpdateHealthUI();
        Debug.Log("Medicine taken!");
    }

    void Die()
    {
        // Ваш код обробки смерті гравця
        // Наприклад, відтворення анімації смерті, перезапуск рівня тощо
        if (scriptGM != null)
        {
            scriptGM.GameOver();
            scriptGM.ShowDeathMessage();
        }
        TeleportToStartPoint();
        Debug.Log("Player has died!");
        currentHealth = 100;
        UpdateHealthUI();
    }

    public void TeleportToStartPoint()
    {
        // Перевірка, чи існує початкова точка
        if (PlayerStartPoint != null)
        {
            // Телепортація персонажа до початкової точки
            transform.position = PlayerStartPoint.position;
        }
        else
        {
            Debug.LogWarning("Початкова точка не встановлена!");
        }
    }

    public void UpdateHealthUI()
    {
        healthSlider.value = currentHealth;
        healthText.text = "Health: " + currentHealth.ToString();
    }
}