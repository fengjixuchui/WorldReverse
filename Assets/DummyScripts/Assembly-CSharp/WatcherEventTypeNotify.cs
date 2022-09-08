/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WatcherEventTypeNotify : MessageBase, IMessage<WatcherEventTypeNotify> // TypeDefIndex: 25776
{
	// Fields
	private static readonly MessageParser<WatcherEventTypeNotify> _parser; // 0x00
	public const int WatcherTriggerTypeFieldNumber = 1; // Metadata: 0x00B098CF
	private uint watcherTriggerType_; // 0x18
	public const int ParamListFieldNumber = 2; // Metadata: 0x00B098D3
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x20
	public const int AddProgressFieldNumber = 3; // Metadata: 0x00B098D7
	private uint addProgress_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WatcherEventTypeNotify> Parser { get => default; } // 0x00000001835D5320-0x00000001835D53B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835D4F70-0x00000001835D5000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835D4C30-0x00000001835D4CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835D4460-0x00000001835D44C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835D5770-0x00000001835D5860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835D54E0-0x00000001835D5540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835D5000-0x00000001835D50F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835D5720-0x00000001835D5770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835D4D50-0x00000001835D4E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherTriggerType { get => default; set {} } // 0x00000001835D5280-0x00000001835D5320 0x00000001835D47F0-0x00000001835D4890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x00000001835D5540-0x00000001835D55A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddProgress { get => default; set {} } // 0x00000001835D44C0-0x00000001835D4560 0x00000001835D50F0-0x00000001835D5190

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25777
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25778
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2204
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventTypeNotify() {} // 0x00000001835D5BB0-0x00000001835D5C40
	static WatcherEventTypeNotify() {} // 0x00000001835D5AD0-0x00000001835D5BB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventTypeNotify Clone() => default; // 0x00000001835D5190-0x00000001835D5280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventTypeNotify ShallowCopy() => default; // 0x00000001835D4CB0-0x00000001835D4D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835D46C0-0x00000001835D4710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D5440-0x00000001835D5490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D5490-0x00000001835D54E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835D4710-0x00000001835D47F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835D4890-0x00000001835D4960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WatcherEventTypeNotify other) => default; // 0x00000001835D4960-0x00000001835D4AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835D4E40-0x00000001835D4F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835D5860-0x00000001835D5AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835D55A0-0x00000001835D5720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835D4AA0-0x00000001835D4C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WatcherEventTypeNotify other) {} // 0x00000001835D4560-0x00000001835D46C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835D42E0-0x00000001835D4460
}

