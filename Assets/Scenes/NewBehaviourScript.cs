using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject _bullet;
    public float time;
   

   
    void Update()
    {
        time -= Time.deltaTime;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime;
        var z = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position += new Vector3(x, 0f, z);

        if (time < 0f)
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Instantiate(_bullet, transform.position, transform.rotation);
                time = 1f;
            }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Key F");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("Key LeftControl");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0f, -360f * Time.deltaTime, 0f);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f, 360f * Time.deltaTime, 0f);
        }
    }
    }

