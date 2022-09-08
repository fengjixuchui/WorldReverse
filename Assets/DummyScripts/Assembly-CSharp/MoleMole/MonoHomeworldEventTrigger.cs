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
	public sealed class MonoHomeworldEventTrigger : MonoEventTrigger // TypeDefIndex: 20388
	{
		// Fields
		public Button triggerButton; // 0x20
		public UnityEngine.UI.Text hintText; // 0x28
		public UnityEngine.UI.Text description; // 0x30
		public UnityEngine.UI.Text comfortLevel; // 0x38
		public UnityEngine.UI.Text numberText; // 0x40
		public MonoUIContainer infoButton; // 0x48
		public GameObject imgLock; // 0x50
		public uint furnitureID; // 0x58
		public int itemIndex; // 0x5C
		public Action<uint, MonoHomeworldEventTrigger> onDragStartCallback; // 0x60
		public Action<uint, MonoHomeworldEventTrigger> onDragEndCallback; // 0x68
		// [Tooltip] // 0x00000001898C4230-0x00000001898C4260
		public Vector2 direction; // 0x70
		// [Tooltip] // 0x00000001898CCFD0-0x00000001898CD000
		public float dragPosTolerance; // 0x78
		// [Tooltip] // 0x00000001898D61B0-0x00000001898D61E0
		public float thresholdAgainstDragBeginPos; // 0x7C
		// [Tooltip] // 0x00000001898DF790-0x00000001898DF7C0
		public bool needDragPosOutOfParentScrollRect; // 0x80
		private Vector2 _tarDirection; // 0x84
		private Vector2 _refDirection; // 0x8C
		private Vector2 _dragBeginPosition; // 0x94
		private bool _flagDragBegin; // 0x9C
		private static Vector3[] _corners; // 0x00
		private ScrollRect _scrollRect; // 0xA0
	
		// Properties
		public ScrollRect scrollRect { /* [XID] */ /* 0x00000001898F7A10-0x00000001898F7A30 */ get => default; } // 0x0000000184B79750-0x0000000184B79850 
	
		// Constructors
		public MonoHomeworldEventTrigger() {} // 0x0000000184B79690-0x0000000184B79750
		static MonoHomeworldEventTrigger() {} // 0x0000000184B79610-0x0000000184B79690
	
		// Methods
		// [XID] // 0x00000001898E89C0-0x00000001898E89E0
		public void Awake() {} // 0x0000000184B78720-0x0000000184B787C0
		// [XID] // 0x00000001898F00E0-0x00000001898F0100
		public void OnDestroy() {} // 0x0000000184B78DD0-0x0000000184B78E70
		// [XID] // 0x00000001898FF070-0x00000001898FF090
		private void InitDragParams() {} // 0x0000000184B78980-0x0000000184B78AE0
		// [XID] // 0x00000001899067F0-0x0000000189906810
		private void ClearDrag() {} // 0x0000000184B78650-0x0000000184B78720
		// [XID] // 0x000000018990E350-0x000000018990E370
		private void SetDragBegin(Vector2 position) {} // 0x0000000184B78AE0-0x0000000184B78BA0
		// [XID] // 0x0000000189915A60-0x0000000189915A80
		private bool IsDragged(Vector2 position) => default; // 0x0000000184B788C0-0x0000000184B78980
		// [XID] // 0x000000018991D470-0x000000018991D490
		private bool CheckDragPos(Vector2 position) => default; // 0x0000000184B791C0-0x0000000184B79610
		// [XID] // 0x0000000189924D60-0x0000000189924D80
		public override void OnDrag(PointerEventData eventData) {} // 0x0000000184B78E70-0x0000000184B79000
		// [XID] // 0x000000018992C280-0x000000018992C2A0
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000184B78C20-0x0000000184B78DD0
		// [XID] // 0x0000000189933720-0x0000000189933740
		public override void OnEndDrag(PointerEventData eventData) {} // 0x0000000184B79000-0x0000000184B791C0
	}
}
