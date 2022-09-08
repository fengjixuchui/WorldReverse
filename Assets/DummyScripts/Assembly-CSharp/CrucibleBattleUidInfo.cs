/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CrucibleBattleUidInfo : MessageBase, IMessage<CrucibleBattleUidInfo> // TypeDefIndex: 21986
{
	// Fields
	private static readonly MessageParser<CrucibleBattleUidInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B00813
	private uint uid_; // 0x18
	public const int NicknameFieldNumber = 2; // Metadata: 0x00B00817
	private string nickname_; // 0x20
	public const int IconFieldNumber = 3; // Metadata: 0x00B0081B
	private uint icon_; // 0x28
	public const int OnlineIdFieldNumber = 4; // Metadata: 0x00B0081F
	private string onlineId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CrucibleBattleUidInfo> Parser { get => default; } // 0x0000000181B64560-0x0000000181B645F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B64100-0x0000000181B64190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B63CA0-0x0000000181B63D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B63280-0x0000000181B632E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B649A0-0x0000000181B64A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B64720-0x0000000181B64780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B642D0-0x0000000181B643C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B64950-0x0000000181B649A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B63DC0-0x0000000181B63EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000181B63C00-0x0000000181B63CA0 0x0000000181B64190-0x0000000181B64230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x0000000181B64230-0x0000000181B642D0 0x0000000181B636C0-0x0000000181B63770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Icon { get => default; set {} } // 0x0000000181B63580-0x0000000181B63620 0x0000000181B632E0-0x0000000181B63380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x0000000181B64060-0x0000000181B64100 0x0000000181B644B0-0x0000000181B64560

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleBattleUidInfo() {} // 0x0000000181B64E30-0x0000000181B64EB0
	static CrucibleBattleUidInfo() {} // 0x0000000181B64D70-0x0000000181B64E30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleBattleUidInfo Clone() => default; // 0x0000000181B643C0-0x0000000181B644B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleBattleUidInfo ShallowCopy() => default; // 0x0000000181B63D20-0x0000000181B63DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B63530-0x0000000181B63580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B64680-0x0000000181B646D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B646D0-0x0000000181B64720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B63620-0x0000000181B636C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B63770-0x0000000181B63840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CrucibleBattleUidInfo other) => default; // 0x0000000181B63840-0x0000000181B63A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B63EB0-0x0000000181B64060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B64A90-0x0000000181B64D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B64780-0x0000000181B64950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B63A00-0x0000000181B63C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CrucibleBattleUidInfo other) {} // 0x0000000181B63380-0x0000000181B63530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B63150-0x0000000181B63280
}

