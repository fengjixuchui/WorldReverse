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
	public class MonoJoypadScrollRect : MonoJoypadInputHandlerBase // TypeDefIndex: 30661
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ScrollRect _scrollRect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _speed; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _axisDelt; // 0x8C
		[SerializeField] // 0x0000000189BA1880-0x0000000189BA18D0
		// [Tooltip] // 0x0000000189BA1880-0x0000000189BA18D0
		protected bool _autoScrollToTopOnFocus; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _leftItemEvent; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _rightItemEvent; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _scrollermEvent; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected JoypadScrollRectType _joypadScrollRectType; // 0xA0
		// [Header] // 0x0000000189BCB880-0x0000000189BCB8E0
		[SerializeField] // 0x0000000189BCB880-0x0000000189BCB8E0
		[Space] // 0x0000000189BCB880-0x0000000189BCB8E0
		protected ScrollRectScrollType _scrollType; // 0xA4
		[SerializeField] // 0x0000000189BDA5A0-0x0000000189BDA5E0
		// [Tooltip] // 0x0000000189BDA5A0-0x0000000189BDA5E0
		private float _scrollShieldAngle; // 0xA8
	
		// Nested types
		public enum ScrollRectScrollType // TypeDefIndex: 30662
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum JoypadScrollRectType // TypeDefIndex: 30663
		{
			Normal = 0,
			MultiDirectional = 1
		}
	
		// Constructors
		public MonoJoypadScrollRect() {} // 0x0000000183F8A7C0-0x0000000183F8A8C0
	
		// Methods
		// [XID] // 0x00000001895EBB80-0x00000001895EBBA0
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F89DC0-0x0000000183F89EE0
		// [XID] // 0x00000001895F2F00-0x00000001895F2F20
		protected ContextEventType ConvertScrollerEvent(ContextEventType contextEvent) => default; // 0x0000000183F89EE0-0x0000000183F89FB0
		// [XID] // 0x00000001895FA760-0x00000001895FA780
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F89FB0-0x0000000183F8A530
		// [XID] // 0x0000000189602130-0x0000000189602150
		private bool CanScrollTip(Vector2 delta) => default; // 0x0000000183F8A530-0x0000000183F8A6B0
	}
}
