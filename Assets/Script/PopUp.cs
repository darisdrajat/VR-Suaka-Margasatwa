using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PopUp : MonoBehaviour {
	public GameObject Komodo;
	public GameObject Gajah;
	public GameObject Rusa;
	public GameObject Badak;
	public GameObject Monyet;
	public GameObject Harimau;
	public GameObject Macan;
	public GameObject Beruang;

    public bool stateKomodo = false;
    public bool stateGajah = false;
    public bool stateRusa = false;
    public bool stateBadak = false;
    public bool stateMonyet = false;
    public bool stateHarimau = false;
    public bool stateMacan = false;
    public bool stateBeruang = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void InfoKomodo(){
        if (stateKomodo == false)
        {
            Komodo.SetActive(true);
            stateKomodo = true;
        }

        else if (stateKomodo == true)
        {
            Komodo.SetActive(false);
            stateKomodo = false;
        }
    }

	public void InfoGajah(){
        if (stateGajah == false)
        {
            Gajah.SetActive(true);
            stateGajah = true;
        }

        else if (stateGajah == true)
        {
            Gajah.SetActive(false);
            stateGajah = false;
        }
    }

	public void InfoRusa(){
		if (stateRusa == false)
        {
            Rusa.SetActive(true);
        stateRusa = true;
        }

        else if (stateRusa == true)
        {
            Rusa.SetActive(false);
            stateRusa = false;
        }
	}

	public void InfoBadak(){
		if (stateBadak == false)
        {
            Badak.SetActive(true);
            stateBadak = true;
        }

        else if (stateBadak == true)
        {
            Badak.SetActive(false);
            stateBadak = false;
        }
	}

	public void InfoMonyet(){
		if (stateMonyet == false)
        {
            Monyet.SetActive(true);
            stateMonyet = true;
        }

        else if (stateMonyet == true)
        {
            Monyet.SetActive(false);
            stateMonyet = false;
        }
	}

	public void InfoHarimau(){
        if (stateHarimau == false)
        {
            Harimau.SetActive(true);
            stateHarimau = true;
        }
		    
        else if (stateHarimau == true)
        {
            Harimau.SetActive(false);
            stateHarimau = false;
        }
	}

	public void InfoMacan(){
		if (stateMacan == false)
        {
            Macan.SetActive(true);
            stateMacan = true;
        }
		    
        else if (stateMacan == true)
        {
            Macan.SetActive(false);
            stateMacan = false;
        }
	}

	public void InfoBeruang(){
		if (stateBeruang == false)
        {
            Beruang.SetActive(true);
            stateBeruang = true;
        }
		    
        else if (stateBeruang == true)
        {
            Beruang.SetActive(false);
            stateBeruang = false;
        }
	}
}

