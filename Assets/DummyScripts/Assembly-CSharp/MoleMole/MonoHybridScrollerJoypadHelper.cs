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
	public class MonoHybridScrollerJoypadHelper : MonoBehaviour // TypeDefIndex: 30803
	{
		// Fields
		private int _currIndex; // 0x18
		private Button _currBtn; // 0x20
		private Button[] _buttonList; // 0x28
		public MonoUIContainer[] btnShownOnToggle; // 0x30
		public MonoUIContainer[] btnShownOnScroller; // 0x38
		public MonoUIContainer toggleTip; // 0x40
		public float sliderStep; // 0x48
	
		// Nested types
		public enum InteractionType // TypeDefIndex: 30804
		{
			None = 0,
			Toggle = 1,
			Scroller = 2
		}
	
		// Constructors
		public MonoHybridScrollerJoypadHelper() {} // 0x00000001846FCA50-0x00000001846FCAC0
	
		// Methods
		// [XID] // 0x000000018960B3C0-0x000000018960B3E0
		public void Init() {} // 0x00000001846FC6F0-0x00000001846FC7A0
		// [XID] // 0x0000000189612770-0x0000000189612790
		public void Reinit() {} // 0x00000001846FC9A0-0x00000001846FCA50
		// [XID] // 0x000000018961A090-0x000000018961A0B0
		private void Refresh() {} // 0x00000001846FBAA0-0x00000001846FC110
		// [XID] // 0x00000001896215D0-0x00000001896215F0
		private void RefreshToggleTips(Toggle toggle = null) {} // 0x00000001846FC7A0-0x00000001846FC9A0
		// [XID] // 0x0000000189628EE0-0x0000000189628F00
		public InteractionType GetCurrInteractionType() => default; // 0x00000001846FC110-0x00000001846FC290
		// [XID] // 0x0000000189630860-0x0000000189630880
		public bool HandleInputActionEventType(ContextEventType type) => default; // 0x00000001846FC290-0x00000001846FC630
		// [XID] // 0x0000000189638300-0x0000000189638320
		public void InitComponents() {} // 0x00000001846FC630-0x00000001846FC6F0
	}
}
