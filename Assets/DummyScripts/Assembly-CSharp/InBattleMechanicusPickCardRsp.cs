/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusPickCardRsp : MessageBase, IMessage<InBattleMechanicusPickCardRsp> // TypeDefIndex: 24132
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusPickCardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05A8F
	private int retcode_; // 0x18
	public const int PlayIndexFieldNumber = 2; // Metadata: 0x00B05A93
	private uint playIndex_; // 0x1C
	public const int GroupIdFieldNumber = 3; // Metadata: 0x00B05A97
	private uint groupId_; // 0x20
	public const int CardIdFieldNumber = 4; // Metadata: 0x00B05A9B
	private uint cardId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusPickCardRsp> Parser { get => default; } // 0x00000001824F96C0-0x00000001824F9750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824F9310-0x00000001824F93A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824F8F00-0x00000001824F8F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824F8530-0x00000001824F8590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824F9AD0-0x00000001824F9BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824F9880-0x00000001824F98E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824F9440-0x00000001824F9530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824F9A80-0x00000001824F9AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824F9020-0x00000001824F9110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001824F8D20-0x00000001824F8DC0 0x00000001824F87F0-0x00000001824F8890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x00000001824F8DC0-0x00000001824F8E60 0x00000001824F93A0-0x00000001824F9440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001824F9530-0x00000001824F95D0 0x00000001824F8E60-0x00000001824F8F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardId { get => default; set {} } // 0x00000001824F9270-0x00000001824F9310 0x00000001824F8890-0x00000001824F8930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24133
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24134
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5309
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardRsp() {} // 0x00000001824F9FA0-0x00000001824FA000
	static InBattleMechanicusPickCardRsp() {} // 0x00000001824F9EE0-0x00000001824F9FA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardRsp Clone() => default; // 0x00000001824F95D0-0x00000001824F96C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPickCardRsp ShallowCopy() => default; // 0x00000001824F8F80-0x00000001824F9020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824F8710-0x00000001824F8760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F97E0-0x00000001824F9830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F9830-0x00000001824F9880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824F8760-0x00000001824F87F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824F8A80-0x00000001824F8B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusPickCardRsp other) => default; // 0x00000001824F8930-0x00000001824F8A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824F9110-0x00000001824F9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824F9BC0-0x00000001824F9EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824F98E0-0x00000001824F9A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824F8B50-0x00000001824F8D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusPickCardRsp other) {} // 0x00000001824F8590-0x00000001824F8710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824F8400-0x00000001824F8530
}

