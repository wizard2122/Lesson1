using UnityEngine;

public class Sherif : MonoBehaviour, IMovable
{
    private IMover _mover;

    [SerializeField] private float _speed;

    public float Speed => _speed;
    public Transform Transform => transform;

    private void Update() => _mover?.Update(Time.deltaTime);

    public void SetMover(IMover mover)
    {
        _mover?.StopMove();
        _mover = mover;
        _mover.StartMove();
    }
}
