using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GraphicsCardText : MonoBehaviour {
	public Text grafika;
    
	void Start () {
		print (SystemInfo.graphicsDeviceName);
		grafika.text = SystemInfo.graphicsDeviceName;
	}
}
