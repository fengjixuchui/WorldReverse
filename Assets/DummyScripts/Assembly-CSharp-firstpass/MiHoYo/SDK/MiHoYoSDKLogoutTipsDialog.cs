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
	internal class MiHoYoSDKLogoutTipsDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8858
	{
		// Fields
		private const string GuestDialogPrefabPath = "UI/LogoutTipsDialog.Prefab"; // Metadata: 0x00AE3348
		private const string CloseButtonPath = "Dialog/CloseContent/CloseBtn"; // Metadata: 0x00AE3366
		private const string TitleTextPath = "Dialog/TitleContent/Text"; // Metadata: 0x00AE3386
		private const string ContentTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE33A2
		private const string SubmitButtonPath = "Dialog/ButtonContent/SubmitBtn"; // Metadata: 0x00AE33B9
		private const string ButtonTextPath = "Dialog/ButtonContent/SubmitBtn/Text"; // Metadata: 0x00AE33DB
		private Button closeButton; // 0x20
		private UnityEngine.UI.Text titleText; // 0x28
		private UnityEngine.UI.Text contentText; // 0x30
		private Button submitButton; // 0x38
		private UnityEngine.UI.Text buttonText; // 0x40
		private Action _callback; // 0x48
		private Action _closeCallback; // 0x50
		private static MiHoYoSDKLogoutTipsDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKLogoutTipsDialog() {} // 0x0000000185F393C0-0x0000000185F39420
	
		// Methods
		// [XID] // 0x00000001899C2550-0x00000001899C2570
		public static MiHoYoSDKLogoutTipsDialog Instance() => default; // 0x0000000185F38F70-0x0000000185F39080
		// [XID] // 0x0000000189AC78A0-0x0000000189AC78C0
		public static bool IsExist() => default; // 0x0000000185F39080-0x0000000185F39180
		// [XID] // 0x0000000189ACEF10-0x0000000189ACEF30
		public void Init() {} // 0x0000000185F389F0-0x0000000185F38F70
		// [XID] // 0x0000000189AD6D50-0x0000000189AD6D70
		public void Show(Action callback = null, Action closeCallback = null) {} // 0x0000000185F39180-0x0000000185F392A0
		// [XID] // 0x0000000189839180-0x00000001898391A0
		public void Hide() {} // 0x0000000185F38900-0x0000000185F389F0
		// [XID] // 0x0000000189824580-0x00000001898245A0
		private void Close() {} // 0x0000000185F387A0-0x0000000185F38840
		// [XID] // 0x0000000189831AD0-0x0000000189831AF0
		private void Submit() {} // 0x0000000185F392A0-0x0000000185F39360
		// [XID] // 0x00000001896CB1F0-0x00000001896CB210
		public override void Dealloc() {} // 0x0000000185F38840-0x0000000185F38900
	}
}
