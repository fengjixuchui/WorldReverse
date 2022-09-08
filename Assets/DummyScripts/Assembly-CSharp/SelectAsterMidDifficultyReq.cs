/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectAsterMidDifficultyReq : MessageBase, IMessage<SelectAsterMidDifficultyReq> // TypeDefIndex: 22004
{
	// Fields
	private static readonly MessageParser<SelectAsterMidDifficultyReq> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B008EB
	private uint scheduleId_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B008EF
	private uint gadgetEntityId_; // 0x1C
	public const int DifficultyIdFieldNumber = 3; // Metadata: 0x00B008F3
	private uint difficultyId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectAsterMidDifficultyReq> Parser { get => default; } // 0x0000000182631AA0-0x0000000182631B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182631790-0x0000000182631820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182631450-0x00000001826314D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182630C50-0x0000000182630CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182631FB0-0x00000001826320A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182631C60-0x0000000182631CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001826318C0-0x00000001826319B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182631F60-0x0000000182631FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182631570-0x0000000182631660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000182631020-0x00000001826310C0 0x0000000182631CC0-0x0000000182631D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000182631D60-0x0000000182631E00 0x0000000182630CB0-0x0000000182630D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000182630D50-0x0000000182630DF0 0x0000000182631820-0x00000001826318C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22005
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22006
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2061
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyReq() {} // 0x00000001826323F0-0x0000000182632450
	static SelectAsterMidDifficultyReq() {} // 0x0000000182632330-0x00000001826323F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyReq Clone() => default; // 0x00000001826319B0-0x0000000182631AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyReq ShallowCopy() => default; // 0x00000001826314D0-0x0000000182631570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182630F50-0x0000000182630FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182631BC0-0x0000000182631C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182631C10-0x0000000182631C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182630FA0-0x0000000182631020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182631200-0x00000001826312D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectAsterMidDifficultyReq other) => default; // 0x00000001826310C0-0x0000000182631200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182631660-0x0000000182631790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826320A0-0x0000000182632330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182631E00-0x0000000182631F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826312D0-0x0000000182631450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectAsterMidDifficultyReq other) {} // 0x0000000182630DF0-0x0000000182630F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182630B40-0x0000000182630C50
}

