using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    Rigidbody rb;
    public const float VELOCITY_MODIFIER = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartingPosition()
    {

    }

    private void StartingVelocity()
    {
        rb.velocity = new Vector3((Random.value + 1) * VELOCITY_MODIFIER, (Random.value + 1) * VELOCITY_MODIFIER, (Random.value + 1) * VELOCITY_MODIFIER);
    }

}
