/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EcoQueue<T> // TypeDefIndex: 11067
{
	// Fields
	private Node _head;
	private Node _tail;
	private int _count;

	// Properties
	public int count { get => default; }
	public bool empty { get => default; }

	// Nested types
	private class Node : IReusable // TypeDefIndex: 11068
	{
		// Properties
		public T value { get; set; }
		public Node<T> next { get; set; }

		// Nested types
		public class Spawner : ISpawner<Node<T>> // TypeDefIndex: 11069
		{
			// Constructors
			public Spawner() {}

			// Methods
			public Node<T> Spawn() => default;
		}

		// Constructors
		private Node() {}

		// Methods
		public void BeforeRecycle() {}
	}

	// Constructors
	public EcoQueue() {}

	// Methods
	public void Enqueue(T item) {}
	public T Dequeue() => default;
	public T Peek() => default;
	private Node Allocate(T item) => default;
	private void Deallocate(Node node) {}
}

