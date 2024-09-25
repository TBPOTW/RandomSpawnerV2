using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] points;
    //public GameObject[] items;

    public void Respawn(GameObject obj)
    {
        int ind = Random.Range(0, points.Length);
        if (obj != null && obj.GetComponent<ItemIndex>())
            obj.transform.position = points[ind].position;
    }
}
