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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x00000001899F8F30-0x00000001899F8FB0
	// [RequireComponent] // 0x00000001899F8F30-0x00000001899F8FB0
	public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 9775
	{
		// Fields
		public bool allowMouseControl; // 0x18
		public int radius; // 0x1C
		private Vector2 origAnchoredPosition; // 0x20
		private Vector3 origWorldPosition; // 0x28
		private Vector2 origScreenResolution; // 0x34
		private ScreenOrientation origScreenOrientation; // 0x3C
		[NonSerialized]
		private bool hasFinger; // 0x40
		[NonSerialized]
		private int lastFingerId; // 0x44
	
		// Properties
		public Vector2 position { /* [XID] */ /* 0x0000000189A12550-0x0000000189A12590 */ get; /* [XID] */ /* 0x0000000189A1C660-0x0000000189A1C6A0 */ private set; } // 0x00000001865639E0-0x0000000186563A50 0x0000000186563A50-0x0000000186563AB0
	
		// Constructors
		public TouchJoystickExample() {} // 0x0000000186563970-0x00000001865639E0
	
		// Methods
		// [XID] // 0x0000000189A999A0-0x0000000189A999C0
		private void Start() {} // 0x0000000186563040-0x00000001865630F0
		// [XID] // 0x0000000189A2E270-0x0000000189A2E290
		private void Update() {} // 0x0000000186563880-0x0000000186563970
		// [XID] // 0x0000000189A35B20-0x0000000189A35B40
		private void Restart() {} // 0x0000000186562EF0-0x0000000186563040
		// [XID] // 0x0000000189AA09A0-0x0000000189AA09C0
		private void StoreOrigValues() {} // 0x00000001865630F0-0x0000000186563260
		// [XID] // 0x000000018983A9E0-0x000000018983AA00
		private void UpdateValue(Vector3 value) {} // 0x0000000186563670-0x0000000186563880
		// [XID] // 0x0000000189B3E170-0x0000000189B3E190
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {} // 0x0000000186563480-0x0000000186563580
		// [XID] // 0x0000000189A53850-0x0000000189A53870
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {} // 0x0000000186563580-0x0000000186563670
		// [XID] // 0x0000000189A5AFE0-0x0000000189A5B000
		void IDragHandler.OnDrag(PointerEventData eventData) {} // 0x0000000186563260-0x0000000186563480
		// [XID] // 0x0000000189A627C0-0x0000000189A627E0
		private static bool IsMousePointerId(int id) => default; // 0x0000000186562E40-0x0000000186562EF0
	}
}
