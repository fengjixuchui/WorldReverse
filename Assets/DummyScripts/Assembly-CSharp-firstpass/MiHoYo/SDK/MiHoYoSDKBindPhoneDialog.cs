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
	internal class MiHoYoSDKBindPhoneDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8841
	{
		// Fields
		private const string BindPhonePrefabPath = "UI/BindPhoneDialog.Prefab"; // Metadata: 0x00AE27FC
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE2819
		private const string BindDescTextPath = "Dialog/Content/DescTxt"; // Metadata: 0x00AE282C
		private const string PhoneInputPath = "Dialog/Content/PhoneInput/InputField"; // Metadata: 0x00AE2846
		private const string CodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE286E
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE2895
		private const string RedirectBtnPath = "Dialog/Content/RedirectBtn"; // Metadata: 0x00AE28B1
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE28CF
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE28F2
		private const string BindTipsPath = "Dialog/Content/DescTxt"; // Metadata: 0x00AE291A
		private const string SubmitButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE2934
		private const string RedirectBtnTextPath = "Dialog/Content/RedirectBtn/Text"; // Metadata: 0x00AE2955
		private Button closeButton; // 0x20
		private UnityEngine.UI.Text bindDescText; // 0x28
		private InputField phoneInput; // 0x30
		private InputField codeInput; // 0x38
		private Button submitButton; // 0x40
		private Button redirectButton; // 0x48
		private Button requestCodeButton; // 0x50
		private UnityEngine.UI.Text requestCodeText; // 0x58
		private UnityEngine.UI.Text submitButtonText; // 0x60
		private UnityEngine.UI.Text redirectButtonText; // 0x68
		private bool isRequestVerifyCode; // 0x70
		private float countDownTime; // 0x74
		private bool retrieveFlag; // 0x78
		private BIND_TYPE bindType; // 0x7C
		private static MiHoYoSDKBindPhoneDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKBindPhoneDialog() {} // 0x0000000186410BF0-0x0000000186410C50
	
		// Methods
		// [XID] // 0x00000001898BB5F0-0x00000001898BB610
		public static MiHoYoSDKBindPhoneDialog Instance() => default; // 0x000000018640FB90-0x000000018640FCA0
		// [XID] // 0x00000001897A8DA0-0x00000001897A8DC0
		public static bool IsExist() => default; // 0x000000018640FCA0-0x000000018640FDA0
		// [XID] // 0x0000000189AF99F0-0x0000000189AF9A10
		public void Init() {} // 0x000000018640F2E0-0x000000018640FB90
		// [XID] // 0x0000000189B00DE0-0x0000000189B00E00
		public void Show(BIND_TYPE type) {} // 0x0000000186410230-0x0000000186410360
		// [XID] // 0x0000000189B084A0-0x0000000189B084C0
		public void Hide() {} // 0x000000018640F210-0x000000018640F2E0
		// [XID] // 0x0000000189B0FDA0-0x0000000189B0FDC0
		public void Close() {} // 0x000000018640EEB0-0x000000018640EF70
		// [XID] // 0x0000000189866CD0-0x0000000189866CF0
		public void ResetCountDown() {} // 0x00000001864100C0-0x0000000186410160
		// [XID] // 0x0000000189B1E6C0-0x0000000189B1E6E0
		public void StartCountDown() {} // 0x0000000186410360-0x00000001864104A0
		// [XID] // 0x0000000189739240-0x0000000189739260
		private void ValueChangePhoneInput() {} // 0x0000000186410B40-0x0000000186410BF0
		// [XID] // 0x00000001899CF390-0x00000001899CF3B0
		private void Bind() {} // 0x000000018640E9E0-0x000000018640EEB0
		// [XID] // 0x00000001896F5730-0x00000001896F5750
		private void ShowBindMailView() {} // 0x0000000186410160-0x0000000186410230
		// [XID] // 0x0000000189B3C130-0x0000000189B3C150
		private void RequestVerifyMessage() {} // 0x000000018640FF20-0x00000001864100C0
		[DebuggerHidden] // 0x0000000189B43D30-0x0000000189B43D70
		// [XID] // 0x0000000189B43D30-0x0000000189B43D70
		private IEnumerator CountDown(float time) => default; // 0x000000018640EF70-0x000000018640F090
		// [XID] // 0x0000000189B4E510-0x0000000189B4E530
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000186410560-0x0000000186410B40
		// [XID] // 0x00000001898497D0-0x00000001898497F0
		private void OnClickTab() {} // 0x000000018640FE40-0x000000018640FF20
		// [XID] // 0x0000000189B5D5E0-0x0000000189B5D600
		private void OnClickReturn() {} // 0x000000018640FDA0-0x000000018640FE40
		// [XID] // 0x0000000189738950-0x0000000189738970
		public override void Dealloc() {} // 0x000000018640F090-0x000000018640F210
	}
}
