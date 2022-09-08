/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayStopNotify : MessageBase, IMessage<GadgetPlayStopNotify> // TypeDefIndex: 23204
{
	// Fields
	private static readonly MessageParser<GadgetPlayStopNotify> _parser; // 0x00
	public const int PlayTypeFieldNumber = 1; // Metadata: 0x00B0379B
	private uint playType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B0379F
	private uint entityId_; // 0x1C
	public const int IsWinFieldNumber = 3; // Metadata: 0x00B037A3
	private bool isWin_; // 0x20
	public const int CostTimeFieldNumber = 4; // Metadata: 0x00B037A7
	private uint costTime_; // 0x24
	public const int UidInfoListFieldNumber = 5; // Metadata: 0x00B037AB
	private static readonly FieldCodec<GadgetPlayUidInfo> _repeated_uidInfoList_codec; // 0x08
	private readonly RepeatedMessageField<GadgetPlayUidInfo> uidInfoList_; // 0x28
	public const int ScoreFieldNumber = 6; // Metadata: 0x00B037AF
	private uint score_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayStopNotify> Parser { get => default; } // 0x00000001816A4920-0x00000001816A49B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816A4610-0x00000001816A46A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001816A4250-0x00000001816A42D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816A3760-0x00000001816A37C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816A5030-0x00000001816A5120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816A4CA0-0x00000001816A4D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816A4740-0x00000001816A4830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001816A4FE0-0x00000001816A5030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816A4370-0x00000001816A4460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x00000001816A4D00-0x00000001816A4DA0 0x00000001816A3D00-0x00000001816A3DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001816A4C00-0x00000001816A4CA0 0x00000001816A5120-0x00000001816A51C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsWin { get => default; set {} } // 0x00000001816A3860-0x00000001816A3900 0x00000001816A51C0-0x00000001816A5260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostTime { get => default; set {} } // 0x00000001816A4A40-0x00000001816A4AE0 0x00000001816A3900-0x00000001816A39A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GadgetPlayUidInfo> UidInfoList { get => default; } // 0x00000001816A5260-0x00000001816A52C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x00000001816A46A0-0x00000001816A4740 0x00000001816A37C0-0x00000001816A3860

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23205
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23206
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 810
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStopNotify() {} // 0x00000001816A57E0-0x00000001816A5870
	static GadgetPlayStopNotify() {} // 0x00000001816A56D0-0x00000001816A57E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStopNotify Clone() => default; // 0x00000001816A4830-0x00000001816A4920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStopNotify ShallowCopy() => default; // 0x00000001816A42D0-0x00000001816A4370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001816A3BA0-0x00000001816A3BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816A4AE0-0x00000001816A4B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816A4B70-0x00000001816A4C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001816A3BF0-0x00000001816A3D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816A3DA0-0x00000001816A3E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayStopNotify other) => default; // 0x00000001816A3E70-0x00000001816A4020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816A4460-0x00000001816A4610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001816A52C0-0x00000001816A56D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001816A4DA0-0x00000001816A4FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816A4020-0x00000001816A4250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayStopNotify other) {} // 0x00000001816A39A0-0x00000001816A3BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816A3580-0x00000001816A3760
}

