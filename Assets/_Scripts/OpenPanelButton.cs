using UnityEngine;

public class OpenPanelButton : MonoBehaviour
{
    public GameObject panelToOpen;

    public void OpenPanel()
    {
        panelToOpen.SetActive(true);
    }
}