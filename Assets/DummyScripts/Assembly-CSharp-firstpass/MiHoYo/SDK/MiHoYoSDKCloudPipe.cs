/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKCloudPipe // TypeDefIndex: 8569
	{
		// Fields
		public const string InvokeFunc = "invoke"; // Metadata: 0x00ADFB7C
		public const string InvokeReturnFunc = "invoke_return"; // Metadata: 0x00ADFB86
		public const string WebFunc = "webview"; // Metadata: 0x00ADFB97
		private static MiHoYoSDKCloudPipe _instance; // 0x00
		public const string pipeSalt = "OK20kydiRu47rOH7HNXzA12xxtlYVOUx"; // Metadata: 0x00ADFBA2
	
		// Properties
		public static MiHoYoSDKCloudPipe Instance { /* [XID] */ /* 0x0000000189BCB500-0x0000000189BCB520 */ get => default; } // 0x0000000186415C70-0x0000000186415E30 
	
		// Nested types
		[Serializable]
		public class PipeSendData // TypeDefIndex: 8570
		{
			// Fields
			public string f; // 0x10
			public string p; // 0x18
			public int i; // 0x20
	
			// Constructors
			public PipeSendData() {} // 0x000000018641C3E0-0x000000018641C450
		}
	
		[Serializable]
		public class PipeParameters // TypeDefIndex: 8571
		{
			// Fields
			public string f; // 0x10
			public string p; // 0x18
	
			// Constructors
			public PipeParameters() {} // 0x000000018641C360-0x000000018641C3E0
		}
	
		// Constructors
		public MiHoYoSDKCloudPipe() {} // 0x0000000186415C10-0x0000000186415C70
	
		// Methods
		// [XID] // 0x0000000189BD2B40-0x0000000189BD2B60
		public void Init() {} // 0x00000001864150B0-0x0000000186415150
		// [XID] // 0x00000001896D0AE0-0x00000001896D0B00
		public void SendData(string typeName, string functionName, string parameters = null, int callbackIndex = -1 /* Metadata: 0x00ADFB70 */) {} // 0x0000000186415940-0x0000000186415A80
		// [XID] // 0x00000001895E6BF0-0x00000001895E6C10
		public void SendParamData(string functionName, string parameters, int callbackIndex = -1 /* Metadata: 0x00ADFB74 */) {} // 0x0000000186415A80-0x0000000186415C10
		// [XID] // 0x00000001895EE6B0-0x00000001895EE6D0
		public static void OnGetPipeData(string dataString) {} // 0x00000001864153C0-0x0000000186415530
		// [XID] // 0x00000001895F5FD0-0x00000001895F5FF0
		public static void OnGetResponse(object data) {} // 0x0000000186415530-0x0000000186415940
		// [XID] // 0x00000001895FD370-0x00000001895FD390
		public static void InvokeCallback(int ret, string msg, string data, int index = -1 /* Metadata: 0x00ADFB78 */) {} // 0x0000000186415150-0x00000001864153C0
		// [XID] // 0x0000000189604D10-0x0000000189604D30
		public static string GetString(string dataString) => default; // 0x0000000186414FB0-0x00000001864150B0
	}
}
