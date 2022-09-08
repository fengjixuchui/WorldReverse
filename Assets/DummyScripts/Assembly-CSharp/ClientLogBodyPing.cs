/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientLogBodyPing : MessageBase, IMessage<ClientLogBodyPing> // TypeDefIndex: 26113
{
	// Fields
	private static readonly MessageParser<ClientLogBodyPing> _parser; // 0x00
	public const int XgFieldNumber = 1; // Metadata: 0x00B0BD3B
	private string xg_; // 0x18
	public const int SignalLevelFieldNumber = 2; // Metadata: 0x00B0BD3F
	private uint signalLevel_; // 0x20
	public const int PingFieldNumber = 3; // Metadata: 0x00B0BD43
	private uint ping_; // 0x24
	public const int ServertypeFieldNumber = 4; // Metadata: 0x00B0BD47
	private string servertype_; // 0x28
	public const int ServeripFieldNumber = 5; // Metadata: 0x00B0BD4B
	private string serverip_; // 0x30
	public const int ServerportFieldNumber = 6; // Metadata: 0x00B0BD4F
	private string serverport_; // 0x38
	public const int PcountFieldNumber = 7; // Metadata: 0x00B0BD53
	private uint pcount_; // 0x40
	public const int PlostFieldNumber = 8; // Metadata: 0x00B0BD57
	private uint plost_; // 0x44
	public const int DnsFieldNumber = 9; // Metadata: 0x00B0BD5B
	private string dns_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientLogBodyPing> Parser { get => default; } // 0x0000000183AC0060-0x0000000183AC00F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ABFC10-0x0000000183ABFCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ABF5B0-0x0000000183ABF630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ABE4B0-0x0000000183ABE510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AC0780-0x0000000183AC0870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AC0220-0x0000000183AC0280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ABFD40-0x0000000183ABFE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AC0730-0x0000000183AC0780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ABF780-0x0000000183ABF870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Xg { get => default; set {} } // 0x0000000183ABE910-0x0000000183ABE9B0 0x0000000183ABEFF0-0x0000000183ABF0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignalLevel { get => default; set {} } // 0x0000000183ABE510-0x0000000183ABE5B0 0x0000000183ABFFC0-0x0000000183AC0060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Ping { get => default; set {} } // 0x0000000183ABFB70-0x0000000183ABFC10 0x0000000183ABFCA0-0x0000000183ABFD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Servertype { get => default; set {} } // 0x0000000183AC0920-0x0000000183AC09C0 0x0000000183AC0280-0x0000000183AC0330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Serverip { get => default; set {} } // 0x0000000183ABE240-0x0000000183ABE2E0 0x0000000183ABF500-0x0000000183ABF5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Serverport { get => default; set {} } // 0x0000000183AC0690-0x0000000183AC0730 0x0000000183AC0870-0x0000000183AC0920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Pcount { get => default; set {} } // 0x0000000183ABEB90-0x0000000183ABEC30 0x0000000183ABEAF0-0x0000000183ABEB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Plost { get => default; set {} } // 0x0000000183ABF460-0x0000000183ABF500 0x0000000183ABE870-0x0000000183ABE910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Dns { get => default; set {} } // 0x0000000183ABFE30-0x0000000183ABFED0 0x0000000183ABF630-0x0000000183ABF6E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyPing() {} // 0x0000000183AC0FD0-0x0000000183AC1070
	static ClientLogBodyPing() {} // 0x0000000183AC0F10-0x0000000183AC0FD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyPing Clone() => default; // 0x0000000183ABFED0-0x0000000183ABFFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogBodyPing ShallowCopy() => default; // 0x0000000183ABF6E0-0x0000000183ABF780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ABE9B0-0x0000000183ABEA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AC0180-0x0000000183AC01D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AC01D0-0x0000000183AC0220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ABEA00-0x0000000183ABEAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ABEC30-0x0000000183ABED00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientLogBodyPing other) => default; // 0x0000000183ABED00-0x0000000183ABEFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ABF870-0x0000000183ABFB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AC09C0-0x0000000183AC0F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AC0330-0x0000000183AC0690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ABF0A0-0x0000000183ABF460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientLogBodyPing other) {} // 0x0000000183ABE5B0-0x0000000183ABE870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ABE2E0-0x0000000183ABE4B0
}

