using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInteraction : MonoBehaviour
{
    public GameObject pbKnife;
    private bool hasTouchedJar = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TouchJar()
    {
        if (!hasTouchedJar)
        {
            GameObject newKnife = Instantiate(pbKnife, transform.position, transform.rotation);
            newKnife.SetActive(true);

            gameObject.SetActive(false);

            hasTouchedJar = true;
        }
    }
}