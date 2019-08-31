﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public List<GameObject> collectableList;
    public GameObject collectable;
    public GameObject player;
    public int cantCollectables;
    public Vector3 pos;
    public int max=23;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cantCollectables; i++)
        {
            collectableList.Add(CreateCollectable());
        }
    }

    public GameObject CreateCollectable()
    {
        pos = new Vector3(Random.Range(-max, max), 1, Random.Range(-max, max));
        GameObject b = Instantiate(collectable, pos,Quaternion.identity);

        return b;
    }
}
