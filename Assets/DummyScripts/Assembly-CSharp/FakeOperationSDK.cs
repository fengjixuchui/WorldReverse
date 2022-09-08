/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal class FakeOperationSDK : IOperationSDK // TypeDefIndex: 21264
{
	// Constructors
	public FakeOperationSDK() {} // 0x000000018124C940-0x000000018124C9A0

	// Methods
	// [XID] // 0x0000000189A4E1F0-0x0000000189A4E210
	public void InitSDK(string appKey, string channelId, bool isSandbox) {} // 0x000000018124C4C0-0x000000018124C590
	// [XID] // 0x0000000189A55A20-0x0000000189A55A40
	public void Register(string account, string eventName) {} // 0x000000018124C720-0x000000018124C7E0
	// [XID] // 0x0000000189A5D280-0x0000000189A5D2A0
	public void Login(string account, string eventName) {} // 0x000000018124C590-0x000000018124C650
	// [XID] // 0x0000000189A64BE0-0x0000000189A64C00
	public void TrackEvent(string eventName) {} // 0x000000018124C890-0x000000018124C940
	// [XID] // 0x0000000189A6C3E0-0x0000000189A6C400
	public void ReYunSetOrder(string ryTID, string hbType, float hbAmount) {} // 0x000000018124C650-0x000000018124C720
	// [XID] // 0x0000000189A73B90-0x0000000189A73BB0
	public void AdjustTrackRevenue(string eventName, float amount, string currency) {} // 0x000000018124C180-0x000000018124C250
	// [XID] // 0x0000000189A7B620-0x0000000189A7B640
	public void SetPrintLog(bool bPrint) {} // 0x000000018124C7E0-0x000000018124C890
	// [XID] // 0x0000000189A82D40-0x0000000189A82D60
	public string GetDeviceId() => default; // 0x000000018124C3F0-0x000000018124C4C0
	// [XID] // 0x0000000189A8A700-0x0000000189A8A720
	public string GetCurrentCaid() => default; // 0x000000018124C320-0x000000018124C3F0
	// [XID] // 0x0000000189A91F40-0x0000000189A91F60
	public string GetCachedCaid() => default; // 0x000000018124C250-0x000000018124C320
}

