/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairStageSettleNotify : MessageBase, IMessage<FleurFairStageSettleNotify> // TypeDefIndex: 24169
{
	// Fields
	private static readonly MessageParser<FleurFairStageSettleNotify> _parser; // 0x00
	public const int StageTypeFieldNumber = 1; // Metadata: 0x00B05C37
	private uint stageType_; // 0x18
	public const int GallerySettleInfoFieldNumber = 11; // Metadata: 0x00B05C3B
	public const int BossSettleInfoFieldNumber = 12; // Metadata: 0x00B05C3F
	private object detail_; // 0x20
	private DetailOneofCase detailCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairStageSettleNotify> Parser { get => default; } // 0x0000000183E642F0-0x0000000183E64380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E64080-0x0000000183E64110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E63C90-0x0000000183E63D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E62FC0-0x0000000183E63020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E64920-0x0000000183E64A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E64720-0x0000000183E64780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E64110-0x0000000183E64200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E648D0-0x0000000183E64920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E63DB0-0x0000000183E63EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageType { get => default; set {} } // 0x0000000183E63150-0x0000000183E631F0 0x0000000183E63FE0-0x0000000183E64080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairGallerySettleInfo GallerySettleInfo { get => default; set {} } // 0x0000000183E63020-0x0000000183E630F0 0x0000000183E635B0-0x0000000183E63650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBossSettleInfo BossSettleInfo { get => default; set {} } // 0x0000000183E64650-0x0000000183E64720 0x0000000183E63BF0-0x0000000183E63C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x0000000183E634E0-0x0000000183E63540 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 24170
	{
		None = 0,
		GallerySettleInfo = 11,
		BossSettleInfo = 12
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24171
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24172
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5342
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairStageSettleNotify() {} // 0x0000000183E64D80-0x0000000183E64DF0
	static FleurFairStageSettleNotify() {} // 0x0000000183E64CC0-0x0000000183E64D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairStageSettleNotify Clone() => default; // 0x0000000183E64200-0x0000000183E642F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairStageSettleNotify ShallowCopy() => default; // 0x0000000183E63D10-0x0000000183E63DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E633C0-0x0000000183E634E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E64410-0x0000000183E64530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E64530-0x0000000183E64650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E63540-0x0000000183E635B0
	public void resetDetail() {} // 0x0000000183E63A20-0x0000000183E63BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x0000000183E630F0-0x0000000183E63150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E637D0-0x0000000183E638A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairStageSettleNotify other) => default; // 0x0000000183E63650-0x0000000183E637D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E63EA0-0x0000000183E63FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E64A10-0x0000000183E64CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E64780-0x0000000183E648D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E638A0-0x0000000183E63A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairStageSettleNotify other) {} // 0x0000000183E631F0-0x0000000183E633C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E62DC0-0x0000000183E62FC0
}

