/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestListNotify : MessageBase, IMessage<QuestListNotify> // TypeDefIndex: 24563
{
	// Fields
	private static readonly MessageParser<QuestListNotify> _parser; // 0x00
	public const int QuestListFieldNumber = 1; // Metadata: 0x00B06B83
	private static readonly FieldCodec<Quest> _repeated_questList_codec; // 0x08
	private readonly RepeatedMessageField<Quest> questList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestListNotify> Parser { get => default; } // 0x0000000182BFCA80-0x0000000182BFCB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BFC7B0-0x0000000182BFC840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BFC4E0-0x0000000182BFC560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BFBF60-0x0000000182BFBFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BFCE70-0x0000000182BFCF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BFCCC0-0x0000000182BFCD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BFC8A0-0x0000000182BFC990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BFCE20-0x0000000182BFCE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BFC600-0x0000000182BFC6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Quest> QuestList { get => default; } // 0x0000000182BFC840-0x0000000182BFC8A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24564
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24565
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 401
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestListNotify() {} // 0x0000000182BFD1C0-0x0000000182BFD250
	static QuestListNotify() {} // 0x0000000182BFD0B0-0x0000000182BFD1C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestListNotify Clone() => default; // 0x0000000182BFC990-0x0000000182BFCA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestListNotify ShallowCopy() => default; // 0x0000000182BFC560-0x0000000182BFC600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BFC0F0-0x0000000182BFC140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BFCBA0-0x0000000182BFCC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BFCC30-0x0000000182BFCCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BFC140-0x0000000182BFC210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BFC320-0x0000000182BFC3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestListNotify other) => default; // 0x0000000182BFC210-0x0000000182BFC320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BFC6F0-0x0000000182BFC7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BFCF60-0x0000000182BFD0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BFCD20-0x0000000182BFCE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BFC3F0-0x0000000182BFC4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestListNotify other) {} // 0x0000000182BFBFC0-0x0000000182BFC0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BFBE30-0x0000000182BFBF60
}

