using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarCollisionHandler : MonoBehaviour
{
    public KnifeInteraction knifeInteraction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ButterKnife"))
        {
            knifeInteraction.TouchJar();
        }
    }
}