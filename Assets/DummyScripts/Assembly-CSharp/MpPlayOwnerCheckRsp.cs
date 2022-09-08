/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayOwnerCheckRsp : MessageBase, IMessage<MpPlayOwnerCheckRsp> // TypeDefIndex: 24069
{
	// Fields
	private static readonly MessageParser<MpPlayOwnerCheckRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B057C7
	private int retcode_; // 0x18
	public const int MpPlayIdFieldNumber = 2; // Metadata: 0x00B057CB
	private uint mpPlayId_; // 0x1C
	public const int WrongUidFieldNumber = 3; // Metadata: 0x00B057CF
	private uint wrongUid_; // 0x20
	public const int IsSkipMatchFieldNumber = 4; // Metadata: 0x00B057D3
	private bool isSkipMatch_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayOwnerCheckRsp> Parser { get => default; } // 0x0000000183992CB0-0x0000000183992D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839929A0-0x0000000183992A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183992590-0x0000000183992610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183991C90-0x0000000183991CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183993200-0x00000001839932F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183992F10-0x0000000183992F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183992AD0-0x0000000183992BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839931B0-0x0000000183993200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839926B0-0x00000001839927A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001839924F0-0x0000000183992590 0x0000000183992090-0x0000000183992130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000183992900-0x00000001839929A0 0x0000000183991FF0-0x0000000183992090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WrongUid { get => default; set {} } // 0x0000000183991E70-0x0000000183991F10 0x0000000183992E70-0x0000000183992F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipMatch { get => default; set {} } // 0x0000000183993110-0x00000001839931B0 0x0000000183992A30-0x0000000183992AD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24070
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24071
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1816
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckRsp() {} // 0x00000001839936D0-0x0000000183993730
	static MpPlayOwnerCheckRsp() {} // 0x0000000183993610-0x00000001839936D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckRsp Clone() => default; // 0x0000000183992BC0-0x0000000183992CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckRsp ShallowCopy() => default; // 0x0000000183992610-0x00000001839926B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183991F10-0x0000000183991F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183992DD0-0x0000000183992E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183992E20-0x0000000183992E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183991F60-0x0000000183991FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183992130-0x0000000183992200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayOwnerCheckRsp other) => default; // 0x0000000183992200-0x0000000183992360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839927A0-0x0000000183992900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839932F0-0x0000000183993610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183992F70-0x0000000183993110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183992360-0x00000001839924F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayOwnerCheckRsp other) {} // 0x0000000183991CF0-0x0000000183991E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183991B60-0x0000000183991C90
}

