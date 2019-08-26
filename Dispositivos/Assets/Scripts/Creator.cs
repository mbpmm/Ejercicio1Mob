using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public List<GameObject> bulletList;
    public GameObject bullet;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Disparar"))
        {
            bulletList.Add(CreateBullet());
        }
    }

    public GameObject CreateBullet()
    {
        GameObject b = Instantiate(bullet,player.transform.position,Quaternion.identity);

        return b;
    }
}
