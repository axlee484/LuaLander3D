using UnityEngine;

public interface IMoveable
{
    public void Move(Vector3 direction, bool relative = false);
    public void Rotate(Vector3 axis);
}
