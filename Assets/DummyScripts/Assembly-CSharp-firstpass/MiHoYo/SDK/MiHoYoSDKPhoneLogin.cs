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
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKPhoneLogin : MiHoYoSDKBaseDialog // TypeDefIndex: 8866
	{
		// Fields
		private const string LoginByPhonePrefabPath = "UI/LoginByPhoneDialog.Prefab"; // Metadata: 0x00AE38A3
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE38C3
		private const string QRCodeButtonPath = "Dialog/QRCode"; // Metadata: 0x00AE38D6
		private const string QRBubblePath = "Dialog/Bubble"; // Metadata: 0x00AE38E7
		private const string ContentPath = "Dialog/Content"; // Metadata: 0x00AE38F8
		private const string PhoneInputPath = "Dialog/Content/PhoneInput/InputField"; // Metadata: 0x00AE390A
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE3932
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE3959
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE397C
		private const string LoginButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE39A4
		private const string BottomContentPath = "Dialog/Content/BottomContent"; // Metadata: 0x00AE39C0
		private const string GuestButtonPath = "GuestBtn"; // Metadata: 0x00AE39E0
		private const string AccountLoginButtonPath = "LoginByAccountBtn"; // Metadata: 0x00AE39EC
		private const string TapTapButtonPath = "TapTapBtn"; // Metadata: 0x00AE3A01
		private const string TestEnvTextPath = "Dialog/TestFlag"; // Metadata: 0x00AE3A0E
		private const string LoginButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE3A21
		private const string PhonePlaceholderPath = "Dialog/Content/PhoneInput/InputField/Placeholder"; // Metadata: 0x00AE3A42
		private const string CodePlaceholderPath = "Dialog/Content/CodeInput/InputField/Placeholder"; // Metadata: 0x00AE3A76
		private Button closeButton; // 0x20
		private Button qrCodeButton; // 0x28
		private GameObject qrBubble; // 0x30
		private InputField phoneInput; // 0x38
		private InputField verifycodeInput; // 0x40
		private Button requestCodeButton; // 0x48
		private UnityEngine.UI.Text requestCodeText; // 0x50
		private Button loginButton; // 0x58
		private Button guestButton; // 0x60
		private Button accountLoginButton; // 0x68
		private Button taptapButton; // 0x70
		private UnityEngine.UI.Text loginButtonText; // 0x78
		private bool isRequestVerifyCode; // 0x80
		private float countDownTime; // 0x84
		private bool retrieveFlag; // 0x88
		private static MiHoYoSDKPhoneLogin _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKPhoneLogin() {} // 0x000000018625C4D0-0x000000018625C540
	
		// Methods
		// [XID] // 0x0000000189B22E10-0x0000000189B22E30
		public static MiHoYoSDKPhoneLogin Instance() => default; // 0x000000018625AF40-0x000000018625B050
		// [XID] // 0x00000001899E3250-0x00000001899E3270
		public static bool IsExist() => default; // 0x000000018625B050-0x000000018625B150
		// [XID] // 0x0000000189AF65C0-0x0000000189AF65E0
		public void Init() {} // 0x0000000186259970-0x000000018625AF40
		// [XID] // 0x0000000189B730B0-0x0000000189B730D0
		private void updateText() {} // 0x000000018625C540-0x000000018625C920
		// [XID] // 0x00000001897BFAD0-0x00000001897BFAF0
		public void Show(MiHoYoSDKUserDataModel model = null) {} // 0x000000018625BAC0-0x000000018625BC40
		// [XID] // 0x00000001897C7270-0x00000001897C7290
		public void Hide() {} // 0x00000001862598A0-0x0000000186259970
		// [XID] // 0x00000001897CE790-0x00000001897CE7B0
		private void Close() {} // 0x0000000186259450-0x0000000186259510
		// [XID] // 0x0000000189990810-0x0000000189990830
		public void ResetCountDown() {} // 0x000000018625BA20-0x000000018625BAC0
		// [XID] // 0x00000001897DD5A0-0x00000001897DD5C0
		private void ValueChangePhoneInput() {} // 0x000000018625C420-0x000000018625C4D0
		// [XID] // 0x0000000189A085D0-0x0000000189A085F0
		private void RequestVerifyMessage() {} // 0x000000018625B870-0x000000018625BA20
		// [XID] // 0x00000001899F9910-0x00000001899F9930
		public void StartCountDown() {} // 0x000000018625BC40-0x000000018625BD80
		// [XID] // 0x00000001897F4420-0x00000001897F4440
		private void Login() {} // 0x000000018625B150-0x000000018625B630
		// [XID] // 0x00000001897D12B0-0x00000001897D12D0
		private void GuestLogin() {} // 0x00000001862597C0-0x00000001862598A0
		// [XID] // 0x00000001898C0700-0x00000001898C0720
		private void ClickTapTapLoginButton() {} // 0x0000000186259380-0x0000000186259450
		// [XID] // 0x0000000189617F10-0x0000000189617F30
		private void AccountLogin() {} // 0x00000001862592C0-0x0000000186259380
		// [XID] // 0x0000000189811E30-0x0000000189811E50
		private void QRCodeLogin() {} // 0x000000018625B7B0-0x000000018625B870
		[DebuggerHidden] // 0x0000000189819B60-0x0000000189819BA0
		// [XID] // 0x0000000189819B60-0x0000000189819BA0
		private IEnumerator CountDown(float time) => default; // 0x0000000186259510-0x0000000186259630
		// [XID] // 0x0000000189AF7E50-0x0000000189AF7E70
		private void UpdateRequestCodeButtonStatus() {} // 0x000000018625BE40-0x000000018625C420
		// [XID] // 0x00000001895FA160-0x00000001895FA180
		private void OnClickTab() {} // 0x000000018625B6D0-0x000000018625B7B0
		// [XID] // 0x0000000189832C40-0x0000000189832C60
		private void OnClickReturn() {} // 0x000000018625B630-0x000000018625B6D0
		// [XID] // 0x000000018983A200-0x000000018983A220
		public override void Dealloc() {} // 0x0000000186259630-0x00000001862597C0
	}
}
