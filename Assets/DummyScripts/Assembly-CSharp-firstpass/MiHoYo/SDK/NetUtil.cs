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
using UnityEngine;
using UnityEngine.Networking;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public static class NetUtil // TypeDefIndex: 8918
	{
		// Nested types
		[Serializable]
		private class ResponseModel // TypeDefIndex: 8919
		{
			// Fields
			public int retcode; // 0x10
			public string message; // 0x18
	
			// Constructors
			public ResponseModel() {} // 0x0000000185A8A470-0x0000000185A8A4D0
		}
	
		// Methods
		[DebuggerHidden] // 0x0000000189715890-0x00000001897158D0
		// [XID] // 0x0000000189715890-0x00000001897158D0
		public static IEnumerator WWWRequestWithRetry(string url, Action<string> callback, Action timeOutCallback, string jsonBody = null, Dictionary<string, string> headers = null, Dictionary<string, string> formDict = null, float timeoutSecond = 5f /* Metadata: 0x00AE4E44 */, int retryTime = 3 /* Metadata: 0x00AE4E48 */, bool checkMD5 = false /* Metadata: 0x00AE4E4C */) => default; // 0x0000000185A84FA0-0x0000000185A85180
		// [XID] // 0x00000001897202C0-0x00000001897202E0
		private static WWWForm CreateWWWForm(Dictionary<string, string> formDict) => default; // 0x0000000185A84DA0-0x0000000185A84FA0
	}
}
