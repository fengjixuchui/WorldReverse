/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetInvestigationMonsterRsp : MessageBase, IMessage<GetInvestigationMonsterRsp> // TypeDefIndex: 23598
{
	// Fields
	private static readonly MessageParser<GetInvestigationMonsterRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04607
	private int retcode_; // 0x18
	public const int MonsterListFieldNumber = 2; // Metadata: 0x00B0460B
	private static readonly FieldCodec<InvestigationMonster> _repeated_monsterList_codec; // 0x08
	private readonly RepeatedMessageField<InvestigationMonster> monsterList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetInvestigationMonsterRsp> Parser { get => default; } // 0x0000000184EAB9F0-0x0000000184EABA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EAB780-0x0000000184EAB810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EAB470-0x0000000184EAB4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EAAD00-0x0000000184EAAD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EABE20-0x0000000184EABF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EABC30-0x0000000184EABC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EAB810-0x0000000184EAB900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EABDD0-0x0000000184EABE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EAB590-0x0000000184EAB680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184EAB3D0-0x0000000184EAB470 0x0000000184EAAFF0-0x0000000184EAB090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InvestigationMonster> MonsterList { get => default; } // 0x0000000184EABF10-0x0000000184EABF70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23599
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23600
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1907
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetInvestigationMonsterRsp() {} // 0x0000000184EAC260-0x0000000184EAC2F0
	static GetInvestigationMonsterRsp() {} // 0x0000000184EAC150-0x0000000184EAC260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetInvestigationMonsterRsp Clone() => default; // 0x0000000184EAB900-0x0000000184EAB9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetInvestigationMonsterRsp ShallowCopy() => default; // 0x0000000184EAB4F0-0x0000000184EAB590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EAAEC0-0x0000000184EAAF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EABB10-0x0000000184EABBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EABBA0-0x0000000184EABC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EAAF10-0x0000000184EAAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EAB090-0x0000000184EAB160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetInvestigationMonsterRsp other) => default; // 0x0000000184EAB160-0x0000000184EAB290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EAB680-0x0000000184EAB780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EABF70-0x0000000184EAC150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EABC90-0x0000000184EABDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EAB290-0x0000000184EAB3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetInvestigationMonsterRsp other) {} // 0x0000000184EAAD60-0x0000000184EAAEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EAABA0-0x0000000184EAAD00
}

