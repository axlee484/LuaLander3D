using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyMovement : MonoBehaviour, IMoveable
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        
    }

    public void Move(Vector3 direction, bool relative = false )
    {
        var force = direction * speed;
        if(relative) 
        {
            rigidBody.AddRelativeForce(force);
            return;
        }
        rigidBody.AddForce(force);

    }
    public void Rotate(Vector3 axis)
    {
        var rot = axis * rotationSpeed;
        rigidBody.AddTorque(rot);
    }
}
