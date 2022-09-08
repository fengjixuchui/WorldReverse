/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineActivityDetailInfo : MessageBase, IMessage<DragonSpineActivityDetailInfo> // TypeDefIndex: 22045
{
	// Fields
	private static readonly MessageParser<DragonSpineActivityDetailInfo> _parser; // 0x00
	public const int ChapterInfoListFieldNumber = 1; // Metadata: 0x00B00A5F
	private static readonly FieldCodec<DragonSpineChapterInfo> _repeated_chapterInfoList_codec; // 0x08
	private readonly RepeatedMessageField<DragonSpineChapterInfo> chapterInfoList_; // 0x18
	public const int WeaponEnhanceLevelFieldNumber = 2; // Metadata: 0x00B00A63
	private uint weaponEnhanceLevel_; // 0x20
	public const int ShimmeringEssenceFieldNumber = 3; // Metadata: 0x00B00A67
	private uint shimmeringEssence_; // 0x24
	public const int WarmEssenceFieldNumber = 4; // Metadata: 0x00B00A6B
	private uint warmEssence_; // 0x28
	public const int WondrousEssenceFieldNumber = 5; // Metadata: 0x00B00A6F
	private uint wondrousEssence_; // 0x2C
	public const int IsContentClosedFieldNumber = 6; // Metadata: 0x00B00A73
	private bool isContentClosed_; // 0x30
	public const int ContentFinishTimeFieldNumber = 7; // Metadata: 0x00B00A77
	private uint contentFinishTime_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineActivityDetailInfo> Parser { get => default; } // 0x00000001829F6030-0x00000001829F60C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829F5C80-0x00000001829F5D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829F57F0-0x00000001829F5870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001829F49F0-0x00000001829F4A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829F66A0-0x00000001829F6790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829F62D0-0x00000001829F6330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829F5DB0-0x00000001829F5EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829F6650-0x00000001829F66A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001829F5910-0x00000001829F5A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DragonSpineChapterInfo> ChapterInfoList { get => default; } // 0x00000001829F6270-0x00000001829F62D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponEnhanceLevel { get => default; set {} } // 0x00000001829F4B90-0x00000001829F4C30 0x00000001829F4A50-0x00000001829F4AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShimmeringEssence { get => default; set {} } // 0x00000001829F5750-0x00000001829F57F0 0x00000001829F5F90-0x00000001829F6030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WarmEssence { get => default; set {} } // 0x00000001829F5100-0x00000001829F51A0 0x00000001829F5D10-0x00000001829F5DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WondrousEssence { get => default; set {} } // 0x00000001829F56B0-0x00000001829F5750 0x00000001829F4E50-0x00000001829F4EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x00000001829F4AF0-0x00000001829F4B90 0x00000001829F5060-0x00000001829F5100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentFinishTime { get => default; set {} } // 0x00000001829F65B0-0x00000001829F6650 0x00000001829F5BE0-0x00000001829F5C80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineActivityDetailInfo() {} // 0x00000001829F6D40-0x00000001829F6DD0
	static DragonSpineActivityDetailInfo() {} // 0x00000001829F6C30-0x00000001829F6D40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineActivityDetailInfo Clone() => default; // 0x00000001829F5EA0-0x00000001829F5F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineActivityDetailInfo ShallowCopy() => default; // 0x00000001829F5870-0x00000001829F5910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829F4EF0-0x00000001829F4F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829F6150-0x00000001829F61E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829F61E0-0x00000001829F6270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001829F4F40-0x00000001829F5060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829F5360-0x00000001829F5430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineActivityDetailInfo other) => default; // 0x00000001829F51A0-0x00000001829F5360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001829F5A00-0x00000001829F5BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001829F6790-0x00000001829F6C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001829F6330-0x00000001829F65B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001829F5430-0x00000001829F56B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineActivityDetailInfo other) {} // 0x00000001829F4C30-0x00000001829F4E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829F4800-0x00000001829F49F0
}

