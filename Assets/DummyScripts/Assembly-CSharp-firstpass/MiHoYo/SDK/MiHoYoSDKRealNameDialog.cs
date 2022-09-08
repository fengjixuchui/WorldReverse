/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKRealNameDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8877
	{
		// Fields
		public REAL_NAME_DIALOG_TYPE dialogType; // 0x20
		private const string RealNamePrefabPath = "UI/RealNameAuthDialog.Prefab"; // Metadata: 0x00AE3EA4
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE3EC4
		private const string QuestionButtonPath = "Dialog/QuestionBtn"; // Metadata: 0x00AE3ED6
		private const string NameInputPath = "Dialog/Content/NameInput/InputField"; // Metadata: 0x00AE3EEC
		private const string IDInputPath = "Dialog/Content/IDInput/InputField"; // Metadata: 0x00AE3F13
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE3F38
		private const string SubmitButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE3F54
		private Button backButton; // 0x28
		private Button questionButton; // 0x30
		private InputField nameInput; // 0x38
		private InputField idInput; // 0x40
		private Button submitButton; // 0x48
		private UnityEngine.UI.Text submitButtonText; // 0x50
		private Action closeCallback; // 0x58
		private static MiHoYoSDKRealNameDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKRealNameDialog() {} // 0x000000018626BBC0-0x000000018626BC20
	
		// Methods
		// [XID] // 0x0000000189ABFD70-0x0000000189ABFD90
		public static MiHoYoSDKRealNameDialog Instance() => default; // 0x000000018626B100-0x000000018626B210
		// [XID] // 0x0000000189AC7880-0x0000000189AC78A0
		public static bool IsExist() => default; // 0x000000018626B210-0x000000018626B310
		// [XID] // 0x00000001899232E0-0x0000000189923300
		public void Init() {} // 0x000000018626AA60-0x000000018626B100
		// [XID] // 0x000000018984BD50-0x000000018984BD70
		private void updateText() {} // 0x000000018626BC20-0x000000018626BF10
		// [XID] // 0x0000000189ADE6C0-0x0000000189ADE6E0
		public void Show(REAL_NAME_DIALOG_TYPE type, Action callback = null) {} // 0x000000018626B6A0-0x000000018626B790
		// [XID] // 0x00000001898D0480-0x00000001898D04A0
		private void Confirm() {} // 0x000000018626A1D0-0x000000018626A380
		// [XID] // 0x00000001898E71B0-0x00000001898E71D0
		private string GetAlertContent() => default; // 0x000000018626A5A0-0x000000018626A7E0
		// [XID] // 0x0000000189AF4FA0-0x0000000189AF4FC0
		private void MeetProblem() {} // 0x000000018626B310-0x000000018626B410
		// [XID] // 0x00000001897D4F10-0x00000001897D4F30
		public void Hide() {} // 0x000000018626A980-0x000000018626AA60
		// [XID] // 0x0000000189891140-0x0000000189891160
		public void ClsoeWithoutCallback() {} // 0x000000018626A100-0x000000018626A1D0
		// [XID] // 0x000000018988C320-0x000000018988C340
		public void Close() {} // 0x000000018626A010-0x000000018626A100
		// [XID] // 0x0000000189B12CA0-0x0000000189B12CC0
		public string GetNameInputText() => default; // 0x000000018626A8B0-0x000000018626A980
		// [XID] // 0x0000000189B1A0F0-0x0000000189B1A110
		public string GetIdentityInputText() => default; // 0x000000018626A7E0-0x000000018626A8B0
		// [XID] // 0x0000000189B215C0-0x0000000189B215E0
		private void Submit() {} // 0x000000018626B790-0x000000018626BB60
		// [XID] // 0x00000001898F61A0-0x00000001898F61C0
		private void CancelAuth() {} // 0x0000000186269F60-0x000000018626A010
		// [XID] // 0x0000000189B30210-0x0000000189B30230
		private void ContinueAuth() {} // 0x000000018626A380-0x000000018626A420
		// [XID] // 0x000000018969E100-0x000000018969E120
		private void RequestRealNameAuth() {} // 0x000000018626B590-0x000000018626B6A0
		// [XID] // 0x00000001898737D0-0x00000001898737F0
		private void OnClickTab() {} // 0x000000018626B4B0-0x000000018626B590
		// [XID] // 0x0000000189B46D20-0x0000000189B46D40
		private void OnClickReturn() {} // 0x000000018626B410-0x000000018626B4B0
		// [XID] // 0x00000001898938B0-0x00000001898938D0
		public override void Dealloc() {} // 0x000000018626A420-0x000000018626A5A0
	}
}
