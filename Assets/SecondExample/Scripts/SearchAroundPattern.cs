using System.Collections.Generic;
using UnityEngine;

public class SearchAroundPattern : ICharacterFinder
{
    private Transform _center;
    private float _radius;

    public SearchAroundPattern(Transform center, float radius)
    {
        _center = center;
        _radius = radius;
    }

    public IEnumerable<Character> Find()
    {
        Collider[] colliders = Physics.OverlapSphere(_center.position, _radius);

        List<Character> findedCharacters = new List<Character>();

        foreach (Collider collider in colliders)
            if(collider.TryGetComponent(out Character character))
                if(character.transform != _center)
                    findedCharacters.Add(character);

        return findedCharacters;
    }
}
