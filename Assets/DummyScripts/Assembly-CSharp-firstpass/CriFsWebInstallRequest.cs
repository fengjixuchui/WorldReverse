/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsWebInstallRequest : CriFsInstallRequest // TypeDefIndex: 7136
{
	// Fields
	private CriFsWebInstaller installer; // 0x58
	private uint crc32; // 0x60
	private bool crc32_set; // 0x64

	// Constructors
	public CriFsWebInstallRequest() {} // Dummy constructor
	public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate) {} // 0x0000000187A36110-0x0000000187A36300

	// Methods
	public override void Stop() {} // 0x0000000187A35E10-0x0000000187A35E80
	public bool GetCRC32(out uint ret_val) {
		ret_val = default;
		return default;
	} // 0x0000000187A35DA0-0x0000000187A35E10
	public override void Update() {} // 0x0000000187A35E80-0x0000000187A36110
	protected override void Dispose(bool disposing) {} // 0x0000000187A35CF0-0x0000000187A35DA0
}

