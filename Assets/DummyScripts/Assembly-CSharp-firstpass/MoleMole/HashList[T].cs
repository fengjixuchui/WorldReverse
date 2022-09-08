/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class HashList<T> : DoublyList<T> // TypeDefIndex: 10566
	{
		// Fields
		private Dictionary<T, ListNode<T>> _findHash;
		public bool needAddRemoveCheck;
	
		// Constructors
		public HashList() {}
	
		// Methods
		public static HashList<T> operator +(HashList<T> a, T b) => default;
		public static HashList<T> operator -(HashList<T> a, T b) => default;
		public override ListNode<T> MarkInvalid(T data) => default;
		public override void Delete(T data) {}
		public override ListNode<T> Get(T data) => default;
		public override void Clear() {}
		protected override void add(ListNode<T> newNode, ListNode<T> prev, ListNode<T> next) {}
		protected override void delete(ListNode<T> deleteNode, ListNode<T> prev, ListNode<T> next) {}
		public override bool Contains(T inElement) => default;
	}
}
