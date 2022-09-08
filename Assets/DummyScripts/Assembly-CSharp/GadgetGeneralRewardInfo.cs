/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetGeneralRewardInfo : MessageBase, IMessage<GadgetGeneralRewardInfo> // TypeDefIndex: 26037
{
	// Fields
	private static readonly MessageParser<GadgetGeneralRewardInfo> _parser; // 0x00
	public const int ResinFieldNumber = 1; // Metadata: 0x00B0ACCB
	private uint resin_; // 0x18
	public const int DeadTimeFieldNumber = 2; // Metadata: 0x00B0ACCF
	private uint deadTime_; // 0x1C
	public const int RemainUidListFieldNumber = 3; // Metadata: 0x00B0ACD3
	private static readonly FieldCodec<uint> _repeated_remainUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> remainUidList_; // 0x20
	public const int QualifyUidListFieldNumber = 4; // Metadata: 0x00B0ACD7
	private static readonly FieldCodec<uint> _repeated_qualifyUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> qualifyUidList_; // 0x28
	public const int ItemParamFieldNumber = 5; // Metadata: 0x00B0ACDB
	private ItemParam itemParam_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetGeneralRewardInfo> Parser { get => default; } // 0x0000000184089F80-0x000000018408A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184089B70-0x0000000184089C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184089700-0x0000000184089780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184088B70-0x0000000184088BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018408A440-0x000000018408A530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018408A1A0-0x000000018408A200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184089C60-0x0000000184089D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018408A3F0-0x000000018408A440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184089820-0x0000000184089910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x0000000184089180-0x0000000184089220 0x0000000184088C70-0x0000000184088D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DeadTime { get => default; set {} } // 0x0000000184088BD0-0x0000000184088C70 0x0000000184089E40-0x0000000184089EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemainUidList { get => default; } // 0x0000000184089B10-0x0000000184089B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> QualifyUidList { get => default; } // 0x0000000184089C00-0x0000000184089C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam ItemParam { get => default; set {} } // 0x000000018408A530-0x000000018408A5D0 0x0000000184089EE0-0x0000000184089F80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfo() {} // 0x000000018408AA20-0x000000018408AAD0
	static GadgetGeneralRewardInfo() {} // 0x000000018408A920-0x000000018408AA20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfo Clone() => default; // 0x0000000184089D50-0x0000000184089E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfo ShallowCopy() => default; // 0x0000000184089780-0x0000000184089820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184088F00-0x0000000184088F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018408A0A0-0x000000018408A120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018408A120-0x000000018408A1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184088F80-0x0000000184089180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184089220-0x00000001840892F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetGeneralRewardInfo other) => default; // 0x00000001840892F0-0x0000000184089490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184089910-0x0000000184089B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018408A5D0-0x000000018408A920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018408A200-0x000000018408A3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184089490-0x0000000184089700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetGeneralRewardInfo other) {} // 0x0000000184088D10-0x0000000184088F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184088910-0x0000000184088B70
}

