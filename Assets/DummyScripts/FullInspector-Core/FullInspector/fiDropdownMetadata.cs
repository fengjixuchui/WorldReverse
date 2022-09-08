/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[Serializable]
	public class fiDropdownMetadata : IGraphMetadataItemPersistent, ISerializationCallbackReceiver // TypeDefIndex: 4866
	{
		// Fields
		private fiAnimBool _isActive; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _showDropdown; // 0x18
		private bool _invertedDefaultState; // 0x19
		private bool _forceDisable; // 0x1A
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _serializedIsActive; // 0x1B
	
		// Properties
		public bool IsActive { get => default; set {} } // 0x0000000185CFC010-0x0000000185CFC090 0x0000000185CFC170-0x0000000185CFC280
		public float AnimPercentage { get => default; } // 0x0000000185CFBF90-0x0000000185CFC010 
		public bool IsAnimating { get => default; } // 0x0000000185CFC090-0x0000000185CFC110 
		public bool ShouldDisplayDropdownArrow { get => default; set {} } // 0x0000000185CFC110-0x0000000185CFC170 0x0000000185CFC280-0x0000000185CFC2F0
	
		// Constructors
		public fiDropdownMetadata() {} // 0x0000000185CFBEC0-0x0000000185CFBF90
	
		// Methods
		public void InvertDefaultState() {} // 0x0000000185CFBD60-0x0000000185CFBDC0
		public void ForceHideWithoutAnimation() {} // 0x0000000185CFBC10-0x0000000185CFBCE0
		public void ForceDisable() {} // 0x0000000185CFBBB0-0x0000000185CFBC10
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185CFBE50-0x0000000185CFBEC0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000185CFBDC0-0x0000000185CFBE50
		bool IGraphMetadataItemPersistent.ShouldSerialize() => default; // 0x0000000185CFBCE0-0x0000000185CFBD60
	}
}
