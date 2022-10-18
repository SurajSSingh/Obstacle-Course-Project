using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    public Transform checkPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            var charController = col.gameObject.GetComponent<CharacterControls>();
            if (charController != null) charController.checkPoint = checkPoint.position;
        }
    }
}
