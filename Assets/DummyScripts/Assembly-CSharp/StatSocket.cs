/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StatSocket // TypeDefIndex: 27600
{
	// Fields
	private Socket _Socket; // 0x10
	public string lastIP; // 0x18
	public string lastPort; // 0x20

	// Constructors
	public StatSocket() {} // 0x0000000183879EB0-0x0000000183879F20

	// Methods
	// [XID] // 0x00000001897E8450-0x00000001897E8470
	public bool IsConnected() => default; // 0x0000000183879DF0-0x0000000183879EB0
	// [XID] // 0x00000001897F0130-0x00000001897F0150
	public void Connect(string serverIP, string serverPort) {} // 0x0000000183879960-0x0000000183879BF0
	// [XID] // 0x00000001897F7920-0x00000001897F7940
	public bool SendContentBySocket(string content) => default; // 0x0000000183879BF0-0x0000000183879DF0
}

