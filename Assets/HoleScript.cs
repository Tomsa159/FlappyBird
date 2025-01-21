using System;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public Logic2Script logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic2Script>();
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.AddScore();

    }
}
