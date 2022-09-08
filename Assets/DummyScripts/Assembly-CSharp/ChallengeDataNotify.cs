/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChallengeDataNotify : MessageBase, IMessage<ChallengeDataNotify> // TypeDefIndex: 22865
{
	// Fields
	private static readonly MessageParser<ChallengeDataNotify> _parser; // 0x00
	public const int ChallengeIndexFieldNumber = 1; // Metadata: 0x00B02913
	private uint challengeIndex_; // 0x18
	public const int ParamIndexFieldNumber = 2; // Metadata: 0x00B02917
	private uint paramIndex_; // 0x1C
	public const int ValueFieldNumber = 3; // Metadata: 0x00B0291B
	private uint value_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChallengeDataNotify> Parser { get => default; } // 0x0000000184EB1F10-0x0000000184EB1FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EB1B60-0x0000000184EB1BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EB1820-0x0000000184EB18A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EB1160-0x0000000184EB11C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EB2420-0x0000000184EB2510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EB2170-0x0000000184EB21D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EB1D30-0x0000000184EB1E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EB23D0-0x0000000184EB2420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EB1940-0x0000000184EB1A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x0000000184EB13F0-0x0000000184EB1490 0x0000000184EB1BF0-0x0000000184EB1C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParamIndex { get => default; set {} } // 0x0000000184EB21D0-0x0000000184EB2270 0x0000000184EB10C0-0x0000000184EB1160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Value { get => default; set {} } // 0x0000000184EB1C90-0x0000000184EB1D30 0x0000000184EB2080-0x0000000184EB2120

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22866
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22867
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 920
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeDataNotify() {} // 0x0000000184EB2860-0x0000000184EB28C0
	static ChallengeDataNotify() {} // 0x0000000184EB27A0-0x0000000184EB2860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeDataNotify Clone() => default; // 0x0000000184EB1E20-0x0000000184EB1F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeDataNotify ShallowCopy() => default; // 0x0000000184EB18A0-0x0000000184EB1940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EB1320-0x0000000184EB1370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EB2030-0x0000000184EB2080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EB2120-0x0000000184EB2170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EB1370-0x0000000184EB13F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EB15D0-0x0000000184EB16A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChallengeDataNotify other) => default; // 0x0000000184EB1490-0x0000000184EB15D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EB1A30-0x0000000184EB1B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EB2510-0x0000000184EB27A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EB2270-0x0000000184EB23D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EB16A0-0x0000000184EB1820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChallengeDataNotify other) {} // 0x0000000184EB11C0-0x0000000184EB1320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EB0FB0-0x0000000184EB10C0
}

