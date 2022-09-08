/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SECTR_JobList<T> : IReusable // TypeDefIndex: 31892
	where T : SECTR_ThreadContext.SECTRJob
{
	// Fields
	protected ListNode _head;
	protected int _count;

	// Properties
	public int Count { get => default; }

	// Nested types
	public class ListNode : IReusable // TypeDefIndex: 31893
	{
		// Fields
		private bool _isValid;
		private ListNode<T> _prev;
		public ListNode<T> next;
		public T data;

		// Properties
		public ListNode<T> prev { get => default; set {} }
		public bool isValid { get => default; }

		// Nested types
		public class Spawner : ISpawner<ListNode<T>, T> // TypeDefIndex: 31894
		{
			// Constructors
			public Spawner() {}

			// Methods
			public ListNode<T> Spawn(T param1) => default;
		}

		public class Polisher : IPolisher<ListNode<T>, T> // TypeDefIndex: 31895
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
		public void BeforeRecycle() {}
	}

	public class Spawner : ISpawner<SECTR_JobList<T>> // TypeDefIndex: 31896
	{
		// Constructors
		public Spawner() {}

		// Methods
		public SECTR_JobList<T> Spawn() => default;
	}

	// Constructors
	public SECTR_JobList() {}

	// Methods
	public void SetNodePool() {}
	public bool Empty() => default;
	public virtual void Delete(T data) {}
	public virtual ListNode AddTail(T data) => default;
	public virtual void AddTail(SECTR_JobList<T> list) {}
	public virtual ListNode Get(T data) => default;
	public void Delete(ListNode node, bool release = true /* Metadata: 0x00B13823 */) {}
	public virtual void Clear() {}
	public void ClearWithOutRelease() {}
	public virtual void Add(ListNode newNode) {}
	public virtual void AddTail(ListNode newNode) {}
	public static ListNode getNode() => default;
	public static void releaseNode(ListNode node) {}
	protected virtual void add(ListNode newNode, ListNode prev, ListNode next) {}
	protected virtual void delete(ListNode deleteNode, ListNode prev, ListNode next) {}
	public ListNode End() => default;
	public ListNode Begin() => default;
	public ListNode Tail() => default;
	public ListNode Next(ListNode it) => default;
	public void BeforeRecycle() {}
}

