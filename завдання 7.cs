using UnityEngine;

public class enemiesautomatic : MonoBehaviour
{
    public Transform startPoint; // Початкова точка руху ворога
    public Transform endPoint;   // Кінцева точка руху ворога
    public float moveSpeed = 2.0f; // Швидкість руху ворога
    public float delayTime = 1.0f; // Час затримки перед зміною напрямку руху

    private float currentDelay;
    private bool movingToEndPoint = true;

    private void Start()
    {
        currentDelay = delayTime;
        transform.position = startPoint.position;
    }

    private void Update()
    {
        if (currentDelay > 0)
        {
            currentDelay -= Time.deltaTime;
            return;
        }

        float step = moveSpeed * Time.deltaTime;

        if (movingToEndPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, step);

            if (Vector3.Distance(transform.position, endPoint.position) < 0.01f)
            {
                currentDelay = delayTime;
                movingToEndPoint = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.position, step);

            if (Vector3.Distance(transform.position, startPoint.position) < 0.01f)
            {
                currentDelay = delayTime;
                movingToEndPoint = true;
            }
        }
    }
}
