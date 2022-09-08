/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterMechanicusDungeonRsp : MessageBase, IMessage<EnterMechanicusDungeonRsp> // TypeDefIndex: 23910
{
	// Fields
	private static readonly MessageParser<EnterMechanicusDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B051C3
	private int retcode_; // 0x18
	public const int DifficultLevelFieldNumber = 2; // Metadata: 0x00B051C7
	private uint difficultLevel_; // 0x1C
	public const int DungeonIdFieldNumber = 3; // Metadata: 0x00B051CB
	private uint dungeonId_; // 0x20
	public const int WrongUidFieldNumber = 4; // Metadata: 0x00B051CF
	private uint wrongUid_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterMechanicusDungeonRsp> Parser { get => default; } // 0x0000000184669D50-0x0000000184669DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184669A40-0x0000000184669AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184669630-0x00000001846696B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184668D00-0x0000000184668D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018466A2A0-0x000000018466A390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184669FB0-0x000000018466A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184669B70-0x0000000184669C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018466A250-0x000000018466A2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846697F0-0x00000001846698E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001846694F0-0x0000000184669590 0x0000000184669060-0x0000000184669100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultLevel { get => default; set {} } // 0x0000000184669AD0-0x0000000184669B70 0x0000000184669590-0x0000000184669630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000184669750-0x00000001846697F0 0x000000018466A1B0-0x000000018466A250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WrongUid { get => default; set {} } // 0x0000000184668EE0-0x0000000184668F80 0x0000000184669F10-0x0000000184669FB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23911
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23912
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3912
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonRsp() {} // 0x000000018466A770-0x000000018466A7D0
	static EnterMechanicusDungeonRsp() {} // 0x000000018466A6B0-0x000000018466A770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonRsp Clone() => default; // 0x0000000184669C60-0x0000000184669D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterMechanicusDungeonRsp ShallowCopy() => default; // 0x00000001846696B0-0x0000000184669750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184668F80-0x0000000184668FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184669E70-0x0000000184669EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184669EC0-0x0000000184669F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184668FD0-0x0000000184669060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184669100-0x00000001846691D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterMechanicusDungeonRsp other) => default; // 0x00000001846691D0-0x0000000184669320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846698E0-0x0000000184669A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018466A390-0x000000018466A6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018466A010-0x000000018466A1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184669320-0x00000001846694F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterMechanicusDungeonRsp other) {} // 0x0000000184668D60-0x0000000184668EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184668BD0-0x0000000184668D00
}

