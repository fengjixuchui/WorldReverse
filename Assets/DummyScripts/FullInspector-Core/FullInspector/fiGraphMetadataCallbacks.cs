/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public static class fiGraphMetadataCallbacks // TypeDefIndex: 4805
	{
		// Fields
		public static Action<fiGraphMetadata, IList, int> ListMetadataCallback; // 0x00
		public static Action<fiGraphMetadata, InspectedProperty> PropertyMetadataCallback; // 0x08
	
		// Nested types
		private sealed class ListWrapper<T> : IList // TypeDefIndex: 4806
		{
			// Fields
			private readonly IList<T> _list;
	
			// Properties
			public bool IsFixedSize { get => default; }
			public bool IsReadOnly { get => default; }
			public object this[int index] { get => default; set {} }
			public int Count { get => default; }
			public bool IsSynchronized { get => default; }
			public object SyncRoot { get => default; }
	
			// Constructors
			public ListWrapper() {} // Dummy constructor
			public ListWrapper(IList<T> list) {}
	
			// Methods
			public int Add(object value) => default;
			public void Clear() {}
			public bool Contains(object value) => default;
			public int IndexOf(object value) => default;
			public void Insert(int index, object value) {}
			public void Remove(object value) {}
			public void RemoveAt(int index) {}
			public void CopyTo(Array array, int index) {}
			public IEnumerator GetEnumerator() => default;
		}
	
		// Constructors
		static fiGraphMetadataCallbacks() {} // 0x0000000185CFD150-0x0000000185CFD2A0
	
		// Methods
		public static IList Cast<T>(IList<T> list) => default;
	}
}
