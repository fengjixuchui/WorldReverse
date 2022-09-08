/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SECTR_LinkedList<T> : IReusable // TypeDefIndex: 31900
	where T : ISECTR_BaseLoader
{
	// Fields
	protected int enterState;
	protected SECTR_LinkedListNode<T> _head;
	protected int _count;

	// Properties
	public int Count { get => default; }
	public SECTR_LinkedListNode<T> First { get => default; }
	public SECTR_LinkedListNode<T> Last { get => default; }

	// Constructors
	public SECTR_LinkedList() {} // Dummy constructor
	public SECTR_LinkedList(T value) {}

	// Methods
	public bool Empty() => default;
	public virtual SECTR_LinkedListNode<T> AddAfter(SECTR_LinkedListNode<T> prev, T data) => default;
	public virtual SECTR_LinkedListNode<T> AddBefore(SECTR_LinkedListNode<T> next, T data) => default;
	public void Remove(SECTR_LinkedListNode<T> node) {}
	public virtual void Clear() {}
	protected virtual void Add(SECTR_LinkedListNode<T> newNode, SECTR_LinkedListNode<T> prev, SECTR_LinkedListNode<T> next) {}
	protected virtual void Delete(SECTR_LinkedListNode<T> deleteNode, SECTR_LinkedListNode<T> prev, SECTR_LinkedListNode<T> next) {}
	public void BeforeRecycle() {}
	public List<SECTR_LinkedListNode<T>> ToList() => default;
	public static SECTR_LinkedListNode<T> GenNode() => default;
	public static void ReleaseNode(SECTR_LinkedListNode<T> node) {}
}

