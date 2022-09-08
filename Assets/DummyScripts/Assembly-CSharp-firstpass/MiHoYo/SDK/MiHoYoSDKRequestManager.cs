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
	public class MiHoYoSDKRequestManager // TypeDefIndex: 8752
	{
		// Fields
		private static MiHoYoSDKRequestManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKRequestManager() {} // 0x0000000185961150-0x00000001859611B0
	
		// Methods
		// [XID] // 0x00000001896C6410-0x00000001896C6430
		public static MiHoYoSDKRequestManager Instance() => default; // 0x000000018595F220-0x000000018595F320
		// [XID] // 0x0000000189831E50-0x0000000189831E70
		public void Init() {} // 0x000000018595F180-0x000000018595F220
		// [XID] // 0x000000018961CCA0-0x000000018961CCC0
		public void LoginByPassword(string account, string password, Action<string> callback, Action OnTimeOut = null) {} // 0x000000018595F600-0x000000018595F840
		[DebuggerHidden] // 0x00000001896241A0-0x00000001896241E0
		// [XID] // 0x00000001896241A0-0x00000001896241E0
		public IEnumerator LoginByToken(string uid, string token, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595FB80-0x000000018595FCE0
		[DebuggerHidden] // 0x000000018962E990-0x000000018962E9D0
		// [XID] // 0x000000018962E990-0x000000018962E9D0
		public IEnumerator LoginByMobileCode(string mobile, string captcha, string action, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595F480-0x000000018595F600
		[DebuggerHidden] // 0x0000000189639510-0x0000000189639550
		// [XID] // 0x0000000189639510-0x0000000189639550
		public IEnumerator LoginByGuest(string game_key, string device, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595F320-0x000000018595F480
		[DebuggerHidden] // 0x0000000189643AC0-0x0000000189643B00
		// [XID] // 0x0000000189643AC0-0x0000000189643B00
		public IEnumerator LoginByThirdParty(string type, string token, string redirectUrl, bool no_regist, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595F9E0-0x000000018595FB80
		[DebuggerHidden] // 0x000000018964E340-0x000000018964E380
		// [XID] // 0x000000018964E340-0x000000018964E380
		public IEnumerator LoginBySony(string client_id, string auth_code, bool no_regist, int issuerId, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595F840-0x000000018595F9E0
		// [XID] // 0x00000001896589C0-0x00000001896589E0
		public void GetMobileVerifyCode(string mobile, Action<string> callback, Action OnTimeOut = null) {} // 0x000000018595EC70-0x000000018595EEA0
		[DebuggerHidden] // 0x0000000189660060-0x00000001896600A0
		// [XID] // 0x0000000189660060-0x00000001896600A0
		public IEnumerator GetTicketByToken(string accountId, string token, Action<string> callback, Action OnTimeOut = null, string actionType = "bind_realname" /* Metadata: 0x00AE2221 */) => default; // 0x000000018595EEA0-0x000000018595F020
		[DebuggerHidden] // 0x000000018966AAA0-0x000000018966AAE0
		// [XID] // 0x000000018966AAA0-0x000000018966AAE0
		public IEnumerator BindRealName(string ticket, string realname, string iddentityCard, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595E4D0-0x000000018595E650
		[DebuggerHidden] // 0x0000000189675690-0x00000001896756D0
		// [XID] // 0x0000000189675690-0x00000001896756D0
		public IEnumerator BindAccount(string aid, string device, string game_key, string guest_id, string region, string token, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595E300-0x000000018595E4D0
		[DebuggerHidden] // 0x000000018967FE10-0x000000018967FE50
		// [XID] // 0x000000018967FE10-0x000000018967FE50
		public IEnumerator RequestQRCode(string appid, string device, Action<string> callback, Action timeout) => default; // 0x0000000185960CF0-0x0000000185960E50
		[DebuggerHidden] // 0x000000018968A8A0-0x000000018968A8E0
		// [XID] // 0x000000018968A8A0-0x000000018968A8E0
		public IEnumerator QueryQRCode(string appid, string ticket, string device, Action<string> callback, Action OnTimeOut = null) => default; // 0x00000001859603E0-0x0000000185960560
		[DebuggerHidden] // 0x00000001896952B0-0x00000001896952F0
		// [XID] // 0x00000001896952B0-0x00000001896952F0
		public IEnumerator ScanQRCode(string appid, string ticket, string device, Action<string> callback, Action timeOutCallback) => default; // 0x0000000185960E50-0x0000000185960FD0
		[DebuggerHidden] // 0x000000018969F9B0-0x000000018969F9F0
		// [XID] // 0x000000018969F9B0-0x000000018969F9F0
		public IEnumerator ConfirmQRCode(string appid, string ticket, string device, JSONObject payload, Action<string> callback, Action timeOutCallback) => default; // 0x000000018595EAD0-0x000000018595EC70
		// [XID] // 0x00000001897652A0-0x00000001897652C0
		public void PreGrantMessage(string uid, string token, GrantType type, Action<string> callback, Action timeOutCallback) {} // 0x0000000185960180-0x00000001859603E0
		// [XID] // 0x0000000189ACE250-0x0000000189ACE270
		public void OverseaGrantMessage(string ticket, GrantType type, Action<string> callback, Action timeOutCallback) {} // 0x000000018595FF40-0x0000000185960180
		[DebuggerHidden] // 0x00000001896B8770-0x00000001896B87B0
		// [XID] // 0x00000001896B8770-0x00000001896B87B0
		public IEnumerator GrantDevice(string ticket, string code, Action<string> callback, Action timeOutCallback) => default; // 0x000000018595F020-0x000000018595F180
		[DebuggerHidden] // 0x00000001896C27F0-0x00000001896C2830
		// [XID] // 0x00000001896C27F0-0x00000001896C2830
		public IEnumerator BindSafeMobileTicket(string uid, string token, Action<string> callback, Action timeOutCallback) => default; // 0x000000018595E650-0x000000018595E7B0
		// [XID] // 0x00000001897D7FC0-0x00000001897D7FE0
		public void MobileCaptcha(string mobile, string ticket, Action<string> callback, Action timeOutCallback, string actionType = "bind_safemobile" /* Metadata: 0x00AE2232 */) {} // 0x000000018595FCE0-0x000000018595FF40
		[DebuggerHidden] // 0x00000001896D4440-0x00000001896D4480
		// [XID] // 0x00000001896D4440-0x00000001896D4480
		public IEnumerator BindSafeMobile(string mobile, string ticket, string captcha, string uid, Action<string> callback, Action timeOutCallback) => default; // 0x000000018595E7B0-0x000000018595E950
		[DebuggerHidden] // 0x00000001896DEE40-0x00000001896DEE80
		// [XID] // 0x00000001896DEE40-0x00000001896DEE80
		public IEnumerator BindThirdParty(string ticket, string thirdParty, string accessToken, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595E950-0x000000018595EAD0
		[DebuggerHidden] // 0x00000001896E9280-0x00000001896E92C0
		// [XID] // 0x00000001896E9280-0x00000001896E92C0
		public IEnumerator BeforeVerify(string app_id, string channel_id, string open_id, string combo_token, string role_id, string region, Action<string> callback, Action OnTimeOut = null) => default; // 0x000000018595E130-0x000000018595E300
		[DebuggerHidden] // 0x00000001896F3760-0x00000001896F37A0
		// [XID] // 0x00000001896F3760-0x00000001896F37A0
		public IEnumerator RequestAgreementInfos(string biz, string uid, string token, string country, Action<string> callback, Action OnTimeOut = null) => default; // 0x0000000185960560-0x0000000185960700
		[DebuggerHidden] // 0x00000001896FDFC0-0x00000001896FE000
		// [XID] // 0x00000001896FDFC0-0x00000001896FE000
		public IEnumerator RequestOperateAgreement(uint agreement_id, int version, string operation, string uid, string token, Action<string> callback, Action OnTimeOut = null) => default; // 0x0000000185960B40-0x0000000185960CF0
		[DebuggerHidden] // 0x0000000189708390-0x00000001897083D0
		// [XID] // 0x0000000189708390-0x00000001897083D0
		public IEnumerator RequestClientConfig(string gameBiz, ClientType type, Action<string> callback, Action timeoutCallback) => default; // 0x0000000185960880-0x00000001859609E0
		[DebuggerHidden] // 0x0000000189712C10-0x0000000189712C50
		// [XID] // 0x0000000189712C10-0x0000000189712C50
		public IEnumerator RequestEmailCaptcha(string email, string mmtParams, Action<string> callback, Action timeoutCallback) => default; // 0x00000001859609E0-0x0000000185960B40
		[DebuggerHidden] // 0x000000018971D3B0-0x000000018971D3F0
		// [XID] // 0x000000018971D3B0-0x000000018971D3F0
		public IEnumerator RequestBindEmailByCode(string email, string captcha, string actionTicket, Action<string> callback, Action timeoutCallback) => default; // 0x0000000185960700-0x0000000185960880
		[DebuggerHidden] // 0x0000000189727A20-0x0000000189727A60
		// [XID] // 0x0000000189727A20-0x0000000189727A60
		public IEnumerator VerifyMobileCaptcha(string actionTicket, string actionType, string captcha, Action<string> callback, Action timeoutCallback) => default; // 0x0000000185960FD0-0x0000000185961150
	}
}
