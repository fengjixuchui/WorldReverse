/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekSettleInfo : MessageBase, IMessage<HideAndSeekSettleInfo> // TypeDefIndex: 24190
{
	// Fields
	private static readonly MessageParser<HideAndSeekSettleInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B05CE7
	private uint uid_; // 0x18
	public const int CardListFieldNumber = 2; // Metadata: 0x00B05CEB
	private static readonly FieldCodec<ExhibitionDisplayInfo> _repeated_cardList_codec; // 0x08
	private readonly RepeatedMessageField<ExhibitionDisplayInfo> cardList_; // 0x20
	public const int HeadImageFieldNumber = 4; // Metadata: 0x00B05CEF
	private uint headImage_; // 0x28
	public const int NicknameFieldNumber = 5; // Metadata: 0x00B05CF3
	private string nickname_; // 0x30
	public const int OnlineIdFieldNumber = 6; // Metadata: 0x00B05CF7
	private string onlineId_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekSettleInfo> Parser { get => default; } // 0x00000001850B2800-0x00000001850B2890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850B2300-0x00000001850B2390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850B1E80-0x00000001850B1F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850B1350-0x00000001850B13B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850B2D20-0x00000001850B2E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850B2A40-0x00000001850B2AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850B2570-0x00000001850B2660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850B2CD0-0x00000001850B2D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850B1FA0-0x00000001850B2090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001850B1DE0-0x00000001850B1E80 0x00000001850B2430-0x00000001850B24D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ExhibitionDisplayInfo> CardList { get => default; } // 0x00000001850B1D80-0x00000001850B1DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HeadImage { get => default; set {} } // 0x00000001850B2390-0x00000001850B2430 0x00000001850B1720-0x00000001850B17C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001850B24D0-0x00000001850B2570 0x00000001850B17C0-0x00000001850B1870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001850B2260-0x00000001850B2300 0x00000001850B2750-0x00000001850B2800

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleInfo() {} // 0x00000001850B3270-0x00000001850B3320
	static HideAndSeekSettleInfo() {} // 0x00000001850B3160-0x00000001850B3270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleInfo Clone() => default; // 0x00000001850B2660-0x00000001850B2750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleInfo ShallowCopy() => default; // 0x00000001850B1F00-0x00000001850B1FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850B15C0-0x00000001850B1610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850B2920-0x00000001850B29B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850B29B0-0x00000001850B2A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850B1610-0x00000001850B1720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850B1870-0x00000001850B1940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekSettleInfo other) => default; // 0x00000001850B1940-0x00000001850B1B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850B2090-0x00000001850B2260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850B2E10-0x00000001850B3160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850B2AA0-0x00000001850B2CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850B1B30-0x00000001850B1D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekSettleInfo other) {} // 0x00000001850B13B0-0x00000001850B15C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850B1190-0x00000001850B1350
}

