using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIndex : MonoBehaviour
{
    public void DestroyItem()
    {
        Destroy(transform.gameObject);
    }
}
