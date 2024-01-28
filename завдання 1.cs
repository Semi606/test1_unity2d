using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public float moveSpeed = 5.0f;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        // Отримуємо вхідні дані від гравця
        float horizontalInput = Input.GetAxis("Horizontal"); // Для руху вліво/вправо

        // Рух персонажа
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime; //вправо і вліво
        transform.Translate(movement);
    }
}
