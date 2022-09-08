/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class ReadOnlyCollectionFormatter<T> : CollectionFormatterBase<T, T[], ReadOnlyCollection<T>> // TypeDefIndex: 8204
	{
		// Constructors
		public ReadOnlyCollectionFormatter() {}
	
		// Methods
		protected override void Add(T[] collection, int index, T value) {}
		protected override ReadOnlyCollection<T> Complete(T[] intermediateCollection) => default;
		protected override T[] Create(int count) => default;
	}
}
