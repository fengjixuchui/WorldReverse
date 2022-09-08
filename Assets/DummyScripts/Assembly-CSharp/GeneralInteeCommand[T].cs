/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GeneralInteeCommand<T> : IGeneralInteeCommandOfT<T> // TypeDefIndex: 29670
{
	// Fields
	private GeneralInteeCommandType command;
	private uint instanceID;
	private T param;
	private bool initialized;

	// Constructors
	public GeneralInteeCommand() {}

	// Methods
	public void Init(uint id, GeneralInteeCommandType c, T p = default) {}
	public T GetParam() => default;
	public GeneralInteeCommandType GetCommandType() => default;
	public uint GetInstanceID() => default;
	public void Dispose() {}
}

