/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldOwnerDailyTaskNotify : MessageBase, IMessage<WorldOwnerDailyTaskNotify> // TypeDefIndex: 24448
{
	// Fields
	private static readonly MessageParser<WorldOwnerDailyTaskNotify> _parser; // 0x00
	public const int TaskListFieldNumber = 1; // Metadata: 0x00B06753
	private static readonly FieldCodec<DailyTaskInfo> _repeated_taskList_codec; // 0x08
	private readonly RepeatedMessageField<DailyTaskInfo> taskList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldOwnerDailyTaskNotify> Parser { get => default; } // 0x0000000184357230-0x00000001843572C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184356FC0-0x0000000184357050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184356CF0-0x0000000184356D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184356710-0x0000000184356770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184357620-0x0000000184357710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184357470-0x00000001843574D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184357050-0x0000000184357140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843575D0-0x0000000184357620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184356E10-0x0000000184356F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DailyTaskInfo> TaskList { get => default; } // 0x0000000184356C90-0x0000000184356CF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24449
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24450
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 149
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerDailyTaskNotify() {} // 0x0000000184357970-0x0000000184357A00
	static WorldOwnerDailyTaskNotify() {} // 0x0000000184357860-0x0000000184357970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerDailyTaskNotify Clone() => default; // 0x0000000184357140-0x0000000184357230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerDailyTaskNotify ShallowCopy() => default; // 0x0000000184356D70-0x0000000184356E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843568A0-0x00000001843568F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184357350-0x00000001843573E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843573E0-0x0000000184357470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843568F0-0x00000001843569C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184356AD0-0x0000000184356BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldOwnerDailyTaskNotify other) => default; // 0x00000001843569C0-0x0000000184356AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184356F00-0x0000000184356FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184357710-0x0000000184357860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843574D0-0x00000001843575D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184356BA0-0x0000000184356C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldOwnerDailyTaskNotify other) {} // 0x0000000184356770-0x00000001843568A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843565E0-0x0000000184356710
}

