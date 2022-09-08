/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarFetterInfo : MessageBase, IMessage<AvatarFetterInfo> // TypeDefIndex: 26067
{
	// Fields
	private static readonly MessageParser<AvatarFetterInfo> _parser; // 0x00
	public const int ExpNumberFieldNumber = 1; // Metadata: 0x00B0AF4B
	private uint expNumber_; // 0x18
	public const int ExpLevelFieldNumber = 2; // Metadata: 0x00B0AF4F
	private uint expLevel_; // 0x1C
	public const int OpenIdListFieldNumber = 3; // Metadata: 0x00B0AF53
	private static readonly FieldCodec<uint> _repeated_openIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> openIdList_; // 0x20
	public const int FinishIdListFieldNumber = 4; // Metadata: 0x00B0AF57
	private static readonly FieldCodec<uint> _repeated_finishIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> finishIdList_; // 0x28
	public const int RewardedFetterLevelListFieldNumber = 5; // Metadata: 0x00B0AF5B
	private static readonly FieldCodec<uint> _repeated_rewardedFetterLevelList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> rewardedFetterLevelList_; // 0x30
	public const int FetterListFieldNumber = 6; // Metadata: 0x00B0AF5F
	private static readonly FieldCodec<FetterData> _repeated_fetterList_codec; // 0x20
	private readonly RepeatedMessageField<FetterData> fetterList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarFetterInfo> Parser { get => default; } // 0x00000001845D9270-0x00000001845D9300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845D8EC0-0x00000001845D8F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845D8B10-0x00000001845D8B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845D80F0-0x00000001845D8150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845D9910-0x00000001845D9A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845D94B0-0x00000001845D9510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845D9090-0x00000001845D9180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845D9860-0x00000001845D98B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845D8C30-0x00000001845D8D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpNumber { get => default; set {} } // 0x00000001845D9510-0x00000001845D95B0 0x00000001845D8F50-0x00000001845D8FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpLevel { get => default; set {} } // 0x00000001845D8FF0-0x00000001845D9090 0x00000001845D95B0-0x00000001845D9650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OpenIdList { get => default; } // 0x00000001845D9A00-0x00000001845D9A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishIdList { get => default; } // 0x00000001845D83F0-0x00000001845D8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RewardedFetterLevelList { get => default; } // 0x00000001845D8150-0x00000001845D81B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FetterData> FetterList { get => default; } // 0x00000001845D98B0-0x00000001845D9910 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterInfo() {} // 0x00000001845D9FA0-0x00000001845DA0A0
	static AvatarFetterInfo() {} // 0x00000001845D9E30-0x00000001845D9FA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterInfo Clone() => default; // 0x00000001845D9180-0x00000001845D9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterInfo ShallowCopy() => default; // 0x00000001845D8B90-0x00000001845D8C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845D83A0-0x00000001845D83F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D9390-0x00000001845D9420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D9420-0x00000001845D94B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845D8450-0x00000001845D8650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845D8650-0x00000001845D8720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarFetterInfo other) => default; // 0x00000001845D8720-0x00000001845D88F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845D8D20-0x00000001845D8EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845D9A60-0x00000001845D9E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845D9650-0x00000001845D9860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845D88F0-0x00000001845D8B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarFetterInfo other) {} // 0x00000001845D81B0-0x00000001845D83A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845D7E00-0x00000001845D80F0
}

