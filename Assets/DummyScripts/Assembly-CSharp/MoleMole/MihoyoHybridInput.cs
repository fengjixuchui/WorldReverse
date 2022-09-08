/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MihoyoHybridInput : BaseInput // TypeDefIndex: 29976
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _virtualCursor; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _useVirtualCursor; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _virtualCursorSensitivity; // 0x24
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private InputActionType _horizontalAxis; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputActionType _verticalAxis; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputActionType _submitButton; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputActionType _cancelButton; // 0x34
		// [Range] // 0x0000000189B51A30-0x0000000189B51A70
		[SerializeField] // 0x0000000189B51A30-0x0000000189B51A70
		private float _navigationDeadZone; // 0x38
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private float _mouseScrollScale; // 0x3C
		private Camera _uiCamera; // 0x40
		private Vector2 _virtualCursorPosition; // 0x4C
	
		// Properties
		private bool validCursor { /* [XID] */ /* 0x0000000189AD5AA0-0x0000000189AD5AC0 */ get => default; } // 0x0000000181145AA0-0x0000000181145BC0 
		private Camera uiCamera { /* [XID] */ /* 0x0000000189ADD430-0x0000000189ADD450 */ get => default; } // 0x0000000181145420-0x0000000181145530 
		public override bool mousePresent { /* [XID] */ /* 0x0000000189AE4C10-0x0000000189AE4C30 */ get => default; } // 0x0000000181146980-0x0000000181146A60 
		public override Vector2 mousePosition { /* [XID] */ /* 0x0000000189AEC2D0-0x0000000189AEC2F0 */ get => default; } // 0x0000000181146850-0x0000000181146980 
		public RectTransform virtualCursor { /* [XID] */ /* 0x0000000189AF3CB0-0x0000000189AF3CD0 */ get => default; /* [XID] */ /* 0x0000000189AFB3C0-0x0000000189AFB3E0 */ set {} } // 0x0000000181147040-0x00000001811470E0 0x00000001811475B0-0x0000000181147660
		public float virtualCursorSensitivity { /* [XID] */ /* 0x0000000189B02A60-0x0000000189B02A80 */ get => default; /* [XID] */ /* 0x0000000189B0A2B0-0x0000000189B0A2D0 */ set {} } // 0x0000000181146F90-0x0000000181147040 0x0000000181147500-0x00000001811475B0
		private bool cursorPressedThisFrame { /* [XID] */ /* 0x0000000189B119D0-0x0000000189B11A10 */ get; /* [XID] */ /* 0x0000000189B1BFB0-0x0000000189B1BFF0 */ set; } // 0x00000001811453C0-0x0000000181145420 0x0000000181145BC0-0x0000000181145C20
		private bool cursorReleasedThisFrame { /* [XID] */ /* 0x0000000189B26610-0x0000000189B26650 */ get; /* [XID] */ /* 0x0000000189B30610-0x0000000189B30650 */ set; } // 0x0000000181145290-0x00000001811452F0 0x0000000181144F30-0x0000000181144F90
		private bool cursorPressed { get; /* [XID] */ /* 0x0000000189B42710-0x0000000189B42750 */ set; } // 0x0000000181145A40-0x0000000181145AA0 0x0000000181145F50-0x0000000181145FB0
		public bool anyRealMouseButtonDown { /* [XID] */ /* 0x0000000189B727A0-0x0000000189B727C0 */ get => default; } // 0x0000000181146630-0x0000000181146710 
		public InputActionType horizontalAxis { /* [XID] */ /* 0x0000000189B90040-0x0000000189B90060 */ get => default; /* [XID] */ /* 0x0000000189B97460-0x0000000189B97480 */ set {} } // 0x00000001811467B0-0x0000000181146850 0x0000000181147190-0x0000000181147240
		public InputActionType verticalAxis { /* [XID] */ /* 0x0000000189B9E900-0x0000000189B9E920 */ get => default; /* [XID] */ /* 0x0000000189BA6270-0x0000000189BA6290 */ set {} } // 0x0000000181146EF0-0x0000000181146F90 0x0000000181147450-0x0000000181147500
		public InputActionType submitButton { /* [XID] */ /* 0x0000000189BAD520-0x0000000189BAD540 */ get => default; /* [XID] */ /* 0x0000000189BB4C90-0x0000000189BB4CB0 */ set {} } // 0x0000000181146DB0-0x0000000181146E50 0x00000001811472F0-0x00000001811473A0
		public InputActionType cancelButton { /* [XID] */ /* 0x0000000189BBC260-0x0000000189BBC280 */ get => default; /* [XID] */ /* 0x0000000189BC3FA0-0x0000000189BC3FC0 */ set {} } // 0x0000000181146710-0x00000001811467B0 0x00000001811470E0-0x0000000181147190
		public float navigationDeadZone { /* [XID] */ /* 0x0000000189BCB950-0x0000000189BCB970 */ get => default; /* [XID] */ /* 0x0000000189BD2EC0-0x0000000189BD2EE0 */ set {} } // 0x0000000181146D00-0x0000000181146DB0 0x0000000181147240-0x00000001811472F0
		public bool navigationActive { /* [XID] */ /* 0x0000000189BDA660-0x0000000189BDA680 */ get => default; } // 0x0000000181146B80-0x0000000181146D00 
		public bool useVirtualCursor { /* [XID] */ /* 0x000000018976F120-0x000000018976F140 */ get => default; /* [XID] */ /* 0x00000001895EE9C0-0x00000001895EE9E0 */ set {} } // 0x0000000181146E50-0x0000000181146EF0 0x00000001811473A0-0x0000000181147450
		public override Vector2 mouseScrollDelta { /* [XID] */ /* 0x0000000189604F80-0x0000000189604FA0 */ get => default; } // 0x0000000181146A60-0x0000000181146B80 
	
		// Constructors
		public MihoyoHybridInput() {} // 0x0000000181146560-0x0000000181146630
	
		// Methods
		// [XID] // 0x0000000189B4D050-0x0000000189B4D070
		public void PressCursor() {} // 0x0000000181145FB0-0x0000000181146090
		// [XID] // 0x0000000189B547D0-0x0000000189B547F0
		public void ReleaseCursor() {} // 0x0000000181146090-0x00000001811461C0
		// [XID] // 0x0000000189B5C3D0-0x0000000189B5C3F0
		public void ClearOnFrameEnd() {} // 0x00000001811450E0-0x0000000181145290
		// [XID] // 0x0000000189B63960-0x0000000189B63980
		public override bool GetMouseButtonDown(int button) => default; // 0x0000000181145720-0x00000001811458B0
		// [XID] // 0x0000000189B6B140-0x0000000189B6B160
		public override bool GetMouseButtonUp(int button) => default; // 0x00000001811458B0-0x0000000181145A40
		// [XID] // 0x0000000189B79CB0-0x0000000189B79CD0
		private void OnApplicationFocus(bool focus) {} // 0x0000000181145DA0-0x0000000181145F50
		// [XID] // 0x0000000189B813E0-0x0000000189B81400
		public float GetAxis(InputActionType inputAction) => default; // 0x0000000181145530-0x0000000181145630
		// [XID] // 0x0000000189B88B90-0x0000000189B88BB0
		public bool GetButtonDown(InputActionType inputAction) => default; // 0x0000000181145630-0x0000000181145720
		// [XID] // 0x00000001895F63A0-0x00000001895F63C0
		public void SetVirtualCursorPosition(Vector2 position) {} // 0x00000001811461C0-0x0000000181146350
		// [XID] // 0x00000001895FD6D0-0x00000001895FD6F0
		public void UpdateVirtualCursor() {} // 0x0000000181146350-0x0000000181146560
		// [XID] // 0x000000018960C9D0-0x000000018960C9F0
		protected override void Awake() {} // 0x0000000181144F90-0x0000000181145060
	}
}
