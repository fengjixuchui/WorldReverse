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
	internal class MiHoYoSDKAlertDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8845
	{
		// Fields
		private const string GuestDialogPrefabPath = "UI/AlertDialog.Prefab"; // Metadata: 0x00AE2AD4
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE2AED
		private const string ContentTextPath = "Dialog/Content/Text"; // Metadata: 0x00AE2B00
		private const string SubmitButtonPath = "Dialog/Content/SubmitBtn"; // Metadata: 0x00AE2B17
		private const string ButtonTextPath = "Dialog/Content/SubmitBtn/Text"; // Metadata: 0x00AE2B33
		private Button closeButton; // 0x20
		private UnityEngine.UI.Text contentText; // 0x28
		private Button submitButton; // 0x30
		private UnityEngine.UI.Text buttonText; // 0x38
		private Action _callback; // 0x40
		private Action _closeCallback; // 0x48
		private static MiHoYoSDKAlertDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKAlertDialog() {} // 0x00000001859EC680-0x00000001859EC6E0
	
		// Methods
		// [XID] // 0x0000000189A779A0-0x0000000189A779C0
		public static MiHoYoSDKAlertDialog Instance() => default; // 0x00000001859EC080-0x00000001859EC190
		// [XID] // 0x00000001896874C0-0x00000001896874E0
		public static bool IsExist() => default; // 0x00000001859EC190-0x00000001859EC290
		// [XID] // 0x000000018968F300-0x000000018968F320
		public void Init() {} // 0x00000001859EBC50-0x00000001859EC080
		// [XID] // 0x0000000189AEF230-0x0000000189AEF250
		public void Show(string content = "" /* Metadata: 0x00AE2AD0 */, string buttonTitle = null, Action callback = null, Action closeCallback = null) {} // 0x00000001859EC360-0x00000001859EC560
		// [XID] // 0x000000018969E300-0x000000018969E320
		public void Hide() {} // 0x00000001859EBB60-0x00000001859EBC50
		// [XID] // 0x00000001896A5380-0x00000001896A53A0
		private void Close() {} // 0x00000001859EBA00-0x00000001859EBAA0
		// [XID] // 0x00000001896ACC00-0x00000001896ACC20
		private void Submit() {} // 0x00000001859EC560-0x00000001859EC620
		// [XID] // 0x00000001896B4020-0x00000001896B4040
		private void OnClickJoyPadBtn(KeyCode keyCode) {} // 0x00000001859EC290-0x00000001859EC360
		// [XID] // 0x00000001896BB520-0x00000001896BB540
		public override void Dealloc() {} // 0x00000001859EBAA0-0x00000001859EBB60
	}
}
