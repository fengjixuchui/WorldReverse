/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairGallerySettleInfo : MessageBase, IMessage<FleurFairGallerySettleInfo> // TypeDefIndex: 24166
{
	// Fields
	private static readonly MessageParser<FleurFairGallerySettleInfo> _parser; // 0x00
	public const int IsSuccessFieldNumber = 1; // Metadata: 0x00B05BF7
	private bool isSuccess_; // 0x18
	public const int EnergyFieldNumber = 2; // Metadata: 0x00B05BFB
	private uint energy_; // 0x1C
	public const int GalleryStageCountFieldNumber = 3; // Metadata: 0x00B05BFF
	private uint galleryStageCount_; // 0x20
	public const int GalleryStageIndexFieldNumber = 4; // Metadata: 0x00B05C03
	private uint galleryStageIndex_; // 0x24
	public const int EnergyStatMapFieldNumber = 5; // Metadata: 0x00B05C07
	private static readonly MapField<uint, int> _map_energyStatMap_codec; // 0x08
	private readonly MapField<uint, int> energyStatMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairGallerySettleInfo> Parser { get => default; } // 0x0000000182608390-0x0000000182608420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182607FE0-0x0000000182608070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182607AD0-0x0000000182607B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826070F0-0x0000000182607150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182608890-0x0000000182608980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826085F0-0x0000000182608650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182608070-0x0000000182608160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182608840-0x0000000182608890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182607BF0-0x0000000182607CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000182608550-0x00000001826085F0 0x0000000182607150-0x00000001826071F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Energy { get => default; set {} } // 0x0000000182607F40-0x0000000182607FE0 0x0000000182607570-0x0000000182607610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryStageCount { get => default; set {} } // 0x0000000182608250-0x00000001826082F0 0x00000001826082F0-0x0000000182608390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryStageIndex { get => default; set {} } // 0x0000000182607390-0x0000000182607430 0x0000000182607EA0-0x0000000182607F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, int> EnergyStatMap { get => default; } // 0x0000000182607610-0x0000000182607670 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairGallerySettleInfo() {} // 0x0000000182608E40-0x0000000182608ED0
	static FleurFairGallerySettleInfo() {} // 0x0000000182608D10-0x0000000182608E40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairGallerySettleInfo Clone() => default; // 0x0000000182608160-0x0000000182608250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairGallerySettleInfo ShallowCopy() => default; // 0x0000000182607B50-0x0000000182607BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182607430-0x0000000182607480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826084B0-0x0000000182608500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182608500-0x0000000182608550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182607480-0x0000000182607570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182607670-0x0000000182607740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairGallerySettleInfo other) => default; // 0x0000000182607740-0x00000001826078E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182607CE0-0x0000000182607EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182608980-0x0000000182608D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182608650-0x0000000182608840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826078E0-0x0000000182607AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairGallerySettleInfo other) {} // 0x00000001826071F0-0x0000000182607390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182606F30-0x00000001826070F0
}

