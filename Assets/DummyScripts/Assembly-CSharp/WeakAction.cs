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

public abstract class WeakAction // TypeDefIndex: 11094
{
	// Fields
	private readonly List<WeakReference> _callbacks; // 0x10

	// Properties
	protected List<WeakReference> callbacks { /* [XID] */ /* 0x0000000189B72480-0x0000000189B724A0 */ get; } // 0x0000000184734210-0x00000001847342B0 

	// Constructors
	public WeakAction() {} // 0x00000001847342B0-0x0000000184734340

	// Methods
	public static void Add<T, THandler>(ref T combined, THandler handler)
		where T : WeakAction, new() {}
	public static void Remove<T, THandler>(ref T combined, THandler handler)
		where T : WeakAction, new() {}
}

