using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float _timer;
    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer = _timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            _timer = 0;
        }
           
        
    }

    void spawnPipe()
    {
        var lowestY = transform.position.y - heightOffset;
        var highestY = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0), transform.rotation);
    }
    
}