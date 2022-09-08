/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadResuableListHandler : MonoJoypadInputHandlerBase // TypeDefIndex: 30660
	{
		// Fields
		// [Header] // 0x0000000189B5A760-0x0000000189B5A7A0
		[SerializeField] // 0x0000000189B5A760-0x0000000189B5A7A0
		protected MonoReusableList _resuableList; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _prevItemEvent; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _nextItemEvent; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _resetSelectIndexOnFocus; // 0x90
	
		// Properties
		public int selectIndex { /* [XID] */ /* 0x0000000189B7C7E0-0x0000000189B7C800 */ get => default; } // 0x0000000183F89CC0-0x0000000183F89DC0 
	
		// Constructors
		public MonoJoypadResuableListHandler() {} // 0x0000000183F89BF0-0x0000000183F89CC0
	
		// Methods
		// [XID] // 0x0000000189B84620-0x0000000189B84640
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F897F0-0x0000000183F89B60
	}
}
