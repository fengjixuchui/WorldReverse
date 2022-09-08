/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayRewardInfo : MessageBase, IMessage<MpPlayRewardInfo> // TypeDefIndex: 26036
{
	// Fields
	private static readonly MessageParser<MpPlayRewardInfo> _parser; // 0x00
	public const int ResinFieldNumber = 1; // Metadata: 0x00B0ACBF
	private uint resin_; // 0x18
	public const int RemainUidListFieldNumber = 2; // Metadata: 0x00B0ACC3
	private static readonly FieldCodec<uint> _repeated_remainUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> remainUidList_; // 0x20
	public const int QualifyUidListFieldNumber = 3; // Metadata: 0x00B0ACC7
	private static readonly FieldCodec<uint> _repeated_qualifyUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> qualifyUidList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayRewardInfo> Parser { get => default; } // 0x0000000184C54DE0-0x0000000184C54E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C54B10-0x0000000184C54BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C54780-0x0000000184C54800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C53F70-0x0000000184C53FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C551C0-0x0000000184C552B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C54FA0-0x0000000184C55000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C54C00-0x0000000184C54CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C55170-0x0000000184C551C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C548A0-0x0000000184C54990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x0000000184C54340-0x0000000184C543E0 0x0000000184C53FD0-0x0000000184C54070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemainUidList { get => default; } // 0x0000000184C54AB0-0x0000000184C54B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> QualifyUidList { get => default; } // 0x0000000184C54BA0-0x0000000184C54C00 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayRewardInfo() {} // 0x0000000184C55610-0x0000000184C556C0
	static MpPlayRewardInfo() {} // 0x0000000184C55510-0x0000000184C55610

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayRewardInfo Clone() => default; // 0x0000000184C54CF0-0x0000000184C54DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayRewardInfo ShallowCopy() => default; // 0x0000000184C54800-0x0000000184C548A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C541C0-0x0000000184C54210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C54F00-0x0000000184C54F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C54F50-0x0000000184C54FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C54210-0x0000000184C54340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C543E0-0x0000000184C544B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayRewardInfo other) => default; // 0x0000000184C544B0-0x0000000184C54600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C54990-0x0000000184C54AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C552B0-0x0000000184C55510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C55000-0x0000000184C55170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C54600-0x0000000184C54780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayRewardInfo other) {} // 0x0000000184C54070-0x0000000184C541C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C53D90-0x0000000184C53F70
}

