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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKDllCloudWin : MonoBehaviour // TypeDefIndex: 8573
	{
		// Fields
		private static object[] parameters2; // 0x00
		private static object[] parameters1; // 0x08
		private static object[] parameters0; // 0x10
		private static System.Type miHoYoDll; // 0x18
		public static List<Action> actionList; // 0x20
		private static MiHoYoSDKDllCloudWin _instance; // 0x28
		private static Action<string> initCallback; // 0x30
		private static Dictionary<int, Action<string>> invokeCallbacks; // 0x38
		private static Dictionary<int, Action<string>> invokeReturnCallbacks; // 0x40
		public static int index; // 0x48
		private static string[] whiteFuncList; // 0x50
	
		// Events
		public event OnDestroyDelegate DLLDestroyHandler;
	
		// Nested types
		public delegate void OnDestroyDelegate(); // TypeDefIndex: 8574; 0x0000000184E0E970-0x0000000184E0EAD0
	
		// Constructors
		public MiHoYoSDKDllCloudWin() {} // 0x0000000184DEC0B0-0x0000000184DEC110
		static MiHoYoSDKDllCloudWin() {} // 0x0000000184DEBD20-0x0000000184DEC0B0
	
		// Methods
		// [XID] // 0x0000000189A1A3F0-0x0000000189A1A410
		public static void AddAction(Action job) {} // 0x0000000184DE9F80-0x0000000184DEA110
		// [XID] // 0x0000000189643B00-0x0000000189643B20
		public static MiHoYoSDKDllCloudWin Instance() => default; // 0x0000000184DEA710-0x0000000184DEA900
		// [XID] // 0x000000018965A0B0-0x000000018965A0D0
		private void Awake() {} // 0x0000000184DEA430-0x0000000184DEA4D0
		// [XID] // 0x0000000189661820-0x0000000189661840
		private void Start() {} // 0x0000000184DEB400-0x0000000184DEB4A0
		// [XID] // 0x0000000189B8EE10-0x0000000189B8EE30
		private void OnDestroy() {} // 0x0000000184DEAEE0-0x0000000184DEAF90
		[DebuggerHidden] // 0x0000000189670ED0-0x0000000189670F10
		// [XID] // 0x0000000189670ED0-0x0000000189670F10
		public IEnumerator AddTime(float seconds, Action action) => default; // 0x0000000184DEA2F0-0x0000000184DEA430
		// [XID] // 0x000000018967B5C0-0x000000018967B5E0
		private void Update() {} // 0x0000000184DEB4A0-0x0000000184DEB740
		// [XID] // 0x000000018962F6C0-0x000000018962F6E0
		private static bool WhiteFuncCheck(string funcName, out string r, string args = null, Action<string> callback = null) {
			r = default;
			return default;
		} // 0x0000000184DEB740-0x0000000184DEBD20
		// [XID] // 0x000000018968A8E0-0x000000018968A900
		public static string Invoke(string funcName, string args = null, Action<string> callback = null) => default; // 0x0000000184DEAC30-0x0000000184DEAEE0
		// [XID] // 0x0000000189692720-0x0000000189692740
		public static string InvokeReturn(string funcName, string args = null) => default; // 0x0000000184DEA900-0x0000000184DEAC30
		// [XID] // 0x0000000189699950-0x0000000189699970
		public static void OnInitResponse(string response) {} // 0x0000000184DEB260-0x0000000184DEB400
		// [XID] // 0x00000001896A0F70-0x00000001896A0F90
		public static void OnGetInvokeResponse(string response) {} // 0x0000000184DEAF90-0x0000000184DEB260
		// [XID] // 0x0000000189637220-0x0000000189637240
		public static void AddCallback(Action<string> callback) {} // 0x0000000184DEA110-0x0000000184DEA200
		// [XID] // 0x00000001896AF730-0x00000001896AF750
		public static void AddInvoreReturnCallback(Action<string> callback) {} // 0x0000000184DEA200-0x0000000184DEA2F0
		// [XID] // 0x00000001896B6F90-0x00000001896B6FB0
		public static void Init(Action<string> callback, bool gameDebug = false /* Metadata: 0x00ADFBC6 */) {} // 0x0000000184DEA5F0-0x0000000184DEA710
		// [XID] // 0x00000001896BE0A0-0x00000001896BE0C0
		public static string cloud_set_launch_parameters(string parameters) => default; // 0x0000000184DEC490-0x0000000184DEC550
		// [XID] // 0x0000000189A21AD0-0x0000000189A21AF0
		public static string cloud_get_data(string key, int callbackIndex) => default; // 0x0000000184DEC230-0x0000000184DEC300
		// [XID] // 0x00000001896CCFE0-0x00000001896CD000
		public static string cloud_set_data(string saveData) => default; // 0x0000000184DEC3D0-0x0000000184DEC490
		// [XID] // 0x00000001896D4480-0x00000001896D44A0
		public static string cloud_save_image(string jsonString, int callbackIndex) => default; // 0x0000000184DEC300-0x0000000184DEC3D0
		// [XID] // 0x00000001896DBCC0-0x00000001896DBCE0
		public static string cloud_transmit_data(string data, int callbackIndex) => default; // 0x0000000184DEC550-0x0000000184DEC640
		// [XID] // 0x00000001896E3400-0x00000001896E3420
		public static string launch_get_disk_free_space() => default; // 0x0000000184DEC640-0x0000000184DEC700
		// [XID] // 0x00000001896D9990-0x00000001896D99B0
		private static void CheckPlatform() {} // 0x0000000184DEA4D0-0x0000000184DEA5F0
	}
}
