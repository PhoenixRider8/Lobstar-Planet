using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public FauxGravityAttractor attractor;
    Rigidbody rb;
    void Start()
    {
       rb= GetComponent<Rigidbody>();
       rb.constraints = RigidbodyConstraints.FreezeRotation;
       rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(transform);
    }
}
