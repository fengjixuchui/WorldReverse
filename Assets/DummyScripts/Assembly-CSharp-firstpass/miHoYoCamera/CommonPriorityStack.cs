/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class CommonPriorityStack : IPriorityStack // TypeDefIndex: 8962
	{
		// Fields
		protected List<List<IPriorityStackItem>> _priorityStacks; // 0x10
		protected int _count; // 0x18
	
		// Properties
		public int Count { /* [XID] */ /* 0x0000000189999410-0x0000000189999430 */ get => default; } // 0x0000000187326650-0x00000001873266F0 
		public IPriorityStackItem this[int index] { /* [XID] */ /* 0x0000000189A19B30-0x0000000189A19B50 */ get => default; } // 0x00000001873266F0-0x0000000187326830 
	
		// Constructors
		public CommonPriorityStack() {} // 0x00000001873265B0-0x0000000187326650
	
		// Methods
		// [XID] // 0x00000001899A8660-0x00000001899A8680
		public void Push(IPriorityStackItem item) {} // 0x0000000187326390-0x00000001873265B0
		// [XID] // 0x0000000189BAA1A0-0x0000000189BAA1C0
		public IPriorityStackItem Pop(int index = 0 /* Metadata: 0x00AE4F05 */) => default; // 0x00000001873261E0-0x0000000187326390
		// [XID] // 0x00000001899B72C0-0x00000001899B72E0
		public IPriorityStackItem Peek(int index = 0 /* Metadata: 0x00AE4F09 */) => default; // 0x0000000187326040-0x00000001873261E0
	}
}
