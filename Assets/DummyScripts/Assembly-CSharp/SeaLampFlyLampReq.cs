/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampFlyLampReq : MessageBase, IMessage<SeaLampFlyLampReq> // TypeDefIndex: 21893
{
	// Fields
	private static readonly MessageParser<SeaLampFlyLampReq> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B00497
	private uint itemId_; // 0x18
	public const int ItemNumFieldNumber = 2; // Metadata: 0x00B0049B
	private uint itemNum_; // 0x1C
	public const int PosFieldNumber = 3; // Metadata: 0x00B0049F
	private Vector pos_; // 0x20
	public const int ParamFieldNumber = 4; // Metadata: 0x00B004A3
	private int param_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampFlyLampReq> Parser { get => default; } // 0x0000000185617820-0x00000001856178B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185617510-0x00000001856175A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185617110-0x0000000185617190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185616890-0x00000001856168F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001856180F0-0x00000001856181E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185617C20-0x0000000185617C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001856175A0-0x0000000185617690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185618000-0x0000000185618050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185617230-0x0000000185617320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x00000001856179E0-0x0000000185617A80 0x0000000185618050-0x00000001856180F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemNum { get => default; set {} } // 0x0000000185617780-0x0000000185617820 0x00000001856178B0-0x0000000185617950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000185617B80-0x0000000185617C20 0x0000000185617F60-0x0000000185618000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param { get => default; set {} } // 0x0000000185617C80-0x0000000185617D20 0x0000000185617D20-0x0000000185617DC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21894
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21895
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2014
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampReq() {} // 0x00000001856185A0-0x0000000185618600
	static SeaLampFlyLampReq() {} // 0x00000001856184E0-0x00000001856185A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampReq Clone() => default; // 0x0000000185617690-0x0000000185617780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampReq ShallowCopy() => default; // 0x0000000185617190-0x0000000185617230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185616AD0-0x0000000185616B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185617A80-0x0000000185617B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185617B00-0x0000000185617B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185616B50-0x0000000185616CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185616CA0-0x0000000185616D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampFlyLampReq other) => default; // 0x0000000185616D70-0x0000000185616EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185617320-0x0000000185617510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001856181E0-0x00000001856184E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185617DC0-0x0000000185617F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185616EE0-0x0000000185617110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampFlyLampReq other) {} // 0x00000001856168F0-0x0000000185616AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185616710-0x0000000185616890
}

