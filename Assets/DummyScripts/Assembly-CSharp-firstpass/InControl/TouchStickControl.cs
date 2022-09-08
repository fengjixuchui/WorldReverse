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
	public class TouchStickControl : TouchControl // TypeDefIndex: 7826
	{
		// Fields
		// [Header] // 0x00000001899E11A0-0x00000001899E11F0
		[SerializeField] // 0x00000001899E11A0-0x00000001899E11F0
		private TouchControlAnchor anchor; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TouchUnitType offsetUnitType; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 offset; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TouchUnitType areaUnitType; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Rect activeArea; // 0x2C
		// [Header] // 0x0000000189A09640-0x0000000189A09670
		public AnalogTarget target; // 0x3C
		public SnapAngles snapAngles; // 0x40
		public LockAxis lockToAxis; // 0x44
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float lowerDeadZone; // 0x48
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float upperDeadZone; // 0x4C
		public AnimationCurve inputCurve; // 0x50
		public bool allowDragging; // 0x58
		public DragAxis allowDraggingAxis; // 0x5C
		public bool snapToInitialTouch; // 0x60
		public bool resetWhenDone; // 0x61
		public float resetDuration; // 0x64
		// [Header] // 0x0000000189A1F830-0x0000000189A1F860
		public TouchSprite ring; // 0x68
		public TouchSprite knob; // 0x70
		public float knobRange; // 0x78
		private Vector3 resetPosition; // 0x7C
		private Vector3 beganPosition; // 0x88
		private Vector3 movedPosition; // 0x94
		private float ringResetSpeed; // 0xA0
		private float knobResetSpeed; // 0xA4
		private Rect worldActiveArea; // 0xA8
		private float worldKnobRange; // 0xB8
		private Vector3 value; // 0xBC
		private Touch currentTouch; // 0xC8
		private bool dirty; // 0xD0
	
		// Properties
		public bool IsActive { /* [XID] */ /* 0x0000000189A71BF0-0x0000000189A71C10 */ get => default; } // 0x00000001877E62D0-0x00000001877E6380 
		public bool IsNotActive { /* [XID] */ /* 0x0000000189A79590-0x0000000189A795B0 */ get => default; } // 0x00000001877E6380-0x00000001877E6430 
		public Vector3 RingPosition { /* [XID] */ /* 0x0000000189A80DD0-0x0000000189A80DF0 */ get => default; /* [XID] */ /* 0x0000000189A88680-0x0000000189A886A0 */ set {} } // 0x00000001877E6700-0x00000001877E6880 0x00000001877E6E00-0x00000001877E6F40
		public Vector3 KnobPosition { /* [XID] */ /* 0x0000000189A8FFD0-0x0000000189A8FFF0 */ get => default; /* [XID] */ /* 0x0000000189897620-0x0000000189897640 */ set {} } // 0x00000001877E6430-0x00000001877E65B0 0x00000001877E6AF0-0x00000001877E6C30
		public TouchControlAnchor Anchor { /* [XID] */ /* 0x0000000189A9EAF0-0x0000000189A9EB10 */ get => default; /* [XID] */ /* 0x0000000189AA65A0-0x0000000189AA65C0 */ set {} } // 0x00000001877E6190-0x00000001877E6230 0x00000001877E6970-0x00000001877E6A30
		public Vector2 Offset { /* [XID] */ /* 0x0000000189AADB70-0x0000000189AADB90 */ get => default; /* [XID] */ /* 0x0000000189A37F10-0x0000000189A37F30 */ set {} } // 0x00000001877E6650-0x00000001877E6700 0x00000001877E6CF0-0x00000001877E6E00
		public TouchUnitType OffsetUnitType { /* [XID] */ /* 0x0000000189ABCF70-0x0000000189ABCF90 */ get => default; /* [XID] */ /* 0x0000000189AC4940-0x0000000189AC4960 */ set {} } // 0x00000001877E65B0-0x00000001877E6650 0x00000001877E6C30-0x00000001877E6CF0
		public Rect ActiveArea { /* [XID] */ /* 0x0000000189ACBF60-0x0000000189ACBF80 */ get => default; /* [XID] */ /* 0x0000000189AD38B0-0x0000000189AD38D0 */ set {} } // 0x00000001877E60C0-0x00000001877E6190 0x00000001877E6880-0x00000001877E6970
		public TouchUnitType AreaUnitType { /* [XID] */ /* 0x0000000189888D40-0x0000000189888D60 */ get => default; /* [XID] */ /* 0x0000000189AE2C00-0x0000000189AE2C20 */ set {} } // 0x00000001877E6230-0x00000001877E62D0 0x00000001877E6A30-0x00000001877E6AF0
	
		// Constructors
		public TouchStickControl() {} // 0x00000001877E5EF0-0x00000001877E60C0
	
		// Methods
		// [XID] // 0x000000018991A730-0x000000018991A750
		public override void CreateControl() {} // 0x00000001877E4810-0x00000001877E4930
		// [XID] // 0x00000001899296A0-0x00000001899296C0
		public override void DestroyControl() {} // 0x00000001877E4930-0x00000001877E4A20
		// [XID] // 0x0000000189A35CE0-0x0000000189A35D00
		public override void ConfigureControl() {} // 0x00000001877E4640-0x00000001877E4810
		// [XID] // 0x0000000189A3D2F0-0x0000000189A3D310
		public override void DrawGizmos() {} // 0x00000001877E4A20-0x00000001877E4C80
		// [XID] // 0x0000000189A44B20-0x0000000189A44B40
		private void Update() {} // 0x00000001877E5AB0-0x00000001877E5EF0
		// [XID] // 0x0000000189A4C280-0x0000000189A4C2A0
		public override void SubmitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E4C80-0x00000001877E4DE0
		// [XID] // 0x00000001896CC010-0x00000001896CC030
		public override void CommitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E4570-0x00000001877E4640
		// [XID] // 0x0000000189A5B0E0-0x0000000189A5B100
		public override void TouchBegan(Touch touch) {} // 0x00000001877E4DE0-0x00000001877E5090
		// [XID] // 0x0000000189A62960-0x0000000189A62980
		public override void TouchMoved(Touch touch) {} // 0x00000001877E5390-0x00000001877E5AB0
		// [XID] // 0x0000000189A6A6E0-0x0000000189A6A700
		public override void TouchEnded(Touch touch) {} // 0x00000001877E5090-0x00000001877E5390
	}
}
