/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OneofAccessor // TypeDefIndex: 26417
{
	// Fields
	private readonly Func<IMessage, int> caseDelegate; // 0x10
	private readonly Action<IMessage> clearDelegate; // 0x18
	private OneofDescriptor descriptor; // 0x20

	// Properties
	public OneofDescriptor Descriptor { /* [XID] */ /* 0x0000000189688170-0x0000000189688190 */ get => default; } // 0x00000001822F53A0-0x00000001822F5440 

	// Constructors
	public OneofAccessor() {} // Dummy constructor
	internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor) {} // 0x00000001822F5540-0x00000001822F5680

	// Methods
	// [XID] // 0x000000018968FAB0-0x000000018968FAD0
	public void Clear(IMessage message) {} // 0x00000001822F52D0-0x00000001822F53A0
	// [XID] // 0x00000001896974D0-0x00000001896974F0
	public FieldDescriptor GetCaseFieldDescriptor(IMessage message) => default; // 0x00000001822F5440-0x00000001822F5540
}

