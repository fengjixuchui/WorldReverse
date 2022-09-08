/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeBeHelpedData : MessageBase, IMessage<FurnitureMakeBeHelpedData> // TypeDefIndex: 23442
{
	// Fields
	private static readonly MessageParser<FurnitureMakeBeHelpedData> _parser; // 0x00
	public const int PlayerNameFieldNumber = 1; // Metadata: 0x00B0408B
	private string playerName_; // 0x18
	public const int TimeFieldNumber = 2; // Metadata: 0x00B0408F
	private uint time_; // 0x20
	public const int UidFieldNumber = 3; // Metadata: 0x00B04093
	private uint uid_; // 0x24
	public const int IconFieldNumber = 4; // Metadata: 0x00B04097
	private uint icon_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeBeHelpedData> Parser { get => default; } // 0x0000000184A08810-0x0000000184A088A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A083C0-0x0000000184A08450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A08020-0x0000000184A080A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A07600-0x0000000184A07660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A08C40-0x0000000184A08D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A089D0-0x0000000184A08A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A084F0-0x0000000184A085E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A08BF0-0x0000000184A08C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A08140-0x0000000184A08230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PlayerName { get => default; set {} } // 0x0000000184A086D0-0x0000000184A08770 0x0000000184A07AC0-0x0000000184A07B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Time { get => default; set {} } // 0x0000000184A08770-0x0000000184A08810 0x0000000184A07660-0x0000000184A07700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184A07F80-0x0000000184A08020 0x0000000184A08450-0x0000000184A084F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Icon { get => default; set {} } // 0x0000000184A07990-0x0000000184A07A30 0x0000000184A07700-0x0000000184A077A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedData() {} // 0x0000000184A090F0-0x0000000184A09160
	static FurnitureMakeBeHelpedData() {} // 0x0000000184A09030-0x0000000184A090F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedData Clone() => default; // 0x0000000184A085E0-0x0000000184A086D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedData ShallowCopy() => default; // 0x0000000184A080A0-0x0000000184A08140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A07940-0x0000000184A07990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A08930-0x0000000184A08980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A08980-0x0000000184A089D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A07A30-0x0000000184A07AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A07D00-0x0000000184A07DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeBeHelpedData other) => default; // 0x0000000184A07B70-0x0000000184A07D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A08230-0x0000000184A083C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A08D30-0x0000000184A09030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A08A30-0x0000000184A08BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A07DD0-0x0000000184A07F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeBeHelpedData other) {} // 0x0000000184A077A0-0x0000000184A07940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A074B0-0x0000000184A07600
}

