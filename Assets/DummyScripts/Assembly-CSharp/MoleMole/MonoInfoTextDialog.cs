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
	public class MonoInfoTextDialog : MonoUIProxy // TypeDefIndex: 31222
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _freeClickBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _label; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _bgCanvasGroup; // 0x50
		// [Range] // 0x00000001896FE3F0-0x00000001896FE440
		[SerializeField] // 0x00000001896FE3F0-0x00000001896FE440
		[Space] // 0x00000001896FE3F0-0x00000001896FE440
		private float _autoCloseLimit; // 0x58
	
		// Properties
		public Button freeClickButton { /* [XID] */ /* 0x000000018970B6F0-0x000000018970B710 */ get => default; } // 0x00000001847112D0-0x0000000184711370 
		public string text { /* [XID] */ /* 0x0000000189712F70-0x0000000189712F90 */ set {} } // 0x00000001847114F0-0x00000001847115D0
		public float minShowTime { /* [XID] */ /* 0x000000018971A7F0-0x000000018971A810 */ get => default; } // 0x0000000184711370-0x0000000184711420 
		public float autoCloseLimit { /* [XID] */ /* 0x0000000189721B70-0x0000000189721B90 */ get => default; } // 0x0000000184711220-0x00000001847112D0 
		public bool raycastTarget { /* [XID] */ /* 0x0000000189738350-0x0000000189738370 */ set {} } // 0x0000000184711420-0x00000001847114F0
	
		// Constructors
		public MonoInfoTextDialog() {} // 0x00000001847111B0-0x0000000184711220
	
		// Methods
		// [XID] // 0x00000001897291A0-0x00000001897291C0
		public void FadeIn() {} // 0x00000001847110D0-0x00000001847111B0
		// [XID] // 0x0000000189730A00-0x0000000189730A20
		public void ClearFadeInTrigger() {} // 0x0000000184710FF0-0x00000001847110D0
	}
}
