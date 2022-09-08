/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DownloadVersionInfo // TypeDefIndex: 11629
{
	// Fields
	public string remoteFileName; // 0x10
	public string localFileName; // 0x18
	public string md5; // 0x20
	public long fileSize; // 0x28
	public bool isPatch; // 0x30

	// Constructors
	public DownloadVersionInfo() {} // 0x00000001833A33F0-0x00000001833A3480

	// Methods
	// [XID] // 0x000000018986D5B0-0x000000018986D5D0
	public override bool Equals(object obj) => default; // 0x00000001833A25F0-0x00000001833A2800
	// [XID] // 0x000000018971E9E0-0x000000018971EA00
	public override int GetHashCode() => default; // 0x00000001833A2DB0-0x00000001833A2EF0
	// [XID] // 0x000000018987C680-0x000000018987C6A0
	public static bool operator ==(DownloadVersionInfo a, DownloadVersionInfo b) => default; // 0x00000001833A2F70-0x00000001833A3130
	// [XID] // 0x00000001898836F0-0x0000000189883710
	public static bool operator !=(DownloadVersionInfo a, DownloadVersionInfo b) => default; // 0x00000001833A3330-0x00000001833A33F0
	// [XID] // 0x000000018988AF10-0x000000018988AF30
	public void ReadVersionFromJsonContent(string content) {} // 0x00000001833A2A20-0x00000001833A2DB0
	// [XID] // 0x00000001898922E0-0x0000000189892300
	public void ReadVersionFromClassicContent(string content) {} // 0x00000001833A2800-0x00000001833A2A20
	// [XID] // 0x0000000189899D50-0x0000000189899D70
	private void SplitMd5AndFileSize(string md5AndFileSize, out string md5, out long fileSize) {
		md5 = default;
		fileSize = default;
	} // 0x00000001833A3130-0x00000001833A3330
}

