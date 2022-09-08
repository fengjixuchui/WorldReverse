/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampContributeItemRsp : MessageBase, IMessage<SeaLampContributeItemRsp> // TypeDefIndex: 21914
{
	// Fields
	private static readonly MessageParser<SeaLampContributeItemRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0055B
	private int retcode_; // 0x18
	public const int TotalContributionFieldNumber = 2; // Metadata: 0x00B0055F
	private uint totalContribution_; // 0x1C
	public const int AddContributionFieldNumber = 3; // Metadata: 0x00B00563
	private uint addContribution_; // 0x20
	public const int AddProgressFieldNumber = 4; // Metadata: 0x00B00567
	private uint addProgress_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampContributeItemRsp> Parser { get => default; } // 0x00000001843C39D0-0x00000001843C3A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843C36C0-0x00000001843C3750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843C32B0-0x00000001843C3330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843C2980-0x00000001843C29E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843C3F20-0x00000001843C4010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843C3B90-0x00000001843C3BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843C3750-0x00000001843C3840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843C3ED0-0x00000001843C3F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843C33D0-0x00000001843C34C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001843C3210-0x00000001843C32B0 0x00000001843C2D80-0x00000001843C2E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalContribution { get => default; set {} } // 0x00000001843C2CE0-0x00000001843C2D80 0x00000001843C3BF0-0x00000001843C3C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddContribution { get => default; set {} } // 0x00000001843C3620-0x00000001843C36C0 0x00000001843C3E30-0x00000001843C3ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddProgress { get => default; set {} } // 0x00000001843C29E0-0x00000001843C2A80 0x00000001843C3840-0x00000001843C38E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21915
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21916
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2021
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampContributeItemRsp() {} // 0x00000001843C43F0-0x00000001843C4450
	static SeaLampContributeItemRsp() {} // 0x00000001843C4330-0x00000001843C43F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampContributeItemRsp Clone() => default; // 0x00000001843C38E0-0x00000001843C39D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampContributeItemRsp ShallowCopy() => default; // 0x00000001843C3330-0x00000001843C33D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843C2C00-0x00000001843C2C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C3AF0-0x00000001843C3B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C3B40-0x00000001843C3B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843C2C50-0x00000001843C2CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843C2F70-0x00000001843C3040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampContributeItemRsp other) => default; // 0x00000001843C2E20-0x00000001843C2F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843C34C0-0x00000001843C3620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843C4010-0x00000001843C4330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843C3C90-0x00000001843C3E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843C3040-0x00000001843C3210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampContributeItemRsp other) {} // 0x00000001843C2A80-0x00000001843C2C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843C2850-0x00000001843C2980
}

