/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestDestroyEntityRsp : MessageBase, IMessage<QuestDestroyEntityRsp> // TypeDefIndex: 24602
{
	// Fields
	private static readonly MessageParser<QuestDestroyEntityRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06CF7
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B06CFB
	private uint entityId_; // 0x1C
	public const int QuestIdFieldNumber = 3; // Metadata: 0x00B06CFF
	private uint questId_; // 0x20
	public const int SceneIdFieldNumber = 4; // Metadata: 0x00B06D03
	private uint sceneId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestDestroyEntityRsp> Parser { get => default; } // 0x0000000181D31F50-0x0000000181D31FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D31CE0-0x0000000181D31D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D31970-0x0000000181D319F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D30FA0-0x0000000181D31000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D32400-0x0000000181D324F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D321B0-0x0000000181D32210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D31D70-0x0000000181D31E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D323B0-0x0000000181D32400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D31A90-0x0000000181D31B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D31790-0x0000000181D31830 0x0000000181D31300-0x0000000181D313A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181D32110-0x0000000181D321B0 0x0000000181D324F0-0x0000000181D32590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000181D30F00-0x0000000181D30FA0 0x0000000181D318D0-0x0000000181D31970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181D31260-0x0000000181D31300 0x0000000181D31830-0x0000000181D318D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24603
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24604
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 413
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityRsp() {} // 0x0000000181D32970-0x0000000181D329D0
	static QuestDestroyEntityRsp() {} // 0x0000000181D328B0-0x0000000181D32970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityRsp Clone() => default; // 0x0000000181D31E60-0x0000000181D31F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityRsp ShallowCopy() => default; // 0x0000000181D319F0-0x0000000181D31A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D31180-0x0000000181D311D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D32070-0x0000000181D320C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D320C0-0x0000000181D32110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D311D0-0x0000000181D31260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D313A0-0x0000000181D31470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestDestroyEntityRsp other) => default; // 0x0000000181D31470-0x0000000181D315C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D31B80-0x0000000181D31CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D32590-0x0000000181D328B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D32210-0x0000000181D323B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D315C0-0x0000000181D31790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestDestroyEntityRsp other) {} // 0x0000000181D31000-0x0000000181D31180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D30DD0-0x0000000181D30F00
}

