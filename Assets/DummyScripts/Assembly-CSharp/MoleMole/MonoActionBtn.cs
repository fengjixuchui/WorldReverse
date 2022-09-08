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
	public class MonoActionBtn : MonoSpriteProxy, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 31096
	{
		// Fields
		public EntityHandle<AvatarEntity> avatarHandle; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected Button _button; // 0x30
		public bool _isPointerHold; // 0x38
		private float _holdTime; // 0x3C
		protected float _totalHoldTime; // 0x40
		private static float HOLD_TIME_THRESHOLD; // 0x00
		private bool _buttonClickTrigger; // 0x44
		private bool _buttonUpTrigger; // 0x45
		public bool resetButtonOnDisable; // 0x46
		public Action onPressDownCallback; // 0x48
		public Action onPressUpCallback; // 0x50
	
		// Constructors
		public MonoActionBtn() {} // 0x0000000184C69910-0x0000000184C69990
		static MonoActionBtn() {} // 0x0000000184C698B0-0x0000000184C69910
	
		// Methods
		// [XID] // 0x0000000189AB3ED0-0x0000000189AB3EF0
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x0000000184C693B0-0x0000000184C69470
		// [XID] // 0x0000000189ABBC30-0x0000000189ABBC50
		public virtual bool OnRealPointerDown(PointerEventData eventData) => default; // 0x0000000184C69540-0x0000000184C69610
		// [XID] // 0x0000000189AC33A0-0x0000000189AC33C0
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x0000000184C69470-0x0000000184C69540
		// [XID] // 0x0000000189ACAAC0-0x0000000189ACAAE0
		public virtual void OnDrag(PointerEventData data) {} // 0x0000000184C692D0-0x0000000184C693B0
		// [XID] // 0x0000000189AD2500-0x0000000189AD2520
		protected virtual void Update() {} // 0x0000000184C69790-0x0000000184C698B0
		// [XID] // 0x0000000189AD9FD0-0x0000000189AD9FF0
		protected virtual void HandlePointDown() {} // 0x0000000184C69170-0x0000000184C69220
		// [XID] // 0x0000000189AE1910-0x0000000189AE1930
		protected virtual void HandlePointUp() {} // 0x0000000184C69020-0x0000000184C690D0
		// [XID] // 0x0000000189AE90C0-0x0000000189AE90E0
		protected virtual void HandleDrag(Vector2 delta) {} // 0x0000000184C690D0-0x0000000184C69170
		// [XID] // 0x0000000189AF0E20-0x0000000189AF0E40
		public virtual void ResetButton() {} // 0x0000000184C69610-0x0000000184C696C0
		// [XID] // 0x0000000189AF8330-0x0000000189AF8350
		private void OnDisable() {} // 0x0000000184C69220-0x0000000184C692D0
		// [XID] // 0x0000000189AFFA00-0x0000000189AFFA20
		public void SetAvatarEntity(AvatarEntity entity) {} // 0x0000000184C696C0-0x0000000184C69790
	}
}
