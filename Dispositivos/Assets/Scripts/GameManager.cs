using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingleton<GameManager>
{
    public override void Awake()
    {
        base.Awake();
    }

    public void FuncionFalopa()
    {
        Debug.Log("Aguante BOKE");
    }
}
