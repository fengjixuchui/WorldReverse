/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SdkInvokeTaskCell<ExecuteType, FlushType> : SdkInvokeTaskCellBase // TypeDefIndex: 26625
	where ExecuteType : class
	where FlushType : class
{
	// Fields
	private _Execute _execute;
	private _Flush _flush;
	private ExecuteType _executeData;
	private FlushType _flushData;

	// Nested types
	public delegate FlushType _Execute(ExecuteType e); // TypeDefIndex: 26626; 0x00000000-0x00000000

	public delegate void _Flush(FlushType e); // TypeDefIndex: 26627; 0x00000000-0x00000000

	// Constructors
	public SdkInvokeTaskCell() {} // Dummy constructor
	public SdkInvokeTaskCell(_Execute _e, _Flush _f, ExecuteType _eData) {}

	// Methods
	public override void Execute() {}
	public override void Flush() {}
}

