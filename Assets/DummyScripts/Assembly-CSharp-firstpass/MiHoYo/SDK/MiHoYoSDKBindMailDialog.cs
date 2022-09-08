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
	internal class MiHoYoSDKBindMailDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8838
	{
		// Fields
		private const string BindMailPrefabPath = "UI/BindMailDialog.Prefab"; // Metadata: 0x00AE2558
		private const string OverSeaBindMailPrefabPath = "UI/OverSeaBindMailDialog.Prefab"; // Metadata: 0x00AE2574
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE2597
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE25AA
		private const string MailInputPath = "Dialog/Content/MailInput/InputField"; // Metadata: 0x00AE25BC
		private const string PasswordInputPath = "Dialog/Content/PasswordInput/InputField"; // Metadata: 0x00AE25E3
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE260E
		private const string RegisterButtonPath = "Dialog/Content/RegisterBtn"; // Metadata: 0x00AE262A
		private const string ForgetPasswordButtonPath = "Dialog/Content/ForgetPswBtn"; // Metadata: 0x00AE2648
		private const string SubmitButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE2667
		private const string RegisterButtonTextPath = "Dialog/Content/RegisterBtn/Text"; // Metadata: 0x00AE2688
		private const string ForgetPasswordButtonTextPath = "Dialog/Content/ForgetPswBtn/Text"; // Metadata: 0x00AE26AB
		private Button closeButton; // 0x20
		private Button backButton; // 0x28
		private InputField mailInput; // 0x30
		private InputField passwordInput; // 0x38
		private Button submitButton; // 0x40
		private Button registerButton; // 0x48
		private Button forgetPasswordButton; // 0x50
		private UnityEngine.UI.Text submitButtonText; // 0x58
		private UnityEngine.UI.Text registerButtonText; // 0x60
		private UnityEngine.UI.Text forgetPasswordButtonText; // 0x68
		private BIND_TYPE bindType; // 0x70
		private static MiHoYoSDKBindMailDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKBindMailDialog() {} // 0x0000000186408250-0x00000001864082B0
	
		// Methods
		// [XID] // 0x0000000189ACC760-0x0000000189ACC780
		public static MiHoYoSDKBindMailDialog Instance() => default; // 0x00000001864078A0-0x00000001864079B0
		// [XID] // 0x000000018980AF70-0x000000018980AF90
		public static bool IsExist() => default; // 0x00000001864079B0-0x0000000186407AB0
		// [XID] // 0x000000018981A240-0x000000018981A260
		public void Init() {} // 0x0000000186406E60-0x00000001864078A0
		// [XID] // 0x000000018994AD10-0x000000018994AD30
		public void Show(BIND_TYPE type) {} // 0x00000001864080F0-0x00000001864081F0
		// [XID] // 0x0000000189B67BB0-0x0000000189B67BD0
		public void Hide() {} // 0x0000000186406D90-0x0000000186406E60
		// [XID] // 0x0000000189959B50-0x0000000189959B70
		public void Close() {} // 0x00000001864068B0-0x0000000186406970
		// [XID] // 0x0000000189961600-0x0000000189961620
		public void Back() {} // 0x0000000186406470-0x00000001864065A0
		// [XID] // 0x00000001897EA1C0-0x00000001897EA1E0
		private void Bind() {} // 0x00000001864065A0-0x00000001864068B0
		// [XID] // 0x00000001899702E0-0x0000000189970300
		private void Register() {} // 0x0000000186407E50-0x00000001864080F0
		// [XID] // 0x00000001896E4050-0x00000001896E4070
		private void ForgetPassword() {} // 0x0000000186406AF0-0x0000000186406D90
		// [XID] // 0x000000018986B5E0-0x000000018986B600
		private void OnRegisterAccount(string username, string pwd) {} // 0x0000000186407D40-0x0000000186407E50
		// [XID] // 0x0000000189B7D140-0x0000000189B7D160
		private void OnForgetPassword(string username, string pwd) {} // 0x0000000186407C30-0x0000000186407D40
		// [XID] // 0x000000018998E6B0-0x000000018998E6D0
		private void OnClickTab() {} // 0x0000000186407B50-0x0000000186407C30
		// [XID] // 0x0000000189AE51E0-0x0000000189AE5200
		private void OnClickReturn() {} // 0x0000000186407AB0-0x0000000186407B50
		// [XID] // 0x000000018999DB80-0x000000018999DBA0
		public override void Dealloc() {} // 0x0000000186406970-0x0000000186406AF0
	}
}
