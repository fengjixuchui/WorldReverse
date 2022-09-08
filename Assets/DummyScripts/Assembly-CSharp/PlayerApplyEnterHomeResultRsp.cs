/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterHomeResultRsp : MessageBase, IMessage<PlayerApplyEnterHomeResultRsp> // TypeDefIndex: 23375
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterHomeResultRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03E23
	private int retcode_; // 0x18
	public const int ApplyUidFieldNumber = 2; // Metadata: 0x00B03E27
	private uint applyUid_; // 0x1C
	public const int IsAgreedFieldNumber = 3; // Metadata: 0x00B03E2B
	private bool isAgreed_; // 0x20
	public const int ParamFieldNumber = 4; // Metadata: 0x00B03E2F
	private uint param_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterHomeResultRsp> Parser { get => default; } // 0x00000001849AB6A0-0x00000001849AB730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849AB430-0x00000001849AB4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849AB0C0-0x00000001849AB140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849AA7C0-0x00000001849AA820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849ABD30-0x00000001849ABE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849AB9A0-0x00000001849ABA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849AB4C0-0x00000001849AB5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849ABCE0-0x00000001849ABD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849AB1E0-0x00000001849AB2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001849AAF80-0x00000001849AB020 0x00000001849AAB20-0x00000001849AABC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ApplyUid { get => default; set {} } // 0x00000001849AB020-0x00000001849AB0C0 0x00000001849AB900-0x00000001849AB9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x00000001849AA820-0x00000001849AA8C0 0x00000001849AB730-0x00000001849AB7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x00000001849ABA00-0x00000001849ABAA0 0x00000001849ABAA0-0x00000001849ABB40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23376
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23377
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4473
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultRsp() {} // 0x00000001849AC200-0x00000001849AC260
	static PlayerApplyEnterHomeResultRsp() {} // 0x00000001849AC140-0x00000001849AC200

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultRsp Clone() => default; // 0x00000001849AB5B0-0x00000001849AB6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultRsp ShallowCopy() => default; // 0x00000001849AB140-0x00000001849AB1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849AAA40-0x00000001849AAA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849AB860-0x00000001849AB8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849AB8B0-0x00000001849AB900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849AAA90-0x00000001849AAB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849AAD20-0x00000001849AADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterHomeResultRsp other) => default; // 0x00000001849AABC0-0x00000001849AAD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849AB2D0-0x00000001849AB430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849ABE20-0x00000001849AC140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849ABB40-0x00000001849ABCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849AADF0-0x00000001849AAF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterHomeResultRsp other) {} // 0x00000001849AA8C0-0x00000001849AAA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849AA690-0x00000001849AA7C0
}

