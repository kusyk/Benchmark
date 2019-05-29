using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using System;

public class LanguageController : MonoBehaviour {
    
	void Awake ()
	{
		if(!PlayerPrefs.HasKey("Language")){
			PlayerPrefs.SetString ("Language", "en");
		}
		ZmianaJezyka (PlayerPrefs.GetString("Language"));
	}

	public void ZmianaJezyka (string jezyk) {
		PlayerPrefs.SetString ("Language", jezyk);
		try {
			string line;
			StreamReader theReader = new StreamReader(Application.dataPath+"/Languages/" + jezyk + ".txt", Encoding.UTF8);

			using(theReader) {
				do {
					line = theReader.ReadLine();
					if (line != null) {
						string[] entries = line.Split(';');
						typeof(GUIStrings).GetProperty(entries[0]).SetValue(null, entries[1], null);
					}
				} while (line != null);
				theReader.Close();
			}
		} catch (Exception e) {
			Console.WriteLine("{0}\n", e.Message);
		}
	}
		
}
