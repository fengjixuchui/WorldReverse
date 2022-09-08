/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseContextData // TypeDefIndex: 28435
{
	// Nested types
	public enum ClearType // TypeDefIndex: 28436
	{
		InLevel = 0,
		Global = 1,
		Persistence = 2
	}

	// Constructors
	protected BaseContextData() {} // 0x00000001846B3170-0x00000001846B31D0

	// Methods
	public abstract ClearType GetClearType();
}

