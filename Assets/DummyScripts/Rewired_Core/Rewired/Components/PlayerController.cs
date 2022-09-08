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
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Components
{
	[Serializable]
	public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController // TypeDefIndex: 3605
	{
		// Fields
		[CustomObfuscation] // 0x00000001899B0060-0x00000001899B00C0
		[SerializeField] // 0x00000001899B0060-0x00000001899B00C0
		// [Tooltip] // 0x00000001899B0060-0x00000001899B00C0
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x00000001899BEE70-0x00000001899BEED0
		[SerializeField] // 0x00000001899BEE70-0x00000001899BEED0
		// [Tooltip] // 0x00000001899BEE70-0x00000001899BEED0
		private int _playerId; // 0x30
		[CustomObfuscation] // 0x00000001899CDE80-0x00000001899CDEE0
		[SerializeField] // 0x00000001899CDE80-0x00000001899CDEE0
		// [Tooltip] // 0x00000001899CDE80-0x00000001899CDEE0
		private List<ElementInfo> _elements; // 0x38
		[CustomObfuscation] // 0x00000001899DC8A0-0x00000001899DC900
		[SerializeField] // 0x00000001899DC8A0-0x00000001899DC900
		// [Tooltip] // 0x00000001899DC8A0-0x00000001899DC900
		private ButtonStateChangedHandler _onButtonStateChanged; // 0x40
		[CustomObfuscation] // 0x00000001899EB710-0x00000001899EB770
		[SerializeField] // 0x00000001899EB710-0x00000001899EB770
		// [Tooltip] // 0x00000001899EB710-0x00000001899EB770
		private AxisValueChangedHandler _onAxisValueChanged; // 0x48
		[CustomObfuscation] // 0x00000001899FACD0-0x00000001899FAD30
		[SerializeField] // 0x00000001899FACD0-0x00000001899FAD30
		// [Tooltip] // 0x00000001899FACD0-0x00000001899FAD30
		private EnabledStateChangedHandler _onEnabledStateChanged; // 0x50
	
		// Properties
		public int playerId { get => default; set {} } // 0x0000000185E8DF20-0x0000000185E8DFC0 0x0000000185E8E1B0-0x0000000185E8E350
		public IList<PlayerController.Button> buttons { get => default; } // 0x0000000185E8DD20-0x0000000185E8DDD0 
		public IList<PlayerController.Axis> axes { get => default; } // 0x0000000185E8DB30-0x0000000185E8DBE0 
		public IList<PlayerController.Element> elements { get => default; } // 0x0000000185E8DE70-0x0000000185E8DF20 
		public int buttonCount { get => default; } // 0x0000000185E8DC80-0x0000000185E8DD20 
		public int axisCount { get => default; } // 0x0000000185E8DBE0-0x0000000185E8DC80 
		public int elementCount { get => default; } // 0x0000000185E8DDD0-0x0000000185E8DE70 
		bool IPlayerController.enabled { get => default; } // 0x0000000185E8D200-0x0000000185E8D270 
		bool IPlayerController.enabled { set {} } // 0x0000000185E8D270-0x0000000185E8D2F0
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent;
		public event Action<int, float> AxisValueChangedEvent;
		public event Action<bool> EnabledStateChangedEvent;
	
		// Nested types
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool> // TypeDefIndex: 3606
		{
			// Constructors
			public ButtonStateChangedHandler() {} // 0x0000000185E702B0-0x0000000185E70320
		}
	
		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float> // TypeDefIndex: 3607
		{
			// Constructors
			public AxisValueChangedHandler() {} // 0x0000000185E6E1C0-0x0000000185E6E230
		}
	
		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool> // TypeDefIndex: 3608
		{
			// Constructors
			public EnabledStateChangedHandler() {} // 0x0000000185E89C80-0x0000000185E89CF0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
		[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
		internal sealed class ElementWithSourceInfo // TypeDefIndex: 3609
		{
			// Fields
			[SerializeField] // 0x0000000189A13FE0-0x0000000189A14030
			// [Tooltip] // 0x0000000189A13FE0-0x0000000189A14030
			private string _name; // 0x10
			[SerializeField] // 0x0000000189A1F8A0-0x0000000189A1F8E0
			// [Tooltip] // 0x0000000189A1F8A0-0x0000000189A1F8E0
			private PlayerController.Element.TypeWithSource _elementType; // 0x18
			[SerializeField] // 0x0000000189A2B420-0x0000000189A2B470
			// [Tooltip] // 0x0000000189A2B420-0x0000000189A2B470
			private bool _enabled; // 0x1C
			[SerializeField] // 0x0000000189A375C0-0x0000000189A37600
			// [Tooltip] // 0x0000000189A375C0-0x0000000189A37600
			private int _actionId; // 0x20
			[SerializeField] // 0x0000000189A434B0-0x0000000189A43500
			// [Tooltip] // 0x0000000189A434B0-0x0000000189A43500
			private AxisCoordinateMode _coordinateMode; // 0x24
			// [FieldRange] // 0x0000000189A4F330-0x0000000189A4F3A0
			[SerializeField] // 0x0000000189A4F330-0x0000000189A4F3A0
			// [Tooltip] // 0x0000000189A4F330-0x0000000189A4F3A0
			private float _absoluteToRelativeSensitivity; // 0x28
			// [FieldRange] // 0x0000000189A5E4E0-0x0000000189A5E550
			[SerializeField] // 0x0000000189A5E4E0-0x0000000189A5E550
			// [Tooltip] // 0x0000000189A5E4E0-0x0000000189A5E550
			private float _repeatRate; // 0x2C
	
			// Properties
			public string name { get => default; set {} } // 0x0000000185E89600-0x0000000185E89660 0x0000000185E89800-0x0000000185E89860
			public PlayerController.Element.TypeWithSource elementType { get => default; set {} } // 0x0000000185E89540-0x0000000185E895A0 0x0000000185E897A0-0x0000000185E89800
			public bool enabled { get => default; } // 0x0000000185E895A0-0x0000000185E89600 
			public int actionId { get => default; } // 0x0000000185E89480-0x0000000185E894E0 
			public AxisCoordinateMode coordinateMode { get => default; set {} } // 0x0000000185E894E0-0x0000000185E89540 0x0000000185E89740-0x0000000185E897A0
			public float absoluteSourceSensitivity { get => default; set {} } // 0x0000000185E89410-0x0000000185E89480 0x0000000185E896D0-0x0000000185E89740
			public float repeatRate { get => default; } // 0x0000000185E89660-0x0000000185E896D0 
	
			// Constructors
			public ElementWithSourceInfo() {} // 0x0000000185E89390-0x0000000185E89410
	
			// Methods
			public PlayerController.Element.Definition ToDefinition() => default; // 0x0000000185E88E70-0x0000000185E89390
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189658AB0-0x0000000189658B00
		[CustomObfuscation] // 0x0000000189658AB0-0x0000000189658B00
		internal sealed class ElementInfo // TypeDefIndex: 3610
		{
			// Fields
			[SerializeField] // 0x0000000189A13FE0-0x0000000189A14030
			// [Tooltip] // 0x0000000189A13FE0-0x0000000189A14030
			private string _name; // 0x10
			[SerializeField] // 0x0000000189A1F8A0-0x0000000189A1F8E0
			// [Tooltip] // 0x0000000189A1F8A0-0x0000000189A1F8E0
			private PlayerController.Element.Type _elementType; // 0x18
			[SerializeField] // 0x0000000189A8D040-0x0000000189A8D080
			// [Tooltip] // 0x0000000189A8D040-0x0000000189A8D080
			private bool _enabled; // 0x1C
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private ElementWithSourceInfo[] _elements; // 0x20
	
			// Properties
			public string name { get => default; set {} } // 0x0000000185E88CF0-0x0000000185E88D50 0x0000000185E88E10-0x0000000185E88E70
			public PlayerController.Element.Type elementType { get => default; set {} } // 0x0000000185E88C30-0x0000000185E88C90 0x0000000185E88D50-0x0000000185E88DB0
			public bool enabled { get => default; } // 0x0000000185E88C90-0x0000000185E88CF0 
			public ElementWithSourceInfo[] elements { set {} } // 0x0000000185E88DB0-0x0000000185E88E10
	
			// Constructors
			public ElementInfo() {} // 0x0000000185E88BA0-0x0000000185E88C30
	
			// Methods
			public PlayerController.Element.Definition ToDefinition() => default; // 0x0000000185E88090-0x0000000185E88BA0
		}
	
		// Constructors
		public PlayerController() {} // 0x0000000185E8D670-0x0000000185E8D830
	
		// Methods
		public bool GetButton(int index) => default; // 0x0000000185E8C890-0x0000000185E8C940
		public bool GetButtonDown(int index) => default; // 0x0000000185E8C730-0x0000000185E8C7E0
		public bool GetButtonUp(int index) => default; // 0x0000000185E8C7E0-0x0000000185E8C890
		public float GetAxis(int index) => default; // 0x0000000185E8C680-0x0000000185E8C730
		public float GetAxisRaw(int index) => default; // 0x0000000185E8C5D0-0x0000000185E8C680
		public PlayerController.Element GetElement(int index) => default; // 0x0000000185E8C9A0-0x0000000185E8CA50
		public T GetElement<T>(int index)
			where T : PlayerController.Element => default;
		protected override void OnAwake() {} // 0x0000000185E8CCA0-0x0000000185E8CD10
		protected override void OnAwakeFinished() {} // 0x0000000185E8CC10-0x0000000185E8CCA0
		protected override void OnEnabled() {} // 0x0000000185E8CE00-0x0000000185E8CEF0
		protected override void OnDisabled() {} // 0x0000000185E8CD10-0x0000000185E8CE00
		protected override void OnValidated() {} // 0x0000000185E8D100-0x0000000185E8D200
		protected override void OnReset() {} // 0x0000000185E8CEF0-0x0000000185E8D100
		protected override void Subscribe() {} // 0x0000000185E8D2F0-0x0000000185E8D4B0
		protected override void Unsubscribe() {} // 0x0000000185E8D4B0-0x0000000185E8D670
		protected override object GetCreateSourceArgs() => default; // 0x0000000185E8C940-0x0000000185E8C9A0
		protected override Rewired.PlayerController CreateSource(object args) => default; // 0x0000000185E8C140-0x0000000185E8C5D0
		internal virtual List<ElementInfo> CreateDefaultElementInfos() => default; // 0x0000000185E8B4B0-0x0000000185E8C140
		private void uDgBeWNklnmhCPigKVFjshKBCmM(int param_00007f49, bool param_00007f4a) {} // 0x0000000185E8E350-0x0000000185E8E440
		private void HWFhkFlLkYUKyhTUFbGsyGCYFc(int param_00007f4b, float param_00007f4c) {} // 0x0000000185E8CA50-0x0000000185E8CB60
		private void caWcTTXIQkNAnQIlYjScUWgCTQn(bool param_00007f4d) {} // 0x0000000185E8DA50-0x0000000185E8DB30
		private void MnydutHyxjmwKMpspBpJJJfHkpz() {} // 0x0000000185E8CB60-0x0000000185E8CC10
	}
}
