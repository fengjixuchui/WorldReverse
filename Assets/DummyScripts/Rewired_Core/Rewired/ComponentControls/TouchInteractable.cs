/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001895F60E0-0x00000001895F6110
	[ExecuteInEditMode] // 0x00000001895F60E0-0x00000001895F6110
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 3550
	{
		// Fields
		public const int POINTER_ID_NULL = -2147483648; // Metadata: 0x00AC3FB9
		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1; // Metadata: 0x00AC3FBD
		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2; // Metadata: 0x00AC3FC1
		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3; // Metadata: 0x00AC3FC5
		internal const int MAX_MOUSE_BUTTONS = 3; // Metadata: 0x00AC3FC9
		[CustomObfuscation] // 0x0000000189600480-0x00000001896004E0
		[SerializeField] // 0x0000000189600480-0x00000001896004E0
		// [Tooltip] // 0x0000000189600480-0x00000001896004E0
		private bool _interactable; // 0x38
		[CustomObfuscation] // 0x000000018960F5E0-0x000000018960F640
		[SerializeField] // 0x000000018960F5E0-0x000000018960F640
		// [Tooltip] // 0x000000018960F5E0-0x000000018960F640
		private bool _visible; // 0x39
		[CustomObfuscation] // 0x000000018961E5C0-0x000000018961E620
		[SerializeField] // 0x000000018961E5C0-0x000000018961E620
		// [Tooltip] // 0x000000018961E5C0-0x000000018961E620
		private bool _hideWhenIdle; // 0x3A
		// [Bitmask] // 0x000000018962D290-0x000000018962D330
		[CustomObfuscation] // 0x000000018962D290-0x000000018962D330
		[SerializeField] // 0x000000018962D290-0x000000018962D330
		// [Tooltip] // 0x000000018962D290-0x000000018962D330
		private MouseButtonFlags _allowedMouseButtons; // 0x3C
		// [Bitmask] // 0x0000000189643BE0-0x0000000189643C80
		[CustomObfuscation] // 0x0000000189643BE0-0x0000000189643C80
		[SerializeField] // 0x0000000189643BE0-0x0000000189643C80
		// [Tooltip] // 0x0000000189643BE0-0x0000000189643C80
		private TransitionTypeFlags _transitionType; // 0x40
		[CustomObfuscation] // 0x000000018965A1B0-0x000000018965A210
		[SerializeField] // 0x000000018965A1B0-0x000000018965A210
		// [Tooltip] // 0x000000018965A1B0-0x000000018965A210
		private ColorBlock _transitionColorTint; // 0x44
		[CustomObfuscation] // 0x0000000189669440-0x00000001896694A0
		[SerializeField] // 0x0000000189669440-0x00000001896694A0
		// [Tooltip] // 0x0000000189669440-0x00000001896694A0
		private SpriteState _transitionSpriteState; // 0x90
		[CustomObfuscation] // 0x00000001896786D0-0x0000000189678730
		[SerializeField] // 0x00000001896786D0-0x0000000189678730
		// [Tooltip] // 0x00000001896786D0-0x0000000189678730
		private AnimationTriggers _transitionAnimationTriggers; // 0xA8
		[CustomObfuscation] // 0x0000000189687640-0x00000001896876A0
		[SerializeField] // 0x0000000189687640-0x00000001896876A0
		// [Tooltip] // 0x0000000189687640-0x00000001896876A0
		private Graphic _targetGraphic; // 0xB0
		[CustomObfuscation] // 0x0000000189696EB0-0x0000000189696F10
		[SerializeField] // 0x0000000189696EB0-0x0000000189696F10
		// [Tooltip] // 0x0000000189696EB0-0x0000000189696F10
		private InteractionStateTransitionEventHandler _onInteractionStateTransition; // 0xB8
		[CustomObfuscation] // 0x00000001896A5440-0x00000001896A54A0
		[SerializeField] // 0x00000001896A5440-0x00000001896A54A0
		// [Tooltip] // 0x00000001896A5440-0x00000001896A54A0
		private VisibilityChangedEventHandler _onVisibilityChanged; // 0xC0
		[CustomObfuscation] // 0x00000001896B40E0-0x00000001896B4140
		[SerializeField] // 0x00000001896B40E0-0x00000001896B4140
		// [Tooltip] // 0x00000001896B40E0-0x00000001896B4140
		private UnityEvent _onInteractionStateChangedToNormal; // 0xC8
		[CustomObfuscation] // 0x00000001896C28D0-0x00000001896C2930
		[SerializeField] // 0x00000001896C28D0-0x00000001896C2930
		// [Tooltip] // 0x00000001896C28D0-0x00000001896C2930
		private UnityEvent _onInteractionStateChangedToHighlighted; // 0xD0
		[CustomObfuscation] // 0x00000001896D1680-0x00000001896D16E0
		[SerializeField] // 0x00000001896D1680-0x00000001896D16E0
		// [Tooltip] // 0x00000001896D1680-0x00000001896D16E0
		private UnityEvent _onInteractionStateChangedToPressed; // 0xD8
		[CustomObfuscation] // 0x00000001896E0590-0x00000001896E05F0
		[SerializeField] // 0x00000001896E0590-0x00000001896E05F0
		// [Tooltip] // 0x00000001896E0590-0x00000001896E05F0
		private UnityEvent _onInteractionStateChangedToDisabled; // 0xE0
		private readonly List<CanvasGroup> _canvasGroupCache; // 0xE8
		private bool _groupsAllowInteraction; // 0xF0
		private InteractionState _interactionState; // 0xF4
		[NonSerialized]
		private bool GXxxUMYvhnAdzwfrIpAYPjIWpue; // 0xF8
		[NonSerialized]
		private bool jYtFWKZUVrechfzATGCgCETBhJCg; // 0xF9
		private bool _varWatch_visible; // 0xFA
		private bool _varWatch_interactable; // 0xFB
		private bool _allowSendingEvents; // 0xFC
		private static InteractionStateTransitionArgs _transitionArgs; // 0x00
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers; // 0x100
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers; // 0x108
		private static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate; // 0x08
	
		// Properties
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IVisibilityChangedHandler, bool> hierarchyVisibilityChangedHandlers { get; } // 0x0000000186A08430-0x0000000186A08530 
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> hierarchyInteractionStateTransitionHandlers { get; } // 0x0000000186A08330-0x0000000186A08430 
		public bool interactable { get; set; } // 0x0000000186A085D0-0x0000000186A08630 0x0000000186A09990-0x0000000186A09A10
		public bool visible { get; set; } // 0x0000000186A08A90-0x0000000186A08AF0 0x0000000186A09DC0-0x0000000186A09EC0
		public bool hideWhenIdle { get; set; } // 0x0000000186A082D0-0x0000000186A08330 0x0000000186A09830-0x0000000186A098B0
		public MouseButtonFlags allowedMouseButtons { get; set; } // 0x0000000186A081E0-0x0000000186A08240 0x0000000186A097B0-0x0000000186A09830
		public TransitionTypeFlags transitionType { get; set; } // 0x0000000186A08A30-0x0000000186A08A90 0x0000000186A09D20-0x0000000186A09DC0
		public ColorBlock transitionColorTint { get; set; } // 0x0000000186A08920-0x0000000186A089B0 0x0000000186A09B90-0x0000000186A09C40
		public SpriteState transitionSpriteState { get; set; } // 0x0000000186A089B0-0x0000000186A08A30 0x0000000186A09C40-0x0000000186A09D20
		public AnimationTriggers transitionAnimationTriggers { get; set; } // 0x0000000186A088C0-0x0000000186A08920 0x0000000186A09AE0-0x0000000186A09B90
		public Graphic targetGraphic { get; set; } // 0x0000000186A08860-0x0000000186A088C0 0x0000000186A09A10-0x0000000186A09AE0
		public Image image { get; set; } // 0x0000000186A08530-0x0000000186A085D0 0x0000000186A098B0-0x0000000186A09990
		public Animator animator { get; } // 0x0000000186A08240-0x0000000186A082D0 
		public InteractionState interactionState { get; } // 0x0000000186A08800-0x0000000186A08860 
		internal static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> interactionStateTransitionHandlerDelegate { get; } // 0x0000000186A08630-0x0000000186A08800 
	
		// Events
		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent;
		public event UnityAction<bool> VisibilityChangedEvent;
		public event UnityAction InteractionStateChangedToNormal;
		public event UnityAction InteractionStateChangedToHighlighted;
		public event UnityAction InteractionStateChangedToPressed;
		public event UnityAction InteractionStateChangedToDisabled;
	
		// Nested types
		public enum InteractionState // TypeDefIndex: 3551
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Disabled = 3
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum TransitionTypeFlags // TypeDefIndex: 3552
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 4
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum MouseButtonFlags // TypeDefIndex: 3553
		{
			AnyButton = -1,
			None = 0,
			LeftButton = 1,
			RightButton = 2,
			MiddleButton = 4
		}
	
		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs> // TypeDefIndex: 3554
		{
			// Constructors
			public InteractionStateTransitionEventHandler() {} // 0x00000001869F8AC0-0x00000001869F8B30
		}
	
		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 3555
		{
			// Constructors
			public VisibilityChangedEventHandler() {} // 0x0000000186A1EF00-0x0000000186A1EF70
		}
	
		public class InteractionStateTransitionArgs // TypeDefIndex: 3556
		{
			// Fields
			private TouchInteractable HVvgSnJtYAILMcUpzQRxwCmTIRPz; // 0x10
			private InteractionState rtvVnhTQYgCakhFQKHBBPREvwqN; // 0x18
			private float GPnqlAJZovolwSSlXIYvGdssvbs; // 0x1C
	
			// Properties
			public TouchInteractable sender { get => default; } // 0x00000001869F8A00-0x00000001869F8A60 
			public InteractionState state { get => default; } // 0x00000001869F8A60-0x00000001869F8AC0 
			public float duration { get => default; } // 0x00000001869F8990-0x00000001869F8A00 
	
			// Constructors
			internal InteractionStateTransitionArgs() {} // 0x00000001869F88A0-0x00000001869F8900
	
			// Methods
			internal void fuLKaTfKQpOpktgPzRLpUDfEjf(TouchInteractable param_00007df5, InteractionState param_00007df6, float param_00007df7) {} // 0x00000001869F8900-0x00000001869F8990
		}
	
		public interface IInteractionStateTransitionHandler // TypeDefIndex: 3557
		{
			// Methods
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal TouchInteractable() {} // 0x0000000186A07450-0x0000000186A077D0
		static TouchInteractable() {} // 0x0000000186A07390-0x0000000186A07450
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Awake() {} // 0x0000000186A04220-0x0000000186A04350
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnCanvasGroupChanged() {} // 0x0000000186A05370-0x0000000186A05630
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDidApplyAnimationProperties() {} // 0x0000000186A05630-0x0000000186A056A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnEnable() {} // 0x0000000186A057F0-0x0000000186A05890
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDisable() {} // 0x0000000186A056A0-0x0000000186A05730
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x0000000186A05DE0-0x0000000186A061D0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Reset() {} // 0x0000000186A06290-0x0000000186A06330
		internal override void OnSetProperty() {} // 0x0000000186A05D70-0x0000000186A05DE0
		internal override void FindEventHandlers() {} // 0x0000000186A049A0-0x0000000186A04A10
		private void jAQGAmQgKbqKrhUPStwqorlTNHK() {} // 0x0000000186A08AF0-0x0000000186A08D40
		private void SuHWIDfTNsChRxehzCBEFxUUSSd(InteractionState param_00007dc4, bool param_00007dc5) {} // 0x0000000186A06710-0x0000000186A06E40
		private void GeMaoYWkSWdVuATkrycOOKBsivlD(Color param_00007dc6, bool param_00007dc7) {} // 0x0000000186A04A10-0x0000000186A04B50
		private void XTdwPHoIYAeXdtxcHVtlnrtFtNI(Sprite param_00007dc8) {} // 0x0000000186A07230-0x0000000186A07300
		private void CnDPxkPDbLAJqkImsyyrmtwSUPMg(string param_00007dc9) {} // 0x0000000186A04350-0x0000000186A04940
		private void lPSCJgLLeQzAoKcuIadJZzmnIqP(bool param_00007dca) {} // 0x0000000186A09060-0x0000000186A09160
		public bool IsInteractable() => default; // 0x0000000186A04B50-0x0000000186A04BC0
		internal virtual bool IsPressed() => default; // 0x0000000186A04BC0-0x0000000186A04C40
		internal void tPzLrmyiYkESrTkUqlRUVdqEdkXD(BaseEventData param_00007dcb) {} // 0x0000000186A09EC0-0x0000000186A0A000
		internal virtual bool IsThisOrTouchRegionGameObject(GameObject param_00007dcc) => default; // 0x0000000186A04C40-0x0000000186A04CF0
		private bool NWAUGwGzCBNJWVGxFxsoJtCcfsg(BaseEventData param_00007dcd) => default; // 0x0000000186A050C0-0x0000000186A05230
		private bool NWAUGwGzCBNJWVGxFxsoJtCcfsg(bool param_00007dce, GameObject param_00007dcf) => default; // 0x0000000186A04F10-0x0000000186A050C0
		private InteractionState uggeuIdUyZrSjgCSzVUqAalNEEK(BaseEventData param_00007dd0) => default; // 0x0000000186A0A240-0x0000000186A0A2F0
		private bool QLoEsvcQmZHGkQPzbIQPMHMGZBrf(InteractionState param_00007dd1) => default; // 0x0000000186A061D0-0x0000000186A06290
		private void DpXYztTnOUCrAJINiuODIfCmiek() {} // 0x0000000186A04940-0x0000000186A049A0
		private void LunFTqfhqohoqAAmuapPhlSpaZF() {} // 0x0000000186A04DC0-0x0000000186A04E50
		private void SWnzUAEKhgDxxwxmMhpFBvKnnQNm(bool param_00007dd2, bool param_00007dd3) {} // 0x0000000186A06600-0x0000000186A06710
		private void uYzFvpGmRyWWGtLVturUCJxekis() {} // 0x0000000186A0A000-0x0000000186A0A240
		private void qVsMyoYBvETfokpXbIGIpiZNXPA() {} // 0x0000000186A092A0-0x0000000186A09380
		private new void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x0000000186A04E50-0x0000000186A04F10
		private void qweXQsffDfaGHLzEsNQlfjGBeBSJ() {} // 0x0000000186A09380-0x0000000186A09450
		internal virtual void OnPointerDown(PointerEventData param_00007dd4) {} // 0x0000000186A05950-0x0000000186A05A40
		internal virtual void OnPointerUp(PointerEventData param_00007dd5) {} // 0x0000000186A05C60-0x0000000186A05D70
		internal virtual void OnPointerEnter(PointerEventData param_00007dd6) {} // 0x0000000186A05A40-0x0000000186A05B50
		internal virtual void OnPointerExit(PointerEventData param_00007dd7) {} // 0x0000000186A05B50-0x0000000186A05C60
		internal virtual void OnBeginDrag(PointerEventData param_00007dd8) {} // 0x0000000186A052B0-0x0000000186A05370
		internal virtual void OnDrag(PointerEventData param_00007dd9) {} // 0x0000000186A05730-0x0000000186A057F0
		internal virtual void OnEndDrag(PointerEventData param_00007dda) {} // 0x0000000186A05890-0x0000000186A05950
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {} // 0x0000000186A07030-0x0000000186A070B0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {} // 0x0000000186A071B0-0x0000000186A07230
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {} // 0x0000000186A070B0-0x0000000186A07130
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {} // 0x0000000186A07130-0x0000000186A071B0
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) {} // 0x0000000186A06EB0-0x0000000186A06F30
		void IDragHandler.OnDrag(PointerEventData eventData) {} // 0x0000000186A06F30-0x0000000186A06FB0
		void IEndDragHandler.OnEndDrag(PointerEventData eventData) {} // 0x0000000186A06FB0-0x0000000186A07030
		internal static bool RoGStfwaKUBSohbxbjNXJoKcyhPq(int param_00007de2) => default; // 0x0000000186A06330-0x0000000186A06600
		internal static Vector3 eWcGendfQFVDlCeIgDmIKeADLJy(int param_00007de3) => default; // 0x0000000186A07CD0-0x0000000186A08000
		internal static bool KuAJRIwcSXvZzXmlUAMUBQvrtsg(int param_00007de4) => default; // 0x0000000186A04CF0-0x0000000186A04D50
		internal static bool LPtfcWbVHTptcvJrjwlirMYQDgGc(int param_00007de5) => default; // 0x0000000186A04D50-0x0000000186A04DC0
		private static int fHkXkQWlHQxjztUUubymvvrnmLX(int param_00007de6) => default; // 0x0000000186A08000-0x0000000186A081E0
		internal static bool jxCLxvxCDOJXvcIvfAZYuiRGzsy(MouseButtonFlags param_00007de7, int param_00007de8) => default; // 0x0000000186A08EA0-0x0000000186A09060
		private static bool NlXYmpaJmCxcYptqaxkqNnCTOAf(MouseButtonFlags param_00007de9, int param_00007dea) => default; // 0x0000000186A05230-0x0000000186A052B0
		private static int eRyxXopMMXoaiMJTJSVEAcbEsQo(int param_00007deb) => default; // 0x0000000186A07BD0-0x0000000186A07CD0
		internal static bool mrmKZDYUuqVORhTlxFDFBEPmIPc(MouseButtonFlags param_00007dec, out int param_00007ded) {
			param_00007ded = default;
			return default;
		} // 0x0000000186A09160-0x0000000186A092A0
		internal static bool jxCLxvxCDOJXvcIvfAZYuiRGzsy(int param_00007dee, MouseButtonFlags param_00007def, UnityEngine.EventSystems.EventTriggerType param_00007df0) => default; // 0x0000000186A08D40-0x0000000186A08EA0
		internal static bool adosDjbqcDBzBFXIUEkqUggQerO(MouseButtonFlags param_00007df1) => default; // 0x0000000186A07B30-0x0000000186A07BD0
	}
}
