using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TrapTests
{
    [Test]
    public void PlayerEnteringTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        CharacterMover characterMover = new CharacterMover();
        trap.HandleCharacterEntered(characterMover);
        Assert.AreEqual(-1, characterMover.Health);
    }

}
