using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float pipeSpeed = 5;
    public float deletePoint = -35;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        transform.position = transform.position + Vector3.left * (pipeSpeed * Time.deltaTime);
        if (transform.position.x < deletePoint)
        {
           Destroy(gameObject); 
        }
    }
}
