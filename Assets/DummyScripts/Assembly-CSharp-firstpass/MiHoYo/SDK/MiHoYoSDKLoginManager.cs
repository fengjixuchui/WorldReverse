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
using TapTap.Sdk;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKLoginManager : MiHoYoSDKBaseClass // TypeDefIndex: 8723
	{
		// Fields
		private const string ACCOUNT_DATA_LIST_FILE = "ACCOUNT_DATA_LIST_FILE"; // Metadata: 0x00AE20FD
		private string phoneVerifyAction; // 0x10
		private MiHoYoSDKUserDataModel userData; // 0x18
		private Action<string> loginCallback; // 0x20
		private Action<string> qrcodeCallback; // 0x28
		private Action<string> logoutCallback; // 0x30
		private Action<string> exitCallback; // 0x38
		private Action refreshAccountInfoCallback; // 0x40
		private string accountName; // 0x48
		private string ticket; // 0x50
		private string raw; // 0x58
		private bool qrCodeScanFlag; // 0x60
		private string loginSuccessTips; // 0x68
		private Coroutine qrCoroutine; // 0x70
		private string accessToken; // 0x78
		private static MiHoYoSDKLoginManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKLoginManager() {} // 0x0000000184E0E590-0x0000000184E0E610
	
		// Methods
		// [XID] // 0x0000000189924680-0x00000001899246A0
		public static MiHoYoSDKLoginManager Instance() => default; // 0x0000000184E02590-0x0000000184E02690
		// [XID] // 0x00000001898A0F10-0x00000001898A0F30
		public void Init() {} // 0x0000000184E024D0-0x0000000184E02590
		// [XID] // 0x0000000189BD1C20-0x0000000189BD1C40
		public void Login(Action<string> callback) {} // 0x0000000184E02690-0x0000000184E02BE0
		// [XID] // 0x000000018993BF50-0x000000018993BF70
		public AccessToken GetTapTapAccessToken() => default; // 0x0000000184E02320-0x0000000184E023D0
		// [XID] // 0x0000000189688090-0x00000001896880B0
		public void RefreshAccountInfo(Action callback = null) {} // 0x0000000184E0B170-0x0000000184E0B360
		// [XID] // 0x00000001899496F0-0x0000000189949710
		private void OnRefreshAccountInfo(string responseString) {} // 0x0000000184E09600-0x0000000184E098D0
		// [XID] // 0x00000001896B48E0-0x00000001896B4900
		private void OnRefreshAccountInfoTimeOut() {} // 0x0000000184E09550-0x0000000184E09600
		// [XID] // 0x0000000189AA2150-0x0000000189AA2170
		private void ShowGameAlert(string content, string cancelTitle, string okTitle = null, Action callback = null) {} // 0x0000000184E0D6F0-0x0000000184E0D810
		// [XID] // 0x000000018995FD30-0x000000018995FD50
		public void ShowLoginView(DialogType dialogType = DialogType.DEFAULT /* Metadata: 0x00AE20EC */) {} // 0x0000000184E0D9A0-0x0000000184E0DB10
		// [XID] // 0x0000000189B482B0-0x0000000189B482D0
		public void ShowPhoneMessageView(MiHoYoSDKUserDataModel model = null) {} // 0x0000000184E0DB10-0x0000000184E0DBE0
		// [XID] // 0x000000018979A370-0x000000018979A390
		public void ShowAccountLoginView(MiHoYoSDKUserDataModel model = null) {} // 0x0000000184E0D620-0x0000000184E0D6F0
		// [XID] // 0x00000001898B17F0-0x00000001898B1810
		public void ShowTapTapLoginView(DialogType dialogType = DialogType.DEFAULT /* Metadata: 0x00AE20F0 */) {} // 0x0000000184E0DDA0-0x0000000184E0DF70
		// [XID] // 0x00000001897CE640-0x00000001897CE660
		public void ShowQRCodeLoginView(LOGIN_TYPE type = LOGIN_TYPE.ACCOUNT_PASSWORD /* Metadata: 0x00AE20F4 */) {} // 0x0000000184E0DBE0-0x0000000184E0DCB0
		// [XID] // 0x0000000189985310-0x0000000189985330
		public void ShowGuestDialog() {} // 0x0000000184E0D810-0x0000000184E0D9A0
		// [XID] // 0x000000018998CE20-0x000000018998CE40
		public void ShowRealNameAuthView() {} // 0x0000000184E0DCB0-0x0000000184E0DDA0
		// [XID] // 0x0000000189B16CC0-0x0000000189B16CE0
		private void OnCloseRealNameDialog() {} // 0x0000000184E037C0-0x0000000184E038D0
		// [XID] // 0x0000000189B1A7B0-0x0000000189B1A7D0
		public void SetQRScanResult(string jsonString, Action<string> callback) {} // 0x0000000184E0CC90-0x0000000184E0D620
		// [XID] // 0x0000000189B65160-0x0000000189B65180
		private IEnumerator ScanQRCode(string v1, string ticket, string v2, Action<string> onGetScanResult, Action onQRCodeLoginTimeOut) => default; // 0x0000000184E0CB70-0x0000000184E0CC90
		// [XID] // 0x00000001899AB8D0-0x00000001899AB8F0
		public void Close() {} // 0x0000000184E01260-0x0000000184E013E0
		// [XID] // 0x00000001899B31B0-0x00000001899B31D0
		private string CreateCloseCallback() => default; // 0x0000000184E013E0-0x0000000184E01530
		// [XID] // 0x0000000189A854B0-0x0000000189A854D0
		public void RequestVerifyMessage(string phone) {} // 0x0000000184E0C8A0-0x0000000184E0CA40
		// [XID] // 0x00000001899C1EF0-0x00000001899C1F10
		public void RequestLoginByPhone(string phone, string verifyCode) {} // 0x0000000184E0BAE0-0x0000000184E0BD40
		// [XID] // 0x00000001899C92C0-0x00000001899C92E0
		public void RequestLoginByAccount(string account, string password) {} // 0x0000000184E0B4D0-0x0000000184E0B690
		// [XID] // 0x0000000189BD5E00-0x0000000189BD5E20
		public void RequestLoginByFacebook(string token, string redirectUrl) {} // 0x0000000184E0B690-0x0000000184E0B8A0
		// [XID] // 0x00000001899D82D0-0x00000001899D82F0
		public void RequestLoginByTwitter(string token, string redirectUrl) {} // 0x0000000184E0C100-0x0000000184E0C310
		// [XID] // 0x0000000189ACA480-0x0000000189ACA4A0
		public void RequestLoginByTapTap(string kid, string macKey, string redirectUrl, bool no_regist, Action<string> callback, Action timeCallback) {} // 0x0000000184E0BD40-0x0000000184E0C100
		// [XID] // 0x00000001898A5E70-0x00000001898A5E90
		public void RequestRealNameAuth() {} // 0x0000000184E0C790-0x0000000184E0C8A0
		// [XID] // 0x0000000189B40A10-0x0000000189B40A30
		public void RequestLoginByGuest() {} // 0x0000000184E0B8A0-0x0000000184E0BAE0
		// [XID] // 0x00000001899F60F0-0x00000001899F6110
		public void RequestQRCodeForLogin() {} // 0x0000000184E0C310-0x0000000184E0C570
		// [XID] // 0x00000001899FD7D0-0x00000001899FD7F0
		public void RequestQueryQRCode() {} // 0x0000000184E0C570-0x0000000184E0C790
		// [XID] // 0x0000000189B95580-0x0000000189B955A0
		public string CreateLoginCallback() => default; // 0x0000000184E01530-0x0000000184E01E40
		// [XID] // 0x0000000189A0C4F0-0x0000000189A0C510
		private void CheckQRCodeRetCode(int ret) {} // 0x0000000184E01030-0x0000000184E01260
		// [XID] // 0x0000000189AEDE90-0x0000000189AEDEB0
		private void OnQRCodeLoginTimeOut() {} // 0x0000000184E092D0-0x0000000184E093B0
		// [XID] // 0x00000001899DA090-0x00000001899DA0B0
		private void OnQRCodeLoginResult(string responseString) {} // 0x0000000184E09050-0x0000000184E092D0
		// [XID] // 0x0000000189A22A40-0x0000000189A22A60
		private void OnQRCodeLoginConfirm() {} // 0x0000000184E08D20-0x0000000184E09050
		// [XID] // 0x0000000189A29C00-0x0000000189A29C20
		private void OnGetScanResult(string responseString) {} // 0x0000000184E074C0-0x0000000184E07770
		// [XID] // 0x0000000189864170-0x0000000189864190
		private void OnGetQRCode(string responseString) {} // 0x0000000184E05EC0-0x0000000184E06560
		// [XID] // 0x0000000189A38DB0-0x0000000189A38DD0
		private void OnGetQueryQRCode(string responseString) {} // 0x0000000184E06560-0x0000000184E074C0
		// [XID] // 0x0000000189A40360-0x0000000189A40380
		private void HideQRLoginDialog() {} // 0x0000000184E023D0-0x0000000184E024D0
		// [XID] // 0x00000001896FCF10-0x00000001896FCF30
		private void OnGetQRCodeTimeOut() {} // 0x0000000184E05E00-0x0000000184E05EC0
		// [XID] // 0x0000000189A4F230-0x0000000189A4F250
		private void OnGetAutoGuestLogin(string responseString) {} // 0x0000000184E051A0-0x0000000184E05460
		// [XID] // 0x0000000189A56840-0x0000000189A56860
		private void OnGetGuestLogin(string responseString) {} // 0x0000000184E05460-0x0000000184E05680
		// [XID] // 0x0000000189A5E4A0-0x0000000189A5E4C0
		public void OnGuestLogin() {} // 0x0000000184E07C10-0x0000000184E07D10
		// [XID] // 0x0000000189A65CA0-0x0000000189A65CC0
		private void OnLoginTipsHide(string responseString) {} // 0x0000000184E08960-0x0000000184E08A60
		// [XID] // 0x000000018960FD80-0x000000018960FDA0
		public void OnLoginCallback(string responseString) {} // 0x0000000184E08840-0x0000000184E08960
		// [XID] // 0x0000000189616930-0x0000000189616950
		private void StopCoroutine() {} // 0x0000000184E0DF70-0x0000000184E0E050
		// [XID] // 0x0000000189A7C5B0-0x0000000189A7C5D0
		public void Logout(Action<string> callback) {} // 0x0000000184E02CC0-0x0000000184E02E90
		// [XID] // 0x0000000189A83F10-0x0000000189A83F30
		public void LogoutWithoutConfirm(Action<string> callback) {} // 0x0000000184E02BE0-0x0000000184E02CC0
		// [XID] // 0x0000000189743C00-0x0000000189743C20
		public void SwitchRole(Action<string> callback) {} // 0x0000000184E0E050-0x0000000184E0E2A0
		// [XID] // 0x0000000189A92EB0-0x0000000189A92ED0
		public void Exit(Action<string> callback) {} // 0x0000000184E01E40-0x0000000184E01FE0
		// [XID] // 0x0000000189A9A9A0-0x0000000189A9A9C0
		private void OnLogout() {} // 0x0000000184E08A60-0x0000000184E08D20
		// [XID] // 0x0000000189AA1A10-0x0000000189AA1A30
		private void OnCancelLogout() {} // 0x0000000184E03610-0x0000000184E037C0
		// [XID] // 0x0000000189A2EA50-0x0000000189A2EA70
		private void OnExit() {} // 0x0000000184E03970-0x0000000184E03C00
		// [XID] // 0x000000018988B270-0x000000018988B290
		private void OnCancelExit() {} // 0x0000000184E03480-0x0000000184E03610
		// [XID] // 0x0000000189AB8300-0x0000000189AB8320
		private void ResetAccount() {} // 0x0000000184E0CA40-0x0000000184E0CB70
		// [XID] // 0x0000000189ABFDD0-0x0000000189ABFDF0
		private void OnTapTapLogin(string responseString) {} // 0x0000000184E099F0-0x0000000184E0A480
		// [XID] // 0x0000000189AC7900-0x0000000189AC7920
		private void OnBindTapTap(string responseString) {} // 0x0000000184E033D0-0x0000000184E03480
		// [XID] // 0x0000000189AAA020-0x0000000189AAA040
		private void OnTwitterLogin(string responseString) {} // 0x0000000184E0A7C0-0x0000000184E0B170
		// [XID] // 0x0000000189B92F40-0x0000000189B92F60
		private void OnFacebookLogin(string responseString) {} // 0x0000000184E03C00-0x0000000184E045B0
		// [XID] // 0x0000000189ADE6E0-0x0000000189ADE700
		private void OnGetAccountLogin(string responseString) {} // 0x0000000184E045B0-0x0000000184E051A0
		// [XID] // 0x0000000189AE60A0-0x0000000189AE60C0
		public void RequestActionTicket(string actionType, Action<string> callback, Action timeoutCallback) {} // 0x0000000184E0B360-0x0000000184E0B4D0
		// [XID] // 0x0000000189AED630-0x0000000189AED650
		private void OnAccountLoginGrantBack() {} // 0x0000000184E02E90-0x0000000184E02F40
		// [XID] // 0x0000000189A62680-0x0000000189A626A0
		private void OnGrantDeviceSuccess(MiHoYoSDKUserDataModel model) {} // 0x0000000184E07AE0-0x0000000184E07C10
		// [XID] // 0x0000000189AFC540-0x0000000189AFC560
		private void OnBindSafePhoneSuccess(MiHoYoSDKUserDataModel model) {} // 0x0000000184E032A0-0x0000000184E033D0
		// [XID] // 0x0000000189B03DB0-0x0000000189B03DD0
		public void OnBindMailByCodeSuccess() {} // 0x0000000184E031C0-0x0000000184E032A0
		// [XID] // 0x0000000189B0B4E0-0x0000000189B0B500
		public void OnBindMailByCodeSkip() {} // 0x0000000184E03080-0x0000000184E031C0
		// [XID] // 0x0000000189B12CC0-0x0000000189B12CE0
		public void OnShowLoginSuccessTips(LOGIN_TYPE type = LOGIN_TYPE.ACCOUNT_PASSWORD /* Metadata: 0x00AE20F8 */) {} // 0x0000000184E098D0-0x0000000184E099F0
		// [XID] // 0x0000000189B1A110-0x0000000189B1A130
		private void OnRealNameSuccess(string name, string identity) {} // 0x0000000184E093B0-0x0000000184E09550
		// [XID] // 0x0000000189B215E0-0x0000000189B21600
		public void OnGetLoginSuccessTips(bool isAutoLogin = false /* Metadata: 0x00AE20FC */) {} // 0x0000000184E05680-0x0000000184E05B30
		// [XID] // 0x0000000189B28D70-0x0000000189B28D90
		private void OnGetVerifyCode(string responseString) {} // 0x0000000184E07770-0x0000000184E07AE0
		// [XID] // 0x0000000189B30270-0x0000000189B30290
		private void OnTokenLoginTimeOut() {} // 0x0000000184E0A680-0x0000000184E0A7C0
		// [XID] // 0x00000001896092E0-0x0000000189609300
		private void OnAutoGuestLoginTimeOut() {} // 0x0000000184E02F40-0x0000000184E03080
		// [XID] // 0x000000018962CF50-0x000000018962CF70
		private void OnTimeOut() {} // 0x0000000184E0A480-0x0000000184E0A580
		// [XID] // 0x0000000189AF08E0-0x0000000189AF0900
		private void OnGetPhoneLogin(string responseString) {} // 0x0000000184E05B30-0x0000000184E05E00
		// [XID] // 0x0000000189B4E570-0x0000000189B4E590
		public void OnConfirmGuestLogin() {} // 0x0000000184E038D0-0x0000000184E03970
		// [XID] // 0x0000000189B55B80-0x0000000189B55BA0
		private void OnLoginByToken(string responseString) {} // 0x0000000184E07D10-0x0000000184E08840
		// [XID] // 0x0000000189B5D600-0x0000000189B5D620
		private void OnTokenLoginGrantBack() {} // 0x0000000184E0A580-0x0000000184E0A680
		// [XID] // 0x0000000189B64D60-0x0000000189B64D80
		public Dictionary<string, string> GetQueryDictionary(string query) => default; // 0x0000000184E01FE0-0x0000000184E02320
	}
}
