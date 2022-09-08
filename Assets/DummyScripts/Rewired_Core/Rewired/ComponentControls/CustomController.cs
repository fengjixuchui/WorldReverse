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
using Rewired.ComponentControls.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x000000018984A610-0x000000018984A650
	[DisallowMultipleComponent] // 0x000000018984A610-0x000000018984A650
	public class CustomController : ComponentController // TypeDefIndex: 3530
	{
		// Fields
		[CustomObfuscation] // 0x0000000189854820-0x0000000189854880
		[SerializeField] // 0x0000000189854820-0x0000000189854880
		// [Tooltip] // 0x0000000189854820-0x0000000189854880
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x0000000189863A70-0x0000000189863AD0
		[SerializeField] // 0x0000000189863A70-0x0000000189863AD0
		// [Tooltip] // 0x0000000189863A70-0x0000000189863AD0
		private CustomControllerSelector _customControllerSelector; // 0x30
		[CustomObfuscation] // 0x0000000189872150-0x00000001898721B0
		[SerializeField] // 0x0000000189872150-0x00000001898721B0
		// [Tooltip] // 0x0000000189872150-0x00000001898721B0
		private CreateCustomControllerSettings _createCustomControllerSettings; // 0x38
		private List<InputEvent> _inputEvents; // 0x40
		[NonSerialized]
		private int _createdCustomControllerId; // 0x48
		private Action _InputSourceUpdateEvent; // 0x50
	
		// Properties
		public InputManager_Base rewiredInputManager { get => default; set {} } // 0x0000000185AA5940-0x0000000185AA59A0 0x0000000185AA5A40-0x0000000185AA5B00
		public CustomControllerSelector customControllerSelector { get => default; } // 0x0000000185AA58E0-0x0000000185AA5940 
		public CreateCustomControllerSettings createCustomControllerSettings { get => default; } // 0x0000000185AA5880-0x0000000185AA58E0 
	
		// Events
		internal event Action InputSourceUpdateEvent;
	
		// Nested types
		[Serializable]
		public class CreateCustomControllerSettings // TypeDefIndex: 3531
		{
			// Fields
			[CustomObfuscation] // 0x00000001898B4770-0x00000001898B47D0
			[SerializeField] // 0x00000001898B4770-0x00000001898B47D0
			// [Tooltip] // 0x00000001898B4770-0x00000001898B47D0
			private bool _createCustomController; // 0x10
			[CustomObfuscation] // 0x00000001898C3920-0x00000001898C3980
			[SerializeField] // 0x00000001898C3920-0x00000001898C3980
			// [Tooltip] // 0x00000001898C3920-0x00000001898C3980
			private int _customControllerSourceId; // 0x14
			[CustomObfuscation] // 0x00000001898D2900-0x00000001898D2960
			[SerializeField] // 0x00000001898D2900-0x00000001898D2960
			// [Tooltip] // 0x00000001898D2900-0x00000001898D2960
			private int _assignToPlayerId; // 0x18
			[CustomObfuscation] // 0x00000001898E1EF0-0x00000001898E1F50
			[SerializeField] // 0x00000001898E1EF0-0x00000001898E1F50
			// [Tooltip] // 0x00000001898E1EF0-0x00000001898E1F50
			private bool _destroyCustomController; // 0x1C
	
			// Properties
			public bool createCustomController { get => default; } // 0x0000000185A9EFC0-0x0000000185A9F020 
			public int customControllerSourceId { get => default; } // 0x0000000185A9F020-0x0000000185A9F080 
			public int assignToPlayerId { get => default; } // 0x0000000185A9EF60-0x0000000185A9EFC0 
			public bool destroyCustomController { get => default; } // 0x0000000185A9F080-0x0000000185A9F0E0 
	
			// Constructors
			public CreateCustomControllerSettings() {} // 0x0000000185A9EEF0-0x0000000185A9EF60
		}
	
		private struct InputEvent // TypeDefIndex: 3532
		{
			// Fields
			public CustomControllerElementSelector.ElementType elementType; // 0x00
			public int elementIndex; // 0x04
			public float value; // 0x08
	
			// Constructors
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value) {
				this.elementType = default;
				this.elementIndex = default;
				this.value = default;
			} // 0x0000000185AA5DC0-0x0000000185AA5DD0
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value) {
				this.elementType = default;
				this.elementIndex = default;
				this.value = default;
			} // 0x0000000185AA5D30-0x0000000185AA5DC0
	
			// Methods
			public bool TargetMatches(CustomControllerElementSelector.ElementType elementType, int elementIndex) => default; // 0x0000000185AA5C80-0x0000000185AA5D30
			public void Merge(float value) {} // 0x0000000185AA5BF0-0x0000000185AA5C80
			public void Merge(bool value) {} // 0x0000000185AA5B00-0x0000000185AA5BF0
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal CustomController() {} // 0x0000000185AA5670-0x0000000185AA57E0
	
		// Methods
		public Rewired.CustomController GetCustomController() => default; // 0x0000000185AA3650-0x0000000185AA36C0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnEnable() {} // 0x0000000185AA3BC0-0x0000000185AA3C60
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDisable() {} // 0x0000000185AA3AF0-0x0000000185AA3BC0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x0000000185AA4110-0x0000000185AA41D0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDestroy() {} // 0x0000000185AA3A30-0x0000000185AA3AF0
		internal override bool OnInitialize() => default; // 0x0000000185AA3C60-0x0000000185AA3D50
		internal override void OnSubscribeEvents() {} // 0x0000000185AA3EB0-0x0000000185AA4010
		internal override void OnUnsubscribeEvents() {} // 0x0000000185AA4010-0x0000000185AA4110
		public override void ClearControlValues() {} // 0x0000000185AA2AB0-0x0000000185AA2B80
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual bool GetUseCustomController() => default; // 0x0000000185AA39E0-0x0000000185AA3A30
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void SetUseCustomController(bool value) {} // 0x0000000185AA4C90-0x0000000185AA4CE0
		internal void SetAxisValue(CustomControllerElementSelector element, float value) {} // 0x0000000185AA44C0-0x0000000185AA4900
		internal void SetButtonValue(CustomControllerElementSelector element, bool value) {} // 0x0000000185AA4900-0x0000000185AA4C90
		internal void ClearElementValue(CustomControllerElementTargetSet targetSet) {} // 0x0000000185AA2B80-0x0000000185AA2C80
		internal void ClearElementValue(CustomControllerElementTarget target) {} // 0x0000000185AA2FF0-0x0000000185AA30B0
		internal void ClearElementValue(CustomControllerElementSelector element) {} // 0x0000000185AA2C80-0x0000000185AA2FF0
		internal int ElementExists_Editor(CustomControllerElementSelector element) => default; // 0x0000000185AA30B0-0x0000000185AA3570
		internal bool ElementExists(CustomControllerElementSelector element) => default; // 0x0000000185AA3570-0x0000000185AA3650
		internal bool ValidateElements(CustomControllerElementTargetSet targetSet) => default; // 0x0000000185AA5530-0x0000000185AA5670
		internal bool ValidateElement(CustomControllerElementTarget target) => default; // 0x0000000185AA5110-0x0000000185AA51D0
		internal bool ValidateElement(CustomControllerElementSelector element) => default; // 0x0000000185AA51D0-0x0000000185AA5530
		private void OnSetProperty() {} // 0x0000000185AA3DC0-0x0000000185AA3EB0
		private bool CheckIsRewiredReady() => default; // 0x0000000185AA2A00-0x0000000185AA2AB0
		private void ProcessInputEvents() {} // 0x0000000185AA41D0-0x0000000185AA44C0
		private Rewired.CustomController GetCustomController(bool warn) => default; // 0x0000000185AA36C0-0x0000000185AA39E0
		private void TryAssignCustomControllerToPlayer(Rewired.CustomController customController) {} // 0x0000000185AA4CE0-0x0000000185AA4F60
		private void TryDestroyCustomController() {} // 0x0000000185AA4F60-0x0000000185AA5110
		private void OnInputSourceUpdate() {} // 0x0000000185AA3D50-0x0000000185AA3DC0
	}
}
