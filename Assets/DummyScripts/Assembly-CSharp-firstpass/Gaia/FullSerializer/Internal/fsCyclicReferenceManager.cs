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

namespace Gaia.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 9263
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 9264
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x0000000186B455E0-0x0000000186B45640
			static ObjectReferenceEqualityComparator() {} // 0x0000000186B45520-0x0000000186B455E0
	
			// Methods
			// [XID] // 0x000000018995E270-0x000000018995E290
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000186B453A0-0x0000000186B45470
			// [XID] // 0x00000001896A4960-0x00000001896A4980
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000186B45470-0x0000000186B45520
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x0000000186B4C270-0x0000000186B4C360
	
		// Methods
		// [XID] // 0x0000000189A277C0-0x0000000189A277E0
		public void Enter() {} // 0x0000000186B4BB40-0x0000000186B4BBE0
		// [XID] // 0x000000018961F2E0-0x000000018961F300
		public bool Exit() => default; // 0x0000000186B4BBE0-0x0000000186B4BD70
		// [XID] // 0x00000001899030D0-0x00000001899030F0
		public object GetReferenceObject(int id) => default; // 0x0000000186B4BE80-0x0000000186B4C010
		// [XID] // 0x00000001898FDDE0-0x00000001898FDE00
		public void AddReferenceWithId(int id, object reference) {} // 0x0000000186B4BA60-0x0000000186B4BB40
		// [XID] // 0x0000000189A685D0-0x0000000189A685F0
		public int GetReferenceId(object item) => default; // 0x0000000186B4BD70-0x0000000186B4BE80
		// [XID] // 0x0000000189919B60-0x0000000189919B80
		public bool IsReference(object item) => default; // 0x0000000186B4C010-0x0000000186B4C0F0
		// [XID] // 0x0000000189921090-0x00000001899210B0
		public void MarkSerialized(object item) {} // 0x0000000186B4C0F0-0x0000000186B4C270
	}
}
