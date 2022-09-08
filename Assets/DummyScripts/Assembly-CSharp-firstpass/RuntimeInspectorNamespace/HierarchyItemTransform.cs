/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class HierarchyItemTransform : HierarchyItem // TypeDefIndex: 9966
	{
		// Fields
		private IEnumerator pointerHeldCoroutine; // 0xA0
		private float nextNameRefreshTime; // 0xA8
		private bool m_isActive; // 0xAC
	
		// Properties
		protected override bool IsValid { /* [XID] */ /* 0x0000000189929EA0-0x0000000189929EC0 */ get => default; } // 0x00000001867F2DB0-0x00000001867F2EC0 
		protected override int ChildCount { /* [XID] */ /* 0x000000018966A970-0x000000018966A990 */ get => default; } // 0x00000001867F2C10-0x00000001867F2D00 
		public Transform BoundTransform { /* [XID] */ /* 0x0000000189672670-0x00000001896726B0 */ get; /* [XID] */ /* 0x000000018967CD00-0x000000018967CD40 */ private set; } // 0x00000001867F2BB0-0x00000001867F2C10 0x00000001867F2EC0-0x00000001867F2F30
		protected override bool IsActive { /* [XID] */ /* 0x0000000189BBBCD0-0x0000000189BBBCF0 */ get => default; /* [XID] */ /* 0x000000018968F280-0x000000018968F2A0 */ set {} } // 0x00000001867F2D00-0x00000001867F2DB0 0x00000001867F2F30-0x00000001867F3080
	
		// Constructors
		public HierarchyItemTransform() {} // 0x00000001867F2B30-0x00000001867F2BB0
	
		// Methods
		// [XID] // 0x0000000189696C70-0x0000000189696C90
		protected override void Initialize() {} // 0x00000001867F2310-0x00000001867F2450
		// [XID] // 0x000000018969E2A0-0x000000018969E2C0
		public void BindTo(Transform target) {} // 0x00000001867F1FB0-0x00000001867F20F0
		// [XID] // 0x0000000189B49C70-0x0000000189B49C90
		public override void Refresh() {} // 0x00000001867F2670-0x00000001867F2830
		// [XID] // 0x00000001895ECC60-0x00000001895ECC80
		private void OnPointerDown(PointerEventData eventData) {} // 0x00000001867F2450-0x00000001867F25A0
		// [XID] // 0x00000001896A6960-0x00000001896A6980
		private void OnPointerUp(PointerEventData eventData) {} // 0x00000001867F25A0-0x00000001867F2670
		// [XID] // 0x000000018960C3A0-0x000000018960C3C0
		public override void Unbind() {} // 0x00000001867F2A40-0x00000001867F2B30
		[DebuggerHidden] // 0x00000001896C2720-0x00000001896C2760
		// [XID] // 0x00000001896C2720-0x00000001896C2760
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData) => default; // 0x00000001867F20F0-0x00000001867F2210
		// [XID] // 0x00000001896CCF20-0x00000001896CCF40
		protected override Transform GetChild(int index) => default; // 0x00000001867F2210-0x00000001867F2310
	}
}
