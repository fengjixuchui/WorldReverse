/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeResinCardDailyRewardRsp : MessageBase, IMessage<TakeResinCardDailyRewardRsp> // TypeDefIndex: 24719
{
	// Fields
	private static readonly MessageParser<TakeResinCardDailyRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0712F
	private int retcode_; // 0x18
	public const int ProductConfigIdFieldNumber = 2; // Metadata: 0x00B07133
	private uint productConfigId_; // 0x1C
	public const int ItemVecFieldNumber = 3; // Metadata: 0x00B07137
	private static readonly FieldCodec<ItemParam> _repeated_itemVec_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemVec_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeResinCardDailyRewardRsp> Parser { get => default; } // 0x000000018187F400-0x000000018187F490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018187F0F0-0x000000018187F180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018187ED50-0x000000018187EDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018187E490-0x000000018187E4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018187F860-0x000000018187F950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018187F640-0x000000018187F6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018187F220-0x000000018187F310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018187F810-0x000000018187F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018187EED0-0x000000018187EFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018187ECB0-0x000000018187ED50 0x000000018187E860-0x000000018187E900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ProductConfigId { get => default; set {} } // 0x000000018187F180-0x000000018187F220 0x000000018187E680-0x000000018187E720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemVec { get => default; } // 0x000000018187EE70-0x000000018187EED0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24720
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24721
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4109
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeResinCardDailyRewardRsp() {} // 0x000000018187FCD0-0x000000018187FD60
	static TakeResinCardDailyRewardRsp() {} // 0x000000018187FBC0-0x000000018187FCD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeResinCardDailyRewardRsp Clone() => default; // 0x000000018187F310-0x000000018187F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeResinCardDailyRewardRsp ShallowCopy() => default; // 0x000000018187EDD0-0x000000018187EE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018187E720-0x000000018187E770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018187F520-0x000000018187F5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018187F5B0-0x000000018187F640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018187E770-0x000000018187E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018187E900-0x000000018187E9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeResinCardDailyRewardRsp other) => default; // 0x000000018187E9D0-0x000000018187EB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018187EFC0-0x000000018187F0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018187F950-0x000000018187FBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018187F6A0-0x000000018187F810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018187EB20-0x000000018187ECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeResinCardDailyRewardRsp other) {} // 0x000000018187E4F0-0x000000018187E680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018187E310-0x000000018187E490
}

