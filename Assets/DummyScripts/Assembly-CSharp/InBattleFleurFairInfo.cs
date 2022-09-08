/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleFleurFairInfo : MessageBase, IMessage<InBattleFleurFairInfo> // TypeDefIndex: 24111
{
	// Fields
	private static readonly MessageParser<InBattleFleurFairInfo> _parser; // 0x00
	public const int AbilityGroupIdListFieldNumber = 1; // Metadata: 0x00B059B7
	private static readonly FieldCodec<uint> _repeated_abilityGroupIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> abilityGroupIdList_; // 0x18
	public const int GalleryIdListFieldNumber = 2; // Metadata: 0x00B059BB
	private static readonly FieldCodec<uint> _repeated_galleryIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> galleryIdList_; // 0x20
	public const int PreviewStageIndexFieldNumber = 3; // Metadata: 0x00B059BF
	private uint previewStageIndex_; // 0x28
	public const int PreviewDisplayDurationFieldNumber = 4; // Metadata: 0x00B059C3
	private uint previewDisplayDuration_; // 0x2C
	public const int GalleryStageIndexFieldNumber = 5; // Metadata: 0x00B059C7
	private uint galleryStageIndex_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleFleurFairInfo> Parser { get => default; } // 0x0000000181A86670-0x0000000181A86700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A86360-0x0000000181A863F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A85F30-0x0000000181A85FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A854A0-0x0000000181A85500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A86B30-0x0000000181A86C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A86890-0x0000000181A868F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A863F0-0x0000000181A864E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A86AE0-0x0000000181A86B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A86050-0x0000000181A86140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AbilityGroupIdList { get => default; } // 0x0000000181A86C20-0x0000000181A86C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> GalleryIdList { get => default; } // 0x0000000181A86700-0x0000000181A86760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreviewStageIndex { get => default; set {} } // 0x0000000181A85500-0x0000000181A855A0 0x0000000181A857F0-0x0000000181A85890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreviewDisplayDuration { get => default; set {} } // 0x0000000181A85A20-0x0000000181A85AC0 0x0000000181A865D0-0x0000000181A86670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryStageIndex { get => default; set {} } // 0x0000000181A85750-0x0000000181A857F0 0x0000000181A862C0-0x0000000181A86360

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleFleurFairInfo() {} // 0x0000000181A870F0-0x0000000181A871A0
	static InBattleFleurFairInfo() {} // 0x0000000181A86FF0-0x0000000181A870F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleFleurFairInfo Clone() => default; // 0x0000000181A864E0-0x0000000181A865D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleFleurFairInfo ShallowCopy() => default; // 0x0000000181A85FB0-0x0000000181A86050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A85890-0x0000000181A858E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A867F0-0x0000000181A86840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A86840-0x0000000181A86890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A858E0-0x0000000181A85A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A85AC0-0x0000000181A85B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleFleurFairInfo other) => default; // 0x0000000181A85B90-0x0000000181A85D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A86140-0x0000000181A862C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A86C80-0x0000000181A86FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A868F0-0x0000000181A86AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A85D20-0x0000000181A85F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleFleurFairInfo other) {} // 0x0000000181A855A0-0x0000000181A85750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A85290-0x0000000181A854A0
}

