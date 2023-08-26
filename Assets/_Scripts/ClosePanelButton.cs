using UnityEngine;

public class ClosePanelButton : MonoBehaviour
{
    public GameObject panelToClose;

    public void ClosePanel()
    {
        panelToClose.SetActive(false);
    }
}