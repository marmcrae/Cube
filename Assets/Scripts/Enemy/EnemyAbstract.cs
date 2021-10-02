using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbstract : MonoBehaviour
{
    [SerializeField] protected float _speedEnemy = 1.0f;
    private int directionChange = 1;

    // Start is called before the first frame update
    void Start()
    {
        //left and right
        //up and down
        //circle
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void leftRight()
    {
        //moves left and right, changes direction after colliding with environment
        if (directionChange > 0)
        {
            transform.Translate(Vector3.left * _speedEnemy * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * _speedEnemy * Time.deltaTime);
        }
    }
    protected virtual void upDown()
    {
        //moves up and down, changes direction after colliding with environment
        if (directionChange > 0)
        {
            transform.Translate(Vector3.up * _speedEnemy * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * _speedEnemy * Time.deltaTime);
        }
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bounds"))
        {
            //reverse direction
            directionChange *= -1;
        }
    }
}
