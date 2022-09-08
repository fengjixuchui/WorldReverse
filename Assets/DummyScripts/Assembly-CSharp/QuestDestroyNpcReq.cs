/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestDestroyNpcReq : MessageBase, IMessage<QuestDestroyNpcReq> // TypeDefIndex: 24623
{
	// Fields
	private static readonly MessageParser<QuestDestroyNpcReq> _parser; // 0x00
	public const int NpcIdFieldNumber = 1; // Metadata: 0x00B06DCF
	private uint npcId_; // 0x18
	public const int ParentQuestIdFieldNumber = 2; // Metadata: 0x00B06DD3
	private uint parentQuestId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestDestroyNpcReq> Parser { get => default; } // 0x0000000182D67C40-0x0000000182D67CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D67890-0x0000000182D67920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D674E0-0x0000000182D67560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D66ED0-0x0000000182D66F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D67FD0-0x0000000182D680C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D67E00-0x0000000182D67E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D67A60-0x0000000182D67B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D67F80-0x0000000182D67FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D676A0-0x0000000182D67790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcId { get => default; set {} } // 0x0000000182D679C0-0x0000000182D67A60 0x0000000182D67560-0x0000000182D67600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000182D67120-0x0000000182D671C0 0x0000000182D67920-0x0000000182D679C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24624
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24625
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 421
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcReq() {} // 0x0000000182D68380-0x0000000182D683E0
	static QuestDestroyNpcReq() {} // 0x0000000182D682C0-0x0000000182D68380

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcReq Clone() => default; // 0x0000000182D67B50-0x0000000182D67C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcReq ShallowCopy() => default; // 0x0000000182D67600-0x0000000182D676A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D67060-0x0000000182D670B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D67D60-0x0000000182D67DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D67DB0-0x0000000182D67E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D670B0-0x0000000182D67120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D672E0-0x0000000182D673B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestDestroyNpcReq other) => default; // 0x0000000182D671C0-0x0000000182D672E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D67790-0x0000000182D67890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D680C0-0x0000000182D682C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D67E60-0x0000000182D67F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D673B0-0x0000000182D674E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestDestroyNpcReq other) {} // 0x0000000182D66F30-0x0000000182D67060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D66DD0-0x0000000182D66ED0
}

