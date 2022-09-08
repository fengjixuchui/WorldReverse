/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AOT;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKBiliBiliManager : MonoBehaviour // TypeDefIndex: 8710
	{
		// Fields
		private const string GameId = "4963"; // Metadata: 0x00AE2090
		private const string AppKey = "fd1098c0489c4d00a08aa8a15e484d6c"; // Metadata: 0x00AE2098
		private const string ServerId = "4099"; // Metadata: 0x00AE20BC
		public static List<Action> actionList; // 0x00
		private JSONNode gamePayInfo; // 0x18
		private static Action<string> loginCallback; // 0x08
		private static Action<string> payCallback; // 0x10
		private static MiHoYoSDKBiliBiliInterface.LoginCallback bLoginCallback; // 0x18
		private static MiHoYoSDKBiliBiliInterface.PayCallback bPayCallback; // 0x20
		private static MiHoYoSDKBiliBiliInterface.AntiAddictionCallback bAntiAddictionCallback; // 0x28
		private static MiHoYoSDKBiliBiliManager _instance; // 0x30
	
		// Constructors
		public MiHoYoSDKBiliBiliManager() {} // 0x00000001859F1370-0x00000001859F13D0
		static MiHoYoSDKBiliBiliManager() {} // 0x00000001859F12E0-0x00000001859F1370
	
		// Methods
		// [XID] // 0x00000001896A1B60-0x00000001896A1B80
		public static MiHoYoSDKBiliBiliManager Instance() => default; // 0x00000001859EE570-0x00000001859EE760
		// [XID] // 0x0000000189B330F0-0x0000000189B33110
		private void Awake() {} // 0x00000001859EE080-0x00000001859EE330
		// [XID] // 0x0000000189B3ACB0-0x0000000189B3ACD0
		private void Update() {} // 0x00000001859F10A0-0x00000001859F12E0
		// [XID] // 0x0000000189B423F0-0x0000000189B42410
		public int Init(Action<string> callback) => default; // 0x00000001859EE450-0x00000001859EE570
		// [XID] // 0x0000000189B49EA0-0x0000000189B49EC0
		public void Login(Action<string> callback) {} // 0x00000001859EEEF0-0x00000001859EF080
		// [XID] // 0x0000000189B516C0-0x0000000189B516E0
		public void Logout() {} // 0x00000001859EF080-0x00000001859EF140
		// [XID] // 0x0000000189B58FA0-0x0000000189B58FC0
		public void OpenAntiAddiction() {} // 0x00000001859F0400-0x00000001859F0670
		// [XID] // 0x0000000189B605E0-0x0000000189B60600
		public void Pay(string jsonString, Action<string> callback) {} // 0x00000001859F0AB0-0x00000001859F1030
		[DebuggerHidden] // 0x0000000189B67DD0-0x0000000189B67E10
		// [XID] // 0x0000000189B67DD0-0x0000000189B67E10
		public IEnumerator CreatOrder(JSONNode payInfo, JSONNode specialInfo, Action<string> callback, Action timeOutCallback) => default; // 0x00000001859EE330-0x00000001859EE450
		// [XID] // 0x0000000189B723A0-0x0000000189B723C0
		private void OnCreateOrder(string responseString) {} // 0x00000001859EF5B0-0x00000001859EFCD0
		// [XID] // 0x0000000189928910-0x0000000189928930
		private void OnCreateOrderTimeOut() {} // 0x00000001859EF4B0-0x00000001859EF5B0
		// [MonoPInvokeCallback] // 0x0000000189B80BA0-0x0000000189B80C10
		// [XID] // 0x0000000189B80BA0-0x0000000189B80C10
		public static void LoginResultCallback(string buf, int buflen) {} // 0x00000001859EE760-0x00000001859EEEF0
		// [MonoPInvokeCallback] // 0x0000000189B8FA40-0x0000000189B8FAA0
		// [XID] // 0x0000000189B8FA40-0x0000000189B8FAA0
		public static void AntiAddictionCallback(string buf, int buflen) {} // 0x00000001859EDD70-0x00000001859EE080
		// [MonoPInvokeCallback] // 0x0000000189B9E410-0x0000000189B9E480
		// [XID] // 0x0000000189B9E410-0x0000000189B9E480
		public static void PayCallback(string buf, int buflen) {} // 0x00000001859F0670-0x00000001859F0AB0
		// [XID] // 0x0000000189BAD1E0-0x0000000189BAD200
		private static void OnCallback(int ret, string msg, Action<string> callback, JSONNode data = null) {} // 0x00000001859EF140-0x00000001859EF4B0
		// [XID] // 0x0000000189BB49C0-0x0000000189BB49E0
		private void OnInitSuccess(Action<string> callback) {} // 0x00000001859EFDC0-0x00000001859EFEB0
		// [XID] // 0x0000000189AE80B0-0x0000000189AE80D0
		private void OnInitFail(Action<string> callback) {} // 0x00000001859EFCD0-0x00000001859EFDC0
		// [XID] // 0x0000000189BC3CD0-0x0000000189BC3CF0
		private static void OnLoginSuccess(Action<string> callback, JSONNode data) {} // 0x00000001859F0070-0x00000001859F0160
		// [XID] // 0x00000001899C06C0-0x00000001899C06E0
		private static void OnLoginFail(Action<string> callback, string msg = "Login Failed" /* Metadata: 0x00AE207C */) {} // 0x00000001859EFF90-0x00000001859F0070
		// [XID] // 0x00000001895FC4F0-0x00000001895FC510
		private static void OnLoginCancel(Action<string> callback) {} // 0x00000001859EFEB0-0x00000001859EFF90
		// [XID] // 0x0000000189BDA010-0x0000000189BDA030
		private static void OnPayFail(Action<string> callback, string msg = "" /* Metadata: 0x00AE208C */) {} // 0x00000001859F0240-0x00000001859F0320
		// [XID] // 0x00000001895E6B90-0x00000001895E6BB0
		private static void OnPayCancel(Action<string> callback) {} // 0x00000001859F0160-0x00000001859F0240
		// [XID] // 0x0000000189603E90-0x0000000189603EB0
		private static void OnPaySuccess(Action<string> callback) {} // 0x00000001859F0320-0x00000001859F0400
	}
}
