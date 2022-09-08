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
	internal class MiHoYoSDKBindMHYDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8839
	{
		// Fields
		private const string BindMiHoYoAccountPrefabPath = "UI/BindMHYDialog.Prefab"; // Metadata: 0x00AE26CF
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE26EA
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE26FD
		private const string BindDescTextPath = "Dialog/Content/DescTxt"; // Metadata: 0x00AE270F
		private const string PhoneInputPath = "Dialog/Content/PhoneInput/InputField"; // Metadata: 0x00AE2729
		private const string CodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE2751
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE2778
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE279B
		private const string BindButtonPath = "Dialog/Content/BindBtn"; // Metadata: 0x00AE27C3
		private const string BindButtonTextPath = "Dialog/Content/BindBtn/Text"; // Metadata: 0x00AE27DD
		private Button closeButton; // 0x20
		private Button backButton; // 0x28
		private UnityEngine.UI.Text bindDescText; // 0x30
		private InputField phoneInput; // 0x38
		private InputField codeInput; // 0x40
		private Button requestCodeButton; // 0x48
		private UnityEngine.UI.Text requestCodeText; // 0x50
		private Button bindButton; // 0x58
		private UnityEngine.UI.Text bindButtonText; // 0x60
		private bool isRequestVerifyCode; // 0x68
		private float countDownTime; // 0x6C
		private bool retrieveFlag; // 0x70
		private static MiHoYoSDKBindMHYDialog _instance; // 0x00
	
		// Events
		public event Action OnTapBackButton;
		public event Action OnTapCloseButton;
		public event Action<string> OnTapCodeButton;
		public event Action<string, string> OnTapBindButton;
	
		// Constructors
		public MiHoYoSDKBindMHYDialog() {} // 0x0000000186403740-0x00000001864037A0
	
		// Methods
		// [XID] // 0x0000000189A0AD30-0x0000000189A0AD50
		public static MiHoYoSDKBindMHYDialog Instance() => default; // 0x0000000186402480-0x0000000186402590
		// [XID] // 0x0000000189A125B0-0x0000000189A125D0
		public static bool IsExist() => default; // 0x0000000186402590-0x0000000186402690
		// [XID] // 0x0000000189A199A0-0x0000000189A199C0
		public void Init() {} // 0x0000000186401CE0-0x0000000186402480
		// [XID] // 0x00000001899DC6C0-0x00000001899DC6E0
		private void UpdateContent() {} // 0x0000000186402DB0-0x00000001864030B0
		// [XID] // 0x0000000189A28390-0x0000000189A283B0
		public void ResetCountDown() {} // 0x0000000186402A50-0x0000000186402AF0
		// [XID] // 0x00000001899F9A70-0x00000001899F9A90
		public void StartCountDown() {} // 0x0000000186402BB0-0x0000000186402CF0
		// [XID] // 0x00000001898FDA20-0x00000001898FDA40
		private void ValueChangePhoneInput() {} // 0x0000000186403690-0x0000000186403740
		// [XID] // 0x0000000189905240-0x0000000189905260
		private void UpdateRequestCodeButtonStatus() {} // 0x00000001864030B0-0x0000000186403690
		// [XID] // 0x0000000189B155B0-0x0000000189B155D0
		private void RequestVerifyMessage() {} // 0x00000001864028F0-0x0000000186402A50
		[DebuggerHidden] // 0x0000000189A4DA10-0x0000000189A4DA50
		// [XID] // 0x0000000189A4DA10-0x0000000189A4DA50
		private IEnumerator CountDown(float time) => default; // 0x0000000186401970-0x0000000186401A90
		// [XID] // 0x0000000189675430-0x0000000189675450
		public void Show() {} // 0x0000000186402AF0-0x0000000186402BB0
		// [XID] // 0x00000001897F04E0-0x00000001897F0500
		public void Hide() {} // 0x0000000186401C10-0x0000000186401CE0
		// [XID] // 0x00000001898D5610-0x00000001898D5630
		public void Close() {} // 0x00000001864018B0-0x0000000186401970
		// [XID] // 0x00000001897FF2D0-0x00000001897FF2F0
		public void Back() {} // 0x0000000186401590-0x0000000186401640
		// [XID] // 0x00000001896F56F0-0x00000001896F5710
		private void Bind() {} // 0x0000000186401640-0x00000001864018B0
		// [XID] // 0x0000000189A7DD00-0x0000000189A7DD20
		private void OnClickCodeButton() {} // 0x0000000186402690-0x0000000186402770
		// [XID] // 0x0000000189B38E10-0x0000000189B38E30
		private void OnClickTab() {} // 0x0000000186402810-0x00000001864028F0
		// [XID] // 0x0000000189908EB0-0x0000000189908ED0
		private void OnClickReturn() {} // 0x0000000186402770-0x0000000186402810
		// [XID] // 0x0000000189A31B00-0x0000000189A31B20
		public override void Dealloc() {} // 0x0000000186401A90-0x0000000186401C10
	}
}
