/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopRewardUpdateNotify : MessageBase, IMessage<CoopRewardUpdateNotify> // TypeDefIndex: 22714
{
	// Fields
	private static readonly MessageParser<CoopRewardUpdateNotify> _parser; // 0x00
	public const int RewardListFieldNumber = 1; // Metadata: 0x00B0236B
	private static readonly FieldCodec<CoopReward> _repeated_rewardList_codec; // 0x08
	private readonly RepeatedMessageField<CoopReward> rewardList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopRewardUpdateNotify> Parser { get => default; } // 0x00000001851B3AE0-0x00000001851B3B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851B3870-0x00000001851B3900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851B3540-0x00000001851B35C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851B2FC0-0x00000001851B3020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851B3ED0-0x00000001851B3FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851B3D20-0x00000001851B3D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851B3900-0x00000001851B39F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851B3E80-0x00000001851B3ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851B3660-0x00000001851B3750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CoopReward> RewardList { get => default; } // 0x00000001851B3810-0x00000001851B3870 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22715
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22716
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1960
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopRewardUpdateNotify() {} // 0x00000001851B4220-0x00000001851B42B0
	static CoopRewardUpdateNotify() {} // 0x00000001851B4110-0x00000001851B4220

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopRewardUpdateNotify Clone() => default; // 0x00000001851B39F0-0x00000001851B3AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopRewardUpdateNotify ShallowCopy() => default; // 0x00000001851B35C0-0x00000001851B3660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851B3150-0x00000001851B31A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851B3C00-0x00000001851B3C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851B3C90-0x00000001851B3D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851B31A0-0x00000001851B3270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851B3270-0x00000001851B3340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopRewardUpdateNotify other) => default; // 0x00000001851B3340-0x00000001851B3450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851B3750-0x00000001851B3810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851B3FC0-0x00000001851B4110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851B3D80-0x00000001851B3E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851B3450-0x00000001851B3540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopRewardUpdateNotify other) {} // 0x00000001851B3020-0x00000001851B3150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851B2E90-0x00000001851B2FC0
}

