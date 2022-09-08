/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class TouchButtonControl : TouchControl // TypeDefIndex: 7823
	{
		// Fields
		// [Header] // 0x0000000189916BB0-0x0000000189916BF0
		[SerializeField] // 0x0000000189916BB0-0x0000000189916BF0
		private TouchControlAnchor anchor; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TouchUnitType offsetUnitType; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 offset; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool lockAspectRatio; // 0x28
		// [Header] // 0x0000000189A09640-0x0000000189A09670
		public ButtonTarget target; // 0x2C
		public bool allowSlideToggle; // 0x30
		public bool toggleOnLeave; // 0x31
		public bool pressureSensitive; // 0x32
		// [Header] // 0x0000000189A1F830-0x0000000189A1F860
		public TouchSprite button; // 0x38
		private bool buttonState; // 0x40
		private Touch currentTouch; // 0x48
		private bool dirty; // 0x50
	
		// Properties
		private bool ButtonState { /* [XID] */ /* 0x00000001896EA720-0x00000001896EA740 */ get => default; /* [XID] */ /* 0x0000000189826030-0x0000000189826050 */ set {} } // 0x00000001877DA990-0x00000001877DAA30 0x00000001877DAD70-0x00000001877DAE40
		public Vector3 ButtonPosition { /* [XID] */ /* 0x0000000189607860-0x0000000189607880 */ get => default; /* [XID] */ /* 0x00000001897374C0-0x00000001897374E0 */ set {} } // 0x00000001877DA810-0x00000001877DA990 0x00000001877DAC30-0x00000001877DAD70
		public TouchControlAnchor Anchor { /* [XID] */ /* 0x00000001897081C0-0x00000001897081E0 */ get => default; /* [XID] */ /* 0x000000018970FC10-0x000000018970FC30 */ set {} } // 0x00000001877DA770-0x00000001877DA810 0x00000001877DAB80-0x00000001877DAC30
		public Vector2 Offset { /* [XID] */ /* 0x0000000189A00F30-0x0000000189A00F50 */ get => default; /* [XID] */ /* 0x00000001899CAD90-0x00000001899CADB0 */ set {} } // 0x00000001877DAAD0-0x00000001877DAB80 0x00000001877DAEF0-0x00000001877DB000
		public TouchUnitType OffsetUnitType { /* [XID] */ /* 0x00000001898FC290-0x00000001898FC2B0 */ get => default; /* [XID] */ /* 0x00000001899D9BA0-0x00000001899D9BC0 */ set {} } // 0x00000001877DAA30-0x00000001877DAAD0 0x00000001877DAE40-0x00000001877DAEF0
	
		// Constructors
		public TouchButtonControl() {} // 0x00000001877DA650-0x00000001877DA770
	
		// Methods
		// [XID] // 0x0000000189A109E0-0x0000000189A10A00
		public override void CreateControl() {} // 0x00000001877D9D70-0x00000001877D9E50
		// [XID] // 0x0000000189952740-0x0000000189952760
		public override void DestroyControl() {} // 0x00000001877D9E50-0x00000001877D9F20
		// [XID] // 0x0000000189ABE5A0-0x0000000189ABE5C0
		public override void ConfigureControl() {} // 0x00000001877D9C30-0x00000001877D9D70
		// [XID] // 0x00000001899616A0-0x00000001899616C0
		public override void DrawGizmos() {} // 0x00000001877D9F20-0x00000001877DA030
		// [XID] // 0x00000001896A0CC0-0x00000001896A0CE0
		private void Update() {} // 0x00000001877DA580-0x00000001877DA650
		// [XID] // 0x0000000189A0FE10-0x0000000189A0FE30
		public override void SubmitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877DA030-0x00000001877DA2F0
		// [XID] // 0x0000000189978180-0x00000001899781A0
		public override void CommitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877D9B60-0x00000001877D9C30
		// [XID] // 0x000000018969D690-0x000000018969D6B0
		public override void TouchBegan(Touch touch) {} // 0x00000001877DA2F0-0x00000001877DA3D0
		// [XID] // 0x0000000189986C00-0x0000000189986C20
		public override void TouchMoved(Touch touch) {} // 0x00000001877DA490-0x00000001877DA580
		// [XID] // 0x0000000189728330-0x0000000189728350
		public override void TouchEnded(Touch touch) {} // 0x00000001877DA3D0-0x00000001877DA490
	}
}
