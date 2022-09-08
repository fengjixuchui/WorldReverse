/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 26395
{
	// Fields
	private readonly FileDescriptor file; // 0x10
	private readonly string fullName; // 0x18
	private readonly int index; // 0x20

	// Properties
	public int Index { /* [XID] */ /* 0x00000001899E4A90-0x00000001899E4AB0 */ get; } // 0x000000018426A5E0-0x000000018426A680 
	public abstract string Name { get; }
	public string FullName { /* [XID] */ /* 0x00000001899EBFE0-0x00000001899EC000 */ get; } // 0x000000018426A680-0x000000018426A720 
	public FileDescriptor File { /* [XID] */ /* 0x00000001899F39D0-0x00000001899F39F0 */ get; } // 0x000000018426A540-0x000000018426A5E0 

	// Constructors
	protected DescriptorBase() {} // Dummy constructor
	internal DescriptorBase(FileDescriptor file, string fullName, int index) {} // 0x000000018426A720-0x000000018426A7B0
}

