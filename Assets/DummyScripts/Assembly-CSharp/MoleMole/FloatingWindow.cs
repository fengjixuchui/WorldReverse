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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class FloatingWindow : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 28366
	{
		// Fields
		public Button floatingbutton; // 0x18
		public GameObject floatingCanvas; // 0x20
		private Vector3 globalMousePos; // 0x28
	
		// Constructors
		public FloatingWindow() {} // 0x0000000181F7CFE0-0x0000000181F7D050
	
		// Methods
		// [XID] // 0x000000018996A880-0x000000018996A8A0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000181F7CD40-0x0000000181F7CE20
		// [XID] // 0x0000000189972660-0x0000000189972680
		public void OnDrag(PointerEventData eventData) {} // 0x0000000181F7CE20-0x0000000181F7CF00
		// [XID] // 0x0000000189979E20-0x0000000189979E40
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000181F7CF00-0x0000000181F7CFE0
		// [XID] // 0x0000000189981590-0x00000001899815B0
		private void SetDraggedPosition(PointerEventData eventData) {} // 0x0000000181F7CB50-0x0000000181F7CD40
		// [XID] // 0x0000000189988DC0-0x0000000189988DE0
		private bool isInScreen(Vector2 point) => default; // 0x0000000181F7C840-0x0000000181F7CB50
	}
}
