/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos.GamepadTemplateUI
{
	public class GamepadTemplateUI : MonoBehaviour // TypeDefIndex: 9783
	{
		// Fields
		private const float stickRadius = 20f; // Metadata: 0x00AE62AE
		public int playerId; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform leftStick; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform rightStick; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement leftStickX; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement leftStickY; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement leftStickButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement rightStickX; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement rightStickY; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement rightStickButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionBottomRow1; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionBottomRow2; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionBottomRow3; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionTopRow1; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionTopRow2; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement actionTopRow3; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement leftShoulder; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement leftTrigger; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement rightShoulder; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement rightTrigger; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement center1; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement center2; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement center3; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement dPadUp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement dPadRight; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement dPadDown; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement dPadLeft; // 0xE0
		private UIElement[] _uiElementsArray; // 0xE8
		private Dictionary<int, ControllerUIElement> _uiElements; // 0xF0
		private IList<ControllerTemplateElementTarget> _tempTargetList; // 0xF8
		private Stick[] _sticks; // 0x100
	
		// Properties
		private Player player { /* [XID] */ /* 0x00000001896B8690-0x00000001896B86B0 */ get => default; } // 0x00000001865530B0-0x0000000186553190 
	
		// Nested types
		private class Stick // TypeDefIndex: 9784
		{
			// Fields
			private RectTransform _transform; // 0x10
			private Vector2 _origPosition; // 0x18
			private int _xAxisElementId; // 0x20
			private int _yAxisElementId; // 0x24
	
			// Properties
			public Vector2 position { /* [XID] */ /* 0x000000018971E940-0x000000018971E960 */ get => default; /* [XID] */ /* 0x00000001897260C0-0x00000001897260E0 */ set {} } // 0x00000001865625C0-0x0000000186562740 0x0000000186562740-0x00000001865628C0
	
			// Constructors
			public Stick() {} // Dummy constructor
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId) {} // 0x00000001865624E0-0x00000001865625C0
	
			// Methods
			// [XID] // 0x00000001898355D0-0x00000001898355F0
			public void Reset() {} // 0x0000000186562290-0x0000000186562380
			// [XID] // 0x000000018969C420-0x000000018969C440
			public bool ContainsElement(int elementId) => default; // 0x0000000186562190-0x0000000186562290
			// [XID] // 0x000000018973C8E0-0x000000018973C900
			public void SetAxisPosition(int elementId, float value) {} // 0x0000000186562380-0x00000001865624E0
		}
	
		private class UIElement // TypeDefIndex: 9785
		{
			// Fields
			public int id; // 0x10
			public ControllerUIElement element; // 0x18
	
			// Constructors
			public UIElement() {} // Dummy constructor
			public UIElement(int id, ControllerUIElement element) {} // 0x0000000186564890-0x0000000186564910
		}
	
		// Constructors
		public GamepadTemplateUI() {} // 0x0000000186552FF0-0x00000001865530B0
	
		// Methods
		// [XID] // 0x0000000189A18990-0x0000000189A189B0
		private void Awake() {} // 0x0000000186550FC0-0x0000000186551CA0
		// [XID] // 0x00000001897AB920-0x00000001897AB940
		private void Start() {} // 0x0000000186552E50-0x0000000186552F20
		// [XID] // 0x00000001896CE840-0x00000001896CE860
		private void OnDestroy() {} // 0x0000000186552D10-0x0000000186552E50
		// [XID] // 0x00000001896D5BB0-0x00000001896D5BD0
		private void Update() {} // 0x0000000186552F20-0x0000000186552FF0
		// [XID] // 0x00000001896DD0E0-0x00000001896DD100
		private void DrawActiveElements() {} // 0x0000000186551CA0-0x0000000186551FE0
		// [XID] // 0x00000001896E4A30-0x00000001896E4A50
		private void ActivateElements(Player player, int actionId) {} // 0x0000000186550C10-0x0000000186550FC0
		// [IDTag] // 0x00000001896EBF90-0x00000001896EBFD0
		// [XID] // 0x00000001896EBF90-0x00000001896EBFD0
		private void DrawLabels() {} // 0x0000000186552790-0x0000000186552A40
		// [IDTag] // 0x00000001896F67A0-0x00000001896F67E0
		// [XID] // 0x00000001896F67A0-0x00000001896F67E0
		private void DrawLabels(Player player, InputAction action) {} // 0x0000000186552530-0x0000000186552790
		// [XID] // 0x000000018986ECD0-0x000000018986ECF0
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element) {} // 0x0000000186551FE0-0x0000000186552530
		// [XID] // 0x00000001897082F0-0x0000000189708310
		private Stick GetStick(int elementId) => default; // 0x0000000186552A40-0x0000000186552BB0
		// [XID] // 0x000000018970FD70-0x000000018970FD90
		private void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x0000000186552BB0-0x0000000186552C60
		// [XID] // 0x0000000189876180-0x00000001898761A0
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x0000000186552C60-0x0000000186552D10
	}
}
