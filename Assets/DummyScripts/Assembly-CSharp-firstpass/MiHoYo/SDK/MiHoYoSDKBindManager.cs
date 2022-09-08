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
	public class MiHoYoSDKBindManager : MiHoYoSDKBaseClass // TypeDefIndex: 8718
	{
		// Fields
		private Action<string> bindCallback; // 0x10
		private string phoneVerifyAction; // 0x18
		private string accountName; // 0x20
		private MiHoYoSDKUserDataModel bindUserData; // 0x28
		private string _region; // 0x30
		private Action<string> bindEmailCallback; // 0x38
		private Action<string> bindMobileCallback; // 0x40
		private Action<string> realNameCallback; // 0x48
		private Action<string> verifyEmailCallback; // 0x50
		private BIND_TYPE bindType; // 0x58
		private string loginResponseString; // 0x60
		private static MiHoYoSDKBindManager _instance; // 0x00
		public Action<int, string, string> OnVerifyMobileCaptcha; // 0x68
		private const string VerifyEmailKey = "MiHoYoSDKVerifyEmail"; // Metadata: 0x00AE20D4
	
		// Constructors
		public MiHoYoSDKBindManager() {} // 0x000000018640E980-0x000000018640E9E0
	
		// Methods
		// [XID] // 0x000000018991DFB0-0x000000018991DFD0
		public static MiHoYoSDKBindManager Instance() => default; // 0x0000000186408DB0-0x0000000186408EB0
		// [XID] // 0x00000001898AF450-0x00000001898AF470
		public void Init() {} // 0x0000000186408D10-0x0000000186408DB0
		// [XID] // 0x000000018969E320-0x000000018969E340
		public void ShowBind(string region, Action<string> callback, BIND_TYPE type = BIND_TYPE.NORMAL /* Metadata: 0x00AE20D0 */) {} // 0x000000018640DD20-0x000000018640DE80
		// [XID] // 0x00000001896A53A0-0x00000001896A53C0
		public void ShowTapTapBind(Action<string> callback) {} // 0x000000018640DF40-0x000000018640E000
		// [XID] // 0x0000000189794530-0x0000000189794550
		private void ShowBindTapTapView() {} // 0x000000018640DBB0-0x000000018640DD20
		// [XID] // 0x00000001896B4040-0x00000001896B4060
		private void UnRegisterBindTapTapViewEvent() {} // 0x000000018640E290-0x000000018640E3D0
		// [XID] // 0x0000000189AE67C0-0x0000000189AE67E0
		private void ShowBindMiHoYoAccountView() {} // 0x000000018640D8C0-0x000000018640DAE0
		// [XID] // 0x00000001896C2830-0x00000001896C2850
		private void UnRegisterBindMHYViewEvent() {} // 0x000000018640E0A0-0x000000018640E290
		// [XID] // 0x0000000189761CE0-0x0000000189761D00
		private void OnTapBindMHYBackButton() {} // 0x000000018640BDB0-0x000000018640BE50
		// [XID] // 0x00000001899C0E10-0x00000001899C0E30
		private void OnTapBindMHYCloseButton() {} // 0x000000018640BF20-0x000000018640C0C0
		// [XID] // 0x00000001896D8CD0-0x00000001896D8CF0
		private void OnTapBindMHYButton(string phone, string code) {} // 0x000000018640BE50-0x000000018640BF20
		// [XID] // 0x00000001896E04D0-0x00000001896E04F0
		private void OnTapPhoneCodeButton(string phone) {} // 0x000000018640C0C0-0x000000018640C170
		// [XID] // 0x00000001896E7790-0x00000001896E77B0
		public void ShowBindPhoneView(BIND_TYPE type) {} // 0x000000018640DAE0-0x000000018640DBB0
		// [XID] // 0x0000000189A9E870-0x0000000189A9E890
		public void ShowBindAccountView(BIND_TYPE type) {} // 0x000000018640D7F0-0x000000018640D8C0
		// [XID] // 0x00000001896F6890-0x00000001896F68B0
		public void ShowOverSeaGuestBindAlert() {} // 0x000000018640DE80-0x000000018640DF40
		// [XID] // 0x0000000189874A50-0x0000000189874A70
		public void Close() {} // 0x00000001864088E0-0x0000000186408A70
		// [XID] // 0x0000000189705330-0x0000000189705350
		private string CreateCloseCallback() => default; // 0x0000000186408A70-0x0000000186408BC0
		// [XID] // 0x00000001896783D0-0x00000001896783F0
		public void RequestVerifyMessage(string phone) {} // 0x000000018640D680-0x000000018640D7F0
		// [XID] // 0x00000001897141D0-0x00000001897141F0
		public void RequestMailVerifyMessage(string mail, string parameters) {} // 0x000000018640D3C0-0x000000018640D570
		// [XID] // 0x000000018971BCE0-0x000000018971BD00
		private void OnGetEmailCaptcha(string responseString) {} // 0x000000018640AB90-0x000000018640AD80
		// [XID] // 0x0000000189723010-0x0000000189723030
		private void OnGetEmailCaptchaTimeOut() {} // 0x000000018640AAF0-0x000000018640AB90
		// [IDTag] // 0x000000018972A740-0x000000018972A780
		// [XID] // 0x000000018972A740-0x000000018972A780
		public void RequestBindEmailByCode(string mail, string code) {} // 0x000000018640CDB0-0x000000018640CFD0
		// [IDTag] // 0x0000000189734E70-0x0000000189734EB0
		// [XID] // 0x0000000189734E70-0x0000000189734EB0
		public void RequestBindEmailByCode(string mail, string code, string ticket) {} // 0x000000018640CBA0-0x000000018640CDB0
		// [XID] // 0x000000018973FCE0-0x000000018973FD00
		private void OnGetActionTicketTimeOut() {} // 0x000000018640A380-0x000000018640A490
		// [XID] // 0x0000000189747190-0x00000001897471B0
		private void OnBindMailByCode(string responseString) {} // 0x0000000186409530-0x0000000186409770
		// [XID] // 0x000000018974E940-0x000000018974E960
		private void OnBindMailByCodeTimeOut() {} // 0x0000000186409420-0x0000000186409530
		// [XID] // 0x0000000189756050-0x0000000189756070
		public void RequestLoginByPhone(string phone, string verifyCode) {} // 0x000000018640D190-0x000000018640D3C0
		// [XID] // 0x0000000189B541C0-0x0000000189B541E0
		public void RequestLoginByAccount(string account, string password) {} // 0x000000018640CFD0-0x000000018640D190
		// [XID] // 0x0000000189764A50-0x0000000189764A70
		private void VerifyMobileCaptchaCallback(int code, string msg, string actionTicket = null) {} // 0x000000018640E5E0-0x000000018640E760
		// [XID] // 0x000000018976C4B0-0x000000018976C4D0
		public void VerifyMobileCaptcha(string actionTicket, string actionType, string captcha) {} // 0x000000018640E760-0x000000018640E980
		// [XID] // 0x0000000189773A00-0x0000000189773A20
		public void RequestBindAccount() {} // 0x000000018640C6F0-0x000000018640CBA0
		// [XID] // 0x00000001899258A0-0x00000001899258C0
		private void OnBindTapTapAccount(string responseString) {} // 0x0000000186409770-0x0000000186409AF0
		// [XID] // 0x00000001898A7970-0x00000001898A7990
		public void RequestRealNameAuth() {} // 0x000000018640D570-0x000000018640D680
		// [XID] // 0x000000018978A020-0x000000018978A040
		public void BindEmail(Action<string> callback) {} // 0x00000001864082B0-0x00000001864084C0
		// [XID] // 0x0000000189791820-0x0000000189791840
		public void BindMobile(Action<string> callback) {} // 0x00000001864086D0-0x00000001864088E0
		// [XID] // 0x0000000189798DD0-0x0000000189798DF0
		public void BindIdentity(Action<string> callback) {} // 0x00000001864084C0-0x00000001864086D0
		// [XID] // 0x00000001897A0CF0-0x00000001897A0D10
		public void VerifyEmail(Action<string> callback) {} // 0x000000018640E3D0-0x000000018640E5E0
		// [XID] // 0x00000001897A8410-0x00000001897A8430
		private void OnTapTapBindButton() {} // 0x000000018640C170-0x000000018640C210
		// [XID] // 0x0000000189B15590-0x0000000189B155B0
		private void OnTapTapRegisterButton() {} // 0x000000018640C310-0x000000018640C500
		// [XID] // 0x000000018982E320-0x000000018982E340
		private void OnTapTapLogin(string responseString) {} // 0x000000018640C210-0x000000018640C310
		// [XID] // 0x00000001897BFAF0-0x00000001897BFB10
		private void OnTapTapTimeOut() {} // 0x000000018640C500-0x000000018640C5F0
		// [XID] // 0x00000001897C7290-0x00000001897C72B0
		private void OnGetPageClose(MiHoYoSDKWebView webView) {} // 0x000000018640AD80-0x000000018640AF40
		// [XID] // 0x00000001897CE7B0-0x00000001897CE7D0
		private void OnGetUniWebViewMessage(MiHoYoSDKWebView webView, MiHoYoSDKUniWebViewMessage message) {} // 0x000000018640B200-0x000000018640B4C0
		// [XID] // 0x00000001897D5EF0-0x00000001897D5F10
		private void OnGetWebBindEmail() {} // 0x000000018640B860-0x000000018640B960
		// [XID] // 0x00000001897DD5C0-0x00000001897DD5E0
		private void OnGetWebBindMobile() {} // 0x000000018640B960-0x000000018640BA60
		// [XID] // 0x000000018971C2D0-0x000000018971C2F0
		private void OnGetWebRealName() {} // 0x000000018640BA60-0x000000018640BB60
		// [XID] // 0x0000000189BB7B00-0x0000000189BB7B20
		private void OnGetWebVerifyEmail() {} // 0x000000018640BB60-0x000000018640BC60
		// [XID] // 0x0000000189A280C0-0x0000000189A280E0
		private string GetAccountParameters() => default; // 0x0000000186408BC0-0x0000000186408D10
		// [XID] // 0x0000000189BAA100-0x0000000189BAA120
		private void OnGetAccountLogin(string responseString) {} // 0x0000000186409AF0-0x000000018640A380
		// [XID] // 0x0000000189619B90-0x0000000189619BB0
		private void OnRealNameSuccess(string name, string identity) {} // 0x000000018640BC60-0x000000018640BDB0
		// [XID] // 0x0000000189670B00-0x0000000189670B20
		private void OnGetVerifyCode(string responseString) {} // 0x000000018640B4C0-0x000000018640B860
		// [XID] // 0x0000000189811E50-0x0000000189811E70
		private void OnGetPhoneLogin(string responseString) {} // 0x000000018640AF40-0x000000018640B200
		// [XID] // 0x0000000189819BA0-0x0000000189819BC0
		private void OnBindAccount(string responseString) {} // 0x0000000186408EB0-0x0000000186409310
		// [XID] // 0x0000000189A395F0-0x0000000189A39610
		private void OnBindEnd() {} // 0x0000000186409310-0x0000000186409420
		// [XID] // 0x0000000189810FF0-0x0000000189811010
		private void OnGetBindTapTapTicket(string responseString) {} // 0x000000018640A490-0x000000018640AAF0
		// [XID] // 0x000000018962E820-0x000000018962E840
		private void OnTimeOut() {} // 0x000000018640C5F0-0x000000018640C6F0
	}
}
