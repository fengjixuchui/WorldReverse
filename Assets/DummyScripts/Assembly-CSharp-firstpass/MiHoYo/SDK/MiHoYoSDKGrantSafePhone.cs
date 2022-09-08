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
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKGrantSafePhone : MiHoYoSDKBaseDialog // TypeDefIndex: 8856
	{
		// Fields
		private const string GrantSafePhonePrefabPath = "UI/GrantSafePhoneDialog.Prefab"; // Metadata: 0x00AE323A
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE325C
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE326F
		private const string SafePhoneTextPath = "Dialog/Content/PhoneTxt"; // Metadata: 0x00AE3281
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE329C
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE32C3
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE32E6
		private const string LoginButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE330E
		private const string QuestionButtonPath = "Dialog/Content/QuestionBtn"; // Metadata: 0x00AE332A
		private Button backButton; // 0x20
		private Button closeButton; // 0x28
		private UnityEngine.UI.Text phoneText; // 0x30
		private InputField verifycodeInput; // 0x38
		private Button requestCodeButton; // 0x40
		private UnityEngine.UI.Text requestCodeText; // 0x48
		private Button loginButton; // 0x50
		private Button questionButton; // 0x58
		private bool isRequestVerifyCode; // 0x60
		private float countDownTime; // 0x64
		private bool retrieveFlag; // 0x68
		private static MiHoYoSDKGrantSafePhone _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKGrantSafePhone() {} // 0x0000000184DFB1A0-0x0000000184DFB210
	
		// Methods
		// [XID] // 0x00000001899F53D0-0x00000001899F53F0
		public static MiHoYoSDKGrantSafePhone Instance() => default; // 0x0000000184DFA180-0x0000000184DFA290
		// [XID] // 0x00000001899DE790-0x00000001899DE7B0
		public static bool IsExist() => default; // 0x0000000184DFA290-0x0000000184DFA390
		// [XID] // 0x0000000189A1A110-0x0000000189A1A130
		public void Init() {} // 0x0000000184DF9A80-0x0000000184DFA180
		// [XID] // 0x0000000189A10C10-0x0000000189A10C30
		public void Show(MiHoYoSDKUserDataModel model) {} // 0x0000000184DFA8C0-0x0000000184DFAA50
		// [XID] // 0x0000000189A82D80-0x0000000189A82DA0
		public void Hide() {} // 0x0000000184DF99B0-0x0000000184DF9A80
		// [XID] // 0x0000000189B20790-0x0000000189B207B0
		public void StartCountDown() {} // 0x0000000184DFAA50-0x0000000184DFAB90
		// [XID] // 0x0000000189A26C40-0x0000000189A26C60
		private void Close() {} // 0x0000000184DF9650-0x0000000184DF9710
		// [XID] // 0x0000000189A2E350-0x0000000189A2E370
		private void Back() {} // 0x0000000184DF94A0-0x0000000184DF9560
		// [XID] // 0x0000000189A35C00-0x0000000189A35C20
		private void ClickQuestionButton() {} // 0x0000000184DF9560-0x0000000184DF9650
		// [XID] // 0x0000000189A3D230-0x0000000189A3D250
		public void ResetCountDown() {} // 0x0000000184DFA820-0x0000000184DFA8C0
		// [XID] // 0x00000001897A4530-0x00000001897A4550
		private void RequestVerifyMessage() {} // 0x0000000184DFA750-0x0000000184DFA820
		// [XID] // 0x0000000189B19050-0x0000000189B19070
		private void Login() {} // 0x0000000184DFA390-0x0000000184DFA5F0
		[DebuggerHidden] // 0x0000000189A539D0-0x0000000189A53A10
		// [XID] // 0x0000000189A539D0-0x0000000189A53A10
		private IEnumerator CountDown(float time) => default; // 0x0000000184DF9710-0x0000000184DF9830
		// [XID] // 0x0000000189A5E480-0x0000000189A5E4A0
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000184DFABF0-0x0000000184DFB1A0
		// [XID] // 0x0000000189A65C80-0x0000000189A65CA0
		private void OnClickTab() {} // 0x0000000184DFA690-0x0000000184DFA750
		// [XID] // 0x0000000189A6D2B0-0x0000000189A6D2D0
		private void OnClickReturn() {} // 0x0000000184DFA5F0-0x0000000184DFA690
		// [XID] // 0x00000001896E18C0-0x00000001896E18E0
		public override void Dealloc() {} // 0x0000000184DF9830-0x0000000184DF99B0
	}
}
