/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 9240
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Constructors
		protected fsBaseConverter() {} // 0x0000000186B4B060-0x0000000186B4B0C0
	
		// Methods
		// [XID] // 0x0000000189A97750-0x0000000189A97770
		public virtual object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186B4A590-0x0000000186B4A8B0
		// [XID] // 0x0000000189A90C10-0x0000000189A90C30
		public virtual bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000186B4AD40-0x0000000186B4AEC0
		// [XID] // 0x0000000189B9AB40-0x0000000189B9AB60
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000186B4AEC0-0x0000000186B4AFB0
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		// [XID] // 0x0000000189AADA70-0x0000000189AADA90
		protected fsResult FailExpectedType(fsData data, params /* 0x000000018989F6F0-0x000000018989F700 */ fsDataType[] types) => default; // 0x0000000186B4A8B0-0x0000000186B4AD40
		// [XID] // 0x0000000189BDC580-0x0000000189BDC5A0
		protected fsResult CheckType(fsData data, fsDataType type) => default; // 0x0000000186B4A150-0x0000000186B4A590
		// [IDTag] // 0x0000000189AC47D0-0x0000000189AC4810
		// [XID] // 0x0000000189AC47D0-0x0000000189AC4810
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000186B4A010-0x0000000186B4A150
		// [IDTag] // 0x0000000189ACEE70-0x0000000189ACEEB0
		// [XID] // 0x0000000189ACEE70-0x0000000189ACEEB0
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000186B49C80-0x0000000186B4A010
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, string name, T value) => default;
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, string name, out T value) {
			value = default;
			return default;
		}
	}
}
