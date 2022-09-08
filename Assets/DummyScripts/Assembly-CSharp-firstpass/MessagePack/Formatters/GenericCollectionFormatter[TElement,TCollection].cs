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
	public class GenericCollectionFormatter<TElement, TCollection> : CollectionFormatterBase<TElement, TCollection> // TypeDefIndex: 8199
		where TCollection : ICollection<TElement>, new()
	{
		// Constructors
		public GenericCollectionFormatter() {}
	
		// Methods
		protected override TCollection Create(int count) => default;
		protected override void Add(TCollection collection, int index, TElement value) {}
	}
}
