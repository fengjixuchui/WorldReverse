/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	// [AddComponentMenu] // 0x00000001896C41C0-0x00000001896C41F0
	public class InControlInputModule : PointerInputModule // TypeDefIndex: 7640
	{
		// Fields
		public Button submitButton; // 0x58
		public Button cancelButton; // 0x5C
		// [Range] // 0x00000001896CD060-0x00000001896CD080
		public float analogMoveThreshold; // 0x60
		public float moveRepeatFirstDuration; // 0x64
		public float moveRepeatDelayDuration; // 0x68
		// [FormerlySerializedAs] // 0x00000001896D44E0-0x00000001896D4510
		public bool forceModuleActive; // 0x6C
		public bool allowMouseInput; // 0x6D
		public bool focusOnMouseHover; // 0x6E
		public bool allowTouchInput; // 0x6F
		private InputDevice inputDevice; // 0x70
		private Vector3 thisMousePosition; // 0x78
		private Vector3 lastMousePosition; // 0x84
		private Vector2 thisVectorState; // 0x90
		private Vector2 lastVectorState; // 0x98
		private bool thisSubmitState; // 0xA0
		private bool lastSubmitState; // 0xA1
		private bool thisCancelState; // 0xA2
		private bool lastCancelState; // 0xA3
		private float nextMoveRepeatTime; // 0xA4
		private float lastVectorPressedTime; // 0xA8
		private TwoAxisInputControl direction; // 0xB0
	
		// Properties
		public PlayerAction SubmitAction { /* [XID] */ /* 0x00000001896FC730-0x00000001896FC770 */ get; set; } // 0x00000001870C8090-0x00000001870C80F0 0x00000001870C88C0-0x00000001870C8930
		public PlayerAction CancelAction { /* [XID] */ /* 0x000000018970E4F0-0x000000018970E530 */ get; set; } // 0x00000001870C7B40-0x00000001870C7BA0 0x00000001870C8730-0x00000001870C87A0
		public PlayerTwoAxisAction MoveAction { /* [XID] */ /* 0x00000001897203E0-0x0000000189720420 */ get; set; } // 0x00000001870C8030-0x00000001870C8090 0x00000001870C8850-0x00000001870C88C0
		public InputDevice Device { /* [XID] */ /* 0x000000018989B3F0-0x000000018989B410 */ get => default; /* [XID] */ /* 0x0000000189929F80-0x0000000189929FA0 */ set {} } // 0x00000001870C7D20-0x00000001870C7DF0 0x00000001870C87A0-0x00000001870C8850
		private InputControl SubmitButton { /* [XID] */ /* 0x0000000189893CB0-0x0000000189893CD0 */ get => default; } // 0x00000001870C80F0-0x00000001870C81B0 
		private InputControl CancelButton { /* [XID] */ /* 0x000000018979A5B0-0x000000018979A5D0 */ get => default; } // 0x00000001870C7BA0-0x00000001870C7C60 
		private bool VectorIsPressed { /* [XID] */ /* 0x000000018980A680-0x000000018980A6A0 */ get => default; } // 0x00000001870C8420-0x00000001870C8510 
		private bool VectorIsReleased { /* [XID] */ /* 0x00000001897B1390-0x00000001897B13B0 */ get => default; } // 0x00000001870C8510-0x00000001870C8600 
		private bool VectorHasChanged { /* [XID] */ /* 0x00000001897B8FA0-0x00000001897B8FC0 */ get => default; } // 0x00000001870C8330-0x00000001870C8420 
		private bool VectorWasPressed { /* [XID] */ /* 0x00000001898E6410-0x00000001898E6430 */ get => default; } // 0x00000001870C8600-0x00000001870C8730 
		private bool SubmitWasPressed { /* [XID] */ /* 0x00000001897C8A60-0x00000001897C8A80 */ get => default; } // 0x00000001870C81B0-0x00000001870C8270 
		private bool SubmitWasReleased { /* [XID] */ /* 0x00000001899F30E0-0x00000001899F3100 */ get => default; } // 0x00000001870C8270-0x00000001870C8330 
		private bool CancelWasPressed { /* [XID] */ /* 0x00000001897D7A20-0x00000001897D7A40 */ get => default; } // 0x00000001870C7C60-0x00000001870C7D20 
		private bool MouseHasMoved { /* [XID] */ /* 0x00000001897DEE90-0x00000001897DEEB0 */ get => default; } // 0x00000001870C7EC0-0x00000001870C8030 
		private bool MouseButtonIsPressed { /* [XID] */ /* 0x00000001897E6960-0x00000001897E6980 */ get => default; } // 0x00000001870C7DF0-0x00000001870C7EC0 
	
		// Nested types
		public enum Button // TypeDefIndex: 7641
		{
			Action1 = 19,
			Action2 = 20,
			Action3 = 21,
			Action4 = 22
		}
	
		// Constructors
		protected InControlInputModule() {} // 0x00000001870C7A60-0x00000001870C7B40
	
		// Methods
		// [XID] // 0x000000018962F5A0-0x000000018962F5C0
		public override void UpdateModule() {} // 0x00000001870C7880-0x00000001870C7970
		// [XID] // 0x0000000189752CB0-0x0000000189752CD0
		public override bool IsModuleSupported() => default; // 0x00000001870C4E40-0x00000001870C4F40
		// [XID] // 0x00000001897411E0-0x0000000189741200
		public override bool ShouldActivateModule() => default; // 0x00000001870C7030-0x00000001870C71B0
		// [XID] // 0x0000000189748AA0-0x0000000189748AC0
		public override void ActivateModule() {} // 0x00000001870C4C60-0x00000001870C4E40
		// [XID] // 0x000000018965E7B0-0x000000018965E7D0
		public override void Process() {} // 0x00000001870C67C0-0x00000001870C68D0
		// [XID] // 0x00000001897576E0-0x0000000189757700
		private bool ProcessTouchEvents() => default; // 0x00000001870C5CE0-0x00000001870C5F50
		// [XID] // 0x000000018975EF90-0x000000018975EFB0
		private bool SendButtonEventToSelectedObject() => default; // 0x00000001870C68D0-0x00000001870C6B10
		// [XID] // 0x000000018985F2F0-0x000000018985F310
		private bool SendVectorEventToSelectedObject() => default; // 0x00000001870C6CC0-0x00000001870C6F10
		// [XID] // 0x000000018991B240-0x000000018991B260
		protected override void ProcessMove(PointerEventData pointerEvent) {} // 0x00000001870C5B40-0x00000001870C5CE0
		// [XID] // 0x0000000189922810-0x0000000189922830
		private void Update() {} // 0x00000001870C7970-0x00000001870C7A60
		// [XID] // 0x000000018977CA20-0x000000018977CA40
		private void UpdateInputState() {} // 0x00000001870C73D0-0x00000001870C7880
		// [XID] // 0x00000001897A2540-0x00000001897A2560
		private void SetVectorRepeatTimer() {} // 0x00000001870C6F10-0x00000001870C7030
		// [XID] // 0x00000001899C5C10-0x00000001899C5C30
		protected bool SendUpdateEventToSelectedObject() => default; // 0x00000001870C6B10-0x00000001870C6CC0
		// [IDTag] // 0x00000001897F5A50-0x00000001897F5A90
		// [XID] // 0x00000001897F5A50-0x00000001897F5A90
		protected void ProcessMouseEvent() {} // 0x00000001870C4F40-0x00000001870C4FE0
		// [IDTag] // 0x00000001898002E0-0x0000000189800320
		// [XID] // 0x00000001898002E0-0x0000000189800320
		protected void ProcessMouseEvent(int id) {} // 0x00000001870C4FE0-0x00000001870C53C0
		// [XID] // 0x000000018980A910-0x000000018980A930
		protected void ProcessMousePress(MouseButtonEventData data) {} // 0x00000001870C53C0-0x00000001870C5B40
		// [XID] // 0x00000001898FCDA0-0x00000001898FCDC0
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x00000001870C5F50-0x00000001870C67C0
	}
}
