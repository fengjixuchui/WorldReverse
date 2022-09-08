/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusConfirmCardNotify : MessageBase, IMessage<InBattleMechanicusConfirmCardNotify> // TypeDefIndex: 24144
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusConfirmCardNotify> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05B0F
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05B13
	private uint groupId_; // 0x1C
	public const int PlayerUidFieldNumber = 3; // Metadata: 0x00B05B17
	private uint playerUid_; // 0x20
	public const int CardIdFieldNumber = 4; // Metadata: 0x00B05B1B
	private uint cardId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusConfirmCardNotify> Parser { get => default; } // 0x000000018425ACB0-0x000000018425AD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018425A900-0x000000018425A990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018425A4F0-0x000000018425A570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184259BC0-0x0000000184259C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018425B160-0x000000018425B250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018425AE70-0x000000018425AED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018425AA30-0x000000018425AB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018425B110-0x000000018425B160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018425A610-0x000000018425A700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x000000018425A3B0-0x000000018425A450 0x000000018425A990-0x000000018425AA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x000000018425AB20-0x000000018425ABC0 0x000000018425A450-0x000000018425A4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x000000018425B070-0x000000018425B110 0x0000000184259E80-0x0000000184259F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardId { get => default; set {} } // 0x000000018425A860-0x000000018425A900 0x0000000184259F20-0x0000000184259FC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24145
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24146
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5313
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardNotify() {} // 0x000000018425B630-0x000000018425B690
	static InBattleMechanicusConfirmCardNotify() {} // 0x000000018425B570-0x000000018425B630

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardNotify Clone() => default; // 0x000000018425ABC0-0x000000018425ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardNotify ShallowCopy() => default; // 0x000000018425A570-0x000000018425A610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184259DA0-0x0000000184259DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018425ADD0-0x000000018425AE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018425AE20-0x000000018425AE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184259DF0-0x0000000184259E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184259FC0-0x000000018425A090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusConfirmCardNotify other) => default; // 0x000000018425A090-0x000000018425A1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018425A700-0x000000018425A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018425B250-0x000000018425B570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018425AED0-0x000000018425B070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018425A1E0-0x000000018425A3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusConfirmCardNotify other) {} // 0x0000000184259C20-0x0000000184259DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184259A90-0x0000000184259BC0
}

