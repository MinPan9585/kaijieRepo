using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOneKnife : MonoBehaviour
{
    public GameObject cut;
    void Update()
    {
        Vector3 knifePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(knifePos.x, knifePos.y, 0);

        if(Input.GetMouseButtonDown(0)){
            Instantiate(cut,transform.position,Quaternion.identity);
        }
    }
}
