/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBattlePassProductRsp : MessageBase, IMessage<GetBattlePassProductRsp> // TypeDefIndex: 22573
{
	// Fields
	private static readonly MessageParser<GetBattlePassProductRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01E57
	private int retcode_; // 0x18
	public const int BattlePassProductPlayTypeFieldNumber = 2; // Metadata: 0x00B01E5B
	private uint battlePassProductPlayType_; // 0x1C
	public const int CurScheduleIdFieldNumber = 3; // Metadata: 0x00B01E5F
	private uint curScheduleId_; // 0x20
	public const int ProductIdFieldNumber = 4; // Metadata: 0x00B01E63
	private string productId_; // 0x28
	public const int PriceTierFieldNumber = 5; // Metadata: 0x00B01E67
	private string priceTier_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBattlePassProductRsp> Parser { get => default; } // 0x0000000184E6BE80-0x0000000184E6BF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E6B980-0x0000000184E6BA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E6B4F0-0x0000000184E6B570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E6AA20-0x0000000184E6AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E6C3A0-0x0000000184E6C490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E6C040-0x0000000184E6C0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E6BAB0-0x0000000184E6BBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E6C2B0-0x0000000184E6C300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E6B610-0x0000000184E6B700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184E6B450-0x0000000184E6B4F0 0x0000000184E6AE00-0x0000000184E6AEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BattlePassProductPlayType { get => default; set {} } // 0x0000000184E6C300-0x0000000184E6C3A0 0x0000000184E6B8E0-0x0000000184E6B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScheduleId { get => default; set {} } // 0x0000000184E6BA10-0x0000000184E6BAB0 0x0000000184E6AC60-0x0000000184E6AD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x0000000184E6BC90-0x0000000184E6BD30 0x0000000184E6BD30-0x0000000184E6BDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PriceTier { get => default; set {} } // 0x0000000184E6BDE0-0x0000000184E6BE80 0x0000000184E6AEA0-0x0000000184E6AF50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22574
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22575
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2610
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBattlePassProductRsp() {} // 0x0000000184E6C8C0-0x0000000184E6C940
	static GetBattlePassProductRsp() {} // 0x0000000184E6C800-0x0000000184E6C8C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBattlePassProductRsp Clone() => default; // 0x0000000184E6BBA0-0x0000000184E6BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBattlePassProductRsp ShallowCopy() => default; // 0x0000000184E6B570-0x0000000184E6B610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E6AD00-0x0000000184E6AD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E6BFA0-0x0000000184E6BFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E6BFF0-0x0000000184E6C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E6AD50-0x0000000184E6AE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E6B130-0x0000000184E6B200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBattlePassProductRsp other) => default; // 0x0000000184E6AF50-0x0000000184E6B130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E6B700-0x0000000184E6B8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E6C490-0x0000000184E6C800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E6C0A0-0x0000000184E6C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E6B200-0x0000000184E6B450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBattlePassProductRsp other) {} // 0x0000000184E6AA80-0x0000000184E6AC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E6A8D0-0x0000000184E6AA20
}

