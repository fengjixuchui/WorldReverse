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
	// [AddComponentMenu] // 0x00000001899A5440-0x00000001899A54C0
	// [RequireComponent] // 0x00000001899A5440-0x00000001899A54C0
	public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 9774
	{
		// Fields
		public bool allowMouseControl; // 0x18
	
		// Properties
		public bool isPressed { /* [XID] */ /* 0x00000001899BED20-0x00000001899BED60 */ get; /* [XID] */ /* 0x00000001899C9200-0x00000001899C9240 */ private set; } // 0x0000000186562D80-0x0000000186562DE0 0x0000000186562DE0-0x0000000186562E40
	
		// Constructors
		public TouchButtonExample() {} // 0x0000000186562D10-0x0000000186562D80
	
		// Methods
		// [XID] // 0x0000000189B6E840-0x0000000189B6E860
		private void Awake() {} // 0x00000001865628C0-0x0000000186562970
		// [XID] // 0x00000001899DB120-0x00000001899DB140
		private void Restart() {} // 0x0000000186562A20-0x0000000186562AF0
		// [XID] // 0x00000001899E2890-0x00000001899E28B0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {} // 0x0000000186562AF0-0x0000000186562C00
		// [XID] // 0x0000000189A91F20-0x0000000189A91F40
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {} // 0x0000000186562C00-0x0000000186562D10
		// [XID] // 0x00000001899F1690-0x00000001899F16B0
		private static bool IsMousePointerId(int id) => default; // 0x0000000186562970-0x0000000186562A20
	}
}
