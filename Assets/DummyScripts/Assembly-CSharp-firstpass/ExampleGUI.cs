/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using com.adjust.sdk;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class ExampleGUI : MonoBehaviour // TypeDefIndex: 6720
{
	// Fields
	private int numberOfButtons; // 0x18
	private bool isEnabled; // 0x1C
	private bool showPopUp; // 0x1D
	private string txtSetEnabled; // 0x20
	private string txtManualLaunch; // 0x28
	private string txtSetOfflineMode; // 0x30

	// Constructors
	public ExampleGUI() {} // 0x00000001863B82B0-0x00000001863B8340

	// Methods
	private void OnGUI() {} // 0x00000001863B6E50-0x00000001863B7AD0
	private void ShowGUI(int windowID) {} // 0x00000001863B8080-0x00000001863B8220
	public void HandleGooglePlayId(string adId) {} // 0x00000001863B6D90-0x00000001863B6E50
	public void AttributionChangedCallback(AdjustAttribution attributionData) {} // 0x00000001863B6060-0x00000001863B64E0
	public void EventSuccessCallback(AdjustEventSuccess eventSuccessData) {} // 0x00000001863B6A00-0x00000001863B6D90
	public void EventFailureCallback(AdjustEventFailure eventFailureData) {} // 0x00000001863B65F0-0x00000001863B6A00
	public void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData) {} // 0x00000001863B7DF0-0x00000001863B8080
	public void SessionFailureCallback(AdjustSessionFailure sessionFailureData) {} // 0x00000001863B7AD0-0x00000001863B7DF0
	private void DeferredDeeplinkCallback(string deeplinkURL) {} // 0x00000001863B64E0-0x00000001863B65F0
}

