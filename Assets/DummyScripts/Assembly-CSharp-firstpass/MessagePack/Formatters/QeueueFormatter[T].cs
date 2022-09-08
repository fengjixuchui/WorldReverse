/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class QeueueFormatter<T> : CollectionFormatterBase<T, Queue<T>, Queue<T>, Queue<T>> // TypeDefIndex: 8201
	{
		// Constructors
		public QeueueFormatter() {}
	
		// Methods
		protected override int? GetCount(Queue<T> sequence) => default;
		protected override void Add(Queue<T> collection, int index, T value) {}
		protected override Queue<T> Create(int count) => default;
		protected override Queue<T> GetSourceEnumerator(Queue<T> source) => default;
		protected override Queue<T> Complete(Queue<T> intermediateCollection) => default;
	}
}
