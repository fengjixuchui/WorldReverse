/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestDestroyEntityReq : MessageBase, IMessage<QuestDestroyEntityReq> // TypeDefIndex: 24599
{
	// Fields
	private static readonly MessageParser<QuestDestroyEntityReq> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06CD7
	private uint entityId_; // 0x18
	public const int QuestIdFieldNumber = 2; // Metadata: 0x00B06CDB
	private uint questId_; // 0x1C
	public const int SceneIdFieldNumber = 3; // Metadata: 0x00B06CDF
	private uint sceneId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestDestroyEntityReq> Parser { get => default; } // 0x0000000182BF43E0-0x0000000182BF4470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BF4170-0x0000000182BF4200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BF3E30-0x0000000182BF3EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BF3630-0x0000000182BF3690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BF4850-0x0000000182BF4940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BF4640-0x0000000182BF46A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BF4200-0x0000000182BF42F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BF4800-0x0000000182BF4850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BF3F50-0x0000000182BF4040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182BF45A0-0x0000000182BF4640 0x0000000182BF4940-0x0000000182BF49E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000182BF3590-0x0000000182BF3630 0x0000000182BF3D90-0x0000000182BF3E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182BF38C0-0x0000000182BF3960 0x0000000182BF3CF0-0x0000000182BF3D90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24600
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24601
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 412
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityReq() {} // 0x0000000182BF4D30-0x0000000182BF4D90
	static QuestDestroyEntityReq() {} // 0x0000000182BF4C70-0x0000000182BF4D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityReq Clone() => default; // 0x0000000182BF42F0-0x0000000182BF43E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyEntityReq ShallowCopy() => default; // 0x0000000182BF3EB0-0x0000000182BF3F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BF37F0-0x0000000182BF3840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BF4500-0x0000000182BF4550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BF4550-0x0000000182BF45A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BF3840-0x0000000182BF38C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BF3960-0x0000000182BF3A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestDestroyEntityReq other) => default; // 0x0000000182BF3A30-0x0000000182BF3B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BF4040-0x0000000182BF4170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BF49E0-0x0000000182BF4C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BF46A0-0x0000000182BF4800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BF3B70-0x0000000182BF3CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestDestroyEntityReq other) {} // 0x0000000182BF3690-0x0000000182BF37F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BF3480-0x0000000182BF3590
}

