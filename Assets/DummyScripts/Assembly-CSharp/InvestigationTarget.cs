/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InvestigationTarget : MessageBase, IMessage<InvestigationTarget> // TypeDefIndex: 23574
{
	// Fields
	private static readonly MessageParser<InvestigationTarget> _parser; // 0x00
	public const int QuestIdFieldNumber = 1; // Metadata: 0x00B04513
	private uint questId_; // 0x18
	public const int InvestigationIdFieldNumber = 2; // Metadata: 0x00B04517
	private uint investigationId_; // 0x1C
	public const int StateFieldNumber = 3; // Metadata: 0x00B0451B
	private Types.State state_; // 0x20
	public const int ProgressFieldNumber = 4; // Metadata: 0x00B0451F
	private uint progress_; // 0x24
	public const int TotalProgressFieldNumber = 5; // Metadata: 0x00B04523
	private uint totalProgress_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InvestigationTarget> Parser { get => default; } // 0x0000000185881180-0x0000000185881210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185880E70-0x0000000185880F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001858809E0-0x0000000185880A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001858800B0-0x0000000185880110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185881670-0x0000000185881760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185881340-0x00000001858813A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185880FA0-0x0000000185881090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185881620-0x0000000185881670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185880BA0-0x0000000185880C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x000000018587FF70-0x0000000185880010 0x0000000185880940-0x00000001858809E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InvestigationId { get => default; set {} } // 0x000000018587FD80-0x000000018587FE20 0x000000018587FCE0-0x000000018587FD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x0000000185880800-0x00000001858808A0 0x00000001858808A0-0x0000000185880940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x0000000185880F00-0x0000000185880FA0 0x0000000185880B00-0x0000000185880BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x0000000185881580-0x0000000185881620 0x0000000185880010-0x00000001858800B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23575
	{
		// Nested types
		public enum State // TypeDefIndex: 23576
		{
			Invalid = 0,
			InProgress = 1,
			Complete = 2,
			RewardTaken = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationTarget() {} // 0x0000000185881BC0-0x0000000185881C30
	static InvestigationTarget() {} // 0x0000000185881B00-0x0000000185881BC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationTarget Clone() => default; // 0x0000000185881090-0x0000000185881180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationTarget ShallowCopy() => default; // 0x0000000185880A60-0x0000000185880B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001858802C0-0x0000000185880310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001858812A0-0x00000001858812F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001858812F0-0x0000000185881340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185880310-0x00000001858803B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185880520-0x00000001858805F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InvestigationTarget other) => default; // 0x00000001858803B0-0x0000000185880520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185880C90-0x0000000185880E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185881760-0x0000000185881B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001858813A0-0x0000000185881580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001858805F0-0x0000000185880800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InvestigationTarget other) {} // 0x0000000185880110-0x00000001858802C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018587FE20-0x000000018587FF70
}

