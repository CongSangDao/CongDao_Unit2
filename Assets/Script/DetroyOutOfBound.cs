using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyOutOfBound : MonoBehaviour
{
    private float topOfScene = 30.0f;
    private float bottomOfScene = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
       if(transform.position.z < bottomOfScene)
        {
          Destroy(gameObject);
            Debug.Log("GameOver!");
        }
    }
}
