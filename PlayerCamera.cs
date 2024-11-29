using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform PlayerTarget;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerTarget.transform.position.x, PlayerTarget.transform.position.y,transform.position.z);
        //changing camera position
    }
}
