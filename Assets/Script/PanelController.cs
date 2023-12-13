using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // Reference to your panel game object

    void Start()
    {
        // Set the panel inactive at the start
        panel.SetActive(false);

        // Invoke the ShowPanel method after 2 seconds (adjust the time as needed)
        Invoke("ShowPanel", 2f);
    }

    void ShowPanel()
    {
        // Set the panel active
        panel.SetActive(true);
    }
}
