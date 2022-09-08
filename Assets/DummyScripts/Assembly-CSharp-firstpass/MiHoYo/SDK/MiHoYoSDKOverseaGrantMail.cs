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
	internal class MiHoYoSDKOverseaGrantMail : MiHoYoSDKBaseDialog // TypeDefIndex: 8859
	{
		// Fields
		private const string OverSeaGrantMailPrefabPath = "UI/OverSeaGrantMailDialog.Prefab"; // Metadata: 0x00AE3402
		private const string DialogPath = "Dialog"; // Metadata: 0x00AE3426
		private const string QuestionButtonPath = "Dialog/QuestionBtn"; // Metadata: 0x00AE3430
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE3446
		private const string ContentTitlePath = "Dialog/Content/Title"; // Metadata: 0x00AE3458
		private const string ContentTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE3470
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE3487
		private const string VerifyCodeInputTipsPath = "Dialog/Content/CodeInput/InputField/Placeholder"; // Metadata: 0x00AE34AE
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE34E1
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE3504
		private const string NextButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE352C
		private const string NextButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE3548
		private const string OtherButtonPath = "Dialog/Content/OtherBtn"; // Metadata: 0x00AE3569
		private const string OtherButtonTextPath = "Dialog/Content/OtherBtn/Text"; // Metadata: 0x00AE3584
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
		private static MiHoYoSDKOverseaGrantMail _instance; // 0x00
	
		// Events
		public event Action OnBack;
	
		// Constructors
		public MiHoYoSDKOverseaGrantMail() {} // 0x0000000185F4DAA0-0x0000000185F4DB10
	
		// Methods
		// [XID] // 0x00000001898CDC10-0x00000001898CDC30
		public static MiHoYoSDKOverseaGrantMail Instance() => default; // 0x0000000185F4C780-0x0000000185F4C890
		// [XID] // 0x00000001898C6540-0x00000001898C6560
		public static bool IsExist() => default; // 0x0000000185F4C890-0x0000000185F4C990
		// [XID] // 0x00000001898D5630-0x00000001898D5650
		public void Init() {} // 0x0000000185F4BD60-0x0000000185F4C780
		// [XID] // 0x0000000189B2BC40-0x0000000189B2BC60
		public void Show(MiHoYoSDKUserDataModel model) {} // 0x0000000185F4CDF0-0x0000000185F4D0D0
		// [XID] // 0x00000001898F3DC0-0x00000001898F3DE0
		public void Hide() {} // 0x0000000185F4BC90-0x0000000185F4BD60
		// [XID] // 0x0000000189B3AC90-0x0000000189B3ACB0
		private void Back() {} // 0x0000000185F4B830-0x0000000185F4B8F0
		// [XID] // 0x0000000189B423B0-0x0000000189B423D0
		private void Question() {} // 0x0000000185F4CAF0-0x0000000185F4CC50
		// [XID] // 0x0000000189634870-0x0000000189634890
		public void ResetCountDown() {} // 0x0000000185F4CD50-0x0000000185F4CDF0
		// [XID] // 0x0000000189B516A0-0x0000000189B516C0
		private void RequestVerifyMessage() {} // 0x0000000185F4CC50-0x0000000185F4CD50
		// [XID] // 0x0000000189B58F40-0x0000000189B58F60
		private void Submit() {} // 0x0000000185F4D210-0x0000000185F4D490
		// [XID] // 0x0000000189860290-0x00000001898602B0
		private void ClictOtherButton() {} // 0x0000000185F4B8F0-0x0000000185F4B9E0
		// [XID] // 0x0000000189982650-0x0000000189982670
		public void StartCountDown() {} // 0x0000000185F4D0D0-0x0000000185F4D210
		[DebuggerHidden] // 0x0000000189B6F0C0-0x0000000189B6F100
		// [XID] // 0x0000000189B6F0C0-0x0000000189B6F100
		private IEnumerator CountDown(float time) => default; // 0x0000000185F4B9E0-0x0000000185F4BB00
		// [XID] // 0x0000000189B798E0-0x0000000189B79900
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000185F4D4F0-0x0000000185F4DAA0
		// [XID] // 0x0000000189B69DB0-0x0000000189B69DD0
		private void OnClickTab() {} // 0x0000000185F4CA30-0x0000000185F4CAF0
		// [XID] // 0x0000000189B88720-0x0000000189B88740
		private void OnClickReturn() {} // 0x0000000185F4C990-0x0000000185F4CA30
		// [XID] // 0x0000000189B8F9E0-0x0000000189B8FA00
		public override void Dealloc() {} // 0x0000000185F4BB00-0x0000000185F4BC90
	}
}
