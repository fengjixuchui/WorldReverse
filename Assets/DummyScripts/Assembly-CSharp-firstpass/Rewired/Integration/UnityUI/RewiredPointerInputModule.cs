/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Integration.UnityUI
{
	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 9805
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x00AE62EE
		public const int kMouseRightId = -2; // Metadata: 0x00AE62F2
		public const int kMouseMiddleId = -3; // Metadata: 0x00AE62F6
		public const int kFakeTouchesId = -4; // Metadata: 0x00AE62FA
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x00AE62FE
		private const int customButtonsMaxCount = 128; // Metadata: 0x00AE6302
		private const int customButtonsLastId = -2147483392; // Metadata: 0x00AE6306
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { /* [XID] */ /* 0x0000000189BBEB70-0x0000000189BBEB90 */ get; } // 0x000000018734C730-0x000000018734C800 
		private IMouseInputSource defaultMouseInputSource { /* [XID] */ /* 0x0000000189BC6760-0x0000000189BC6780 */ get; } // 0x000000018734C800-0x000000018734C8B0 
		protected ITouchInputSource defaultTouchInputSource { /* [XID] */ /* 0x0000000189A804A0-0x0000000189A804C0 */ get; } // 0x000000018734C8B0-0x000000018734C960 
		protected virtual bool isMouseSupported { /* [XID] */ /* 0x0000000189625940-0x0000000189625960 */ get; } // 0x000000018734C960-0x000000018734CAC0 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 9806
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState() {} // 0x0000000187345E50-0x0000000187345EE0
	
			// Methods
			// [XID] // 0x000000018969E2C0-0x000000018969E2E0
			public bool AnyPressesThisFrame() => default; // 0x00000001873458A0-0x00000001873459F0
			// [XID] // 0x00000001896A5340-0x00000001896A5360
			public bool AnyReleasesThisFrame() => default; // 0x00000001873459F0-0x0000000187345B40
			// [XID] // 0x000000018998C1F0-0x000000018998C210
			public ButtonState GetButtonState(int button) => default; // 0x0000000187345B40-0x0000000187345D30
			// [XID] // 0x00000001896B3EF0-0x00000001896B3F10
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data) {} // 0x0000000187345D30-0x0000000187345E50
		}
	
		public class MouseButtonEventData // TypeDefIndex: 9807
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData() {} // 0x0000000187345840-0x00000001873458A0
	
			// Methods
			// [XID] // 0x00000001896BB4E0-0x00000001896BB500
			public bool PressedThisFrame() => default; // 0x00000001873456E0-0x0000000187345790
			// [XID] // 0x00000001896C2790-0x00000001896C27B0
			public bool ReleasedThisFrame() => default; // 0x0000000187345790-0x0000000187345840
		}
	
		protected class ButtonState // TypeDefIndex: 9808
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { /* [XID] */ /* 0x00000001896C9CF0-0x00000001896C9D10 */ get => default; /* [XID] */ /* 0x00000001898025C0-0x00000001898025E0 */ set {} } // 0x0000000187341130-0x00000001873411D0 0x0000000187341280-0x0000000187341330
			public int button { /* [XID] */ /* 0x00000001896D8C10-0x00000001896D8C30 */ get => default; /* [XID] */ /* 0x00000001896E0450-0x00000001896E0470 */ set {} } // 0x0000000187341090-0x0000000187341130 0x00000001873411D0-0x0000000187341280
	
			// Constructors
			public ButtonState() {} // 0x0000000187341020-0x0000000187341090
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 9809
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { /* [XID] */ /* 0x00000001896E76E0-0x00000001896E7700 */ get => default; } // 0x0000000187356B50-0x0000000187356C00 
			int ITouchInputSource.playerId { /* [XID] */ /* 0x00000001896EEDA0-0x00000001896EEDC0 */ get => default; } // 0x00000001873570B0-0x0000000187357160 
			bool IMouseInputSource.enabled { /* [XID] */ /* 0x00000001896F6780-0x00000001896F67A0 */ get => default; } // 0x00000001873569E0-0x0000000187356A90 
			bool IMouseInputSource.locked { /* [XID] */ /* 0x00000001896FDF20-0x00000001896FDF40 */ get => default; } // 0x0000000187356A90-0x0000000187356B50 
			int IMouseInputSource.buttonCount { /* [XID] */ /* 0x000000018993E0D0-0x000000018993E0F0 */ get => default; } // 0x0000000187356930-0x00000001873569E0 
			Vector2 IMouseInputSource.screenPosition { /* [XID] */ /* 0x0000000189722F60-0x0000000189722F80 */ get => default; } // 0x0000000187356D00-0x0000000187356E20 
			Vector2 IMouseInputSource.screenPositionDelta { /* [XID] */ /* 0x000000018972A690-0x000000018972A6B0 */ get => default; } // 0x0000000187356C00-0x0000000187356D00 
			Vector2 IMouseInputSource.wheelDelta { /* [XID] */ /* 0x000000018994CC30-0x000000018994CC50 */ get => default; } // 0x0000000187356E20-0x0000000187356F00 
			bool ITouchInputSource.touchSupported { /* [XID] */ /* 0x0000000189739430-0x0000000189739450 */ get => default; } // 0x0000000187357230-0x0000000187357300 
			int ITouchInputSource.touchCount { /* [XID] */ /* 0x0000000189741120-0x0000000189741140 */ get => default; } // 0x0000000187357160-0x0000000187357230 
	
			// Constructors
			public UnityInputSource() {} // 0x0000000187357450-0x00000001873574C0
	
			// Methods
			// [XID] // 0x0000000189936610-0x0000000189936630
			bool IMouseInputSource.GetButtonDown(int button) => default; // 0x0000000187356690-0x0000000187356770
			// [XID] // 0x00000001896AAD50-0x00000001896AAD70
			bool IMouseInputSource.GetButtonUp(int button) => default; // 0x0000000187356770-0x0000000187356850
			// [XID] // 0x00000001899457E0-0x0000000189945800
			bool IMouseInputSource.GetButton(int button) => default; // 0x0000000187356850-0x0000000187356930
			// [XID] // 0x0000000189748970-0x0000000189748990
			Touch ITouchInputSource.GetTouch(int index) => default; // 0x0000000187356F00-0x00000001873570B0
			// [XID] // 0x000000018974FEB0-0x000000018974FED0
			private void TryUpdate() {} // 0x0000000187357300-0x0000000187357450
		}
	
		// Constructors
		protected RewiredPointerInputModule() {} // 0x000000018734C660-0x000000018734C730
	
		// Methods
		// [XID] // 0x0000000189BD56B0-0x0000000189BD56D0
		protected bool IsDefaultMouse(IMouseInputSource mouse) => default; // 0x000000018734AF60-0x000000018734B020
		// [XID] // 0x0000000189BDD310-0x0000000189BDD330
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) => default; // 0x0000000187349BD0-0x0000000187349DF0
		// [XID] // 0x00000001895E9D60-0x00000001895E9D80
		public void RemoveMouseInputSource(IMouseInputSource source) {} // 0x000000018734B9A0-0x000000018734BAA0
		// [XID] // 0x00000001895F1360-0x00000001895F1380
		public void AddMouseInputSource(IMouseInputSource source) {} // 0x0000000187348A70-0x0000000187348BB0
		// [XID] // 0x00000001895F8F40-0x00000001895F8F60
		public int GetMouseInputSourceCount(int playerId) => default; // 0x0000000187349A10-0x0000000187349BD0
		// [XID] // 0x00000001896002B0-0x00000001896002D0
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) => default; // 0x000000018734AA80-0x000000018734AB90
		// [XID] // 0x0000000189607940-0x0000000189607960
		public void RemoveTouchInputSource(ITouchInputSource source) {} // 0x000000018734BC90-0x000000018734BD80
		// [XID] // 0x000000018960F430-0x000000018960F450
		public void AddTouchInputSource(ITouchInputSource source) {} // 0x0000000187348BB0-0x0000000187348CD0
		// [XID] // 0x00000001896169D0-0x00000001896169F0
		public int GetTouchInputSourceCount(int playerId) => default; // 0x000000018734A9B0-0x000000018734AA80
		// [XID] // 0x000000018961E380-0x000000018961E3A0
		protected void ClearMouseInputSources() {} // 0x0000000187348CD0-0x0000000187348D80
		protected abstract bool IsDefaultPlayer(int playerId);
		// [XID] // 0x0000000189A3DDD0-0x0000000189A3DDF0
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) {
			data = default;
			return default;
		} // 0x000000018734A490-0x000000018734A9B0
		// [XID] // 0x00000001898FDB80-0x00000001898FDBA0
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) => default; // 0x00000001873492E0-0x00000001873495C0
		// [XID] // 0x0000000189932320-0x0000000189932340
		protected void RemovePointerData(PlayerPointerEventData data) {} // 0x000000018734BAA0-0x000000018734BC90
		// [XID] // 0x0000000189643A00-0x0000000189643A20
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) {
			pressed = default;
			released = default;
			return default;
		} // 0x000000018734AB90-0x000000018734AF60
		// [XID] // 0x000000018964B0A0-0x000000018964B0C0
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex) => default; // 0x0000000187349DF0-0x000000018734A490
		// [XID] // 0x0000000189811220-0x0000000189811240
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) => default; // 0x0000000187349740-0x0000000187349A10
		// [XID] // 0x00000001899B96D0-0x00000001899B96F0
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) => default; // 0x000000018734BD80-0x000000018734BEE0
		// [XID] // 0x0000000189661740-0x0000000189661760
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent) {} // 0x000000018734B670-0x000000018734B9A0
		// [XID] // 0x00000001896692E0-0x0000000189669300
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent) {} // 0x000000018734B2D0-0x000000018734B670
		// [XID] // 0x0000000189670D50-0x0000000189670D70
		public override bool IsPointerOverGameObject(int pointerTypeId) => default; // 0x000000018734B020-0x000000018734B2D0
		// [XID] // 0x0000000189678550-0x0000000189678570
		protected void ClearSelection() {} // 0x0000000187348D80-0x0000000187349140
		// [XID] // 0x000000018967FDB0-0x000000018967FDD0
		public override string ToString() => default; // 0x000000018734C030-0x000000018734C570
		// [XID] // 0x00000001896873E0-0x0000000189687400
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x00000001873495C0-0x0000000187349740
		// [XID] // 0x000000018968F2A0-0x000000018968F2C0
		protected void CopyFromTo(PointerEventData from, PointerEventData to) {} // 0x0000000187349140-0x00000001873492E0
		// [XID] // 0x0000000189696C90-0x0000000189696CB0
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) => default; // 0x000000018734BEE0-0x000000018734C030
	}
}
