/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SceneWidgetPool<T> // TypeDefIndex: 14737
	where T : new()
{
	// Fields
	private int _capacity;
	private int _count;
	private int _endingIndex;
	private Func<T> constructor;
	private T[] _buffer;
	private SortedList<int, int> _unusedIndices;

	// Properties
	public int Capacity { get => default; }
	public bool AllowCapacityEnlarge { get; private set; }
	public int Count { get => default; }
	public int EndingIndex { get => default; }
	public T[] Buffer { get => default; }
	public T this[int index] { get => default; set {} }

	// Nested types
	public struct Iterator<U> // TypeDefIndex: 14738
		where U : new()
	{
		// Fields
		private SceneWidgetPool<U> _pool;
		private int _id;

		// Properties
		public U value { get => default; set {} }
		public int id { get => default; }

		// Constructors
		public Iterator(SceneWidgetPool<U> pool, int id) : this() {
			_pool = default;
			_id = default;
		}

		// Methods
		public bool IsExist() => default;
		public void Release() {}
		public void ReleaseWithReset() {}
	}

	// Constructors
	public SceneWidgetPool() {} // Dummy constructor
	public SceneWidgetPool(int capacity, bool allowCapicityEnlarge = true /* Metadata: 0x00AEBE8E */, Func<T> constructor = null) {}

	// Methods
	public bool IsFull() => default;
	public void EnlargeCapacity(int capacity) {}
	public Iterator GetEmptyIterator() => default;
	public int GetEmptyIndex() => default;
	private void UpdateEndingIndex() {}
	public bool IsExist(int id) => default;
	public void Remove(int id) {}
	public void RemoveWithReset(int id) {}
	public void Clear() {}
}

