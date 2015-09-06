using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;

public class JSONReader : MonoBehaviour {
	string inp_ln = "";

	// Use this for initialization
	void Start () {
	
		string mailJson = readTextFile ("Assets/mail.json");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	string readTextFile(string file_path)
	{
		StreamReader inp_stm = new StreamReader(file_path);
		
		while(!inp_stm.EndOfStream)
		{
			inp_ln = inp_stm.ReadLine ();
			// Do Something with the input. 
		}
		
		inp_stm.Close( );  
		return inp_ln;
	}
}
