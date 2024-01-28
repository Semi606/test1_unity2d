using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; //об'єкт, який ми спавнимо
    public int numOfObj = 10; //кількість об'єктів для створення
    public float spawnRad = 5f; //радіус спавну
    
    void Start()
    {
        SpawnObjects(); //запускаемо метод спавну
    }

   
    void SpawnObjects() //прописуєм метод
    {
        for(int i=0; i< numOfObj; i++){
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRad; //генеруємо випадкові координати в межах радіусу
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity); //створюємо об'єкти на випадкових координатах
        }
    }

    void Update(){
        
    }
}
