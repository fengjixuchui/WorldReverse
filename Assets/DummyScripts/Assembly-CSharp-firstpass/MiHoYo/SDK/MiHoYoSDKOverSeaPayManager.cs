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
	public class MiHoYoSDKOverSeaPayManager : MiHoYoSDKBaseClass // TypeDefIndex: 8738
	{
		// Fields
		private const string PayVendorInfo = "MIHOYO_SDK_OVERSEA_PAY_VENDOR"; // Metadata: 0x00AE216D
		private string orderNumber; // 0x10
		private Action<string> payCallback; // 0x18
		private JSONNode gamePayInfo; // 0x20
		private Coroutine payCoroutine; // 0x28
		private Coroutine closeCoroutine; // 0x30
		private Action<string> priceTierCallback; // 0x38
		private static MiHoYoSDKOverSeaPayManager _instance; // 0x00
	
		// Nested types
		public enum PayVendor // TypeDefIndex: 8739
		{
			VISA = 0,
			ECMC = 1,
			AMEX = 2,
			JCB = 3,
			PAYPAL = 4
		}
	
		private enum OrderStatus // TypeDefIndex: 8740
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
		public MiHoYoSDKOverSeaPayManager() {} // 0x0000000185F4B7D0-0x0000000185F4B830
	
		// Methods
		// [XID] // 0x000000018980D6C0-0x000000018980D6E0
		public static MiHoYoSDKOverSeaPayManager Instance() => default; // 0x0000000185F48050-0x0000000185F48150
		// [XID] // 0x0000000189ADFE20-0x0000000189ADFE40
		public void Init() {} // 0x0000000185F47FB0-0x0000000185F48050
		// [XID] // 0x000000018981C840-0x000000018981C860
		public void RequestPriceTier(Action<string> callback, string currency = null) {} // 0x0000000185F4B130-0x0000000185F4B330
		// [XID] // 0x0000000189A3D920-0x0000000189A3D940
		public void GetProductList(string jsonString, Action<string> callback = null) {} // 0x0000000185F47C00-0x0000000185F47EF0
		// [XID] // 0x00000001897D0890-0x00000001897D08B0
		private void OnGetProductListError(Action<string> callback) {} // 0x0000000185F4A080-0x0000000185F4A200
		// [XID] // 0x0000000189832C60-0x0000000189832C80
		public void Close() {} // 0x0000000185F47710-0x0000000185F477E0
		// [XID] // 0x00000001896CCE00-0x00000001896CCE20
		public void SavePayVendor(PayVendor vendor) {} // 0x0000000185F4B4F0-0x0000000185F4B5D0
		// [XID] // 0x00000001898416C0-0x00000001898416E0
		public PayVendor GetPayVendor() => default; // 0x0000000185F47B10-0x0000000185F47C00
		// [XID] // 0x0000000189778010-0x0000000189778030
		private void StopCoroutine() {} // 0x0000000185F4B6A0-0x0000000185F4B7D0
		// [XID] // 0x0000000189AEF210-0x0000000189AEF230
		public void Pay(string jsonString, Action<string> callback) {} // 0x0000000185F4A700-0x0000000185F4AD10
		// [XID] // 0x00000001898576B0-0x00000001898576D0
		public void RequestPayPlat() {} // 0x0000000185F4AFB0-0x0000000185F4B130
		// [XID] // 0x0000000189B6D830-0x0000000189B6D850
		private void OnGetPayPlat(string responseString) {} // 0x0000000185F49120-0x0000000185F49BE0
		// [XID] // 0x0000000189866090-0x00000001898660B0
		private void OnGetPayPlatTimeOut() {} // 0x0000000185F49060-0x0000000185F49120
		// [XID] // 0x000000018986D8C0-0x000000018986D8E0
		public void ShowPayDialog(JSONObject vendors) {} // 0x0000000185F4B5D0-0x0000000185F4B6A0
		// [XID] // 0x0000000189874D50-0x0000000189874D70
		public void HidePayDialog() {} // 0x0000000185F47EF0-0x0000000185F47FB0
		// [XID] // 0x0000000189B05330-0x0000000189B05350
		private void OnPayCallbackFail(string msg = "" /* Metadata: 0x00AE2169 */) {} // 0x0000000185F4A3A0-0x0000000185F4A490
		// [XID] // 0x00000001899550C0-0x00000001899550E0
		private void OnPayCallbackCancel() {} // 0x0000000185F4A200-0x0000000185F4A3A0
		// [XID] // 0x00000001898D3D30-0x00000001898D3D50
		private void OnPayCallbackSuccess() {} // 0x0000000185F4A490-0x0000000185F4A630
		// [XID] // 0x0000000189761D00-0x0000000189761D20
		public void RequestCreateOrder(JSONNode payInfo, JSONNode vendor) {} // 0x0000000185F4AD10-0x0000000185F4AEA0
		// [XID] // 0x00000001897690F0-0x0000000189769110
		public void RequestQueryOrderStatus() {} // 0x0000000185F4B330-0x0000000185F4B4F0
		// [XID] // 0x00000001898A1160-0x00000001898A1180
		private void OnCheckOrderTimeout() {} // 0x0000000185F48270-0x0000000185F48320
		// [XID] // 0x00000001898A8600-0x00000001898A8620
		private void OnCheckOrder(string responseString) {} // 0x0000000185F48320-0x0000000185F487D0
		// [XID] // 0x00000001898CC3E0-0x00000001898CC400
		private void ClosePayDialog() {} // 0x0000000185F47650-0x0000000185F47710
		// [XID] // 0x00000001898B77E0-0x00000001898B7800
		private void OnCreateOrder(string responseString) {} // 0x0000000185F48910-0x0000000185F49060
		// [XID] // 0x00000001898BEE80-0x00000001898BEEA0
		private void OnCreateOrderTimeOut() {} // 0x0000000185F487D0-0x0000000185F48910
		// [XID] // 0x0000000189B4FB90-0x0000000189B4FBB0
		private string CreateFailPayCallback(string msg) => default; // 0x0000000185F47950-0x0000000185F47B10
		// [XID] // 0x0000000189B380B0-0x0000000189B380D0
		private void OnGetPriceTier(string responseString) {} // 0x0000000185F49D40-0x0000000185F4A080
		// [XID] // 0x0000000189B47320-0x0000000189B47340
		private void OnGetPriceTierTimeOut() {} // 0x0000000185F49BE0-0x0000000185F49D40
		// [XID] // 0x00000001898DD220-0x00000001898DD240
		private void OnPriceTierCallback(string response) {} // 0x0000000185F4A630-0x0000000185F4A700
		// [XID] // 0x0000000189BD19F0-0x0000000189BD1A10
		private bool CheckParameters(JSONNode payInfo) => default; // 0x0000000185F472A0-0x0000000185F47650
		[DebuggerHidden] // 0x00000001898EC680-0x00000001898EC6C0
		// [XID] // 0x00000001898EC680-0x00000001898EC6C0
		private IEnumerator ListPayPlat(JSONNode payInfo, Action<string> callback, Action timeOutCallback) => default; // 0x0000000185F48150-0x0000000185F48270
		[DebuggerHidden] // 0x00000001898F7140-0x00000001898F7180
		// [XID] // 0x00000001898F7140-0x00000001898F7180
		public IEnumerator CreatOrder(JSONNode payInfo, JSONNode vendor, Action<string> callback, Action timeOutCallback) => default; // 0x0000000185F477E0-0x0000000185F47950
		[DebuggerHidden] // 0x0000000189901990-0x00000001899019D0
		// [XID] // 0x0000000189901990-0x00000001899019D0
		public IEnumerator CheckOrder(string order_no, Action<string> callback, Action timeOutCallback) => default; // 0x0000000185F47150-0x0000000185F472A0
		[DebuggerHidden] // 0x000000018990C0F0-0x000000018990C130
		// [XID] // 0x000000018990C0F0-0x000000018990C130
		public IEnumerator RequestListPriceTier(string currency, Action<string> callback, Action timeOutCallback) => default; // 0x0000000185F4AEA0-0x0000000185F4AFB0
	}
}
