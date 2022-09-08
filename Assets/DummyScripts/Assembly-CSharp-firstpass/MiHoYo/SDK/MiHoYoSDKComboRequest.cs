/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKComboRequest // TypeDefIndex: 8673
	{
		// Fields
		private float pingTime; // 0x10
		private const float MinPingTime = 60f; // Metadata: 0x00AE1F44
		private Coroutine pingCoroutine; // 0x18
		private long totalTime; // 0x20
		private static MiHoYoSDKComboRequest _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKComboRequest() {} // 0x000000018641C2F0-0x000000018641C360
	
		// Methods
		// [XID] // 0x000000018997F200-0x000000018997F220
		public static MiHoYoSDKComboRequest Instance() => default; // 0x000000018641B380-0x000000018641B460
		[DebuggerHidden] // 0x0000000189986BC0-0x0000000189986C00
		// [XID] // 0x0000000189986BC0-0x0000000189986C00
		public IEnumerator RequestComboLogin(string body, Action<string> callback, Action timeoutCallback, float timeOut = 5f /* Metadata: 0x00AE1F40 */) => default; // 0x000000018641BDB0-0x000000018641BED0
		[DebuggerHidden] // 0x00000001899919D0-0x0000000189991A10
		// [XID] // 0x00000001899919D0-0x0000000189991A10
		public IEnumerator RequestPS4ComboLogin(string body, Action<string> callback, Action timeoutCallback) => default; // 0x000000018641BFF0-0x000000018641C100
		[DebuggerHidden] // 0x000000018999C3C0-0x000000018999C400
		// [XID] // 0x000000018999C3C0-0x000000018999C400
		public IEnumerator RequestComboConfig(Action<string> callback, Action timeoutCallback = null) => default; // 0x000000018641BC80-0x000000018641BDB0
		[DebuggerHidden] // 0x00000001899A6D70-0x00000001899A6DB0
		// [XID] // 0x00000001899A6D70-0x00000001899A6DB0
		public IEnumerator RequestCheckPopNotice(string requestString, Action<string> callback) => default; // 0x000000018641BB50-0x000000018641BC80
		[DebuggerHidden] // 0x00000001899B17A0-0x00000001899B17E0
		// [XID] // 0x00000001899B17A0-0x00000001899B17E0
		public IEnumerator RequestCompareProtocolVersion(string major, string minimum, Action<string> callback, Action timeoutCallback = null) => default; // 0x000000018641BED0-0x000000018641BFF0
		// [XID] // 0x0000000189AA4DA0-0x0000000189AA4DC0
		public void ComboPing() {} // 0x000000018641B1B0-0x000000018641B380
		// [XID] // 0x00000001899C3860-0x00000001899C3880
		public void StopPing() {} // 0x000000018641C200-0x000000018641C2F0
		// [XID] // 0x0000000189A9D570-0x0000000189A9D590
		private void OnGetPing(string responseString) {} // 0x000000018641B5D0-0x000000018641BB50
		// [XID] // 0x00000001899D2380-0x00000001899D23A0
		private void OnGetPingTimeOut() {} // 0x000000018641B460-0x000000018641B5D0
		[DebuggerHidden] // 0x00000001899D9AE0-0x00000001899D9B20
		// [XID] // 0x00000001899D9AE0-0x00000001899D9B20
		public IEnumerator RequestPing(Action<string> callback, Action timeoutCallback = null) => default; // 0x000000018641C100-0x000000018641C200
	}
}
