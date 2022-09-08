/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class CollectionWrapper<T> : ICollection<T>, IWrappedCollection // TypeDefIndex: 5325
	{
		// Fields
		private readonly IList _list;
		private readonly ICollection<T> _genericCollection;
		private object _syncRoot;
	
		// Properties
		public virtual int Count { get => default; }
		public virtual bool IsReadOnly { get => default; }
		bool IList.IsFixedSize { get => default; }
		object IList.this[int index] { get => default; set {} }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		public object UnderlyingCollection { get => default; }
	
		// Constructors
		public CollectionWrapper() {} // Dummy constructor
	
		// Methods
		public virtual void Add(T item) {}
		public virtual void Clear() {}
		public virtual bool Contains(T item) => default;
		public virtual void CopyTo(T[] array, int arrayIndex) {}
		public virtual bool Remove(T item) => default;
		public virtual IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		int IList.Add(object value) => default;
		bool IList.Contains(object value) => default;
		int IList.IndexOf(object value) => default;
		void IList.RemoveAt(int index) {}
		void IList.Insert(int index, object value) {}
		void IList.Remove(object value) {}
		void ICollection.CopyTo(Array array, int arrayIndex) {}
		private static void VerifyValueType(object value) {}
		private static bool IsCompatibleObject(object value) => default;
	}
}
