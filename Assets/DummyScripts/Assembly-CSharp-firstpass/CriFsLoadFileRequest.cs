/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsLoadFileRequest : CriFsRequest // TypeDefIndex: 7131
{
	// Fields
	private Phase phase; // 0x50
	private CriFsBinder refBinder; // 0x58
	private CriFsBinder newBinder; // 0x60
	private uint bindId; // 0x68
	private CriFsLoader loader; // 0x70
	private int readUnitSize; // 0x78
	private long fileSize; // 0x80

	// Properties
	public string path { get; private set; } // 0x0000000187A30700-0x0000000187A30760 0x0000000187A307C0-0x0000000187A30820
	public byte[] bytes { get; private set; } // 0x0000000187A306A0-0x0000000187A30700 0x0000000187A30760-0x0000000187A307C0

	// Nested types
	private enum Phase // TypeDefIndex: 7132
	{
		Stop = 0,
		Bind = 1,
		Load = 2,
		Done = 3,
		Error = 4
	}

	// Constructors
	public CriFsLoadFileRequest() {} // Dummy constructor
	public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize) {} // 0x0000000187A30490-0x0000000187A306A0

	// Methods
	protected override void Dispose(bool disposing) {} // 0x0000000187A2FE00-0x0000000187A2FF10
	public override void Stop() {} // 0x0000000187A30040-0x0000000187A300B0
	public override void Update() {} // 0x0000000187A30400-0x0000000187A30490
	private void UpdateBinder() {} // 0x0000000187A300B0-0x0000000187A301B0
	private void UpdateLoader() {} // 0x0000000187A301B0-0x0000000187A30400
	private void OnError() {} // 0x0000000187A2FF10-0x0000000187A30040
}

