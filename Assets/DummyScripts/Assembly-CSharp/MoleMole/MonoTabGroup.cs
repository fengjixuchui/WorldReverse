/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTabGroup : MonoBehaviour // TypeDefIndex: 30943
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private List<Button> _buttons; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoUIContainer[] buttonContainer; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoTabGroupEvent _onSelectChanged; // 0x28
		private int _prevSelectIndex; // 0x30
		public bool playPressedForDisabled; // 0x34
	
		// Properties
		public UnityEvent<int> onSelectChanged { /* [XID] */ /* 0x0000000189812190-0x00000001898121B0 */ get => default; } // 0x0000000185010860-0x0000000185010900 
		public List<Button> Buttons { /* [XID] */ /* 0x000000018982FFE0-0x0000000189830000 */ get => default; } // 0x00000001850107C0-0x0000000185010860 
	
		// Nested types
		[Serializable]
		private class MonoTabGroupEvent : UnityEvent<int> // TypeDefIndex: 30944
		{
			// Constructors
			public MonoTabGroupEvent() {} // 0x000000018500FC10-0x000000018500FC80
		}
	
		// Constructors
		public MonoTabGroup() {} // 0x00000001850106E0-0x00000001850107C0
	
		// Methods
		// [XID] // 0x00000001897FC150-0x00000001897FC170
		private void OnSelectedChanged(int index) {} // 0x0000000185010320-0x00000001850103F0
		// [XID] // 0x0000000189803610-0x0000000189803630
		private void Awake() {} // 0x000000018500FC80-0x000000018500FEB0
		// [XID] // 0x000000018980ABC0-0x000000018980ABE0
		public void Init() {} // 0x0000000185010090-0x0000000185010320
		// [XID] // 0x0000000189819D40-0x0000000189819D60
		public void UpdateSelect(int index) {} // 0x00000001850105D0-0x00000001850106E0
		// [XID] // 0x00000001898215C0-0x00000001898215E0
		public void UpdateSelectView(int index) {} // 0x00000001850103F0-0x00000001850105D0
		// [XID] // 0x0000000189828BB0-0x0000000189828BD0
		public void DeactiveateExcept(int exceptIndex) {} // 0x000000018500FEB0-0x0000000185010090
	}
}
