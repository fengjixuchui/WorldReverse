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
	// [RequireComponent] // 0x000000018997F500-0x000000018997F550
	public class MonoQuestSubDescItem : MonoBehaviour // TypeDefIndex: 31298
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _background; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _subTraceMark; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subQuestName; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _plusBtn; // 0x40
	
		// Properties
		public MonoUIContainer plusBtn { /* [XID] */ /* 0x00000001899BBFC0-0x00000001899BBFE0 */ get => default; } // 0x0000000184426670-0x0000000184426710 
		public bool showBackground { /* [XID] */ /* 0x00000001899C3AF0-0x00000001899C3B10 */ set {} } // 0x00000001844267F0-0x00000001844268C0
		public bool lightColor { /* [XID] */ /* 0x00000001899CB110-0x00000001899CB130 */ set {} } // 0x0000000184426710-0x00000001844267F0
		public bool showIcon { /* [XID] */ /* 0x00000001899D2620-0x00000001899D2640 */ set {} } // 0x00000001844268C0-0x0000000184426990
		public string text { /* [XID] */ /* 0x00000001899D9D30-0x00000001899D9D50 */ set {} } // 0x0000000184426990-0x0000000184426A60
		public Button actionBtn { /* [XID] */ /* 0x00000001899E1610-0x00000001899E1630 */ get => default; } // 0x00000001844265D0-0x0000000184426670 
	
		// Constructors
		public MonoQuestSubDescItem() {} // 0x0000000184426560-0x00000001844265D0
	}
}
