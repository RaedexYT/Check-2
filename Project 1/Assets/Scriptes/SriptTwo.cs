using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SriptTwo: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FirstScript script = FindObjectOfType<FirstScript>();
        script.CallName("ada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
