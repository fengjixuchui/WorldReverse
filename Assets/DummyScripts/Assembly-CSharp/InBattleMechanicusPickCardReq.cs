/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusPickCardReq : MessageBase, IMessage<InBattleMechanicusPickCardReq> // TypeDefIndex: 24129
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusPickCardReq> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05A6F
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05A73
	private uint groupId_; // 0x1C
	public const int CardIdFieldNumber = 3; // Metadata: 0x00B05A77
	private uint cardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusPickCardReq> Parser { get => default; } // 0x0000000183506FD0-0x0000000183507060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183506C20-0x0000000183506CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183506840-0x00000001835068C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183506040-0x00000001835060A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835073A0-0x0000000183507490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183507190-0x00000001835071F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183506D50-0x0000000183506E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183507350-0x00000001835073A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183506960-0x0000000183506A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x0000000183506700-0x00000001835067A0 0x0000000183506CB0-0x0000000183506D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000183506E40-0x0000000183506EE0 0x00000001835067A0-0x0000000183506840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardId { get => default; set {} } // 0x0000000183506B80-0x0000000183506C20 0x00000001835062D0-0x0000000183506370

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24130
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24131
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5308
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardReq() {} // 0x00000001835077E0-0x0000000183507840
	static InBattleMechanicusPickCardReq() {} // 0x0000000183507720-0x00000001835077E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardReq Clone() => default; // 0x0000000183506EE0-0x0000000183506FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardReq ShallowCopy() => default; // 0x00000001835068C0-0x0000000183506960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183506200-0x0000000183506250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835070F0-0x0000000183507140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183507140-0x0000000183507190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183506250-0x00000001835062D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183506370-0x0000000183506440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusPickCardReq other) => default; // 0x0000000183506440-0x0000000183506580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183506A50-0x0000000183506B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183507490-0x0000000183507720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835071F0-0x0000000183507350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183506580-0x0000000183506700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusPickCardReq other) {} // 0x00000001835060A0-0x0000000183506200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183505F30-0x0000000183506040
}

