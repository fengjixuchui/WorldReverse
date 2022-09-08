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
	internal class MiHoYoSDKOverseaVerifyPhone : MiHoYoSDKBaseDialog // TypeDefIndex: 8863
	{
		// Fields
		private const string OverSeaVerifyPhonePrefabPath = "UI/OverSeaVerifyPhoneDialog.Prefab"; // Metadata: 0x00AE3747
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE376D
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE3780
		private const string ContentTitlePath = "Dialog/Content/Title"; // Metadata: 0x00AE3792
		private const string ContentTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE37AA
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE37C1
		private const string VerifyCodeInputTipsPath = "Dialog/Content/CodeInput/InputField/Placeholder"; // Metadata: 0x00AE37E8
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE381B
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE383E
		private const string NextButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE3866
		private const string NextButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE3882
		private Button backButton; // 0x20
		private GameObject closeButtonObject; // 0x28
		private Button closeButton; // 0x30
		private UnityEngine.UI.Text contentTitle; // 0x38
		private UnityEngine.UI.Text contentText; // 0x40
		private InputField verifycodeInput; // 0x48
		private Button requestCodeButton; // 0x50
		private UnityEngine.UI.Text requestCodeText; // 0x58
		private Button nextButton; // 0x60
		private UnityEngine.UI.Text nextButtonText; // 0x68
		private bool isRequestVerifyCode; // 0x70
		private float countDownTime; // 0x74
		private bool retrieveFlag; // 0x78
		private MiHoYoSDKUserDataModel userData; // 0x80
		private string ticket; // 0x88
		private static MiHoYoSDKOverseaVerifyPhone _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKOverseaVerifyPhone() {} // 0x00000001862537E0-0x0000000186253850
	
		// Methods
		// [XID] // 0x00000001896BE080-0x00000001896BE0A0
		public static MiHoYoSDKOverseaVerifyPhone Instance() => default; // 0x0000000186252180-0x0000000186252290
		// [XID] // 0x00000001896C5970-0x00000001896C5990
		public static bool IsExist() => default; // 0x0000000186252290-0x0000000186252390
		// [XID] // 0x00000001896CCFC0-0x00000001896CCFE0
		public void Init() {} // 0x0000000186251820-0x0000000186252180
		// [XID] // 0x00000001896D43E0-0x00000001896D4400
		public void Show(MiHoYoSDKUserDataModel model) {} // 0x0000000186252C00-0x0000000186252F50
		// [XID] // 0x000000018972A4A0-0x000000018972A4C0
		public void Hide() {} // 0x0000000186251750-0x0000000186251820
		// [XID] // 0x00000001896E33A0-0x00000001896E33C0
		private void Close() {} // 0x00000001862513D0-0x00000001862514B0
		// [XID] // 0x00000001896EA8A0-0x00000001896EA8C0
		private void Back() {} // 0x0000000186251300-0x00000001862513D0
		// [XID] // 0x00000001896F1910-0x00000001896F1930
		public void ResetCountDown() {} // 0x0000000186252B60-0x0000000186252C00
		// [XID] // 0x0000000189741020-0x0000000189741040
		private void RequestVerifyMessage() {} // 0x0000000186252930-0x0000000186252B60
		// [XID] // 0x0000000189700D70-0x0000000189700D90
		private void Submit() {} // 0x0000000186252F50-0x00000001862531D0
		[DebuggerHidden] // 0x0000000189708350-0x0000000189708390
		// [XID] // 0x0000000189708350-0x0000000189708390
		private IEnumerator CountDown(float time) => default; // 0x00000001862514B0-0x00000001862515D0
		// [XID] // 0x0000000189712BF0-0x0000000189712C10
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000186253230-0x00000001862537E0
		// [XID] // 0x000000018971A5D0-0x000000018971A5F0
		private void OnClickTab() {} // 0x0000000186252430-0x00000001862524F0
		// [XID] // 0x00000001897217E0-0x0000000189721800
		private void OnClickReturn() {} // 0x0000000186252390-0x0000000186252430
		// [XID] // 0x0000000189728E20-0x0000000189728E40
		private void OnGetActionTicket(string responseString) {} // 0x00000001862524F0-0x0000000186252880
		// [XID] // 0x000000018983D120-0x000000018983D140
		private void OnTimeOut() {} // 0x0000000186252880-0x0000000186252930
		// [XID] // 0x00000001897380A0-0x00000001897380C0
		public override void Dealloc() {} // 0x00000001862515D0-0x0000000186251750
	}
}
