/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientLogBodyLogin : MessageBase, IMessage<ClientLogBodyLogin> // TypeDefIndex: 26112
{
	// Fields
	private static readonly MessageParser<ClientLogBodyLogin> _parser; // 0x00
	public const int ActionTypeFieldNumber = 1; // Metadata: 0x00B0BD23
	private string actionType_; // 0x18
	public const int ActionResultFieldNumber = 2; // Metadata: 0x00B0BD27
	private string actionResult_; // 0x20
	public const int ActionTimeFieldNumber = 3; // Metadata: 0x00B0BD2B
	private uint actionTime_; // 0x28
	public const int XgFieldNumber = 4; // Metadata: 0x00B0BD2F
	private string xg_; // 0x30
	public const int SignalLevelFieldNumber = 5; // Metadata: 0x00B0BD33
	private uint signalLevel_; // 0x38
	public const int DnsFieldNumber = 6; // Metadata: 0x00B0BD37
	private string dns_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientLogBodyLogin> Parser { get => default; } // 0x00000001842F80B0-0x00000001842F8140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842F7D00-0x00000001842F7D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842F77F0-0x00000001842F7870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842F69E0-0x00000001842F6A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842F8650-0x00000001842F8740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842F8320-0x00000001842F8380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842F7D90-0x00000001842F7E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842F8600-0x00000001842F8650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842F79C0-0x00000001842F7AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ActionType { get => default; set {} } // 0x00000001842F67D0-0x00000001842F6870 0x00000001842F8270-0x00000001842F8320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ActionResult { get => default; set {} } // 0x00000001842F7750-0x00000001842F77F0 0x00000001842F6A40-0x00000001842F6AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActionTime { get => default; set {} } // 0x00000001842F6E60-0x00000001842F6F00 0x00000001842F76B0-0x00000001842F7750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Xg { get => default; set {} } // 0x00000001842F6DC0-0x00000001842F6E60 0x00000001842F7340-0x00000001842F73F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignalLevel { get => default; set {} } // 0x00000001842F6AF0-0x00000001842F6B90 0x00000001842F8010-0x00000001842F80B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Dns { get => default; set {} } // 0x00000001842F7E80-0x00000001842F7F20 0x00000001842F7870-0x00000001842F7920

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyLogin() {} // 0x00000001842F8BD0-0x00000001842F8C60
	static ClientLogBodyLogin() {} // 0x00000001842F8B10-0x00000001842F8BD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyLogin Clone() => default; // 0x00000001842F7F20-0x00000001842F8010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyLogin ShallowCopy() => default; // 0x00000001842F7920-0x00000001842F79C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842F6F00-0x00000001842F6F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842F81D0-0x00000001842F8220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842F8220-0x00000001842F8270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842F6F50-0x00000001842F7010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842F7270-0x00000001842F7340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientLogBodyLogin other) => default; // 0x00000001842F7010-0x00000001842F7270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842F7AB0-0x00000001842F7D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842F8740-0x00000001842F8B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842F8380-0x00000001842F8600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842F73F0-0x00000001842F76B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientLogBodyLogin other) {} // 0x00000001842F6B90-0x00000001842F6DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842F6870-0x00000001842F69E0
}

