/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using com.adjust.sdk;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class AdjustEntrance : MonoBehaviour, IOperationSDK // TypeDefIndex: 6725
{
	// Fields
	private bool _printLog; // 0x18

	// Constructors
	public AdjustEntrance() {} // 0x00000001864C76D0-0x00000001864C7740

	// Methods
	private void Awake() {} // 0x00000001864C70F0-0x00000001864C71A0
	public void InitSDK(string appKey, string channelId, bool isSandbox) {} // 0x00000001864C7440-0x00000001864C7490
	public void Register(string account, string eventName) {} // 0x00000001864C7530-0x00000001864C7580
	public void Login(string account, string eventName) {} // 0x00000001864C7490-0x00000001864C74E0
	public void TrackEvent(string eventName) {} // 0x00000001864C7680-0x00000001864C76D0
	public void ReYunSetOrder(string ryTID, string hbType, float hbAmount) {} // 0x00000001864C74E0-0x00000001864C7530
	public void AdjustTrackRevenue(string eventName, float amount, string currency) {} // 0x00000001864C7050-0x00000001864C70A0
	public void AttributionChangedCallback(AdjustAttribution attributionData) {} // 0x00000001864C70A0-0x00000001864C70F0
	public void EventSuccessCallback(AdjustEventSuccess eventSuccessData) {} // 0x00000001864C7240-0x00000001864C7290
	public void EventFailureCallback(AdjustEventFailure eventFailureData) {} // 0x00000001864C71F0-0x00000001864C7240
	public void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData) {} // 0x00000001864C75D0-0x00000001864C7620
	public void SessionFailureCallback(AdjustSessionFailure sessionFailureData) {} // 0x00000001864C7580-0x00000001864C75D0
	public void DeferredDeeplinkCallback(string deeplinkURL) {} // 0x00000001864C71A0-0x00000001864C71F0
	public void SetPrintLog(bool bPrint) {} // 0x00000001864C7620-0x00000001864C7680
	public void AdjustLog(string msg) {} // 0x00000001864C6FB0-0x00000001864C7050
	public string GetDeviceId() => default; // 0x00000001864C73B0-0x00000001864C7440
	public string GetCurrentCaid() => default; // 0x00000001864C7320-0x00000001864C73B0
	public string GetCachedCaid() => default; // 0x00000001864C7290-0x00000001864C7320
}

