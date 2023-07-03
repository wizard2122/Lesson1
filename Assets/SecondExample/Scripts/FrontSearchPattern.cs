using System.Collections.Generic;
using UnityEngine;

public class FrontSearchPattern : ICharacterFinder
{
    private float _viewingRange;
    private Transform _center;

    public FrontSearchPattern(float viewingRange, Transform center)
    {
        _viewingRange = viewingRange;
        _center = center;
    }

    public IEnumerable<Character> Find()
    {
        RaycastHit[] hits = Physics.RaycastAll(new Ray(_center.position, _center.forward), _viewingRange);

        List<Character> findedCharacters = new List<Character>();

        foreach (RaycastHit hit in hits)
            if (hit.collider.TryGetComponent(out Character character))
                if(character.transform != _center)
                    findedCharacters.Add(character);

        return findedCharacters;
    }
}
