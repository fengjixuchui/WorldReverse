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
	public class MonoMapTag : MonoBehaviour // TypeDefIndex: 31138
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _freeClickButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _cancelBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _okBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _replaceBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _deleteBtn; // 0x38
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoGridScroller _tagBtnScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tagNumGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _num; // 0x50
	
		// Properties
		public MonoGridScroller tagBtnScroller { /* [XID] */ /* 0x00000001897249F0-0x0000000189724A10 */ get => default; } // 0x0000000184935C40-0x0000000184935CE0 
		public bool showTagBtnScroller { /* [XID] */ /* 0x000000018972C240-0x000000018972C260 */ get => default; /* [XID] */ /* 0x0000000189733900-0x0000000189733920 */ set {} } // 0x0000000184935B70-0x0000000184935C40 0x00000001849361D0-0x00000001849362D0
		public bool showOkButton { /* [XID] */ /* 0x000000018973B040-0x000000018973B060 */ set {} } // 0x0000000184935F10-0x0000000184936070
		public bool showDeleteButton { /* [XID] */ /* 0x00000001897429F0-0x0000000189742A10 */ set {} } // 0x0000000184935DB0-0x0000000184935F10
		public bool showReplaceButton { /* [XID] */ /* 0x000000018974A6C0-0x000000018974A6E0 */ set {} } // 0x0000000184936070-0x00000001849361D0
		public bool showTagNumGrp { /* [XID] */ /* 0x00000001897517D0-0x00000001897517F0 */ set {} } // 0x00000001849362D0-0x0000000184936430
		public Button cancelButton { /* [XID] */ /* 0x0000000189758D90-0x0000000189758DB0 */ get => default; } // 0x0000000184935810-0x00000001849358C0 
		public Button okButton { /* [XID] */ /* 0x0000000189760A70-0x0000000189760A90 */ get => default; } // 0x0000000184935A10-0x0000000184935AC0 
		public Button deleteButton { /* [XID] */ /* 0x0000000189767D50-0x0000000189767D70 */ get => default; } // 0x00000001849358C0-0x0000000184935970 
		public Button replaceButton { /* [XID] */ /* 0x000000018976F2E0-0x000000018976F300 */ get => default; } // 0x0000000184935AC0-0x0000000184935B70 
		public Button freeClickButton { /* [XID] */ /* 0x0000000189776D40-0x0000000189776D60 */ get => default; } // 0x0000000184935970-0x0000000184935A10 
		public string numText { /* [XID] */ /* 0x000000018977E3E0-0x000000018977E400 */ set {} } // 0x0000000184935CE0-0x0000000184935DB0
	
		// Constructors
		public MonoMapTag() {} // 0x00000001849357B0-0x0000000184935810
	}
}
