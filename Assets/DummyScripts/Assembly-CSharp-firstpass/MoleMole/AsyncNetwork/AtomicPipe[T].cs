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
	public class AtomicPipe<T> // TypeDefIndex: 10662
	{
		// Fields
		private AtomicQueue<T> _queue;
		private uint _w;
		private uint _r;
		public const uint DEFAULT_CHUNK_SIZE = 32; // Metadata: 0x00AE805D
	
		// Constructors
		public AtomicPipe() {} // Dummy constructor
		public AtomicPipe(uint chunckSize = 32 /* Metadata: 0x00AE8058 */) {}
	
		// Methods
		public void Write(T value, bool incomplete_ = false /* Metadata: 0x00AE805C */) {}
		public bool Unwrite(out T value) {
			value = default;
			return default;
		}
		public bool CheckRead() => default;
		public bool Read(out T value) {
			value = default;
			return default;
		}
	}
}
