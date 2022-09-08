/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [DefaultExecutionOrder] // 0x00000001898C3C20-0x00000001898C3C40
	public class MonoScrollRectExtention : ScrollRect, IEndDragHandler, IBeginDragHandler // TypeDefIndex: 30929
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool _useFocus; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _focusTarget; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _transitSpeed; // 0x138
		// [MinMax] // 0x0000000189B7FA50-0x0000000189B7FA90
		[SerializeField] // 0x0000000189B7FA50-0x0000000189B7FA90
		private Vector2 _xRange; // 0x13C
		// [MinMax] // 0x00000001898EFAE0-0x00000001898EFB20
		[SerializeField] // 0x00000001898EFAE0-0x00000001898EFB20
		private Vector2 _yRange; // 0x144
		private Bounds _viewBounds; // 0x14C
		private Bounds _focusViewportBounds; // 0x164
		private Bounds _focusTargetBounds; // 0x17C
		public UnityAction onEndDrag; // 0x198
		public UnityAction onBeginDrag; // 0x1A0
		public UnityAction onScroll; // 0x1A8
		private readonly Vector3[] _corners; // 0x1B0
		private bool _isToCenter; // 0x1B8
		private int _autoClearMinFrameCount; // 0x1BC
	
		// Properties
		public RectTransform finalViewRect { /* [XID] */ /* 0x000000018998BB90-0x000000018998BBB0 */ get => default; } // 0x0000000184112610-0x00000001841126C0 
		public bool useFocus { /* [XID] */ /* 0x0000000189993740-0x0000000189993760 */ get => default; /* [XID] */ /* 0x000000018999B040-0x000000018999B060 */ set {} } // 0x00000001841126C0-0x0000000184112770 0x0000000184112940-0x00000001841129F0
		public bool autoClearFocusTarget { /* [XID] */ /* 0x00000001899A2860-0x00000001899A28A0 */ get; /* [XID] */ /* 0x00000001899AD190-0x00000001899AD1D0 */ set; } // 0x00000001841125B0-0x0000000184112610 0x00000001841128D0-0x0000000184112940
		public Vector2 xRange { /* [XID] */ /* 0x00000001899B7640-0x00000001899B7660 */ get => default; /* [XID] */ /* 0x00000001899BF060-0x00000001899BF080 */ set {} } // 0x0000000184112770-0x0000000184112820 0x00000001841129F0-0x0000000184112AA0
		public Vector2 yRange { /* [XID] */ /* 0x00000001899C6A00-0x00000001899C6A20 */ get => default; /* [XID] */ /* 0x00000001899CDFA0-0x00000001899CDFC0 */ set {} } // 0x0000000184112820-0x00000001841128D0 0x0000000184112AA0-0x0000000184112B50
	
		// Constructors
		public MonoScrollRectExtention() {} // 0x0000000184112490-0x00000001841125B0
	
		// Methods
		// [XID] // 0x0000000189904C60-0x0000000189904C80
		protected override void LateUpdate() {} // 0x0000000184110250-0x0000000184110420
		// [XID] // 0x000000018990C4A0-0x000000018990C4C0
		public override void OnEndDrag(PointerEventData data) {} // 0x0000000184111490-0x0000000184111560
		// [XID] // 0x0000000189913D90-0x0000000189913DB0
		public override void OnBeginDrag(PointerEventData data) {} // 0x00000001841113C0-0x0000000184111490
		// [XID] // 0x000000018991B700-0x000000018991B720
		public override void OnScroll(PointerEventData data) {} // 0x0000000184111560-0x0000000184111630
		// [XID] // 0x0000000189922CA0-0x0000000189922CC0
		private Bounds UpdateFocusViewPortBounds() => default; // 0x000000018410F620-0x000000018410F8D0
		// [XID] // 0x000000018992A590-0x000000018992A5B0
		private Bounds UpdateFocusTargetBounds() => default; // 0x0000000184111000-0x00000001841113C0
		// [XID] // 0x0000000189931B60-0x0000000189931B80
		private static new Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) => default; // 0x000000018410EE20-0x000000018410F150
		// [XID] // 0x00000001899395C0-0x00000001899395E0
		private Vector2 CalculateOffset() => default; // 0x0000000184110420-0x0000000184110AD0
		// [XID] // 0x0000000189940890-0x00000001899408B0
		private Vector2 CalculateTargetCenterOffset() => default; // 0x0000000184110AD0-0x0000000184110FA0
		// [XID] // 0x0000000189948110-0x0000000189948130
		public void ScrollToTarget(RectTransform target, bool autoClear = true /* Metadata: 0x00B11ACA */, bool force = false /* Metadata: 0x00B11ACB */) {} // 0x0000000184111AD0-0x0000000184111FA0
		// [XID] // 0x000000018994F890-0x000000018994F8B0
		public void ScrollTargetToCenter(RectTransform target, bool autoClear = true /* Metadata: 0x00B11ACC */, bool force = false /* Metadata: 0x00B11ACD */) {} // 0x0000000184111630-0x0000000184111AD0
		// [XID] // 0x0000000189956E30-0x0000000189956E50
		private void SetNewContentAnchoredPosition(Vector2 offset) {} // 0x000000018410EC00-0x000000018410EE20
		// [XID] // 0x000000018995E9A0-0x000000018995E9C0
		private static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ref Vector2 delta) => default; // 0x000000018410F8D0-0x000000018410FBC0
		// [XID] // 0x00000001899660A0-0x00000001899660C0
		public void UpdateFocusTarget(RectTransform target, bool autoClear = true /* Metadata: 0x00B11ACE */) {} // 0x0000000184112290-0x00000001841123B0
		// [XID] // 0x000000018996D580-0x000000018996D5A0
		public void UpdateTargetToCenter(RectTransform target, bool autoClear = true /* Metadata: 0x00B11ACF */) {} // 0x00000001841123B0-0x0000000184112490
		// [XID] // 0x0000000189975100-0x0000000189975120
		public Vector2 TargetOffsetInViewBound(RectTransform target) => default; // 0x0000000184111FA0-0x0000000184112290
		// [XID] // 0x000000018997C2C0-0x000000018997C2E0
		private Vector2 CalculateTargetOffset(ref Bounds targetBounds) => default; // 0x000000018410FC40-0x0000000184110250
		// [XID] // 0x0000000189983FB0-0x0000000189983FD0
		private Bounds UpdateTargetBounds(RectTransform target) => default; // 0x000000018410F250-0x000000018410F620
	}
}
