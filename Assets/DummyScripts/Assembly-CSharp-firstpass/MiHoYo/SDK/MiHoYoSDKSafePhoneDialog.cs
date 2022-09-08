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
	internal class MiHoYoSDKSafePhoneDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8878
	{
		// Fields
		private const string BindPhonePrefabPath = "UI/BindSafeMobileDialog.Prefab"; // Metadata: 0x00AE3F75
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE3F97
		private const string PhoneInputPath = "Dialog/Content/PhoneInput/InputField"; // Metadata: 0x00AE3FAA
		private const string CodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE3FD2
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE3FF9
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE4015
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE4038
		private Button closeButton; // 0x20
		private InputField phoneInput; // 0x28
		private InputField codeInput; // 0x30
		private Button submitButton; // 0x38
		private Button requestCodeButton; // 0x40
		private UnityEngine.UI.Text requestCodeText; // 0x48
		private bool isRequestVerifyCode; // 0x50
		private float countDownTime; // 0x54
		private bool retrieveFlag; // 0x58
		private static MiHoYoSDKSafePhoneDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKSafePhoneDialog() {} // 0x0000000185966F90-0x0000000185966FF0
	
		// Methods
		// [XID] // 0x0000000189B55B60-0x0000000189B55B80
		public static MiHoYoSDKSafePhoneDialog Instance() => default; // 0x0000000185966130-0x0000000185966240
		// [XID] // 0x0000000189BB38D0-0x0000000189BB38F0
		public static bool IsExist() => default; // 0x0000000185966240-0x0000000185966340
		// [XID] // 0x0000000189B64D40-0x0000000189B64D60
		public void Init() {} // 0x0000000185965B00-0x0000000185966130
		// [XID] // 0x0000000189B6C110-0x0000000189B6C130
		public void Show() {} // 0x0000000185966690-0x0000000185966750
		// [XID] // 0x00000001898B2150-0x00000001898B2170
		public void Hide() {} // 0x0000000185965A30-0x0000000185965B00
		// [XID] // 0x0000000189B7AE80-0x0000000189B7AEA0
		public void StartCountDown() {} // 0x0000000185966750-0x0000000185966890
		// [XID] // 0x00000001897D9D30-0x00000001897D9D50
		public void Close() {} // 0x00000001859656D0-0x0000000185965790
		// [XID] // 0x0000000189BA2750-0x0000000189BA2770
		public void ResetCountDown() {} // 0x00000001859665F0-0x0000000185966690
		// [XID] // 0x0000000189B915B0-0x0000000189B915D0
		private void ValueChangePhoneInput() {} // 0x0000000185966EE0-0x0000000185966F90
		// [XID] // 0x0000000189B988B0-0x0000000189B988D0
		private void Bind() {} // 0x00000001859652D0-0x00000001859656D0
		// [XID] // 0x000000018969A990-0x000000018969A9B0
		private void RequestVerifyMessage() {} // 0x00000001859664C0-0x00000001859665F0
		[DebuggerHidden] // 0x0000000189BA7550-0x0000000189BA7590
		// [XID] // 0x0000000189BA7550-0x0000000189BA7590
		private IEnumerator CountDown(float time) => default; // 0x0000000185965790-0x00000001859658B0
		// [XID] // 0x000000018981D120-0x000000018981D140
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000185966950-0x0000000185966EE0
		// [XID] // 0x0000000189BB8BE0-0x0000000189BB8C00
		private void OnClickTab() {} // 0x00000001859663E0-0x00000001859664C0
		// [XID] // 0x0000000189BC05A0-0x0000000189BC05C0
		private void OnClickReturn() {} // 0x0000000185966340-0x00000001859663E0
		// [XID] // 0x0000000189BC7EF0-0x0000000189BC7F10
		public override void Dealloc() {} // 0x00000001859658B0-0x0000000185965A30
	}
}
