/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class Quadtree<T> // TypeDefIndex: 9333
	{
		// Fields
		private readonly int nodeCapacity;
		private readonly List<QuadtreeNode> nodes;
		private Quadtree<T>[] children;
		private Rect boundaries;
	
		// Properties
		public int Count { get; private set; }
	
		// Nested types
		private class QuadtreeNode // TypeDefIndex: 9334
		{
			// Properties
			public Vector2 Position { get; private set; }
			public T Value { get; private set; }
	
			// Constructors
			public QuadtreeNode() {} // Dummy constructor
			public QuadtreeNode(Vector2 position, T value) {}
		}
	
		// Constructors
		public Quadtree() {} // Dummy constructor
		public Quadtree(Rect boundaries, int nodeCapacity = 32 /* Metadata: 0x00AE5762 */) {}
	
		// Methods
		public bool Insert(float x, float y, T value) => default;
		public bool Insert(Vector2 position, T value) => default;
		private bool Insert(QuadtreeNode node) => default;
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerable<T> Find(Rect range) => default;
		public bool Remove(float x, float z, T value) => default;
		public bool Remove(Vector2 position, T value) => default;
		private void Subdivide() {}
		private void Combine() {}
	}
}
