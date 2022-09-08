/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 4710
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Constructors
		protected fsBaseConverter() {} // 0x0000000185D08B20-0x0000000185D08B80
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185D08230-0x0000000185D084F0
		public virtual bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000185D08950-0x0000000185D08A80
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000185D08A80-0x0000000185D08B20
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params /* 0x000000018989F6F0-0x000000018989F700 */ fsDataType[] types) => default; // 0x0000000185D084F0-0x0000000185D08950
		protected fsResult CheckType(fsData data, fsDataType type) => default; // 0x0000000185D07E40-0x0000000185D08230
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000185D07A10-0x0000000185D07B20
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000185D07B20-0x0000000185D07E40
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value) => default;
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out T value) {
			value = default;
			return default;
		}
	}
}
