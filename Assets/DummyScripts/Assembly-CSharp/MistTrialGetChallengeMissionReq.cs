/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialGetChallengeMissionReq : MessageBase, IMessage<MistTrialGetChallengeMissionReq> // TypeDefIndex: 22341
{
	// Fields
	private static readonly MessageParser<MistTrialGetChallengeMissionReq> _parser; // 0x00
	public const int TrialIdFieldNumber = 1; // Metadata: 0x00B015EF
	private uint trialId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialGetChallengeMissionReq> Parser { get => default; } // 0x000000018255C6A0-0x000000018255C730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018255C390-0x000000018255C420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018255C0A0-0x000000018255C120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018255BB10-0x000000018255BB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018255C9F0-0x000000018255CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018255C860-0x000000018255C8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018255C420-0x000000018255C510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018255C9A0-0x000000018255C9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018255C1C0-0x000000018255C2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialId { get => default; set {} } // 0x000000018255C600-0x000000018255C6A0 0x000000018255C000-0x000000018255C0A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22342
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22343
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8023
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionReq() {} // 0x000000018255CD10-0x000000018255CD70
	static MistTrialGetChallengeMissionReq() {} // 0x000000018255CC50-0x000000018255CD10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionReq Clone() => default; // 0x000000018255C510-0x000000018255C600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionReq ShallowCopy() => default; // 0x000000018255C120-0x000000018255C1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018255BC80-0x000000018255BCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018255C7C0-0x000000018255C810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018255C810-0x000000018255C860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018255BCD0-0x000000018255BD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018255BE40-0x000000018255BF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialGetChallengeMissionReq other) => default; // 0x000000018255BD40-0x000000018255BE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018255C2B0-0x000000018255C390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018255CAE0-0x000000018255CC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018255C8C0-0x000000018255C9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018255BF10-0x000000018255C000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialGetChallengeMissionReq other) {} // 0x000000018255BB70-0x000000018255BC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018255BA30-0x000000018255BB10
}

