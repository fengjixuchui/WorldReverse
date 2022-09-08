/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeAchievementRewardReq : MessageBase, IMessage<TakeAchievementRewardReq> // TypeDefIndex: 21837
{
	// Fields
	private static readonly MessageParser<TakeAchievementRewardReq> _parser; // 0x00
	public const int IdListFieldNumber = 1; // Metadata: 0x00B001B3
	private static readonly FieldCodec<uint> _repeated_idList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> idList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeAchievementRewardReq> Parser { get => default; } // 0x00000001818B0000-0x00000001818B0090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818AFD90-0x00000001818AFE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818AFAC0-0x00000001818AFB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818AF520-0x00000001818AF580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818B0370-0x00000001818B0460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818B01C0-0x00000001818B0220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818AFE20-0x00000001818AFF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818B0320-0x00000001818B0370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818AFBE0-0x00000001818AFCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> IdList { get => default; } // 0x00000001818AF7A0-0x00000001818AF800 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21838
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21839
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2653
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardReq() {} // 0x00000001818B0690-0x00000001818B0720
	static TakeAchievementRewardReq() {} // 0x00000001818B05B0-0x00000001818B0690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardReq Clone() => default; // 0x00000001818AFF10-0x00000001818B0000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardReq ShallowCopy() => default; // 0x00000001818AFB40-0x00000001818AFBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818AF690-0x00000001818AF6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818B0120-0x00000001818B0170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818B0170-0x00000001818B01C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818AF6E0-0x00000001818AF7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818AF900-0x00000001818AF9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeAchievementRewardReq other) => default; // 0x00000001818AF800-0x00000001818AF900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818AFCD0-0x00000001818AFD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818B0460-0x00000001818B05B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818B0220-0x00000001818B0320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818AF9D0-0x00000001818AFAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeAchievementRewardReq other) {} // 0x00000001818AF580-0x00000001818AF690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818AF3E0-0x00000001818AF520
}

