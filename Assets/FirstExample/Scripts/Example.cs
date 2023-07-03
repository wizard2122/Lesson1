using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Sherif _sherif;
    [SerializeField] private Transform _target;
    [SerializeField] private List<Transform> _patrolPoint = new List<Transform>();

    private void Awake()
    {
        _sherif.SetMover(new NoMovePattern());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Все спокойно, преступника нет");
            _sherif.SetMover(new NoMovePattern());
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Патрулирую город");
            _sherif.SetMover(new PointByPointMover(_sherif, _patrolPoint.Select(point => point.position)));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Преследую преступника");
            _sherif.SetMover(new MoveToTargetPattern(_sherif, _target));
        }
    }
}
