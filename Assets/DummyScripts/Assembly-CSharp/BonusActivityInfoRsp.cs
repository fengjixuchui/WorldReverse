/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BonusActivityInfoRsp : MessageBase, IMessage<BonusActivityInfoRsp> // TypeDefIndex: 25468
{
	// Fields
	private static readonly MessageParser<BonusActivityInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08D3B
	private int retcode_; // 0x18
	public const int BonusActivityInfoListFieldNumber = 2; // Metadata: 0x00B08D3F
	private static readonly FieldCodec<BonusActivityInfo> _repeated_bonusActivityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<BonusActivityInfo> bonusActivityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BonusActivityInfoRsp> Parser { get => default; } // 0x00000001830CA910-0x00000001830CA9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830CA6A0-0x00000001830CA730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830CA390-0x00000001830CA410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830C9BC0-0x00000001830C9C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830CAD40-0x00000001830CAE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830CAB50-0x00000001830CABB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830CA730-0x00000001830CA820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830CACF0-0x00000001830CAD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830CA4B0-0x00000001830CA5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001830CA2F0-0x00000001830CA390 0x00000001830C9EB0-0x00000001830C9F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BonusActivityInfo> BonusActivityInfoList { get => default; } // 0x00000001830C9F50-0x00000001830C9FB0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25469
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25470
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2514
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfoRsp() {} // 0x00000001830CB120-0x00000001830CB1B0
	static BonusActivityInfoRsp() {} // 0x00000001830CB010-0x00000001830CB120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfoRsp Clone() => default; // 0x00000001830CA820-0x00000001830CA910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfoRsp ShallowCopy() => default; // 0x00000001830CA410-0x00000001830CA4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830C9D80-0x00000001830C9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830CAA30-0x00000001830CAAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830CAAC0-0x00000001830CAB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830C9DD0-0x00000001830C9EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830C9FB0-0x00000001830CA080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BonusActivityInfoRsp other) => default; // 0x00000001830CA080-0x00000001830CA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830CA5A0-0x00000001830CA6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830CAE30-0x00000001830CB010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830CABB0-0x00000001830CACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830CA1B0-0x00000001830CA2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BonusActivityInfoRsp other) {} // 0x00000001830C9C20-0x00000001830C9D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830C9A60-0x00000001830C9BC0
}

