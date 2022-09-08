/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MessageInfo // TypeDefIndex: 26108
{
	// Fields
	private Dictionary<ushort, string> _cmdNameDict; // 0x10
	private Dictionary<string, ushort> _cmdIdDict; // 0x18
	private Dictionary<ushort, uint> _cmdChannelIdDict; // 0x20
	private Dictionary<ushort, MessageAllocFuncHandler> _cmdAllocFunc; // 0x28
	private HashSet<ushort> _cmdIsReliableSet; // 0x30
	private HashSet<ushort> _cmdIsAllowedSet; // 0x38

	// Nested types
	private delegate MessageBase MessageAllocFuncHandler(); // TypeDefIndex: 26109; 0x000000018309DAC0-0x000000018309DC30

	// Constructors
	public MessageInfo() {} // 0x0000000180E630B0-0x0000000180F0F7E0

	// Methods
	// [XID] // 0x000000018981B7F0-0x000000018981B810
	public MessageBase AllocMessageByCmdId(ushort cmdId) => default; // 0x0000000180E62B60-0x0000000180E62EF0
	// [XID] // 0x0000000189822D80-0x0000000189822DA0
	public string GetCmdName(ushort cmdId) => default; // 0x0000000180E62A70-0x0000000180E62B60
	// [XID] // 0x000000018982A6E0-0x000000018982A700
	public ushort GetCmdId(string name) => default; // 0x0000000180E62FC0-0x0000000180E630B0
	// [XID] // 0x0000000189831AD0-0x0000000189831AF0
	public uint GetChannelId(ushort cmdId) => default; // 0x0000000180E628B0-0x0000000180E629A0
	// [XID] // 0x0000000189839180-0x00000001898391A0
	public bool IsReliable(ushort cmdId) => default; // 0x0000000180E629A0-0x0000000180E62A70
	// [XID] // 0x00000001898407C0-0x00000001898407E0
	public bool IsAllowedForClient(ushort cmdId) => default; // 0x0000000180E62EF0-0x0000000180E62FC0
}

