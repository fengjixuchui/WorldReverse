/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityCondStateChangeNotify : MessageBase, IMessage<ActivityCondStateChangeNotify> // TypeDefIndex: 21951
{
	// Fields
	private static readonly MessageParser<ActivityCondStateChangeNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B006E3
	private uint scheduleId_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B006E7
	private uint activityId_; // 0x1C
	public const int MeetCondListFieldNumber = 3; // Metadata: 0x00B006EB
	private static readonly FieldCodec<uint> _repeated_meetCondList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> meetCondList_; // 0x20
	public const int ExpireCondListFieldNumber = 4; // Metadata: 0x00B006EF
	private static readonly FieldCodec<uint> _repeated_expireCondList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> expireCondList_; // 0x28
	public const int ActivatedSaleIdListFieldNumber = 5; // Metadata: 0x00B006F3
	private static readonly FieldCodec<uint> _repeated_activatedSaleIdList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> activatedSaleIdList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityCondStateChangeNotify> Parser { get => default; } // 0x0000000183D324E0-0x0000000183D32570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D32210-0x0000000183D322A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D31E90-0x0000000183D31F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D31450-0x0000000183D314B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D32A70-0x0000000183D32B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D32740-0x0000000183D327A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D32300-0x0000000183D323F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D32A20-0x0000000183D32A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D31FB0-0x0000000183D320A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000183D31930-0x0000000183D319D0 0x0000000183D327A0-0x0000000183D32840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183D326A0-0x0000000183D32740 0x0000000183D31510-0x0000000183D315B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MeetCondList { get => default; } // 0x0000000183D319D0-0x0000000183D31A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExpireCondList { get => default; } // 0x0000000183D314B0-0x0000000183D31510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ActivatedSaleIdList { get => default; } // 0x0000000183D322A0-0x0000000183D32300 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21952
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21953
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2035
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCondStateChangeNotify() {} // 0x0000000183D32FD0-0x0000000183D330A0
	static ActivityCondStateChangeNotify() {} // 0x0000000183D32EB0-0x0000000183D32FD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCondStateChangeNotify Clone() => default; // 0x0000000183D323F0-0x0000000183D324E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCondStateChangeNotify ShallowCopy() => default; // 0x0000000183D31F10-0x0000000183D31FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D31750-0x0000000183D317A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D32600-0x0000000183D32650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D32650-0x0000000183D326A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D317A0-0x0000000183D31930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D31BD0-0x0000000183D31CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityCondStateChangeNotify other) => default; // 0x0000000183D31A30-0x0000000183D31BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D320A0-0x0000000183D32210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D32B60-0x0000000183D32EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D32840-0x0000000183D32A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D31CA0-0x0000000183D31E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityCondStateChangeNotify other) {} // 0x0000000183D315B0-0x0000000183D31750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D311E0-0x0000000183D31450
}

