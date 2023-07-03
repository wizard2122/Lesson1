using UnityEngine;

public interface IMovable
{
    Transform Transform { get; }
    float Speed { get; }
}
