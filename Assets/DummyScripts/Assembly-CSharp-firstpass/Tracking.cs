/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class Tracking : MonoBehaviour // TypeDefIndex: 10074
{
	// Fields
	private static Tracking _instance; // 0x00

	// Properties
	public static Tracking Instance { get => default; } // 0x0000000186075730-0x0000000186075A00 

	// Constructors
	public Tracking() {} // 0x00000001860755B0-0x0000000186075610
	static Tracking() {} // 0x0000000186075550-0x00000001860755B0

	// Methods
	private void Awake() {} // 0x00000001860754C0-0x0000000186075550
	public void init(string appKey, string channelId) {} // 0x0000000186075A00-0x0000000186075A50
	public void register(string account) {} // 0x0000000186075AA0-0x0000000186075AF0
	public void login(string account) {} // 0x0000000186075A50-0x0000000186075AA0
	public void setryzf(string ryTID, string ryzfType, string hbType, float hbAmount) {} // 0x0000000186075D20-0x0000000186075D70
	public void setDD(string ryTID, string hbType, float hbAmount) {} // 0x0000000186075AF0-0x0000000186075B40
	public void setEvent(string eventName) {} // 0x0000000186075B40-0x0000000186075B90
	public void setTrackViewDuration(string pageID, long duration) {} // 0x0000000186075CD0-0x0000000186075D20
	public void setTrackAdShow(string adPlatform, string adId) {} // 0x0000000186075C30-0x0000000186075C80
	public void setTrackAdClick(string adPlatform, string adId) {} // 0x0000000186075BE0-0x0000000186075C30
	public void setTrackAppDuration(long duration) {} // 0x0000000186075C80-0x0000000186075CD0
	public string getDeviceId() => default; // 0x00000001860756D0-0x0000000186075730
	public string getCurrentCaid() => default; // 0x0000000186075670-0x00000001860756D0
	public string getCachedCaid() => default; // 0x0000000186075610-0x0000000186075670
	public void setPrintLog(bool print) {} // 0x0000000186075B90-0x0000000186075BE0
}

