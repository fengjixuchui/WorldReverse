/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelGalleySide : MonoBehaviour // TypeDefIndex: 31225
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _hintProgress; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintSubProgress; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _resetBtnSwitch; // 0x30
	
		// Properties
		public string hintProgress { /* [XID] */ /* 0x000000018980AB00-0x000000018980AB20 */ set {} } // 0x0000000183D59160-0x0000000183D59230
		public string hintSubProgress { /* [XID] */ /* 0x0000000189812110-0x0000000189812130 */ set {} } // 0x0000000183D59230-0x0000000183D59300
		public MonoControlElement keyElement { /* [XID] */ /* 0x000000018982FF40-0x000000018982FF60 */ get => default; } // 0x0000000183D58F80-0x0000000183D590A0 
		public MonoUIContainer resetBtnContainer { /* [XID] */ /* 0x0000000189837680-0x00000001898376A0 */ get => default; } // 0x0000000183D590A0-0x0000000183D59160 
	
		// Constructors
		public MonoInLevelGalleySide() {} // 0x0000000183D58F00-0x0000000183D58F80
	
		// Methods
		// [XID] // 0x0000000189819CC0-0x0000000189819CE0
		public void SetSubHintVisible(bool bVis) {} // 0x0000000183D58C70-0x0000000183D58D50
		// [XID] // 0x0000000189821540-0x0000000189821560
		public void TriggerProgressUpdate() {} // 0x0000000183D58E20-0x0000000183D58F00
		// [XID] // 0x0000000189828B30-0x0000000189828B50
		public void SetValid(bool value) {} // 0x0000000183D58D50-0x0000000183D58E20
	}
}
