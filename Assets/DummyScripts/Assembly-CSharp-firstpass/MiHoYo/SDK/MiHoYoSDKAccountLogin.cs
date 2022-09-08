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
	internal class MiHoYoSDKAccountLogin : MiHoYoSDKBaseDialog // TypeDefIndex: 8852
	{
		// Fields
		private const string LoginByAccountPrefabPath = "UI/LoginByAccountDialog.Prefab"; // Metadata: 0x00AE2DA4
		private const string LoginByAccountSpecialPrefabPath = "UI/LoginByAccountDialogSpecial.Prefab"; // Metadata: 0x00AE2DC6
		private const string OverSeaAccountLoginPrefabPath = "UI/OverSeaAccountLoginDialog.Prefab"; // Metadata: 0x00AE2DEF
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE2E16
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE2E29
		private const string QRCodeButtonPath = "Dialog/QRCode"; // Metadata: 0x00AE2E3B
		private const string QRBubblePath = "Dialog/Bubble"; // Metadata: 0x00AE2E4C
		private const string AccountInputPath = "Dialog/Content/AccountInput/InputField"; // Metadata: 0x00AE2E5D
		private const string PasswordInputPath = "Dialog/Content/PasswordInput/InputField"; // Metadata: 0x00AE2E87
		private const string LoginButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE2EB2
		private const string RegisterButtonPath = "Dialog/Content/RegisterBtn"; // Metadata: 0x00AE2ECE
		private const string ForgetPasswordButtonPath = "Dialog/Content/ForgetPswBtn"; // Metadata: 0x00AE2EEC
		private const string GuestButtonPath = "GuestBtn"; // Metadata: 0x00AE2F0B
		private const string PhoneLoginButtonPath = "LoginByPhoneBtn"; // Metadata: 0x00AE2F17
		private const string TestEnvTextPath = "Dialog/TestFlag"; // Metadata: 0x00AE2F2A
		private const string AccountPlaceholderPath = "Dialog/Content/AccountInput/InputField/Placeholder"; // Metadata: 0x00AE2F3D
		private const string PasswordPlaceholderPath = "Dialog/Content/PasswordInput/InputField/Placeholder"; // Metadata: 0x00AE2F73
		private const string LoginButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE2FAA
		private const string NoAccountTextPath = "Dialog/Content/RegisterBtn/Label"; // Metadata: 0x00AE2FCB
		private const string RegisterTextPath = "Dialog/Content/RegisterBtn/Label/Text"; // Metadata: 0x00AE2FEF
		private const string ForgetPasswordTextPath = "Dialog/Content/ForgetPswBtn/Text"; // Metadata: 0x00AE3018
		private const string GuestButtonTextPath = "GuestBtn/Text"; // Metadata: 0x00AE303C
		private const string PhoneLoginButtonTextPath = "LoginByPhoneBtn/Text"; // Metadata: 0x00AE304D
		private const string BottomContentPath = "Dialog/Content/BottomContent"; // Metadata: 0x00AE3065
		private const string ContentPath = "Dialog/Content"; // Metadata: 0x00AE3085
		private const string ThirdPartyPath = "Dialog/Content/ThirdParty"; // Metadata: 0x00AE3097
		private const string OverSeaGuestButtonPath = "GuestBtn"; // Metadata: 0x00AE30B4
		private const string TapTapButtonPath = "TapTapBtn"; // Metadata: 0x00AE30C0
		private const string FaceBookButtonPath = "FacebookBtn"; // Metadata: 0x00AE30CD
		private const string TwitterButtonPath = "TwitterBtn"; // Metadata: 0x00AE30DC
		private Button closeButton; // 0x20
		private Button backButton; // 0x28
		private Button qrCodeButton; // 0x30
		private GameObject qrBubble; // 0x38
		private InputField accountInput; // 0x40
		private InputField passwordInput; // 0x48
		private Button loginButton; // 0x50
		private Button registerButton; // 0x58
		private Button forgetPasswordButton; // 0x60
		private Button guestButton; // 0x68
		private Button taptapButton; // 0x70
		private Button phoneLoginButton; // 0x78
		private Button facebookButton; // 0x80
		private Button twitterButton; // 0x88
		private MiHoYoSDKWebView facebookWeb; // 0x90
		private MiHoYoSDKWebView twitterWeb; // 0x98
		private static MiHoYoSDKAccountLogin _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKAccountLogin() {} // 0x00000001859E9450-0x00000001859E94B0
	
		// Methods
		// [XID] // 0x0000000189884040-0x0000000189884060
		public static MiHoYoSDKAccountLogin Instance() => default; // 0x00000001859E7D90-0x00000001859E7EA0
		// [XID] // 0x00000001898048F0-0x0000000189804910
		public static bool IsExist() => default; // 0x00000001859E7EA0-0x00000001859E7FA0
		// [XID] // 0x000000018980BDF0-0x000000018980BE10
		public void Init() {} // 0x00000001859E5A50-0x00000001859E7D90
		// [XID] // 0x0000000189813600-0x0000000189813620
		private void updateText() {} // 0x00000001859E94B0-0x00000001859EA2D0
		// [XID] // 0x00000001897A22E0-0x00000001897A2300
		public void Show(MiHoYoSDKUserDataModel model = null) {} // 0x00000001859E8F10-0x00000001859E9210
		// [XID] // 0x0000000189822760-0x0000000189822780
		public void Hide() {} // 0x00000001859E58C0-0x00000001859E5A50
		// [XID] // 0x0000000189829DD0-0x0000000189829DF0
		public void Close() {} // 0x00000001859E5230-0x00000001859E52F0
		// [XID] // 0x0000000189831330-0x0000000189831350
		public void Back() {} // 0x00000001859E4D50-0x00000001859E4E10
		// [XID] // 0x0000000189708120-0x0000000189708140
		private void Login() {} // 0x00000001859E7FA0-0x00000001859E82C0
		// [XID] // 0x00000001898400C0-0x00000001898400E0
		private void Register() {} // 0x00000001859E8C70-0x00000001859E8F10
		// [XID] // 0x000000018972D490-0x000000018972D4B0
		private void ForgetPassword() {} // 0x00000001859E5470-0x00000001859E5710
		// [XID] // 0x000000018984EF50-0x000000018984EF70
		private void GuestLogin() {} // 0x00000001859E5710-0x00000001859E5820
		// [XID] // 0x0000000189B4BE40-0x0000000189B4BE60
		private void PhoneLogin() {} // 0x00000001859E8B00-0x00000001859E8BA0
		// [XID] // 0x000000018985D220-0x000000018985D240
		private void QRCodeLogin() {} // 0x00000001859E8BA0-0x00000001859E8C70
		// [XID] // 0x0000000189696B70-0x0000000189696B90
		private void ClickFaceBookButton() {} // 0x00000001859E4E10-0x00000001859E4FD0
		// [XID] // 0x00000001897FB070-0x00000001897FB090
		private void ClickTwitterButton() {} // 0x00000001859E50A0-0x00000001859E5230
		// [XID] // 0x0000000189873710-0x0000000189873730
		private void ClickTapTapLoginButton() {} // 0x00000001859E4FD0-0x00000001859E50A0
		// [XID] // 0x0000000189BA1280-0x0000000189BA12A0
		private void HideFacebookLoading() {} // 0x00000001859E5820-0x00000001859E58C0
		// [XID] // 0x00000001898822E0-0x0000000189882300
		private void UpdateFacebookWeb() {} // 0x00000001859E9270-0x00000001859E9450
		// [XID] // 0x000000018993D820-0x000000018993D840
		private void OnFacebookPageError(MiHoYoSDKWebView webView, string url, int errorCode, string errorMessage) {} // 0x00000001859E8440-0x00000001859E8570
		// [XID] // 0x0000000189982E20-0x0000000189982E40
		private void OnGetUniWebViewMessage(MiHoYoSDKWebView web, MiHoYoSDKUniWebViewMessage message) {} // 0x00000001859E8680-0x00000001859E89F0
		// [XID] // 0x00000001899B8AA0-0x00000001899B8AC0
		private void OnRegisterAccount(string username, string pwd) {} // 0x00000001859E89F0-0x00000001859E8B00
		// [XID] // 0x000000018989F690-0x000000018989F6B0
		private void OnForgetPassword(string username, string pwd) {} // 0x00000001859E8570-0x00000001859E8680
		// [XID] // 0x00000001898A71A0-0x00000001898A71C0
		private void OnClickTab() {} // 0x00000001859E8360-0x00000001859E8440
		// [XID] // 0x00000001898AEBF0-0x00000001898AEC10
		private void OnClickReturn() {} // 0x00000001859E82C0-0x00000001859E8360
		// [XID] // 0x00000001898B5E70-0x00000001898B5E90
		public override void Dealloc() {} // 0x00000001859E52F0-0x00000001859E5470
	}
}
