using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour {

	public GameObject Menu;
	public GameObject Warning;
	public GameObject Play;
	public GameObject Quiz;
	public GameObject Soal;
	public GameObject About;
	public GameObject Help;
	public GameObject Nilai;
    public GameObject Joystick;
    public GameObject Exit;

	public void GoMenu() {
		Menu.SetActive(true);
		Warning.SetActive(false);
		Quiz.SetActive(false);
		Soal.SetActive(false);
		About.SetActive(false);
		Help.SetActive(false);
		Nilai.SetActive(false);
        Joystick.SetActive(false);
    }

	public void GoWarning() {
		Warning.SetActive(true);
		Menu.SetActive(false);
	}

	public void GoPlay() {
		Application.LoadLevel(1);
	}

	public void GoQuiz() {
		Quiz.SetActive(true);
		Menu.SetActive(false);
	}

	public void KeSoal() {
		Soal.SetActive(true);
		Quiz.SetActive(false);
	}

	public void GoAbout() {
		About.SetActive(true);
		Menu.SetActive(false);
	}

	public void GoHelp() {
		Help.SetActive(true);
		Menu.SetActive(false);
	}

	public void SelesaiKuis() {
		Application.LoadLevel(0);
    }

	public void GoExit() {
		Application.Quit();
	}
}
