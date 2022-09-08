/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	// [AddComponentMenu] // 0x00000001899A9D00-0x00000001899A9D30
	public class QuickDrag : QuickBase // TypeDefIndex: 7259
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnDragStart onDragStart; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnDrag onDrag; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnDragEnd onDragEnd; // 0x80
		public bool isStopOncollisionEnter; // 0x88
		private Vector3 deltaPosition; // 0x8C
		private bool isOnDrag; // 0x98
		private Gesture lastGesture; // 0xA0
	
		// Nested types
		[Serializable]
		public class OnDragStart : UnityEvent<Gesture> // TypeDefIndex: 7260
		{
			// Constructors
			public OnDragStart() {} // 0x0000000180C9A4D0-0x0000000180C9A540
		}
	
		[Serializable]
		public class OnDrag : UnityEvent<Gesture> // TypeDefIndex: 7261
		{
			// Constructors
			public OnDrag() {} // 0x0000000180C9A540-0x0000000180C9A5B0
		}
	
		[Serializable]
		public class OnDragEnd : UnityEvent<Gesture> // TypeDefIndex: 7262
		{
			// Constructors
			public OnDragEnd() {} // 0x0000000180C9A460-0x0000000180C9A4D0
		}
	
		// Constructors
		public QuickDrag() {} // 0x0000000180C9E970-0x0000000180C9EA90
	
		// Methods
		// [XID] // 0x00000001899C9380-0x00000001899C93A0
		public override void OnEnable() {} // 0x0000000180C9D690-0x0000000180C9D8A0
		// [XID] // 0x00000001899D0EF0-0x00000001899D0F10
		public override void OnDisable() {} // 0x0000000180C9D5E0-0x0000000180C9D690
		// [XID] // 0x00000001899D83B0-0x00000001899D83D0
		private void OnDestroy() {} // 0x0000000180C9D540-0x0000000180C9D5E0
		// [XID] // 0x00000001899DF980-0x00000001899DF9A0
		private void UnsubscribeEvent() {} // 0x0000000180C9E760-0x0000000180C9E970
		// [XID] // 0x00000001899E74B0-0x00000001899E74D0
		private void OnCollisionEnter() {} // 0x0000000180C9D490-0x0000000180C9D540
		// [XID] // 0x00000001896B0AC0-0x00000001896B0AE0
		private void On_TouchStart(Gesture gesture) {} // 0x0000000180C9E290-0x0000000180C9E450
		// [XID] // 0x00000001896B85F0-0x00000001896B8610
		private void On_TouchDown(Gesture gesture) {} // 0x0000000180C9DFC0-0x0000000180C9E290
		// [XID] // 0x00000001899FD8D0-0x00000001899FD8F0
		private void On_TouchUp(Gesture gesture) {} // 0x0000000180C9E450-0x0000000180C9E520
		// [XID] // 0x0000000189A04F20-0x0000000189A04F40
		private void On_DragStart(Gesture gesture) {} // 0x0000000180C9D970-0x0000000180C9DCE0
		// [XID] // 0x0000000189A0C610-0x0000000189A0C630
		private void On_Drag(Gesture gesture) {} // 0x0000000180C9DCE0-0x0000000180C9DFC0
		// [XID] // 0x0000000189A13F70-0x0000000189A13F90
		private void On_DragEnd(Gesture gesture) {} // 0x0000000180C9D8A0-0x0000000180C9D970
		// [XID] // 0x0000000189A1B1C0-0x0000000189A1B1E0
		private Vector3 GetPositionAxes(Vector3 position) => default; // 0x0000000180C9D0F0-0x0000000180C9D490
		// [XID] // 0x0000000189A22B40-0x0000000189A22B60
		public void StopDrag() {} // 0x0000000180C9E520-0x0000000180C9E6A0
	}
}
