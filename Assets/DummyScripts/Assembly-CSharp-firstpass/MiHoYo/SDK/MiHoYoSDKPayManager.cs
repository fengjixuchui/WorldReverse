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
	public class MiHoYoSDKPayManager : MiHoYoSDKBaseClass // TypeDefIndex: 8747
	{
		// Fields
		private const string PayPlatInfo = "MIHOYO_SDK_PAY_TYPE"; // Metadata: 0x00AE21DA
		private string orderNumber; // 0x10
		private Action<string> payCallback; // 0x18
		private JSONNode gamePayInfo; // 0x20
		private string weixinUrl; // 0x28
		private string aliUrl; // 0x30
		private DateTime weixinUrlDateTime; // 0x38
		private DateTime aliUrlDateTime; // 0x48
		private PayPlat currentPayPlat; // 0x58
		private const int OverdueTime = 30; // Metadata: 0x00AE21F1
		private Coroutine qrWeixinCoroutine; // 0x60
		private Coroutine qrAliCoroutine; // 0x68
		private Coroutine closeCoroutine; // 0x70
		private bool isRealName; // 0x78
		private static MiHoYoSDKPayManager _instance; // 0x00
	
		// Nested types
		private enum OrderStatus // TypeDefIndex: 8748
		{
			Init = 0,
			Prepay = 1,
			Verify = 2,
			Payed = 3,
			Refund = 4,
			InTransit = 5,
			GetBack = 6,
			Finish = 900,
			Timeout = 901,
			Cancel = 902,
			Reject = 903
		}
	
		// Constructors
		public MiHoYoSDKPayManager() {} // 0x0000000186259250-0x00000001862592C0
	
		// Methods
		// [XID] // 0x0000000189A3A330-0x0000000189A3A350
		public static MiHoYoSDKPayManager Instance() => default; // 0x00000001862568D0-0x00000001862569D0
		// [XID] // 0x00000001899A4830-0x00000001899A4850
		public void Init() {} // 0x0000000186256830-0x00000001862568D0
		// [XID] // 0x0000000189A49170-0x0000000189A49190
		public void Close() {} // 0x0000000186256290-0x0000000186256360
		// [XID] // 0x0000000189A50B00-0x0000000189A50B20
		public void SavePayPlat(PayPlat plat) {} // 0x0000000186258D90-0x0000000186258E70
		// [XID] // 0x000000018971ED50-0x000000018971ED70
		public PayPlat GetPayPlat() => default; // 0x0000000186256680-0x0000000186256770
		// [XID] // 0x0000000189A5FC00-0x0000000189A5FC20
		private void StopCoroutine() {} // 0x0000000186258F30-0x00000001862590B0
		// [XID] // 0x0000000189A675E0-0x0000000189A67600
		public void Pay(string jsonString, Action<string> callback) {} // 0x0000000186258310-0x00000001862586A0
		// [XID] // 0x000000018960E6C0-0x000000018960E6E0
		public void ShowPayDialog() {} // 0x0000000186258E70-0x0000000186258F30
		// [XID] // 0x0000000189A40D10-0x0000000189A40D30
		public void HidePayDialog() {} // 0x0000000186256770-0x0000000186256830
		// [XID] // 0x0000000189BB7B20-0x0000000189BB7B40
		private void OnBindCallback(string responseString) {} // 0x00000001862569D0-0x0000000186256C60
		// [XID] // 0x0000000189A856E0-0x0000000189A85700
		public void RequestRealNameAuth() {} // 0x0000000186258C60-0x0000000186258D90
		// [XID] // 0x0000000189A90570-0x0000000189A90590
		private void OnCloseRealName() {} // 0x00000001862574F0-0x00000001862575A0
		// [XID] // 0x0000000189A94390-0x0000000189A943B0
		private void OnRealNameSuccess(string name, string identity) {} // 0x0000000186258190-0x0000000186258310
		// [XID] // 0x0000000189A9BDD0-0x0000000189A9BDF0
		private void OnPayCallbackFail(string msg = "" /* Metadata: 0x00AE21D6 */) {} // 0x0000000186257F00-0x0000000186257FF0
		// [XID] // 0x0000000189A4FCA0-0x0000000189A4FCC0
		private void OnPayCallbackCancel() {} // 0x0000000186257D60-0x0000000186257F00
		// [XID] // 0x0000000189AAA7E0-0x0000000189AAA800
		private void OnPayCallbackSuccess() {} // 0x0000000186257FF0-0x0000000186258190
		// [XID] // 0x0000000189AB2570-0x0000000189AB2590
		public void RequestCreateOrder(PayPlat type, JSONNode payInfo) {} // 0x00000001862586A0-0x0000000186258960
		// [XID] // 0x0000000189AB9A90-0x0000000189AB9AB0
		private bool CheckQRCode(DateTime createTime) => default; // 0x0000000186256060-0x00000001862561D0
		// [XID] // 0x0000000189713600-0x0000000189713620
		public void RequestQueryWeixinOrderStatus() {} // 0x0000000186258AE0-0x0000000186258C60
		// [XID] // 0x00000001895E8EF0-0x00000001895E8F10
		public void RequestQueryAliOrderStatus() {} // 0x0000000186258960-0x0000000186258AE0
		// [XID] // 0x0000000189633DB0-0x0000000189633DD0
		private void UpdateWeixinQRCode() {} // 0x0000000186259180-0x0000000186259250
		// [XID] // 0x00000001898D41F0-0x00000001898D4210
		private void UpdateAliQRCode() {} // 0x00000001862590B0-0x0000000186259180
		// [XID] // 0x0000000189AE00C0-0x0000000189AE00E0
		private void OnCheckWeixinOrder(string response) {} // 0x0000000186257420-0x00000001862574F0
		// [XID] // 0x0000000189AE76D0-0x0000000189AE76F0
		private void OnCheckAliOrder(string response) {} // 0x0000000186256D10-0x0000000186256DE0
		// [XID] // 0x0000000189AEF3D0-0x0000000189AEF3F0
		private void OnCheckWeixinOrderTimeout() {} // 0x0000000186257370-0x0000000186257420
		// [XID] // 0x00000001896FD050-0x00000001896FD070
		private void OnCheckAliOrderTimeout() {} // 0x0000000186256C60-0x0000000186256D10
		// [XID] // 0x0000000189AFDD70-0x0000000189AFDD90
		private void OnCheckOrder(string responseString) {} // 0x0000000186256DE0-0x0000000186257370
		// [XID] // 0x0000000189B05570-0x0000000189B05590
		private void ClosePayDialog() {} // 0x00000001862561D0-0x0000000186256290
		// [XID] // 0x000000018966FFB0-0x000000018966FFD0
		private void OnCreateWeixinOrder(string responseString) {} // 0x0000000186257C10-0x0000000186257D60
		// [XID] // 0x0000000189B141D0-0x0000000189B141F0
		private void OnCreateAliOrder(string responseString) {} // 0x00000001862575A0-0x00000001862576F0
		// [XID] // 0x0000000189B1BA80-0x0000000189B1BAA0
		private string OnCreateOrder(string responseString) => default; // 0x00000001862577B0-0x0000000186257C10
		// [XID] // 0x0000000189B22FB0-0x0000000189B22FD0
		private void OnCreateOrderTimeOut() {} // 0x00000001862576F0-0x00000001862577B0
		// [XID] // 0x0000000189B2A6A0-0x0000000189B2A6C0
		private string CreateFailPayCallback(string msg) => default; // 0x00000001862564C0-0x0000000186256680
		[DebuggerHidden] // 0x0000000189B31BB0-0x0000000189B31BF0
		// [XID] // 0x0000000189B31BB0-0x0000000189B31BF0
		public IEnumerator CreatOrder(PayPlat type, JSONNode payInfo, Action<string> callback, Action timeOutCallback) => default; // 0x0000000186256360-0x00000001862564C0
		[DebuggerHidden] // 0x0000000189B3C150-0x0000000189B3C190
		// [XID] // 0x0000000189B3C150-0x0000000189B3C190
		public IEnumerator CheckOrder(string order_no, Action<string> callback, Action timeOutCallback) => default; // 0x0000000186255F10-0x0000000186256060
	}
}
