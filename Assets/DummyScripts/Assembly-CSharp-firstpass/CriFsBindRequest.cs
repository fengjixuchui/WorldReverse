/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsBindRequest : CriFsRequest // TypeDefIndex: 7137
{
	// Properties
	public string path { get; private set; } // 0x0000000187A2BDF0-0x0000000187A2BE50 0x0000000187A2BEB0-0x0000000187A2BF10
	public uint bindId { get; private set; } // 0x0000000187A2BD90-0x0000000187A2BDF0 0x0000000187A2BE50-0x0000000187A2BEB0

	// Nested types
	public enum BindType // TypeDefIndex: 7138
	{
		Cpk = 0,
		Directory = 1,
		File = 2
	}

	// Constructors
	public CriFsBindRequest() {} // Dummy constructor
	public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path) {} // 0x0000000187A2BBB0-0x0000000187A2BD90

	// Methods
	public override void Stop() {} // 0x0000000187A2BA50-0x0000000187A2BAA0
	public override void Update() {} // 0x0000000187A2BAA0-0x0000000187A2BBB0
	protected override void Dispose(bool disposing) {} // 0x0000000187A2B9C0-0x0000000187A2BA50
}

