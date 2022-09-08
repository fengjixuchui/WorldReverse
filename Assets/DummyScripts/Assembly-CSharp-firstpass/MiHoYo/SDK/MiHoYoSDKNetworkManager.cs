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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKNetworkManager // TypeDefIndex: 8783
	{
		// Fields
		private Dictionary<string, string> _headers; // 0x10
		private static MiHoYoSDKNetworkManager _instance; // 0x00
		public const int TimeOutValue = -2147483648; // Metadata: 0x00AE225E
		public const int ExceptionValue = -2147483647; // Metadata: 0x00AE2262
	
		// Properties
		public static MiHoYoSDKNetworkManager Instance { /* [XID] */ /* 0x000000018980B2E0-0x000000018980B300 */ get => default; } // 0x0000000185F3D8A0-0x0000000185F3D9A0 
	
		// Constructors
		public MiHoYoSDKNetworkManager() {} // 0x0000000185F3D830-0x0000000185F3D8A0
	
		// Methods
		// [XID] // 0x000000018986D8A0-0x000000018986D8C0
		private void SharedHeaders() {} // 0x0000000185F3D340-0x0000000185F3D830
		// [XID] // 0x0000000189874D30-0x0000000189874D50
		public Dictionary<string, string> GetHeaders() => default; // 0x0000000185F3BAD0-0x0000000185F3BB70
		// [XID] // 0x000000018987C820-0x000000018987C840
		public static void SetGameKey(string gameKey) {} // 0x0000000185F3D010-0x0000000185F3D170
		// [XID] // 0x00000001898838D0-0x00000001898838F0
		public static void SetLanguage() {} // 0x0000000185F3D170-0x0000000185F3D340
		[DebuggerHidden] // 0x000000018988B0B0-0x000000018988B100
		// [IDTag] // 0x000000018988B0B0-0x000000018988B100
		// [XID] // 0x000000018988B0B0-0x000000018988B100
		public IEnumerator Post(string requestUrl, string bodyString, Dictionary<string, string> headers, Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185F3C9E0-0x0000000185F3CB60
		[DebuggerHidden] // 0x0000000189898440-0x0000000189898490
		// [IDTag] // 0x0000000189898440-0x0000000189898490
		// [XID] // 0x0000000189898440-0x0000000189898490
		public IEnumerator Post(string requestUrl, string bodyString, Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185F3CEA0-0x0000000185F3D010
		[DebuggerHidden] // 0x00000001898A5BE0-0x00000001898A5C30
		// [IDTag] // 0x00000001898A5BE0-0x00000001898A5C30
		// [XID] // 0x00000001898A5BE0-0x00000001898A5C30
		public IEnumerator Post(string requestUrl, string bodyString, Action<string> callback, Action timeoutCallback = null, string extHeaders = null) => default; // 0x0000000185F3CB60-0x0000000185F3CCF0
		[DebuggerHidden] // 0x00000001898B2E60-0x00000001898B2EB0
		// [IDTag] // 0x00000001898B2E60-0x00000001898B2EB0
		// [XID] // 0x00000001898B2E60-0x00000001898B2EB0
		public IEnumerator Post(string requestUrl, string bodyString, Action<string> callback, Action timeoutCallback = null, float timeoutSecond = 5f /* Metadata: 0x00AE2245 */, int retryTime = 3 /* Metadata: 0x00AE2249 */) => default; // 0x0000000185F3CCF0-0x0000000185F3CEA0
		[DebuggerHidden] // 0x00000001898C0910-0x00000001898C0960
		// [IDTag] // 0x00000001898C0910-0x00000001898C0960
		// [XID] // 0x00000001898C0910-0x00000001898C0960
		public IEnumerator Post(string requestUrl, Dictionary<string, string> bodyDic, Action<string> callback, Action timeoutCallback = null) => default; // 0x0000000185F3C870-0x0000000185F3C9E0
		[DebuggerHidden] // 0x00000001898CDEA0-0x00000001898CDEF0
		// [IDTag] // 0x00000001898CDEA0-0x00000001898CDEF0
		// [XID] // 0x00000001898CDEA0-0x00000001898CDEF0
		public IEnumerator Get(string requestUrl, JSONObject query, Action<string> callback, Action timeoutCallback = null, bool checkMD5 = false /* Metadata: 0x00AE224D */) => default; // 0x0000000185F3BF60-0x0000000185F3C0F0
		[DebuggerHidden] // 0x00000001898DB7B0-0x00000001898DB800
		// [IDTag] // 0x00000001898DB7B0-0x00000001898DB800
		// [XID] // 0x00000001898DB7B0-0x00000001898DB800
		public IEnumerator Get(string requestUrl, JSONObject query, Action<string> callback, Action timeoutCallback, float timeoutSecond, int retryTime) => default; // 0x0000000185F3BDB0-0x0000000185F3BF60
		// [XID] // 0x00000001898E9B10-0x00000001898E9B30
		public void PostRequest(string requestUrl, string bodyString, Action<NetworkResponseModel> callback, float timeoutSecond = 5f /* Metadata: 0x00AE224E */, int retryTime = 3 /* Metadata: 0x00AE2252 */) {} // 0x0000000185F3C630-0x0000000185F3C870
		// [XID] // 0x00000001898F0FA0-0x00000001898F0FC0
		public void GetRequest(string requestUrl, JSONObject query, Action<NetworkResponseModel> callback, float timeoutSecond = 5f /* Metadata: 0x00AE2256 */, int retryTime = 3 /* Metadata: 0x00AE225A */) {} // 0x0000000185F3BB70-0x0000000185F3BDB0
		// [XID] // 0x00000001898F89D0-0x00000001898F89F0
		private NetworkResponseModel OnGetCallback(string responseString) => default; // 0x0000000185F3C1D0-0x0000000185F3C520
		// [XID] // 0x000000018978E5C0-0x000000018978E5E0
		private NetworkResponseModel OnGetTimeOut() => default; // 0x0000000185F3C520-0x0000000185F3C630
		// [XID] // 0x0000000189907930-0x0000000189907950
		private void OnCallback(Action<NetworkResponseModel> callback, NetworkResponseModel response) {} // 0x0000000185F3C0F0-0x0000000185F3C1D0
	}
}
