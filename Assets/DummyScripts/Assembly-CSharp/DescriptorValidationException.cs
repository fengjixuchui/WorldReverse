/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DescriptorValidationException : Exception // TypeDefIndex: 26400
{
	// Fields
	private readonly string name; // 0x60
	private readonly string description; // 0x68

	// Properties
	public string ProblemSymbolName { /* [XID] */ /* 0x0000000189A5A080-0x0000000189A5A0A0 */ get => default; } // 0x0000000184723620-0x00000001847236C0 
	public string Description { /* [XID] */ /* 0x0000000189A618B0-0x0000000189A618D0 */ get => default; } // 0x0000000184723580-0x0000000184723620 

	// Constructors
	public DescriptorValidationException() {} // Dummy constructor
	internal DescriptorValidationException(IDescriptor problemDescriptor, string description) {} // 0x00000001847237D0-0x00000001847238E0
	internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause) {} // 0x00000001847236C0-0x00000001847237D0
}

