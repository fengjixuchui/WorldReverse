/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DumbUnmanagedAllocator : IUnmanagedAllocator // TypeDefIndex: 11065
{
	// Fields
	private readonly Dictionary<IntPtr, int> _allocations; // 0x10
	private int _totalAllocated; // 0x18

	// Constructors
	public DumbUnmanagedAllocator() {} // 0x00000001832C3990-0x00000001832C3A30

	// Methods
	// [XID] // 0x0000000189965E50-0x0000000189965E70
	public IntPtr Allocate(int size) => default; // 0x00000001832C3720-0x00000001832C3860
	// [XID] // 0x000000018996D3F0-0x000000018996D410
	public void Free(IntPtr ptr) {} // 0x00000001832C3860-0x00000001832C3990
}

