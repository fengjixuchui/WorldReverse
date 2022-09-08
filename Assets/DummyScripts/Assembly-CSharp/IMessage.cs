/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IMessage // TypeDefIndex: 26326
{
	// Properties
	MessageDescriptor Descriptor { get; }
	string ClassName { get; }
	string FullClassName { get; }
	ushort CmdId { get; }

	// Methods
	void MergeFrom(CodedInputStream input);
	void WriteTo(CodedOutputStream output);
	int CalculateSize();
	void Reset();
}

