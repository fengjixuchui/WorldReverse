/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoBaseSDK : MonoBehaviour // TypeDefIndex: 8580
	{
		// Fields
		private const string CanvasName = "MiHoYoSDK"; // Metadata: 0x00ADFBC8
		public static bool isCloudPlat; // 0x00
		private static MiHoYoSDK _baseInstance; // 0x08
		public Action<string> MiHoYoSDKNotification; // 0x18
		public Action<string> MiHoYoSDKDownloadNotification; // 0x20
		public Action<InputField> MiHoYoSDKAddInputField; // 0x28
	
		// Constructors
		public MiHoYoBaseSDK() {} // 0x00000001859E4C90-0x00000001859E4CF0
		static MiHoYoBaseSDK() {} // 0x00000001859E4C30-0x00000001859E4C90
	
		// Methods
		// [XID] // 0x0000000189778350-0x0000000189778370
		public static MiHoYoSDK BaseInstance() => default; // 0x00000001859E4180-0x00000001859E4370
		// [XID] // 0x000000018977F7C0-0x000000018977F7E0
		public static bool IsExists() => default; // 0x00000001859E4730-0x00000001859E4830
		// [XID] // 0x0000000189787210-0x0000000189787230
		public static void SetCloudPlat(bool flag) {} // 0x00000001859E4B60-0x00000001859E4C30
		// [XID] // 0x000000018978E7E0-0x000000018978E800
		public void OnNotificationCallback(string message) {} // 0x00000001859E49B0-0x00000001859E4A70
		// [XID] // 0x0000000189795ED0-0x0000000189795EF0
		public void OnDownloadNotificationCallback(string message) {} // 0x00000001859E48F0-0x00000001859E49B0
		// [XID] // 0x000000018979E150-0x000000018979E170
		public void OnAddInputField(InputField inputField) {} // 0x00000001859E4830-0x00000001859E48F0
		// [XID] // 0x00000001897A5720-0x00000001897A5740
		public virtual void Init(Action<string> callback, bool gameDebug = false /* Metadata: 0x00ADFBC7 */) {} // 0x00000001859E44A0-0x00000001859E4570
		// [XID] // 0x00000001897ACCF0-0x00000001897ACD10
		public virtual string InvokeReturn(string funcName, string args = null) => default; // 0x00000001859E4570-0x00000001859E4650
		// [XID] // 0x00000001897B4A70-0x00000001897B4A90
		public virtual void Invoke(string funcName, string args = null, Action<string> callback = null) {} // 0x00000001859E4650-0x00000001859E4730
		// [XID] // 0x00000001897BC9A0-0x00000001897BC9C0
		public virtual void CheckPlatform() {} // 0x00000001859E4370-0x00000001859E44A0
		// [XID] // 0x00000001897C3E30-0x00000001897C3E50
		public virtual void ReportAction(int actionId, string actionName, string cBody, string level) {} // 0x00000001859E4A70-0x00000001859E4B60
	}
}
