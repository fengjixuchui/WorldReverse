/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DoGachaReq : MessageBase, IMessage<DoGachaReq> // TypeDefIndex: 23164
{
	// Fields
	private static readonly MessageParser<DoGachaReq> _parser; // 0x00
	public const int GachaTypeFieldNumber = 1; // Metadata: 0x00B03593
	private uint gachaType_; // 0x18
	public const int GachaTimesFieldNumber = 2; // Metadata: 0x00B03597
	private uint gachaTimes_; // 0x1C
	public const int GachaRandomFieldNumber = 3; // Metadata: 0x00B0359B
	private uint gachaRandom_; // 0x20
	public const int GachaScheduleIdFieldNumber = 4; // Metadata: 0x00B0359F
	private uint gachaScheduleId_; // 0x24
	public const int GachaTagFieldNumber = 5; // Metadata: 0x00B035A3
	private string gachaTag_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DoGachaReq> Parser { get => default; } // 0x0000000185B2B180-0x0000000185B2B210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185B2AD30-0x0000000185B2ADC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185B2A8D0-0x0000000185B2A950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185B29E90-0x0000000185B29EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185B2B680-0x0000000185B2B770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185B2B340-0x0000000185B2B3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185B2AF00-0x0000000185B2AFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185B2B630-0x0000000185B2B680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185B2A9F0-0x0000000185B2AAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaType { get => default; set {} } // 0x0000000185B2B3A0-0x0000000185B2B440 0x0000000185B2AC90-0x0000000185B2AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaTimes { get => default; set {} } // 0x0000000185B29EF0-0x0000000185B29F90 0x0000000185B2A240-0x0000000185B2A2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaRandom { get => default; set {} } // 0x0000000185B2B0E0-0x0000000185B2B180 0x0000000185B2A2E0-0x0000000185B2A380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaScheduleId { get => default; set {} } // 0x0000000185B2AE60-0x0000000185B2AF00 0x0000000185B2ADC0-0x0000000185B2AE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaTag { get => default; set {} } // 0x0000000185B2A600-0x0000000185B2A6A0 0x0000000185B29DE0-0x0000000185B29E90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23165
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23166
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1503
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaReq() {} // 0x0000000185B2BBC0-0x0000000185B2BC30
	static DoGachaReq() {} // 0x0000000185B2BB00-0x0000000185B2BBC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaReq Clone() => default; // 0x0000000185B2AFF0-0x0000000185B2B0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaReq ShallowCopy() => default; // 0x0000000185B2A950-0x0000000185B2A9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185B2A150-0x0000000185B2A1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B2B2A0-0x0000000185B2B2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185B2B2F0-0x0000000185B2B340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185B2A1A0-0x0000000185B2A240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185B2A530-0x0000000185B2A600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DoGachaReq other) => default; // 0x0000000185B2A380-0x0000000185B2A530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185B2AAE0-0x0000000185B2AC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185B2B770-0x0000000185B2BB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185B2B440-0x0000000185B2B630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185B2A6A0-0x0000000185B2A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DoGachaReq other) {} // 0x0000000185B29F90-0x0000000185B2A150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185B29C90-0x0000000185B29DE0
}

