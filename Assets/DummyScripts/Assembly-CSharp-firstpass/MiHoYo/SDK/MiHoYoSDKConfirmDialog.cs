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
	internal class MiHoYoSDKConfirmDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8846
	{
		// Fields
		private const string GuestDialogPrefabPath = "UI/ConfirmDialog.Prefab"; // Metadata: 0x00AE2B58
		private const string ContentTextPath = "Dialog/Content"; // Metadata: 0x00AE2B73
		private const string CancelButtonPath = "Dialog/BtnDialog/CancelBtn"; // Metadata: 0x00AE2B85
		private const string CancelTextPath = "Dialog/BtnDialog/CancelBtn/Text"; // Metadata: 0x00AE2BA3
		private const string OKButtonPath = "Dialog/BtnDialog/OKBtn"; // Metadata: 0x00AE2BC6
		private const string OKTextPath = "Dialog/BtnDialog/OKBtn/Text"; // Metadata: 0x00AE2BE0
		private UnityEngine.UI.Text contentText; // 0x20
		private Button cancelButton; // 0x28
		private UnityEngine.UI.Text cancelText; // 0x30
		private Button okButton; // 0x38
		private UnityEngine.UI.Text okText; // 0x40
		private Action _okCallback; // 0x48
		private Action _cancelCallback; // 0x50
		private static MiHoYoSDKConfirmDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKConfirmDialog() {} // 0x0000000184DE9EC0-0x0000000184DE9F20
	
		// Methods
		// [XID] // 0x00000001896959E0-0x0000000189695A00
		public static MiHoYoSDKConfirmDialog Instance() => default; // 0x0000000184DE98F0-0x0000000184DE9A00
		// [XID] // 0x000000018968E110-0x000000018968E130
		public static bool IsExist() => default; // 0x0000000184DE9A00-0x0000000184DE9B00
		// [XID] // 0x00000001896D15A0-0x00000001896D15C0
		public void Init() {} // 0x0000000184DE9420-0x0000000184DE98F0
		// [XID] // 0x0000000189926210-0x0000000189926230
		public void Show(string content = "" /* Metadata: 0x00AE2B54 */, Action okCallback = null, Action cancelCallback = null, string okTitle = null, string cancelTitle = null) {} // 0x0000000184DE9BB0-0x0000000184DE9E60
		// [XID] // 0x00000001896E04B0-0x00000001896E04D0
		public void Cancel() {} // 0x0000000184DE9140-0x0000000184DE91F0
		// [XID] // 0x00000001896E7770-0x00000001896E7790
		public void OK() {} // 0x0000000184DE9B00-0x0000000184DE9BB0
		// [XID] // 0x0000000189934DB0-0x0000000189934DD0
		public void Hide() {} // 0x0000000184DE9350-0x0000000184DE9420
		// [XID] // 0x0000000189678090-0x00000001896780B0
		private void Close() {} // 0x0000000184DE91F0-0x0000000184DE9290
		// [XID] // 0x00000001896FDF80-0x00000001896FDFA0
		public override void Dealloc() {} // 0x0000000184DE9290-0x0000000184DE9350
	}
}
