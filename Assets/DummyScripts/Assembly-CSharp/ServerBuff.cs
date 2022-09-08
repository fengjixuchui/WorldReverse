/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerBuff : MessageBase, IMessage<ServerBuff> // TypeDefIndex: 26013
{
	// Fields
	private static readonly MessageParser<ServerBuff> _parser; // 0x00
	public const int ServerBuffUidFieldNumber = 1; // Metadata: 0x00B0AACF
	private uint serverBuffUid_; // 0x18
	public const int ServerBuffIdFieldNumber = 2; // Metadata: 0x00B0AAD3
	private uint serverBuffId_; // 0x1C
	public const int ServerBuffTypeFieldNumber = 3; // Metadata: 0x00B0AAD7
	private uint serverBuffType_; // 0x20
	public const int InstancedModifierIdFieldNumber = 4; // Metadata: 0x00B0AADB
	private uint instancedModifierId_; // 0x24
	public const int DoneOnaddedActionListFieldNumber = 5; // Metadata: 0x00B0AADF
	private static readonly FieldCodec<uint> _repeated_doneOnaddedActionList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> doneOnaddedActionList_; // 0x28
	public const int IsOnaddedActionAllowFieldNumber = 6; // Metadata: 0x00B0AAE3
	private bool isOnaddedActionAllow_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerBuff> Parser { get => default; } // 0x0000000183739640-0x00000001837396D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183739230-0x00000001837392C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183738E70-0x0000000183738EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183738330-0x0000000183738390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183739CD0-0x0000000183739DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837399E0-0x0000000183739A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837393C0-0x00000001837394B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183739C80-0x0000000183739CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183738F90-0x0000000183739080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ServerBuffUid { get => default; set {} } // 0x0000000183738DD0-0x0000000183738E70 0x00000001837397B0-0x0000000183739850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ServerBuffId { get => default; set {} } // 0x00000001837395A0-0x0000000183739640 0x0000000183738600-0x00000001837386A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ServerBuffType { get => default; set {} } // 0x00000001837386A0-0x0000000183738740 0x0000000183739940-0x00000001837399E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x0000000183738390-0x0000000183738430 0x00000001837392C0-0x0000000183739360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DoneOnaddedActionList { get => default; } // 0x0000000183739360-0x00000001837393C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOnaddedActionAllow { get => default; set {} } // 0x0000000183738890-0x0000000183738930 0x0000000183739850-0x00000001837398F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuff() {} // 0x000000018373A2B0-0x000000018373A340
	static ServerBuff() {} // 0x000000018373A1D0-0x000000018373A2B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuff Clone() => default; // 0x00000001837394B0-0x00000001837395A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerBuff ShallowCopy() => default; // 0x0000000183738EF0-0x0000000183738F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183738740-0x0000000183738790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183739760-0x00000001837397B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837398F0-0x0000000183739940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183738790-0x0000000183738890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183738930-0x0000000183738A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerBuff other) => default; // 0x0000000183738A00-0x0000000183738BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183739080-0x0000000183739230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183739DC0-0x000000018373A1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183739A40-0x0000000183739C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183738BA0-0x0000000183738DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerBuff other) {} // 0x0000000183738430-0x0000000183738600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183738150-0x0000000183738330
}

