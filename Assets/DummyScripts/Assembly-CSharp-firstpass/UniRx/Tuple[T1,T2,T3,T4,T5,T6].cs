/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UniRx
{
	[Serializable]
	public struct Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple // TypeDefIndex: 10651
	{
		// Fields
		private T1 item1;
		private T2 item2;
		private T3 item3;
		private T4 item4;
		private T5 item5;
		private T6 item6;
	
		// Properties
		public T1 Item1 { get => default; }
		public T2 Item2 { get => default; }
		public T3 Item3 { get => default; }
		public T4 Item4 { get => default; }
		public T5 Item5 { get => default; }
		public T6 Item6 { get => default; }
	
		// Constructors
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) : this() {
			this.item1 = default;
			this.item2 = default;
			this.item3 = default;
			this.item4 = default;
			this.item5 = default;
			this.item6 = default;
		}
	
		// Methods
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, IComparer comparer) => default;
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		string ITuple.ToString() => default;
		public override string ToString() => default;
	}
}
