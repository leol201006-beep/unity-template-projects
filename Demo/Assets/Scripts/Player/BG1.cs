using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG1 : MonoBehaviour
{
    public float BGboundary;
    public Vector3 starting_point;
    public GameObject backgroundcopy;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        starting_point = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(speed,0,0));
        if (transform.position.x <= BGboundary){
            Instantiate(backgroundcopy,starting_point,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
