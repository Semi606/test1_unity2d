using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text deathText;

    // Метод для зупинки гри після смерті персонажа
    public void GameOver()
    {
        // Зупинка гри
        Time.timeScale = 0f;

        // Опціонально: викликати інші дії, які повинні відбутися після смерті, наприклад, виведення екрану смерті, відображення кнопок тощо.
        // Наприклад, виведення екрану смерті або активація кнопки перезавантаження рівня.
        // SceneManager.LoadScene("DeathScreen"); // Приклад виведення екрану смерті
    }


    //Метод для показу повідомлення про смерть
    public void ShowDeathMessage()
    {
        // Встановлює текст повідомлення про смерть
        deathText.text = "Ви померли!";
    }
}