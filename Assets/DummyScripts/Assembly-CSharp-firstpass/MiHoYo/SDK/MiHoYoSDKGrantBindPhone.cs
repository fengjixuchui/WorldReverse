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
	internal class MiHoYoSDKGrantBindPhone : MiHoYoSDKBaseDialog // TypeDefIndex: 8854
	{
		// Fields
		private const string GrantBindPhonePrefabPath = "UI/GrantBindPhoneDialog.Prefab"; // Metadata: 0x00AE310C
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE312E
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE3141
		private const string BindPhoneTextPath = "Dialog/Content/PhoneTxt"; // Metadata: 0x00AE3153
		private const string VerifyCodeInputPath = "Dialog/Content/CodeInput/InputField"; // Metadata: 0x00AE316E
		private const string RequestCodeButtonPath = "Dialog/Content/CodeInput/Button"; // Metadata: 0x00AE3195
		private const string RequestCodeTextPath = "Dialog/Content/CodeInput/Button/Text"; // Metadata: 0x00AE31B8
		private const string LoginButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE31E0
		private const string GrantSafePhoneButtonPath = "Dialog/Content/SafeMobileBtn"; // Metadata: 0x00AE31FC
		private const string QuestionButtonPath = "Dialog/Content/QuestionBtn"; // Metadata: 0x00AE321C
		private Button backButton; // 0x20
		private Button closeButton; // 0x28
		private UnityEngine.UI.Text phoneText; // 0x30
		private InputField verifycodeInput; // 0x38
		private Button requestCodeButton; // 0x40
		private UnityEngine.UI.Text requestCodeText; // 0x48
		private Button loginButton; // 0x50
		private Button grantSafePhoneButton; // 0x58
		private Button questionButton; // 0x60
		private bool isRequestVerifyCode; // 0x68
		private float countDownTime; // 0x6C
		private bool retrieveFlag; // 0x70
		private static MiHoYoSDKGrantBindPhone _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKGrantBindPhone() {} // 0x0000000184DF7EB0-0x0000000184DF7F20
	
		// Methods
		// [XID] // 0x0000000189B26A90-0x0000000189B26AB0
		public static MiHoYoSDKGrantBindPhone Instance() => default; // 0x0000000184DF6E20-0x0000000184DF6F30
		// [XID] // 0x000000018995B170-0x000000018995B190
		public static bool IsExist() => default; // 0x0000000184DF6F30-0x0000000184DF7030
		// [XID] // 0x0000000189AF4110-0x0000000189AF4130
		public void Init() {} // 0x0000000184DF6720-0x0000000184DF6E20
		// [XID] // 0x0000000189943650-0x0000000189943670
		public void Show(MiHoYoSDKUserDataModel model) {} // 0x0000000184DF7560-0x0000000184DF7760
		// [XID] // 0x0000000189AE5DC0-0x0000000189AE5DE0
		public void Hide() {} // 0x0000000184DF6650-0x0000000184DF6720
		// [XID] // 0x00000001899526E0-0x0000000189952700
		public void StartCountDown() {} // 0x0000000184DF7760-0x0000000184DF78A0
		// [XID] // 0x0000000189959B30-0x0000000189959B50
		private void Close() {} // 0x0000000184DF62F0-0x0000000184DF63B0
		// [XID] // 0x00000001899615E0-0x0000000189961600
		private void Back() {} // 0x0000000184DF6080-0x0000000184DF6140
		// [XID] // 0x0000000189968B90-0x0000000189968BB0
		private void ClickGrantSafePhoneButton() {} // 0x0000000184DF6140-0x0000000184DF6200
		// [XID] // 0x00000001899702C0-0x00000001899702E0
		private void ClickQuestionButton() {} // 0x0000000184DF6200-0x0000000184DF62F0
		// [XID] // 0x0000000189978100-0x0000000189978120
		public void ResetCountDown() {} // 0x0000000184DF74C0-0x0000000184DF7560
		// [XID] // 0x000000018997F1E0-0x000000018997F200
		private void RequestVerifyMessage() {} // 0x0000000184DF73F0-0x0000000184DF74C0
		// [XID] // 0x0000000189A2E0E0-0x0000000189A2E100
		private void Login() {} // 0x0000000184DF7030-0x0000000184DF7290
		[DebuggerHidden] // 0x000000018998E670-0x000000018998E6B0
		// [XID] // 0x000000018998E670-0x000000018998E6B0
		private IEnumerator CountDown(float time) => default; // 0x0000000184DF63B0-0x0000000184DF64D0
		// [XID] // 0x0000000189B712E0-0x0000000189B71300
		private void UpdateRequestCodeButtonStatus() {} // 0x0000000184DF7900-0x0000000184DF7EB0
		// [XID] // 0x0000000189A536B0-0x0000000189A536D0
		private void OnClickTab() {} // 0x0000000184DF7330-0x0000000184DF73F0
		// [XID] // 0x00000001899A86A0-0x00000001899A86C0
		private void OnClickReturn() {} // 0x0000000184DF7290-0x0000000184DF7330
		// [XID] // 0x00000001899AFF10-0x00000001899AFF30
		public override void Dealloc() {} // 0x0000000184DF64D0-0x0000000184DF6650
	}
}
