using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            var charController = col.gameObject.GetComponent<CharacterControls>();
            if (charController != null) charController.LoadCheckPoint();
        }
    }
}
