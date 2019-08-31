using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : GenericSingleton<ScoreManager>
{
    public int score;
    public int points=200;

    public override void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
