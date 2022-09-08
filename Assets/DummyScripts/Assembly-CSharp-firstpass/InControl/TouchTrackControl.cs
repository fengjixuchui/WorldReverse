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
	public class TouchTrackControl : TouchControl // TypeDefIndex: 7828
	{
		// Fields
		// [Header] // 0x0000000189B88820-0x0000000189B88860
		[SerializeField] // 0x0000000189B88820-0x0000000189B88860
		private TouchUnitType areaUnitType; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Rect activeArea; // 0x1C
		// [Header] // 0x0000000189B06DD0-0x0000000189B06E00
		public AnalogTarget target; // 0x2C
		public float scale; // 0x30
		// [Header] // 0x0000000189BA3100-0x0000000189BA3130
		public ButtonTarget tapTarget; // 0x34
		public float maxTapDuration; // 0x38
		public float maxTapMovement; // 0x3C
		private Rect worldActiveArea; // 0x40
		private Vector3 lastPosition; // 0x50
		private Vector3 thisPosition; // 0x5C
		private Touch currentTouch; // 0x68
		private bool dirty; // 0x70
		private bool fireButtonTarget; // 0x71
		private float beganTime; // 0x74
		private Vector3 beganPosition; // 0x78
	
		// Properties
		public Rect ActiveArea { /* [XID] */ /* 0x0000000189603620-0x0000000189603640 */ get => default; /* [XID] */ /* 0x000000018960B0A0-0x000000018960B0C0 */ set {} } // 0x00000001877E90B0-0x00000001877E9180 0x00000001877E9220-0x00000001877E9310
		public TouchUnitType AreaUnitType { /* [XID] */ /* 0x0000000189612480-0x00000001896124A0 */ get => default; /* [XID] */ /* 0x0000000189619DF0-0x0000000189619E10 */ set {} } // 0x00000001877E9180-0x00000001877E9220 0x00000001877E9310-0x00000001877E93C0
	
		// Constructors
		public TouchTrackControl() {} // 0x00000001877E8FB0-0x00000001877E90B0
	
		// Methods
		// [XID] // 0x00000001896CCE60-0x00000001896CCE80
		public override void CreateControl() {} // 0x00000001877E84E0-0x00000001877E8590
		// [XID] // 0x0000000189700B10-0x0000000189700B30
		public override void DestroyControl() {} // 0x00000001877E8590-0x00000001877E8650
		// [XID] // 0x000000018971E7C0-0x000000018971E7E0
		public override void ConfigureControl() {} // 0x00000001877E8410-0x00000001877E84E0
		// [XID] // 0x0000000189BC2580-0x0000000189BC25A0
		public override void DrawGizmos() {} // 0x00000001877E8650-0x00000001877E8760
		// [XID] // 0x0000000189BC9B40-0x0000000189BC9B60
		private void OnValidate() {} // 0x00000001877E8760-0x00000001877E8810
		// [XID] // 0x0000000189BD12D0-0x0000000189BD12F0
		private void Update() {} // 0x00000001877E8EF0-0x00000001877E8FB0
		// [XID] // 0x0000000189BD89E0-0x0000000189BD8A00
		public override void SubmitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E8810-0x00000001877E8A20
		// [XID] // 0x00000001898B91A0-0x00000001898B91C0
		public override void CommitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E8330-0x00000001877E8410
		// [XID] // 0x00000001898D6FD0-0x00000001898D6FF0
		public override void TouchBegan(Touch touch) {} // 0x00000001877E8A20-0x00000001877E8BC0
		// [XID] // 0x00000001895F4560-0x00000001895F4580
		public override void TouchMoved(Touch touch) {} // 0x00000001877E8DD0-0x00000001877E8EF0
		// [XID] // 0x00000001898F5690-0x00000001898F56B0
		public override void TouchEnded(Touch touch) {} // 0x00000001877E8BC0-0x00000001877E8DD0
	}
}
