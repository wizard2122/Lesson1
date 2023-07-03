using System.Collections.Generic;
using UnityEngine;

public class ChraracterFinderExample : MonoBehaviour
{
    [SerializeField] private Ork _ork;
    [SerializeField] private List<Human> _humans;

    private void Awake()
    {
        foreach (Human human in _humans)
            human.Initialize(new NoViewPattern(), character => character is Human);

        _ork.Initialize(new FrontSearchPattern(5, _ork.transform), character => character is Ork);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        //Gizmos.DrawWireSphere(_ork.transform.position, 5);
        Gizmos.DrawRay(_ork.transform.position, _ork.transform.forward * 5);
    }
}
