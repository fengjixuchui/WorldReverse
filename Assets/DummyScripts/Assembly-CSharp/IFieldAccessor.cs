/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IFieldAccessor // TypeDefIndex: 26411
{
	// Properties
	FieldDescriptor Descriptor { get; }

	// Methods
	void Clear(IMessage message);
	object GetValue(IMessage message);
	void SetValue(IMessage message, object value);
}

