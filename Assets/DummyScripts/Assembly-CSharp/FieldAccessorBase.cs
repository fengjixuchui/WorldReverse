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

internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 26404
{
	// Fields
	private readonly Func<IMessage, object> getValueDelegate; // 0x10
	private readonly FieldDescriptor descriptor; // 0x18

	// Properties
	public FieldDescriptor Descriptor { /* [XID] */ /* 0x0000000189AD29A0-0x0000000189AD29C0 */ get; } // 0x00000001849EAC30-0x00000001849EACD0 

	// Constructors
	protected FieldAccessorBase() {} // Dummy constructor
	internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor) {} // 0x00000001849EADA0-0x00000001849EAE70

	// Methods
	// [XID] // 0x0000000189ADA3B0-0x0000000189ADA3D0
	public object GetValue(IMessage message) => default; // 0x00000001849EACD0-0x00000001849EADA0
	public abstract void Clear(IMessage message);
	public abstract void SetValue(IMessage message, object value);
}

