using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject FonScrollStal;
    public GameObject FonScrolllenin;
    public GameObject FonScrollRB;
    public GameObject FonScrollprom;
    public GameObject FonScrollflag;
    public GameObject FonScrollPrezident;
    public GameObject FonScrollVorygenieBSSR;
    public GameObject museam;
    public GameObject BSSR;
    public GameObject grogori;
    public GameObject guns;
    


    public void FonScrollStalin()
    {
        FonScrollStal.SetActive(true);
    }
    public void FonScrollleni()
    {
        FonScrolllenin.SetActive(true);
    }
    public void FonScrollR()
    {
        FonScrollRB.SetActive(true);
    }
    public void FonScrollproms()
    {
        FonScrollprom.SetActive(true);
    }
    public void FonScrollflags()
    {
        FonScrollflag.SetActive(true);
    }
    public void FonScrollPrezidents()
    {
        FonScrollPrezident.SetActive(true);
    }
    public void FonScrollVorygenieBSSRs()
    {
        FonScrollVorygenieBSSR.SetActive(true);
    }
    public void Museam()
    {
        museam.SetActive(true);
    }
    public void BsSR()
    {
        BSSR.SetActive(true);
    }
    public void Grigori()
    {
        grogori.SetActive(true);
    }
    public void Guns()
    {
        guns.SetActive(true);
    }
    public void ClearButtons()
    {
        FonScrollStal.SetActive(false);
        FonScrolllenin.SetActive(false);
        FonScrollRB.SetActive(false);
        FonScrollprom.SetActive(false);
        FonScrollflag.SetActive(false);
        FonScrollPrezident.SetActive(false);
        FonScrollVorygenieBSSR.SetActive(false);
        museam.SetActive(false);
        BSSR.SetActive(false);
        grogori.SetActive(false);
        guns.SetActive(false);
    }
}
