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
	public class TouchSwipeControl : TouchControl // TypeDefIndex: 7827
	{
		// Fields
		// [Header] // 0x00000001899E11A0-0x00000001899E11F0
		[SerializeField] // 0x00000001899E11A0-0x00000001899E11F0
		private TouchUnitType areaUnitType; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Rect activeArea; // 0x1C
		// [Header] // 0x0000000189AFC590-0x0000000189AFC5F0
		// [Range] // 0x0000000189AFC590-0x0000000189AFC5F0
		public float sensitivity; // 0x2C
		public bool oneSwipePerTouch; // 0x30
		// [Header] // 0x0000000189B06DD0-0x0000000189B06E00
		public AnalogTarget target; // 0x34
		public SnapAngles snapAngles; // 0x38
		// [Header] // 0x0000000189B0FE20-0x0000000189B0FE50
		public ButtonTarget upTarget; // 0x3C
		public ButtonTarget downTarget; // 0x40
		public ButtonTarget leftTarget; // 0x44
		public ButtonTarget rightTarget; // 0x48
		public ButtonTarget tapTarget; // 0x4C
		private Rect worldActiveArea; // 0x50
		private Vector3 currentVector; // 0x60
		private bool currentVectorIsSet; // 0x6C
		private Vector3 beganPosition; // 0x70
		private Vector3 lastPosition; // 0x7C
		private Touch currentTouch; // 0x88
		private bool fireButtonTarget; // 0x90
		private ButtonTarget nextButtonTarget; // 0x94
		private ButtonTarget lastButtonTarget; // 0x98
		private bool dirty; // 0x9C
	
		// Properties
		public Rect ActiveArea { /* [XID] */ /* 0x00000001896A8210-0x00000001896A8230 */ get => default; /* [XID] */ /* 0x0000000189B72400-0x0000000189B72420 */ set {} } // 0x00000001877E8010-0x00000001877E80E0 0x00000001877E8180-0x00000001877E8270
		public TouchUnitType AreaUnitType { /* [XID] */ /* 0x0000000189B79940-0x0000000189B79960 */ get => default; /* [XID] */ /* 0x00000001896F16D0-0x00000001896F16F0 */ set {} } // 0x00000001877E80E0-0x00000001877E8180 0x00000001877E8270-0x00000001877E8330
	
		// Constructors
		public TouchSwipeControl() {} // 0x00000001877E7F00-0x00000001877E8010
	
		// Methods
		// [XID] // 0x0000000189B18A70-0x0000000189B18A90
		public override void CreateControl() {} // 0x00000001877E7120-0x00000001877E71C0
		// [XID] // 0x0000000189B20130-0x0000000189B20150
		public override void DestroyControl() {} // 0x00000001877E71C0-0x00000001877E7280
		// [XID] // 0x0000000189B27720-0x0000000189B27740
		public override void ConfigureControl() {} // 0x00000001877E7050-0x00000001877E7120
		// [XID] // 0x0000000189B2EA90-0x0000000189B2EAB0
		public override void DrawGizmos() {} // 0x00000001877E7280-0x00000001877E7390
		// [XID] // 0x0000000189B362A0-0x0000000189B362C0
		private void Update() {} // 0x00000001877E7E40-0x00000001877E7F00
		// [XID] // 0x0000000189B3D810-0x0000000189B3D830
		public override void SubmitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E75C0-0x00000001877E7870
		// [XID] // 0x0000000189B456C0-0x0000000189B456E0
		public override void CommitControlState(ulong updateTick, float deltaTime) {} // 0x00000001877E6F40-0x00000001877E7050
		// [XID] // 0x0000000189B4CCF0-0x0000000189B4CD10
		public override void TouchBegan(Touch touch) {} // 0x00000001877E7870-0x00000001877E7A00
		// [XID] // 0x0000000189B542E0-0x0000000189B54300
		public override void TouchMoved(Touch touch) {} // 0x00000001877E7C00-0x00000001877E7E40
		// [XID] // 0x000000018996F360-0x000000018996F380
		public override void TouchEnded(Touch touch) {} // 0x00000001877E7A00-0x00000001877E7C00
		// [XID] // 0x0000000189B63410-0x0000000189B63430
		private ButtonTarget GetButtonTargetForVector(Vector2 vector) => default; // 0x00000001877E7390-0x00000001877E75C0
	}
}
