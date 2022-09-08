/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestProgressUpdateNotify : MessageBase, IMessage<QuestProgressUpdateNotify> // TypeDefIndex: 24610
{
	// Fields
	private static readonly MessageParser<QuestProgressUpdateNotify> _parser; // 0x00
	public const int QuestIdFieldNumber = 1; // Metadata: 0x00B06D47
	private uint questId_; // 0x18
	public const int FinishProgressListFieldNumber = 2; // Metadata: 0x00B06D4B
	private static readonly FieldCodec<uint> _repeated_finishProgressList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> finishProgressList_; // 0x20
	public const int FailProgressListFieldNumber = 3; // Metadata: 0x00B06D4F
	private static readonly FieldCodec<uint> _repeated_failProgressList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> failProgressList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestProgressUpdateNotify> Parser { get => default; } // 0x0000000181C130A0-0x0000000181C13130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C12E30-0x0000000181C12EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C12B00-0x0000000181C12B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C12390-0x0000000181C123F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C134E0-0x0000000181C135D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C13260-0x0000000181C132C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C12EC0-0x0000000181C12FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C13430-0x0000000181C13480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C12C20-0x0000000181C12D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000181C122F0-0x0000000181C12390 0x0000000181C12A60-0x0000000181C12B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishProgressList { get => default; } // 0x0000000181C13480-0x0000000181C134E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FailProgressList { get => default; } // 0x0000000181C12290-0x0000000181C122F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24611
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24612
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 417
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestProgressUpdateNotify() {} // 0x0000000181C13930-0x0000000181C139E0
	static QuestProgressUpdateNotify() {} // 0x0000000181C13830-0x0000000181C13930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestProgressUpdateNotify Clone() => default; // 0x0000000181C12FB0-0x0000000181C130A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestProgressUpdateNotify ShallowCopy() => default; // 0x0000000181C12B80-0x0000000181C12C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C12540-0x0000000181C12590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C131C0-0x0000000181C13210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C13210-0x0000000181C13260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C12590-0x0000000181C126C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C12810-0x0000000181C128E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestProgressUpdateNotify other) => default; // 0x0000000181C126C0-0x0000000181C12810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C12D10-0x0000000181C12E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C135D0-0x0000000181C13830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C132C0-0x0000000181C13430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C128E0-0x0000000181C12A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestProgressUpdateNotify other) {} // 0x0000000181C123F0-0x0000000181C12540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C120B0-0x0000000181C12290
}

