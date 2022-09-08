/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public abstract class fsObjectProcessor // TypeDefIndex: 4729
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x0000000188DD73C0-0x0000000188DD7420
	
		// Methods
		public virtual bool CanProcess(System.Type type) => default; // 0x0000000188DD71C0-0x0000000188DD7230
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000188DD7370-0x0000000188DD73C0
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DD7280-0x0000000188DD72D0
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x0000000188DD7320-0x0000000188DD7370
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DD72D0-0x0000000188DD7320
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000188DD7230-0x0000000188DD7280
	}
}
