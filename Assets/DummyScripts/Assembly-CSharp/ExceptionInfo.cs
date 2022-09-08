/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ExceptionInfo // TypeDefIndex: 11565
{
	// Fields
	public int errCode; // 0x10
	public string message; // 0x18
	public string realMessage; // 0x20
	public ExceptionType exceptionType; // 0x28

	// Nested types
	public enum ExceptionType // TypeDefIndex: 11566
	{
		None = 0,
		Warning = 1,
		Error = 2
	}

	// Constructors
	public ExceptionInfo() {} // 0x00000001836E40A0-0x00000001836E4100
}

