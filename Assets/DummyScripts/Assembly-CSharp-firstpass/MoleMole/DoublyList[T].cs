/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class DoublyList<T> : IEnumerable<T>, IListRemoveInfo // TypeDefIndex: 10559
	{
		// Fields
		protected ListNode _head;
		protected int _count;
		private int _lockEnumratorCount;
	
		// Properties
		public int Count { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 10560
		{
			// Fields
			private ListNode<T> head;
			private ListNode<T> now;
			private DoublyList<T> list;
	
			// Properties
			object IEnumerator.Current { get => default; }
			public T Current { get => default; }
	
			// Constructors
			public Enumerator(ListNode<T> head, DoublyList<T> list) : this() {
				this.head = default;
				now = default;
				this.list = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public class ListNode : IReusable, IListRemoveInfo // TypeDefIndex: 10561
		{
			// Fields
			private bool _isValid;
			public ListNode<T> prev;
			public ListNode<T> next;
			public T data;
			internal DoublyList<T> list;
	
			// Properties
			public bool isValid { get => default; }
	
			// Nested types
			public class Spawner : ISpawner<ListNode<T>, T> // TypeDefIndex: 10562
			{
				// Constructors
				public Spawner() {}
	
				// Methods
				public ListNode<T> Spawn(T param1) => default;
			}
	
			public class Polisher : IPolisher<ListNode<T>, T> // TypeDefIndex: 10563
			{
				// Constructors
				public Polisher() {}
	
				// Methods
				public void Polish(ListNode<T> reused, T param1) {}
			}
	
			// Constructors
			public ListNode(T data) {}
			public ListNode() {}
	
			// Methods
			public void MarkInvalid() {}
			public virtual void BeforeRecycle() {}
			public virtual void Recycle() {}
		}
	
		public struct DoublyListEnumeratorKeepSafe : IDisposable // TypeDefIndex: 10564
		{
			// Fields
			public DoublyList<T> _list;
	
			// Constructors
			public DoublyListEnumeratorKeepSafe(DoublyList<T> list) {
				_list = default;
			}
	
			// Methods
			public void Dispose() {}
		}
	
		// Constructors
		public DoublyList() {}
	
		// Methods
		public static DoublyList<T> operator +(DoublyList<T> a, T b) => default;
		public static DoublyList<T> operator -(DoublyList<T> a, T b) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Empty() => default;
		public virtual ListNode Add(T data) => default;
		public virtual void Delete(T data) {}
		public virtual bool Contains(T data) => default;
		public virtual ListNode Add(T data, ListNode prev) => default;
		public virtual ListNode AddTail(T data) => default;
		public virtual void AddTail(DoublyList<T> list) {}
		public virtual ListNode Get(T data) => default;
		public virtual ListNode MarkInvalid(T data) => default;
		public void Delete(ListNode node, bool release = true /* Metadata: 0x00AE7B5F */) {}
		public virtual void Clear() {}
		public void ClearWithOutRelease() {}
		public virtual void Add(ListNode newNode) {}
		public virtual void AddTail(ListNode newNode) {}
		public static ListNode getNode() => default;
		public static void releaseNode(ListNode node, ObjectPoolOfReusable<ListNode> pool = null) {}
		protected virtual void add(ListNode newNode, ListNode prev, ListNode next) {}
		protected virtual void delete(ListNode deleteNode, ListNode prev, ListNode next) {}
		public ListNode End() => default;
		public ListNode Begin() => default;
		public T Pop() => default;
		public ListNode Tail() => default;
		public List<ListNode> ToList() => default;
		public ListNode Next(ListNode it) => default;
		public void Get() {}
		public void Release() {}
		public void Destory() {}
		public virtual void Recycle() {}
		public void LockEnumerator(bool isLock) {}
		public ListNode SafetyBegin(out ListNode next) {
			next = default;
			return default;
		}
		public ListNode SafetyNext(ref ListNode next) => default;
		public static void Del(ListNode entry) {}
	}
}
