using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBlock : MonoBehaviour
{
    public Transform prefab;
    public bool create = false;
    void Update()
    {
        if (create)
        {
            createBlock();
        }    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
    public void createBlock()
    {
        Vector3 pos = transform.position;
        pos.y -= 0.5F;
        Instantiate(prefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
