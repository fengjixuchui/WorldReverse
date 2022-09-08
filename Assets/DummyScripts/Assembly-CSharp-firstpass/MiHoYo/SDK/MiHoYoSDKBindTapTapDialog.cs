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
	internal class MiHoYoSDKBindTapTapDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8843
	{
		// Fields
		private const string BindTapTapPrefabPath = "UI/BindTapTapDialog.Prefab"; // Metadata: 0x00AE2978
		private const string BindButtonPath = "Dialog/BindBtn"; // Metadata: 0x00AE2996
		private const string RegisterButtonPath = "Dialog/RegisterBtn"; // Metadata: 0x00AE29A8
		private const string BindTapTapTipsTextPath = "Dialog/ContentText"; // Metadata: 0x00AE29BE
		private const string BindButtonTextPath = "Dialog/BindBtn/Text"; // Metadata: 0x00AE29D4
		private const string RegisterButtonTextPath = "Dialog/RegisterBtn/Text"; // Metadata: 0x00AE29EB
		private Button bindButton; // 0x20
		private Button registerButton; // 0x28
		private UnityEngine.UI.Text tipsText; // 0x30
		private UnityEngine.UI.Text bindButtonText; // 0x38
		private UnityEngine.UI.Text registerButtonText; // 0x40
		private static MiHoYoSDKBindTapTapDialog _instance; // 0x00
	
		// Events
		public event Action OnTapBindButton;
		public event Action OnTapRegisterButton;
	
		// Constructors
		public MiHoYoSDKBindTapTapDialog() {} // 0x0000000186411990-0x00000001864119F0
	
		// Methods
		// [XID] // 0x0000000189679DA0-0x0000000189679DC0
		public static MiHoYoSDKBindTapTapDialog Instance() => default; // 0x0000000186411320-0x0000000186411430
		// [XID] // 0x00000001895F9020-0x00000001895F9040
		public static bool IsExist() => default; // 0x0000000186411430-0x0000000186411530
		// [XID] // 0x0000000189BC98D0-0x0000000189BC98F0
		public void Init() {} // 0x0000000186410E90-0x0000000186411320
		// [XID] // 0x0000000189B24600-0x0000000189B24620
		private void UpdateContent() {} // 0x0000000186411700-0x0000000186411990
		// [XID] // 0x0000000189B1CF10-0x0000000189B1CF30
		public void Show() {} // 0x00000001864115E0-0x00000001864116A0
		// [XID] // 0x0000000189616A50-0x0000000189616A70
		public void Hide() {} // 0x0000000186410DC0-0x0000000186410E90
		// [XID] // 0x000000018961E4A0-0x000000018961E4C0
		private void Bind() {} // 0x0000000186410C50-0x0000000186410D00
		// [XID] // 0x0000000189BD1050-0x0000000189BD1070
		private void Register() {} // 0x0000000186411530-0x00000001864115E0
		// [XID] // 0x000000018962D220-0x000000018962D240
		public override void Dealloc() {} // 0x0000000186410D00-0x0000000186410DC0
	}
}
