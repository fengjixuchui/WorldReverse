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
	internal class MiHoYoSDKBindMailByCodeDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8836
	{
		// Fields
		private const string BindMailByCodePrefabPath = "UI/BindMailByCodeDialog.Prefab"; // Metadata: 0x00AE2407
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE2429
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE243B
		private const string BindDescTextPath = "Dialog/Content/DescTxt"; // Metadata: 0x00AE244E
		private const string MailInputPath = "Dialog/Content/MailInput/InputField"; // Metadata: 0x00AE2468
		private const string CodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE248F
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE24B6
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE24D2
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE24F5
		private const string BindTipsPath = "Dialog/Content/DescTxt"; // Metadata: 0x00AE251D
		private const string SubmitButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE2537
		private Button backButton; // 0x20
		private Button closeButton; // 0x28
		private GameObject closeButtonObject; // 0x30
		private UnityEngine.UI.Text bindDescText; // 0x38
		private InputField mailInput; // 0x40
		private InputField codeInput; // 0x48
		private Button submitButton; // 0x50
		private Button requestCodeButton; // 0x58
		private UnityEngine.UI.Text requestCodeText; // 0x60
		private UnityEngine.UI.Text submitButtonText; // 0x68
		private bool isRequestVerifyCode; // 0x70
		private float countDownTime; // 0x74
		private bool retrieveFlag; // 0x78
		private BIND_TYPE bindType; // 0x7C
		private string ticket; // 0x80
		private static MiHoYoSDKBindMailByCodeDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKBindMailByCodeDialog() {} // 0x0000000186406410-0x0000000186406470
	
		// Methods
		// [XID] // 0x0000000189861AA0-0x0000000189861AC0
		public static MiHoYoSDKBindMailByCodeDialog Instance() => default; // 0x00000001864054C0-0x00000001864055D0
		// [XID] // 0x00000001898693E0-0x0000000189869400
		public static bool IsExist() => default; // 0x00000001864055D0-0x00000001864056D0
		// [XID] // 0x0000000189B662A0-0x0000000189B662C0
		public void Init() {} // 0x00000001864049D0-0x00000001864054C0
		// [XID] // 0x00000001896D8AA0-0x00000001896D8AC0
		public void Show(string actionTicket = null) {} // 0x0000000186405AF0-0x0000000186405BC0
		// [XID] // 0x000000018987F630-0x000000018987F650
		public void Hide() {} // 0x0000000186404900-0x00000001864049D0
		// [XID] // 0x0000000189B74E30-0x0000000189B74E50
		public void Back() {} // 0x00000001864040A0-0x0000000186404170
		// [XID] // 0x0000000189B7C370-0x0000000189B7C390
		public void Close() {} // 0x0000000186404580-0x0000000186404660
		// [XID] // 0x0000000189843B00-0x0000000189843B20
		public void ResetCountDown() {} // 0x0000000186405A50-0x0000000186405AF0
		// [XID] // 0x000000018989CB60-0x000000018989CB80
		private void ValueChangePhoneInput() {} // 0x0000000186406360-0x0000000186406410
		// [XID] // 0x000000018977C640-0x000000018977C660
		private void Bind() {} // 0x0000000186404170-0x0000000186404580
		// [XID] // 0x00000001898AB580-0x00000001898AB5A0
		private void RequestVerifyMessage() {} // 0x0000000186405850-0x0000000186405A50
		[DebuggerHidden] // 0x00000001898B2E20-0x00000001898B2E60
		// [XID] // 0x00000001898B2E20-0x00000001898B2E60
		private IEnumerator CountDown(float time) => default; // 0x0000000186404660-0x0000000186404780
		// [XID] // 0x0000000189795BA0-0x0000000189795BC0
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000186405DD0-0x0000000186406360
		// [XID] // 0x00000001896C9B70-0x00000001896C9B90
		private void OnClickTab() {} // 0x0000000186405770-0x0000000186405850
		// [XID] // 0x00000001896D1360-0x00000001896D1380
		private void OnClickReturn() {} // 0x00000001864056D0-0x0000000186405770
		// [XID] // 0x00000001898D3FA0-0x00000001898D3FC0
		public override void Dealloc() {} // 0x0000000186404780-0x0000000186404900
	}
}
