/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class TrackingEntrance : MonoBehaviour, IOperationSDK // TypeDefIndex: 10075
{
	// Constructors
	public TrackingEntrance() {} // 0x0000000186075460-0x00000001860754C0

	// Methods
	private void Awake() {} // 0x0000000186074EF0-0x0000000186074FA0
	public void InitSDK(string appKey, string channelId, bool isSandbox) {} // 0x0000000186075210-0x0000000186075260
	public void Register(string account, string eventName) {} // 0x0000000186075300-0x0000000186075350
	public void Login(string account, string eventName) {} // 0x0000000186075260-0x00000001860752B0
	public void TrackEvent(string eventName) {} // 0x0000000186075410-0x0000000186075460
	public void ReYunSetOrder(string ryTID, string hbType, float hbAmount) {} // 0x00000001860752B0-0x0000000186075300
	public void AdjustTrackRevenue(string eventName, float amount, string currency) {} // 0x0000000186074EA0-0x0000000186074EF0
	public string GetDeviceId() => default; // 0x0000000186075140-0x0000000186075210
	public string GetCurrentCaid() => default; // 0x0000000186075070-0x0000000186075140
	public string GetCachedCaid() => default; // 0x0000000186074FA0-0x0000000186075070
	public void SetPrintLog(bool bPrint) {} // 0x0000000186075350-0x0000000186075410
}

