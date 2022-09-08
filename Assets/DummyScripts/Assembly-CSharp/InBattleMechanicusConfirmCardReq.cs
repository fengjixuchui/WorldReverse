/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusConfirmCardReq : MessageBase, IMessage<InBattleMechanicusConfirmCardReq> // TypeDefIndex: 24138
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusConfirmCardReq> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05ACF
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05AD3
	private uint groupId_; // 0x1C
	public const int CardIdFieldNumber = 3; // Metadata: 0x00B05AD7
	private uint cardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusConfirmCardReq> Parser { get => default; } // 0x0000000181BFEA60-0x0000000181BFEAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BFE6B0-0x0000000181BFE740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BFE2D0-0x0000000181BFE350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BFDAD0-0x0000000181BFDB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BFEE30-0x0000000181BFEF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BFEC20-0x0000000181BFEC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BFE7E0-0x0000000181BFE8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BFEDE0-0x0000000181BFEE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BFE3F0-0x0000000181BFE4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x0000000181BFE190-0x0000000181BFE230 0x0000000181BFE740-0x0000000181BFE7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000181BFE8D0-0x0000000181BFE970 0x0000000181BFE230-0x0000000181BFE2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardId { get => default; set {} } // 0x0000000181BFE610-0x0000000181BFE6B0 0x0000000181BFDD60-0x0000000181BFDE00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24139
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24140
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5311
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardReq() {} // 0x0000000181BFF270-0x0000000181BFF2D0
	static InBattleMechanicusConfirmCardReq() {} // 0x0000000181BFF1B0-0x0000000181BFF270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardReq Clone() => default; // 0x0000000181BFE970-0x0000000181BFEA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusConfirmCardReq ShallowCopy() => default; // 0x0000000181BFE350-0x0000000181BFE3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BFDC90-0x0000000181BFDCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BFEB80-0x0000000181BFEBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BFEBD0-0x0000000181BFEC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BFDCE0-0x0000000181BFDD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BFDF40-0x0000000181BFE010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusConfirmCardReq other) => default; // 0x0000000181BFDE00-0x0000000181BFDF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BFE4E0-0x0000000181BFE610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BFEF20-0x0000000181BFF1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BFEC80-0x0000000181BFEDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BFE010-0x0000000181BFE190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusConfirmCardReq other) {} // 0x0000000181BFDB30-0x0000000181BFDC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BFD9C0-0x0000000181BFDAD0
}

