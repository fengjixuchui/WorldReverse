/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 4755
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 4756
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x0000000188DCBC70-0x0000000188DCBCD0
			static ObjectReferenceEqualityComparator() {} // 0x0000000188DCBBB0-0x0000000188DCBC70
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000188DCBAD0-0x0000000188DCBB40
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000188DCBB40-0x0000000188DCBBB0
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x0000000188DCEED0-0x0000000188DCEFC0
	
		// Methods
		public void Enter() {} // 0x0000000188DCE930-0x0000000188DCE990
		public bool Exit() => default; // 0x0000000188DCE990-0x0000000188DCEAD0
		public object GetReferenceObject(int id) => default; // 0x0000000188DCEBA0-0x0000000188DCECE0
		public void AddReferenceWithId(int id, object reference) {} // 0x0000000188DCE890-0x0000000188DCE930
		public int GetReferenceId(object item) => default; // 0x0000000188DCEAD0-0x0000000188DCEBA0
		public bool IsReference(object item) => default; // 0x0000000188DCECE0-0x0000000188DCED90
		public void MarkSerialized(object item) {} // 0x0000000188DCED90-0x0000000188DCEED0
	}
}
