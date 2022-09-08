/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public class fiGraphMetadataSerializer<TPersistentData> : fiIGraphMetadataStorage, ISerializationCallbackReceiver // TypeDefIndex: 5025
		where TPersistentData : IGraphMetadataItemPersistent
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string[] _keys;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TPersistentData[] _values;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Object _target;
	
		// Constructors
		public fiGraphMetadataSerializer() {}
	
		// Methods
		void ISerializationCallbackReceiver.OnAfterDeserialize() {}
		void ISerializationCallbackReceiver.OnBeforeSerialize() {}
	}
}
