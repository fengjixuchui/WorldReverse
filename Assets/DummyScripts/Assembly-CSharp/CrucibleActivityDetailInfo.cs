/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CrucibleActivityDetailInfo : MessageBase, IMessage<CrucibleActivityDetailInfo> // TypeDefIndex: 21987
{
	// Fields
	private static readonly MessageParser<CrucibleActivityDetailInfo> _parser; // 0x00
	public const int CostTimeFieldNumber = 1; // Metadata: 0x00B00823
	private uint costTime_; // 0x18
	public const int UidInfoListFieldNumber = 2; // Metadata: 0x00B00827
	private static readonly FieldCodec<CrucibleBattleUidInfo> _repeated_uidInfoList_codec; // 0x08
	private readonly RepeatedMessageField<CrucibleBattleUidInfo> uidInfoList_; // 0x20
	public const int PosFieldNumber = 3; // Metadata: 0x00B0082B
	private Vector pos_; // 0x28
	public const int BattleWorldLevelFieldNumber = 4; // Metadata: 0x00B0082F
	private uint battleWorldLevel_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CrucibleActivityDetailInfo> Parser { get => default; } // 0x0000000183653A50-0x0000000183653AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836537E0-0x0000000183653870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183653360-0x00000001836533E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836529A0-0x0000000183652A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836541A0-0x0000000183654290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183653E90-0x0000000183653EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183653870-0x0000000183653960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183654150-0x00000001836541A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183653480-0x0000000183653570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostTime { get => default; set {} } // 0x0000000183653C10-0x0000000183653CB0 0x0000000183652A00-0x0000000183652AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CrucibleBattleUidInfo> UidInfoList { get => default; } // 0x0000000183654290-0x00000001836542F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000183653DF0-0x0000000183653E90 0x00000001836540B0-0x0000000183654150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BattleWorldLevel { get => default; set {} } // 0x0000000183653740-0x00000001836537E0 0x0000000183653AE0-0x0000000183653B80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleActivityDetailInfo() {} // 0x00000001836546E0-0x0000000183654770
	static CrucibleActivityDetailInfo() {} // 0x00000001836545D0-0x00000001836546E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleActivityDetailInfo Clone() => default; // 0x0000000183653960-0x0000000183653A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleActivityDetailInfo ShallowCopy() => default; // 0x00000001836533E0-0x0000000183653480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183652CA0-0x0000000183652D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183653CB0-0x0000000183653D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183653D50-0x0000000183653DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183652D20-0x0000000183652ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183652ED0-0x0000000183652FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CrucibleActivityDetailInfo other) => default; // 0x0000000183652FA0-0x0000000183653120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183653570-0x0000000183653740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836542F0-0x00000001836545D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183653EF0-0x00000001836540B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183653120-0x0000000183653360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CrucibleActivityDetailInfo other) {} // 0x0000000183652AA0-0x0000000183652CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836527D0-0x00000001836529A0
}

