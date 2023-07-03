using UnityEngine;

public class MoveToTargetPattern : IMover
{
    private IMovable _movable;
    private Transform _target;

    private bool _isMoving;

    public MoveToTargetPattern(IMovable movable, Transform target)
    {
        _movable = movable;
        _target = target;
    }

    public void StartMove() => _isMoving = true;

    public void StopMove() => _isMoving = false;

    public void Update(float deltaTime)
    {
        if (_isMoving == false)
            return;

        Vector3 direction = _target.position - _movable.Transform.position;
        _movable.Transform.Translate(direction.normalized * _movable.Speed * deltaTime);
    }
}
