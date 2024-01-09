using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float xValue;
    public float yValue;
    public float zValue;
    // Start is called before the first frame update
    void Start()
    {
        SetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new(target.transform.position.x + xValue, yValue, target.transform.position.z + zValue);
        gameObject.transform.position = pos;
    }

    public void SetTarget(GameObject target)
    {
        this.target = target;
    }

    public void SetPlayer()
    {
        target = GameObject.FindWithTag("Player");
    }
}
