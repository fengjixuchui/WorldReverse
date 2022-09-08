/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public abstract class BaseSerializer // TypeDefIndex: 4797
	{
		// Properties
		public virtual bool SupportsMultithreading { get; } // 0x0000000185CE99D0-0x0000000185CE9A20 
	
		// Constructors
		protected BaseSerializer() {} // 0x0000000185CE9970-0x0000000185CE99D0
	
		// Methods
		public abstract string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator);
		public abstract object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator);
		protected static System.Type GetStorageType(MemberInfo member) => default; // 0x0000000185CE96E0-0x0000000185CE9970
	}
}
