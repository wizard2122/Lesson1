using System.Collections.Generic;

public class NoViewPattern : ICharacterFinder
{
    public IEnumerable<Character> Find() => null;
}
