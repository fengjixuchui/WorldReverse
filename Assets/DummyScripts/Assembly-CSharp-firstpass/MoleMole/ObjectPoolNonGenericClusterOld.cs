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

namespace MoleMole
{
	public class ObjectPoolNonGenericClusterOld : IObjectPoolCluster // TypeDefIndex: 7451
	{
		// Fields
		private Dictionary<System.Type, ObjectPoolInstanceNonGenericOld> _objectPoolCluster; // 0x10
	
		// Constructors
		public ObjectPoolNonGenericClusterOld() {} // 0x0000000186C30A50-0x0000000186C30AF0
	
		// Methods
		// [XID] // 0x0000000189994C20-0x0000000189994C40
		private static ObjectPoolInstanceNonGenericOld CreateObjectPoolNonGeneric(System.Type t) => default; // 0x0000000186C30380-0x0000000186C304F0
		// [XID] // 0x000000018999C460-0x000000018999C480
		private void Init() {} // 0x0000000186C307E0-0x0000000186C30880
		// [XID] // 0x00000001899A3DC0-0x00000001899A3DE0
		public ObjectPoolInstanceNonGenericOld GetObjectPool(System.Type t) => default; // 0x0000000186C306C0-0x0000000186C307E0
		// [XID] // 0x00000001899AB990-0x00000001899AB9B0
		public void PreRegisterObjectPools(params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] types) {} // 0x0000000186C30880-0x0000000186C30970
		public T Allocate<T>()
			where T : class, new() => default;
		public T Allocate<T>(ref bool isNew)
			where T : class, new() => default;
		// [IDTag] // 0x00000001899BA580-0x00000001899BA5C0
		// [XID] // 0x00000001899BA580-0x00000001899BA5C0
		public void Deallocate(object objInstance) {} // 0x0000000186C305D0-0x0000000186C306C0
		public void Deallocate<T>(ref T objInstance)
			where T : class, new() {}
		// [XID] // 0x00000001899C5050-0x00000001899C5070
		public void ReplaceAllocator(System.Type t, Func<object> inAllocator) {} // 0x0000000186C30970-0x0000000186C30A50
		// [XID] // 0x00000001899CC550-0x00000001899CC570
		public object Allocate(System.Type t) => default; // 0x0000000186C302B0-0x0000000186C30380
		// [IDTag] // 0x00000001899D3BF0-0x00000001899D3C30
		// [XID] // 0x00000001899D3BF0-0x00000001899D3C30
		public void Deallocate(System.Type t, object obj) {} // 0x0000000186C304F0-0x0000000186C305D0
		public ObjectPoolInstanceBase GetObjectPool<T>()
			where T : class, new() => default;
	}
}
