/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoEventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 30761
	{
		// Fields
		[NonSerialized]
		public List<EventTrigger.Entry> triggers; // 0x18
	
		// Constructors
		public MonoEventTrigger() {} // 0x0000000185620020-0x00000001856200B0
	
		// Methods
		// [XID] // 0x00000001899E2C80-0x00000001899E2CA0
		private void OnDisable() {} // 0x000000018561F500-0x000000018561F5A0
		// [XID] // 0x00000001899EA3B0-0x00000001899EA3D0
		public void AddTrigger(EventTrigger.Entry entry) {} // 0x000000018561F0D0-0x000000018561F1B0
		// [XID] // 0x00000001899F1D80-0x00000001899F1DA0
		public void ClearTriggers() {} // 0x000000018561F1B0-0x000000018561F2C0
		// [XID] // 0x00000001899F95C0-0x00000001899F95E0
		private void Execute(UnityEngine.EventSystems.EventTriggerType id, BaseEventData eventData) {} // 0x000000018561EF70-0x000000018561F0D0
		// [XID] // 0x0000000189A008E0-0x0000000189A00900
		public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x000000018561FAE0-0x000000018561FBA0
		// [XID] // 0x0000000189A081C0-0x0000000189A081E0
		public virtual void OnPointerExit(PointerEventData eventData) {} // 0x000000018561FBA0-0x000000018561FC60
		// [XID] // 0x0000000189A0F5D0-0x0000000189A0F5F0
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018561F5A0-0x000000018561F660
		// [XID] // 0x0000000189A16C60-0x0000000189A16C80
		public virtual void OnDrop(PointerEventData eventData) {} // 0x000000018561F660-0x000000018561F720
		// [XID] // 0x0000000189A1E2C0-0x0000000189A1E2E0
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x000000018561FA20-0x000000018561FAE0
		// [XID] // 0x0000000189A259C0-0x0000000189A259E0
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x000000018561FC60-0x000000018561FD20
		// [XID] // 0x0000000189A2CDE0-0x0000000189A2CE00
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018561F960-0x000000018561FA20
		// [XID] // 0x0000000189A347B0-0x0000000189A347D0
		public virtual void OnSelect(BaseEventData eventData) {} // 0x000000018561FDE0-0x000000018561FEA0
		// [XID] // 0x0000000189A3BBD0-0x0000000189A3BBF0
		public virtual void OnDeselect(BaseEventData eventData) {} // 0x000000018561F440-0x000000018561F500
		// [XID] // 0x0000000189A43860-0x0000000189A43880
		public virtual void OnScroll(PointerEventData eventData) {} // 0x000000018561FD20-0x000000018561FDE0
		// [XID] // 0x0000000189A4ACB0-0x0000000189A4ACD0
		public virtual void OnMove(AxisEventData eventData) {} // 0x000000018561F8A0-0x000000018561F960
		// [XID] // 0x0000000189A52390-0x0000000189A523B0
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x000000018561FF60-0x0000000185620020
		// [XID] // 0x0000000189A59CC0-0x0000000189A59CE0
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x000000018561F7E0-0x000000018561F8A0
		// [XID] // 0x0000000189A61480-0x0000000189A614A0
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018561F2C0-0x000000018561F380
		// [XID] // 0x0000000189A693B0-0x0000000189A693D0
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018561F720-0x000000018561F7E0
		// [XID] // 0x0000000189A70740-0x0000000189A70760
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018561FEA0-0x000000018561FF60
		// [XID] // 0x0000000189A78010-0x0000000189A78030
		public virtual void OnCancel(BaseEventData eventData) {} // 0x000000018561F380-0x000000018561F440
	}
}
