/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterMpResultRsp : MessageBase, IMessage<PlayerApplyEnterMpResultRsp> // TypeDefIndex: 24037
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterMpResultRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05697
	private int retcode_; // 0x18
	public const int ApplyUidFieldNumber = 2; // Metadata: 0x00B0569B
	private uint applyUid_; // 0x1C
	public const int IsAgreedFieldNumber = 3; // Metadata: 0x00B0569F
	private bool isAgreed_; // 0x20
	public const int ParamFieldNumber = 4; // Metadata: 0x00B056A3
	private uint param_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterMpResultRsp> Parser { get => default; } // 0x0000000181F50010-0x0000000181F500A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F4FDA0-0x0000000181F4FE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F4FA30-0x0000000181F4FAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F4F130-0x0000000181F4F190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F506A0-0x0000000181F50790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F50310-0x0000000181F50370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F4FE30-0x0000000181F4FF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F50650-0x0000000181F506A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F4FB50-0x0000000181F4FC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181F4F8F0-0x0000000181F4F990 0x0000000181F4F490-0x0000000181F4F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ApplyUid { get => default; set {} } // 0x0000000181F4F990-0x0000000181F4FA30 0x0000000181F50270-0x0000000181F50310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x0000000181F4F190-0x0000000181F4F230 0x0000000181F500A0-0x0000000181F50140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000181F50370-0x0000000181F50410 0x0000000181F50410-0x0000000181F504B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24038
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24039
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1806
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultRsp() {} // 0x0000000181F50B70-0x0000000181F50BD0
	static PlayerApplyEnterMpResultRsp() {} // 0x0000000181F50AB0-0x0000000181F50B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultRsp Clone() => default; // 0x0000000181F4FF20-0x0000000181F50010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultRsp ShallowCopy() => default; // 0x0000000181F4FAB0-0x0000000181F4FB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F4F3B0-0x0000000181F4F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F501D0-0x0000000181F50220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F50220-0x0000000181F50270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F4F400-0x0000000181F4F490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F4F690-0x0000000181F4F760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterMpResultRsp other) => default; // 0x0000000181F4F530-0x0000000181F4F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F4FC40-0x0000000181F4FDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F50790-0x0000000181F50AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F504B0-0x0000000181F50650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F4F760-0x0000000181F4F8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterMpResultRsp other) {} // 0x0000000181F4F230-0x0000000181F4F3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F4F000-0x0000000181F4F130
}

