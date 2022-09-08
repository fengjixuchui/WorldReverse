/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKComboManager : MiHoYoSDKBaseClass // TypeDefIndex: 8668
	{
		// Fields
		private Action<string> loginCallback; // 0x10
		private Action<string> protocolCallback; // 0x18
		private JSONObject successLoginCallbackModel; // 0x20
		public bool _isBind; // 0x28
		public JSONNode comboUserModel; // 0x30
		private const string USER_AGREEMENT_SHOW_FLAG = "MIHOYOSDK_USER_AGREEMENT_SHOW_FLAG_"; // Metadata: 0x00AE1EEE
		private const string PROTOCOL_VERSION = "MIHOYOSDK_PROTOCOL_VERSION_"; // Metadata: 0x00AE1F15
		private static MiHoYoSDKComboManager _instance; // 0x00
	
		// Nested types
		private enum UserAgreementResult // TypeDefIndex: 8669
		{
			Refuse = -1,
			Agree = 0,
			UnShow = 1
		}
	
		// Constructors
		public MiHoYoSDKComboManager() {} // 0x000000018641B140-0x000000018641B1B0
	
		// Methods
		// [XID] // 0x0000000189838BC0-0x0000000189838BE0
		public static MiHoYoSDKComboManager Instance() => default; // 0x0000000186416F00-0x0000000186416FE0
		// [XID] // 0x00000001898400E0-0x0000000189840100
		public void Init() {} // 0x0000000186416D70-0x0000000186416F00
		// [XID] // 0x0000000189A0F180-0x0000000189A0F1A0
		private void Dealloc() {} // 0x00000001864169C0-0x0000000186416A80
		// [XID] // 0x0000000189A167E0-0x0000000189A16800
		public void Login(Action<string> callback) {} // 0x0000000186416FE0-0x00000001864172B0
		// [XID] // 0x0000000189AB23D0-0x0000000189AB23F0
		public void Pay(string jsonString, Action<string> callback) {} // 0x000000018641A340-0x000000018641A620
		// [XID] // 0x000000018985D280-0x000000018985D2A0
		public void Logout(Action<string> callback) {} // 0x0000000186417380-0x0000000186417450
		// [XID] // 0x0000000189864C70-0x0000000189864C90
		public void LogoutWithoutConfirm(Action<string> callback) {} // 0x00000001864172B0-0x0000000186417380
		// [XID] // 0x000000018986C200-0x000000018986C220
		public void SwitchRole(Action<string> callback) {} // 0x000000018641AFA0-0x000000018641B140
		// [XID] // 0x0000000189A36320-0x0000000189A36340
		public void Exit(Action<string> callback) {} // 0x0000000186416A80-0x0000000186416B50
		// [XID] // 0x0000000189883B50-0x0000000189883B70
		public void Bind(string region, Action<string> callback, BIND_TYPE type = BIND_TYPE.NORMAL /* Metadata: 0x00AE1EE9 */) {} // 0x0000000186416530-0x0000000186416670
		// [XID] // 0x0000000189882300-0x0000000189882320
		public void BeforeVerify(Action<string> callback) {} // 0x0000000186415FC0-0x0000000186416530
		// [IDTag] // 0x0000000189889910-0x0000000189889950
		// [XID] // 0x0000000189889910-0x0000000189889950
		public void ShowUserAgreement(string jsonString, Action<string> callback) {} // 0x000000018641ACF0-0x000000018641AFA0
		// [IDTag] // 0x0000000189893EA0-0x0000000189893EE0
		// [XID] // 0x0000000189893EA0-0x0000000189893EE0
		public void ShowUserAgreement(Action<string> callback) {} // 0x000000018641AAB0-0x000000018641ACF0
		// [XID] // 0x0000000189A6AC20-0x0000000189A6AC40
		public void RequestProtocolVersion() {} // 0x000000018641A620-0x000000018641A930
		// [XID] // 0x00000001897B1DD0-0x00000001897B1DF0
		private void ShowProtocolView(bool isUpdate = false /* Metadata: 0x00AE1EED */) {} // 0x000000018641A930-0x000000018641AAB0
		// [XID] // 0x00000001896D0600-0x00000001896D0620
		private void OnAcceptUserAgreement() {} // 0x0000000186417450-0x00000001864176E0
		// [XID] // 0x00000001898B45C0-0x00000001898B45E0
		private void OnRefuseUserAgreement() {} // 0x000000018641A1A0-0x000000018641A340
		// [XID] // 0x00000001898BC3B0-0x00000001898BC3D0
		private void OnNoShowUserAgreement(Action<string> callback) {} // 0x0000000186419D30-0x0000000186419EB0
		// [XID] // 0x0000000189A88E40-0x0000000189A88E60
		private string GetProtocolShowFlagKey() => default; // 0x0000000186416B50-0x0000000186416C60
		// [XID] // 0x0000000189A813C0-0x0000000189A813E0
		private string GetProtocolVersionKey() => default; // 0x0000000186416C60-0x0000000186416D70
		// [XID] // 0x00000001897B97F0-0x00000001897B9810
		private void OnBeforeVerifyFailed(Action<string> callback) {} // 0x00000001864176E0-0x0000000186417860
		// [XID] // 0x00000001898DA190-0x00000001898DA1B0
		private string CreateBeforeVerifyString(int ret, string msg, string url = null) => default; // 0x0000000186416670-0x0000000186416870
		// [XID] // 0x0000000189A464D0-0x0000000189A464F0
		private void OnLoginCallback(string responseString) {} // 0x0000000186419400-0x0000000186419C80
		// [XID] // 0x00000001898E9B30-0x00000001898E9B50
		private void OnBiliBiliLoginCallback(string responseString) {} // 0x0000000186417860-0x0000000186417E20
		// [XID] // 0x00000001898F0FC0-0x00000001898F0FE0
		private void OnComboLogin(string responseString) {} // 0x0000000186418430-0x00000001864192D0
		// [XID] // 0x0000000189A76210-0x0000000189A76230
		private void OnComboLoginTimeout() {} // 0x0000000186418310-0x0000000186418430
		// [XID] // 0x000000018985E620-0x000000018985E640
		private void OnFailLoginCallback(string response) {} // 0x00000001864192D0-0x0000000186419400
		// [XID] // 0x0000000189907950-0x0000000189907970
		private void OnLogout(string response) {} // 0x0000000186419C80-0x0000000186419D30
		// [XID] // 0x000000018990F280-0x000000018990F2A0
		private void OnComboConfig(string responseString) {} // 0x0000000186417EE0-0x0000000186418310
		// [XID] // 0x0000000189916B90-0x0000000189916BB0
		private void OnComboConfigTimeOut() {} // 0x0000000186417E20-0x0000000186417EE0
		// [XID] // 0x000000018991E2E0-0x000000018991E300
		public void OnProtocolAccept() {} // 0x0000000186419EB0-0x000000018641A0E0
		// [XID] // 0x0000000189925B10-0x0000000189925B30
		public void OnProtocolRefuse() {} // 0x000000018641A0E0-0x000000018641A1A0
		// [XID] // 0x0000000189A1DC60-0x0000000189A1DC80
		private string CreateFailCallback() => default; // 0x0000000186416870-0x00000001864169C0
	}
}
