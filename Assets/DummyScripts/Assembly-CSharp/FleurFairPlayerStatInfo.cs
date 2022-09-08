/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairPlayerStatInfo : MessageBase, IMessage<FleurFairPlayerStatInfo> // TypeDefIndex: 24167
{
	// Fields
	private static readonly MessageParser<FleurFairPlayerStatInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B05C0B
	private uint uid_; // 0x18
	public const int StatIdFieldNumber = 2; // Metadata: 0x00B05C0F
	private uint statId_; // 0x1C
	public const int ParamFieldNumber = 3; // Metadata: 0x00B05C13
	private int param_; // 0x20
	public const int HeadImageFieldNumber = 4; // Metadata: 0x00B05C17
	private uint headImage_; // 0x24
	public const int NickNameFieldNumber = 5; // Metadata: 0x00B05C1B
	private string nickName_; // 0x28
	public const int OnlineIdFieldNumber = 6; // Metadata: 0x00B05C1F
	private string onlineId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairPlayerStatInfo> Parser { get => default; } // 0x00000001831F7860-0x00000001831F78F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831F7400-0x00000001831F7490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831F6F40-0x00000001831F6FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831F6350-0x00000001831F63B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831F7E60-0x00000001831F7F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831F7A20-0x00000001831F7A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831F75D0-0x00000001831F76C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831F7E10-0x00000001831F7E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831F7060-0x00000001831F7150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001831F6EA0-0x00000001831F6F40 0x00000001831F7530-0x00000001831F75D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StatId { get => default; set {} } // 0x00000001831F6140-0x00000001831F61E0 0x00000001831F6700-0x00000001831F67A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param { get => default; set {} } // 0x00000001831F7A80-0x00000001831F7B20 0x00000001831F7B20-0x00000001831F7BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HeadImage { get => default; set {} } // 0x00000001831F7490-0x00000001831F7530 0x00000001831F68A0-0x00000001831F6940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NickName { get => default; set {} } // 0x00000001831F6460-0x00000001831F6500 0x00000001831F63B0-0x00000001831F6460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001831F7360-0x00000001831F7400 0x00000001831F77B0-0x00000001831F7860

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairPlayerStatInfo() {} // 0x00000001831F8410-0x00000001831F8490
	static FleurFairPlayerStatInfo() {} // 0x00000001831F8350-0x00000001831F8410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairPlayerStatInfo Clone() => default; // 0x00000001831F76C0-0x00000001831F77B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairPlayerStatInfo ShallowCopy() => default; // 0x00000001831F6FC0-0x00000001831F7060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831F67A0-0x00000001831F67F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831F7980-0x00000001831F79D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831F79D0-0x00000001831F7A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831F67F0-0x00000001831F68A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831F6940-0x00000001831F6A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairPlayerStatInfo other) => default; // 0x00000001831F6A10-0x00000001831F6C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831F7150-0x00000001831F7360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831F7F50-0x00000001831F8350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831F7BC0-0x00000001831F7E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831F6C10-0x00000001831F6EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairPlayerStatInfo other) {} // 0x00000001831F6500-0x00000001831F6700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831F61E0-0x00000001831F6350
}

