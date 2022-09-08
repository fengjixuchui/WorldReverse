/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class AtomicQueue<T> // TypeDefIndex: 10663
	{
		// Fields
		private Chunk _beginChunk;
		private uint _beginPos;
		private Chunk _backChunk;
		private uint _backPos;
		private Chunk _endChunk;
		private uint _endPos;
		private uint _chunkSize;
		private uint _chunkOffset;
		private AtomicObject<Chunk> _spareChunk;
		public const uint DEFAULT_CHUNK_SIZE = 32; // Metadata: 0x00AE8061
	
		// Properties
		public T front { get => default; }
		public T back { get => default; set {} }
		public uint frontPos { get => default; }
		public uint backPos { get => default; }
		public uint endPos { get => default; }
	
		// Nested types
		protected class Chunk // TypeDefIndex: 10664
		{
			// Fields
			public readonly T[] values;
			public uint offset;
			public Chunk<T> prev;
			public Chunk<T> next;
	
			// Constructors
			public Chunk() {} // Dummy constructor
			public Chunk(uint offset, uint size) {}
		}
	
		// Constructors
		public AtomicQueue() {} // Dummy constructor
		public AtomicQueue(uint chunkSize) {}
	
		// Methods
		public void Push() {}
		public void Pop() {}
		public void Unpush() {}
		private Chunk AllocChunk() => default;
	}
}
