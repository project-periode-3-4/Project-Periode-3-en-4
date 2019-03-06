using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;
    public GameObject fourthPanel;
    public GameObject fifthPanel;
    public GameObject sixthPanel;
    public GameObject seventhPanel;
    public GameObject eigthPanel;

	void Start ()
    {
        OpenFirstPanel();
    }

    public void OpenFirstPanel()
    {
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenSecondPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenThirdPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(true);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenFourthPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(true);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenFifthPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(true);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenSixthPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(true);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(false);
    }

    public void OpenSeventhPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(true);
        eigthPanel.SetActive(false);
    }

    public void OpenEigthPanel()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        fifthPanel.SetActive(false);
        sixthPanel.SetActive(false);
        seventhPanel.SetActive(false);
        eigthPanel.SetActive(true);
    }
}
