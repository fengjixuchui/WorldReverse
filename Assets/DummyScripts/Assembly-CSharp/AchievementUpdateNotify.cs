/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AchievementUpdateNotify : MessageBase, IMessage<AchievementUpdateNotify> // TypeDefIndex: 21834
{
	// Fields
	private static readonly MessageParser<AchievementUpdateNotify> _parser; // 0x00
	public const int AchievementListFieldNumber = 1; // Metadata: 0x00B0019F
	private static readonly FieldCodec<Achievement> _repeated_achievementList_codec; // 0x08
	private readonly RepeatedMessageField<Achievement> achievementList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AchievementUpdateNotify> Parser { get => default; } // 0x0000000183D9B540-0x0000000183D9B5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D9B2D0-0x0000000183D9B360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D9B000-0x0000000183D9B080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D9AA80-0x0000000183D9AAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D9B990-0x0000000183D9BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D9B7E0-0x0000000183D9B840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D9B360-0x0000000183D9B450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D9B940-0x0000000183D9B990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D9B120-0x0000000183D9B210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Achievement> AchievementList { get => default; } // 0x0000000183D9B6F0-0x0000000183D9B750 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21835
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21836
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2652
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementUpdateNotify() {} // 0x0000000183D9BCE0-0x0000000183D9BD70
	static AchievementUpdateNotify() {} // 0x0000000183D9BBD0-0x0000000183D9BCE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementUpdateNotify Clone() => default; // 0x0000000183D9B450-0x0000000183D9B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AchievementUpdateNotify ShallowCopy() => default; // 0x0000000183D9B080-0x0000000183D9B120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D9AC10-0x0000000183D9AC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D9B660-0x0000000183D9B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D9B750-0x0000000183D9B7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D9AC60-0x0000000183D9AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D9AE40-0x0000000183D9AF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AchievementUpdateNotify other) => default; // 0x0000000183D9AD30-0x0000000183D9AE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D9B210-0x0000000183D9B2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D9BA80-0x0000000183D9BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D9B840-0x0000000183D9B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D9AF10-0x0000000183D9B000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AchievementUpdateNotify other) {} // 0x0000000183D9AAE0-0x0000000183D9AC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D9A950-0x0000000183D9AA80
}

