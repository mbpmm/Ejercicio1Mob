using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : GenericSingleton<SoundManager>
{
    public override void Awake()
    {
        base.Awake();
    }

    public void FuncionFalopa2()
    {
        Debug.Log("Daniele De Rossi metiendole una patada a Goltz");
    }
}
