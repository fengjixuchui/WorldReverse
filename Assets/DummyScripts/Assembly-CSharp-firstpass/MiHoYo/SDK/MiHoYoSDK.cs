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
	public class MiHoYoSDK : MiHoYoBaseSDK // TypeDefIndex: 8582
	{
		// Fields
		private static MiHoYoSDK _instance; // 0x00
		public static readonly string asbPath; // 0x10
	
		// Events
		public event Action<string> MiHoYoSDKShowTextNotification;
		public static event Action<string> MiHoYoSDKLogNotification;
	
		// Constructors
		public MiHoYoSDK() {} // 0x00000001859F2190-0x00000001859F2250
		static MiHoYoSDK() {} // 0x00000001859F2120-0x00000001859F2190
	
		// Methods
		// [XID] // 0x00000001897E07E0-0x00000001897E0800
		public static MiHoYoSDK Instance() => default; // 0x00000001859F1520-0x00000001859F1860
		// [XID] // 0x00000001897F7200-0x00000001897F7220
		public void OnShowTextNotification(string msg) {} // 0x00000001859F1C50-0x00000001859F1D10
		// [XID] // 0x0000000189635B10-0x0000000189635B30
		public static void OnMiHoYoSDKLogNotification(string msg) {} // 0x00000001859F1B40-0x00000001859F1C50
		// [XID] // 0x0000000189814DB0-0x0000000189814DD0
		public override void Init(Action<string> callback, bool gameDebug = false /* Metadata: 0x00ADFBD5 */) {} // 0x00000001859F13D0-0x00000001859F1520
		// [XID] // 0x000000018981C860-0x000000018981C880
		public override string InvokeReturn(string funcName, string args = null) => default; // 0x00000001859F1860-0x00000001859F19C0
		// [XID] // 0x0000000189823D20-0x0000000189823D40
		public override void Invoke(string funcName, string args = null, Action<string> callback = null) {} // 0x00000001859F19C0-0x00000001859F1B40
		// [XID] // 0x000000018982B7E0-0x000000018982B800
		public override void ReportAction(int actionId, string actionName, string cBody, string level) {} // 0x00000001859F1D10-0x00000001859F1ED0
	}
}
