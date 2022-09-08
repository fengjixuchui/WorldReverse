/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityScheduleInfoNotify : MessageBase, IMessage<ActivityScheduleInfoNotify> // TypeDefIndex: 21870
{
	// Fields
	private static readonly MessageParser<ActivityScheduleInfoNotify> _parser; // 0x00
	public const int ActivityScheduleListFieldNumber = 1; // Metadata: 0x00B003A7
	private static readonly FieldCodec<ActivityScheduleInfo> _repeated_activityScheduleList_codec; // 0x08
	private readonly RepeatedMessageField<ActivityScheduleInfo> activityScheduleList_; // 0x18
	public const int RemainFlySeaLampNumFieldNumber = 2; // Metadata: 0x00B003AB
	private uint remainFlySeaLampNum_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityScheduleInfoNotify> Parser { get => default; } // 0x0000000182AD2AA0-0x0000000182AD2B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AD2730-0x0000000182AD27C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AD2420-0x0000000182AD24A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AD1DF0-0x0000000182AD1E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AD2F70-0x0000000182AD3060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AD2CE0-0x0000000182AD2D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AD28C0-0x0000000182AD29B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AD2F20-0x0000000182AD2F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AD2540-0x0000000182AD2630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ActivityScheduleInfo> ActivityScheduleList { get => default; } // 0x0000000182AD27C0-0x0000000182AD2820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainFlySeaLampNum { get => default; set {} } // 0x0000000182AD2820-0x0000000182AD28C0 0x0000000182AD2D40-0x0000000182AD2DE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21871
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21872
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2007
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfoNotify() {} // 0x0000000182AD3350-0x0000000182AD33E0
	static ActivityScheduleInfoNotify() {} // 0x0000000182AD3240-0x0000000182AD3350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfoNotify Clone() => default; // 0x0000000182AD29B0-0x0000000182AD2AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfoNotify ShallowCopy() => default; // 0x0000000182AD24A0-0x0000000182AD2540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AD1FC0-0x0000000182AD2010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AD2BC0-0x0000000182AD2C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AD2C50-0x0000000182AD2CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AD2010-0x0000000182AD20F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AD20F0-0x0000000182AD21C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityScheduleInfoNotify other) => default; // 0x0000000182AD21C0-0x0000000182AD22E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AD2630-0x0000000182AD2730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AD3060-0x0000000182AD3240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AD2DE0-0x0000000182AD2F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AD22E0-0x0000000182AD2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityScheduleInfoNotify other) {} // 0x0000000182AD1E50-0x0000000182AD1FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AD1C90-0x0000000182AD1DF0
}

