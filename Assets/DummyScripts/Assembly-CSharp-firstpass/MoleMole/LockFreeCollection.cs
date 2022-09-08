/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class LockFreeCollection : ICollection // TypeDefIndex: 10586
	{
		// Properties
		public abstract int Count { get; }
		public virtual bool IsSynchronized { /* [XID] */ /* 0x000000018994DC00-0x000000018994DC20 */ get; } // 0x0000000189BFAEF0-0x0000000189BFAF90 
		public abstract int Capacity { get; set; }
		public virtual object SyncRoot { /* [XID] */ /* 0x00000001899552C0-0x00000001899552E0 */ get; } // 0x0000000189BFAF90-0x0000000189BFB060 
	
		// Constructors
		protected LockFreeCollection() {} // 0x0000000189BFAE90-0x0000000189BFAEF0
	
		// Methods
		public abstract void Clear();
		public abstract bool Push(object item);
		public abstract object Pop();
		public abstract void CopyTo(Array array, int index);
		// [XID] // 0x000000018995CA40-0x000000018995CA60
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BFADC0-0x0000000189BFAE90
	}
}
