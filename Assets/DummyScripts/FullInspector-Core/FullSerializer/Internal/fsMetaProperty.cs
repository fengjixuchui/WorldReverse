/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public class fsMetaProperty // TypeDefIndex: 4765
	{
		// Fields
		private MemberInfo _memberInfo; // 0x10
	
		// Properties
		public System.Type StorageType { get; private set; } // 0x0000000188DD68D0-0x0000000188DD6930 0x0000000188DD6B70-0x0000000188DD6BD0
		public System.Type OverrideConverterType { get; private set; } // 0x0000000188DD6870-0x0000000188DD68D0 0x0000000188DD6B10-0x0000000188DD6B70
		public bool CanRead { get; private set; } // 0x0000000188DD6690-0x0000000188DD66F0 0x0000000188DD6930-0x0000000188DD6990
		public bool CanWrite { get; private set; } // 0x0000000188DD66F0-0x0000000188DD6750 0x0000000188DD6990-0x0000000188DD69F0
		public string JsonName { get; private set; } // 0x0000000188DD67B0-0x0000000188DD6810 0x0000000188DD6A50-0x0000000188DD6AB0
		public string MemberName { get; private set; } // 0x0000000188DD6810-0x0000000188DD6870 0x0000000188DD6AB0-0x0000000188DD6B10
		public bool IsPublic { get; private set; } // 0x0000000188DD6750-0x0000000188DD67B0 0x0000000188DD69F0-0x0000000188DD6A50
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(fsConfig config, FieldInfo field) {} // 0x0000000188DD6210-0x0000000188DD6410
		internal fsMetaProperty(fsConfig config, PropertyInfo property) {} // 0x0000000188DD6410-0x0000000188DD6690
	
		// Methods
		private void CommonInitialize(fsConfig config) {} // 0x0000000188DD5C90-0x0000000188DD5ED0
		public void Write(object context, object value) {} // 0x0000000188DD6030-0x0000000188DD6210
		public object Read(object context) => default; // 0x0000000188DD5ED0-0x0000000188DD6030
	}
}
