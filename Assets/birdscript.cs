using UnityEngine;
using UnityEngine.Serialization;

public class birdscript : MonoBehaviour
{
    [FormerlySerializedAs("MyRigidbody2D")] public Rigidbody2D myRigidbody2D;
    [FormerlySerializedAs("Strength")] public float strength;
    public Logic2Script logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic2Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) 
        {
            myRigidbody2D.linearVelocity = Vector2.up * strength;
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
