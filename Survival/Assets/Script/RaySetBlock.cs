using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaySetBlock : MonoBehaviour
{

    //public Transform pointer;
    public Camera camera;

    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //pointer.position = hit.point;

            SetBlock setBlock = hit.collider.gameObject.GetComponent<SetBlock>();
            if (setBlock&&Input.GetKeyDown(KeyCode.Mouse0))
            {
                setBlock.createBlock();
            }
        }
    }
}
