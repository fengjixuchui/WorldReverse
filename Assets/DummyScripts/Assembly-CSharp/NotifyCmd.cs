/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NotifyCmd : ActorCommand // TypeDefIndex: 20606
{
	// Fields
	public string alias; // 0x18
	public int evtType; // 0x20
	public object[] evtParams; // 0x28
	public int sourceType; // 0x30
	public uint sourceId; // 0x34

	// Constructors
	public NotifyCmd() {} // 0x0000000184529010-0x0000000184529090

	// Methods
	// [XID] // 0x0000000189A69060-0x0000000189A69080
	public static NotifyCmd Get(string alias, int evtType, object[] evtParams, int sourceType, uint sourceId) => default; // 0x0000000184528DF0-0x0000000184528F30
	// [XID] // 0x00000001896DDC20-0x00000001896DDC40
	public override void ResetObject() {} // 0x0000000184528F30-0x0000000184529010
}

