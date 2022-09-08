/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GeneralMatchInfo : MessageBase, IMessage<GeneralMatchInfo> // TypeDefIndex: 23844
{
	// Fields
	private static readonly MessageParser<GeneralMatchInfo> _parser; // 0x00
	public const int MatchIdFieldNumber = 1; // Metadata: 0x00B04F5B
	private uint matchId_; // 0x18
	public const int PlayerListFieldNumber = 2; // Metadata: 0x00B04F5F
	private static readonly FieldCodec<MatchPlayerInfo> _repeated_playerList_codec; // 0x08
	private readonly RepeatedMessageField<MatchPlayerInfo> playerList_; // 0x20
	public const int MatchParamFieldNumber = 3; // Metadata: 0x00B04F63
	private uint matchParam_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GeneralMatchInfo> Parser { get => default; } // 0x0000000182A74900-0x0000000182A74990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A745F0-0x0000000182A74680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A742B0-0x0000000182A74330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A73A90-0x0000000182A73AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A74E70-0x0000000182A74F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A74B40-0x0000000182A74BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A74680-0x0000000182A74770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A74E20-0x0000000182A74E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A743D0-0x0000000182A744C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x0000000182A73E60-0x0000000182A73F00 0x0000000182A73AF0-0x0000000182A73B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MatchPlayerInfo> PlayerList { get => default; } // 0x0000000182A74DC0-0x0000000182A74E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchParam { get => default; set {} } // 0x0000000182A74860-0x0000000182A74900 0x0000000182A74BA0-0x0000000182A74C40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GeneralMatchInfo() {} // 0x0000000182A752E0-0x0000000182A75370
	static GeneralMatchInfo() {} // 0x0000000182A751D0-0x0000000182A752E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GeneralMatchInfo Clone() => default; // 0x0000000182A74770-0x0000000182A74860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GeneralMatchInfo ShallowCopy() => default; // 0x0000000182A74330-0x0000000182A743D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A73D20-0x0000000182A73D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A74A20-0x0000000182A74AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A74AB0-0x0000000182A74B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A73D70-0x0000000182A73E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A73F00-0x0000000182A73FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GeneralMatchInfo other) => default; // 0x0000000182A73FD0-0x0000000182A74120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A744C0-0x0000000182A745F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A74F60-0x0000000182A751D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A74C40-0x0000000182A74DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A74120-0x0000000182A742B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GeneralMatchInfo other) {} // 0x0000000182A73B90-0x0000000182A73D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A73910-0x0000000182A73A90
}

