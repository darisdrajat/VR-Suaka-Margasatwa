using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilihJawaban : MonoBehaviour {
	public TextMesh skor;
	public TextMesh kata;
	public GameObject soal1;
	public GameObject soal2;
	public GameObject soal3;
	public GameObject soal4;
	public GameObject soal5;
	public GameObject soal6;
	public GameObject soal7;
	public GameObject soal8;
	public GameObject penjelasan1;
	public GameObject penjelasan2;
	public GameObject penjelasan3;
	public GameObject penjelasan4;
	public GameObject penjelasan5;
	public GameObject penjelasan6;
	public GameObject penjelasan7;
	public GameObject penjelasan8;
	public GameObject nilai;
	public float benar = 0;
	public float kalah = 0;
	public float hasil = 0;
	
	// Update is called once per frame
	void Update () {
		hasil = (benar / 8) * 100;
		skor.text = "Benar= " + benar + "\nSalah = " + kalah + "\n\nNilai = " + hasil ;
	    if (hasil == 100)
			kata.text = "Kamu Sangat Mengerti";
		else if (hasil > 60 && hasil < 100) 
			kata.text = "Kamu Sudah Mengerti";
		else if (hasil < 60)
			kata.text = "Kamu Harus Belajar Lagi Ya";
		/*kata.text = "Kamu Hebat";*/
	}

	//Untuk Jawaban yang benar
	public void pointerdowntrue1(){
		benar++;
		soal1.SetActive (false);
		soal2.SetActive (true);
	}
	public void pointerdowntrue2(){
		benar++;
		soal2.SetActive (false);
		soal3.SetActive (true);
	}
	public void pointerdowntrue3(){
		benar++;
		soal3.SetActive (false);
		soal4.SetActive (true);
	}

	public void pointerdowntrue4(){
		benar++;
		soal4.SetActive (false);
		soal5.SetActive (true);
	}
	public void pointerdowntrue5(){
		benar++;
		soal5.SetActive (false);
		soal6.SetActive (true);
	}
	public void pointerdowntrue6(){
		benar++;
		soal6.SetActive (false);
		soal7.SetActive (true);
	}
	public void pointerdowntrue7(){
		benar++;
		soal7.SetActive (false);
		soal8.SetActive (true);
	}
	public void pointerdowntrue8(){
		benar++;
		soal8.SetActive (false);
		nilai.SetActive (true);
	}

	//Untuk Jawaban yang salah
	public void pointerdownfalse1(){
		kalah++;
		soal1.SetActive (false);
		penjelasan1.SetActive (true);
	}
	public void pointerdownfalse2(){
		kalah++;
		soal2.SetActive (false);
		penjelasan2.SetActive (true);
	}
	public void pointerdownfalse3(){
		kalah++;
		soal3.SetActive (false);
		penjelasan3.SetActive (true);
	}
	public void pointerdownfalse4(){
		kalah++;
		soal4.SetActive (false);
		penjelasan4.SetActive (true);;
	}
	public void pointerdownfalse5(){
		kalah++;
		soal5.SetActive (false);
		penjelasan5.SetActive (true);
	}
	public void pointerdownfalse6(){
		kalah++;
		soal6.SetActive (false);
		penjelasan6.SetActive (true);
	}
	public void pointerdownfalse7(){
		kalah++;
		soal7.SetActive (false);
		penjelasan7.SetActive (true);;
	}
	public void pointerdownfalse8(){
		kalah++;
		soal8.SetActive (false);
		penjelasan8.SetActive (true);
	}

	//Untuk memberikan penjelasan jika menjawab yang salah
	public void pointerdownpenjelasan1(){
		penjelasan1.SetActive (false);
		soal2.SetActive (true);
	}
	public void pointerdownpenjelasan2(){
		penjelasan2.SetActive (false);
		soal3.SetActive (true);
	}
	public void pointerdownpenjelasan3(){
		penjelasan3.SetActive (false);
		soal4.SetActive (true);
	}
	public void pointerdownpenjelasan4(){
		penjelasan4.SetActive (false);
		soal5.SetActive (true);;
	}
	public void pointerdownpenjelasan5(){
		penjelasan5.SetActive (false);
		soal6.SetActive (true);
	}
	public void pointerdownpenjelasan6(){
		penjelasan6.SetActive (false);
		soal7.SetActive (true);
	}
	public void pointerdownpenjelasan7(){
		penjelasan7.SetActive (false);
		soal8.SetActive (true);;
	}
	public void pointerdownpenjelasan8(){
		penjelasan8.SetActive (false);
		nilai.SetActive (true);
	}
}
