/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SECTR_LinkedListNode<T> : IReusable // TypeDefIndex: 31897
	where T : ISECTR_BaseLoader
{
	// Fields
	public SECTR_LinkedListNode<T> Prev;
	public SECTR_LinkedListNode<T> Next;
	public T Value;

	// Properties
	public bool isValid { get => default; }

	// Nested types
	public class Spawner : ISpawner<SECTR_LinkedListNode<T>, T> // TypeDefIndex: 31898
	{
		// Constructors
		public Spawner() {}

		// Methods
		public SECTR_LinkedListNode<T> Spawn(T param1) => default;
	}

	public class Polisher : IPolisher<SECTR_LinkedListNode<T>, T> // TypeDefIndex: 31899
	{
		// Constructors
		public Polisher() {}

		// Methods
		public void Polish(SECTR_LinkedListNode<T> reused, T param1) {}
	}

	// Constructors
	public SECTR_LinkedListNode() {} // Dummy constructor
	public SECTR_LinkedListNode(T data) {}

	// Methods
	public void BeforeRecycle() {}
}

