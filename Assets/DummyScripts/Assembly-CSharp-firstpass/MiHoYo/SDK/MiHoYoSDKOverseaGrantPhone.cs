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
	internal class MiHoYoSDKOverseaGrantPhone : MiHoYoSDKBaseDialog // TypeDefIndex: 8861
	{
		// Fields
		private const string OverSeaGrantPhonePrefabPath = "UI/OverSeaGrantPhoneDialog.Prefab"; // Metadata: 0x00AE35A4
		private const string DialogPath = "Dialog"; // Metadata: 0x00AE35C9
		private const string QuestionButtonPath = "Dialog/QuestionBtn"; // Metadata: 0x00AE35D3
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE35E9
		private const string ContentTitlePath = "Dialog/Content/Title"; // Metadata: 0x00AE35FB
		private const string ContentTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE3613
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE362A
		private const string VerifyCodeInputTipsPath = "Dialog/Content/CodeInput/InputField/Placeholder"; // Metadata: 0x00AE3651
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE3684
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE36A7
		private const string NextButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE36CF
		private const string NextButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE36EB
		private const string OtherButtonPath = "Dialog/Content/OtherBtn"; // Metadata: 0x00AE370C
		private const string OtherButtonTextPath = "Dialog/Content/OtherBtn/Text"; // Metadata: 0x00AE3727
		public GameObject dialog; // 0x20
		private Button backButton; // 0x28
		private Button questionButton; // 0x30
		private UnityEngine.UI.Text contentTitle; // 0x38
		private UnityEngine.UI.Text contentText; // 0x40
		private InputField verifycodeInput; // 0x48
		private Button requestCodeButton; // 0x50
		private UnityEngine.UI.Text requestCodeText; // 0x58
		private Button nextButton; // 0x60
		private UnityEngine.UI.Text nextButtonText; // 0x68
		private Button otherButton; // 0x70
		private UnityEngine.UI.Text otherButtonText; // 0x78
		private bool isRequestVerifyCode; // 0x80
		private float countDownTime; // 0x84
		private bool retrieveFlag; // 0x88
		private static MiHoYoSDKOverseaGrantPhone _instance; // 0x00
	
		// Events
		public event Action OnBack;
	
		// Constructors
		public MiHoYoSDKOverseaGrantPhone() {} // 0x0000000185F51800-0x0000000185F51870
	
		// Methods
		// [XID] // 0x0000000189BD78D0-0x0000000189BD78F0
		public static MiHoYoSDKOverseaGrantPhone Instance() => default; // 0x0000000185F50370-0x0000000185F50480
		// [XID] // 0x00000001899D5180-0x00000001899D51A0
		public static bool IsExist() => default; // 0x0000000185F50480-0x0000000185F50580
		// [XID] // 0x00000001896079A0-0x00000001896079C0
		public void Init() {} // 0x0000000185F4F950-0x0000000185F50370
		// [XID] // 0x000000018960F4B0-0x000000018960F4D0
		public void Show(MiHoYoSDKUserDataModel model) {} // 0x0000000185F509D0-0x0000000185F50E30
		// [XID] // 0x0000000189616A30-0x0000000189616A50
		public void Hide() {} // 0x0000000185F4F880-0x0000000185F4F950
		// [XID] // 0x000000018961E480-0x000000018961E4A0
		private void Back() {} // 0x0000000185F4F420-0x0000000185F4F4E0
		// [XID] // 0x00000001896259E0-0x0000000189625A00
		private void Question() {} // 0x0000000185F506E0-0x0000000185F50840
		// [XID] // 0x000000018962D200-0x000000018962D220
		private void ClictOtherButton() {} // 0x0000000185F4F4E0-0x0000000185F4F5D0
		// [XID] // 0x0000000189634D00-0x0000000189634D20
		public void ResetCountDown() {} // 0x0000000185F50930-0x0000000185F509D0
		// [XID] // 0x000000018963C340-0x000000018963C360
		private void RequestVerifyMessage() {} // 0x0000000185F50840-0x0000000185F50930
		// [XID] // 0x0000000189BD55B0-0x0000000189BD55D0
		private void Submit() {} // 0x0000000185F50F70-0x0000000185F511F0
		// [XID] // 0x0000000189B0CA60-0x0000000189B0CA80
		public void StartCountDown() {} // 0x0000000185F50E30-0x0000000185F50F70
		[DebuggerHidden] // 0x00000001896529B0-0x00000001896529F0
		// [XID] // 0x00000001896529B0-0x00000001896529F0
		private IEnumerator CountDown(float time) => default; // 0x0000000185F4F5D0-0x0000000185F4F6F0
		// [XID] // 0x000000018980D520-0x000000018980D540
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000185F51250-0x0000000185F51800
		// [XID] // 0x0000000189664990-0x00000001896649B0
		private void OnClickTab() {} // 0x0000000185F50620-0x0000000185F506E0
		// [XID] // 0x000000018966BFA0-0x000000018966BFC0
		private void OnClickReturn() {} // 0x0000000185F50580-0x0000000185F50620
		// [XID] // 0x0000000189B4D860-0x0000000189B4D880
		public override void Dealloc() {} // 0x0000000185F4F6F0-0x0000000185F4F880
	}
}
