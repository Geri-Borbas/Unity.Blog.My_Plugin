using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.InteropServices;

public class My_Plugin : MonoBehaviour
{
	[DllImport("__Internal")]
	extern static public string getMessage();

	void Start()
	{
		#if UNITY_ANDROID
		AndroidJavaClass pluginClass = new AndroidJavaClass("com.eppz.myplugin.My_Plugin");
		GetComponent<Text>().text = pluginClass.CallStatic<string>("getMessage");
		#elif UNITY_IOS
		GetComponent<Text>().text = getMessage();
		#endif
	}
}
