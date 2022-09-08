/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKGameAlertDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8847
	{
		// Fields
		private const string AlertDialogPrefabPath = "UI/GameAlertDialog.Prefab"; // Metadata: 0x00AE2BFF
		private const string ContentTextPath = "Dialog/Content/DescText"; // Metadata: 0x00AE2C1C
		private const string CancelButtonPath = "Dialog/Content/ActionBtns/BtnCancel"; // Metadata: 0x00AE2C37
		private const string CancelButtonTextPath = "Dialog/Content/ActionBtns/BtnCancel/Text"; // Metadata: 0x00AE2C5E
		private const string OKButtonPath = "Dialog/Content/ActionBtns/BtnOK"; // Metadata: 0x00AE2C8A
		private const string OKButtonTextPath = "Dialog/Content/ActionBtns/BtnOK/Text"; // Metadata: 0x00AE2CAD
		private UnityEngine.UI.Text contentText; // 0x20
		private GameObject okButtonObject; // 0x28
		private Button okButton; // 0x30
		private UnityEngine.UI.Text okButtonText; // 0x38
		private Button cancelButton; // 0x40
		private UnityEngine.UI.Text cancelButtonText; // 0x48
		private Action _callback; // 0x50
		private static MiHoYoSDKGameAlertDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKGameAlertDialog() {} // 0x0000000184DF4F90-0x0000000184DF4FF0
	
		// Methods
		// [XID] // 0x00000001897052F0-0x0000000189705310
		public static MiHoYoSDKGameAlertDialog Instance() => default; // 0x0000000184DF4B10-0x0000000184DF4C20
		// [XID] // 0x0000000189ADEC90-0x0000000189ADECB0
		public static bool IsExist() => default; // 0x0000000184DF4C20-0x0000000184DF4D20
		// [XID] // 0x0000000189AD7230-0x0000000189AD7250
		public void Init() {} // 0x0000000184DF46D0-0x0000000184DF4B10
		// [XID] // 0x000000018971BCA0-0x000000018971BCC0
		public void Show(string content, string cancelButtonTitle, string okButtonTitle, Action callback) {} // 0x0000000184DF4D20-0x0000000184DF4F30
		// [XID] // 0x0000000189AE65E0-0x0000000189AE6600
		public void Hide() {} // 0x0000000184DF4600-0x0000000184DF46D0
		// [XID] // 0x0000000189636110-0x0000000189636130
		private void Close() {} // 0x0000000184DF43B0-0x0000000184DF4450
		// [XID] // 0x0000000189AA9670-0x0000000189AA9690
		private void Confirm() {} // 0x0000000184DF4450-0x0000000184DF4540
		// [XID] // 0x0000000189739620-0x0000000189739640
		private void Cancel() {} // 0x0000000184DF42F0-0x0000000184DF43B0
		// [XID] // 0x0000000189668D60-0x0000000189668D80
		public override void Dealloc() {} // 0x0000000184DF4540-0x0000000184DF4600
	}
}
