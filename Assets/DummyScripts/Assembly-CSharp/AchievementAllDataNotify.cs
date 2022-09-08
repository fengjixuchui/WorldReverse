/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AchievementAllDataNotify : MessageBase, IMessage<AchievementAllDataNotify> // TypeDefIndex: 21831
{
	// Fields
	private static readonly MessageParser<AchievementAllDataNotify> _parser; // 0x00
	public const int AchievementListFieldNumber = 1; // Metadata: 0x00B00187
	private static readonly FieldCodec<Achievement> _repeated_achievementList_codec; // 0x08
	private readonly RepeatedMessageField<Achievement> achievementList_; // 0x18
	public const int RewardTakenGoalIdListFieldNumber = 2; // Metadata: 0x00B0018B
	private static readonly FieldCodec<uint> _repeated_rewardTakenGoalIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> rewardTakenGoalIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AchievementAllDataNotify> Parser { get => default; } // 0x0000000183DE3D50-0x0000000183DE3DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DE3A80-0x0000000183DE3B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DE3780-0x0000000183DE3800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DE3120-0x0000000183DE3180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DE41D0-0x0000000183DE42C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DE3FF0-0x0000000183DE4050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DE3B70-0x0000000183DE3C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DE4180-0x0000000183DE41D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DE38A0-0x0000000183DE3990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Achievement> AchievementList { get => default; } // 0x0000000183DE3F00-0x0000000183DE3F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RewardTakenGoalIdList { get => default; } // 0x0000000183DE3B10-0x0000000183DE3B70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21832
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21833
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2651
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementAllDataNotify() {} // 0x0000000183DE45B0-0x0000000183DE4660
	static AchievementAllDataNotify() {} // 0x0000000183DE4480-0x0000000183DE45B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementAllDataNotify Clone() => default; // 0x0000000183DE3C60-0x0000000183DE3D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementAllDataNotify ShallowCopy() => default; // 0x0000000183DE3800-0x0000000183DE38A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DE32E0-0x0000000183DE3330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DE3E70-0x0000000183DE3F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DE3F60-0x0000000183DE3FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DE3330-0x0000000183DE3460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DE3590-0x0000000183DE3660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AchievementAllDataNotify other) => default; // 0x0000000183DE3460-0x0000000183DE3590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DE3990-0x0000000183DE3A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DE42C0-0x0000000183DE4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DE4050-0x0000000183DE4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DE3660-0x0000000183DE3780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AchievementAllDataNotify other) {} // 0x0000000183DE3180-0x0000000183DE32E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DE2F70-0x0000000183DE3120
}

