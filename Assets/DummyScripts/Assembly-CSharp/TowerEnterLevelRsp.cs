/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerEnterLevelRsp : MessageBase, IMessage<TowerEnterLevelRsp> // TypeDefIndex: 25725
{
	// Fields
	private static readonly MessageParser<TowerEnterLevelRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09713
	private int retcode_; // 0x18
	public const int FloorIdFieldNumber = 2; // Metadata: 0x00B09717
	private uint floorId_; // 0x1C
	public const int LevelIndexFieldNumber = 3; // Metadata: 0x00B0971B
	private uint levelIndex_; // 0x20
	public const int TowerBuffIdListFieldNumber = 4; // Metadata: 0x00B0971F
	private static readonly FieldCodec<uint> _repeated_towerBuffIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> towerBuffIdList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerEnterLevelRsp> Parser { get => default; } // 0x00000001853BC1F0-0x00000001853BC280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001853BBF20-0x00000001853BBFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001853BBBB0-0x00000001853BBC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001853BB170-0x00000001853BB1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001853BC6B0-0x00000001853BC7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001853BC450-0x00000001853BC4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001853BBFB0-0x00000001853BC0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001853BC660-0x00000001853BC6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001853BBCD0-0x00000001853BBDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001853BBB10-0x00000001853BBBB0 0x00000001853BB660-0x00000001853BB700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorId { get => default; set {} } // 0x00000001853BC310-0x00000001853BC3B0 0x00000001853BB5C0-0x00000001853BB660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LevelIndex { get => default; set {} } // 0x00000001853BB1D0-0x00000001853BB270 0x00000001853BB520-0x00000001853BB5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TowerBuffIdList { get => default; } // 0x00000001853BC190-0x00000001853BC1F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25726
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25727
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2412
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelRsp() {} // 0x00000001853BCB80-0x00000001853BCC10
	static TowerEnterLevelRsp() {} // 0x00000001853BCAA0-0x00000001853BCB80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelRsp Clone() => default; // 0x00000001853BC0A0-0x00000001853BC190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelRsp ShallowCopy() => default; // 0x00000001853BBC30-0x00000001853BBCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001853BB3F0-0x00000001853BB440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BC3B0-0x00000001853BC400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BC400-0x00000001853BC450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001853BB440-0x00000001853BB520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001853BB860-0x00000001853BB930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerEnterLevelRsp other) => default; // 0x00000001853BB700-0x00000001853BB860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001853BBDC0-0x00000001853BBF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001853BC7A0-0x00000001853BCAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001853BC4B0-0x00000001853BC660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001853BB930-0x00000001853BBB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerEnterLevelRsp other) {} // 0x00000001853BB270-0x00000001853BB3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001853BAFD0-0x00000001853BB170
}

