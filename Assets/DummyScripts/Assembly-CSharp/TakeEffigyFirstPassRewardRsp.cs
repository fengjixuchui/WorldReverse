/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeEffigyFirstPassRewardRsp : MessageBase, IMessage<TakeEffigyFirstPassRewardRsp> // TypeDefIndex: 22080
{
	// Fields
	private static readonly MessageParser<TakeEffigyFirstPassRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00BF7
	private int retcode_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B00BFB
	private uint challengeId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeEffigyFirstPassRewardRsp> Parser { get => default; } // 0x000000018108E470-0x000000018108E500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018108E160-0x000000018108E1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018108DDB0-0x000000018108DE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018108D700-0x000000018108D760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018108E800-0x000000018108E8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018108E630-0x000000018108E690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018108E1F0-0x000000018108E2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018108E7B0-0x000000018108E800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018108DED0-0x000000018108DFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018108DD10-0x000000018108DDB0 0x000000018108D950-0x000000018108D9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x000000018108E0C0-0x000000018108E160 0x000000018108E3D0-0x000000018108E470

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22081
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22082
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2106
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardRsp() {} // 0x000000018108EBB0-0x000000018108EC10
	static TakeEffigyFirstPassRewardRsp() {} // 0x000000018108EAF0-0x000000018108EBB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardRsp Clone() => default; // 0x000000018108E2E0-0x000000018108E3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardRsp ShallowCopy() => default; // 0x000000018108DE30-0x000000018108DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018108D890-0x000000018108D8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018108E590-0x000000018108E5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018108E5E0-0x000000018108E630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018108D8E0-0x000000018108D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018108D9F0-0x000000018108DAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeEffigyFirstPassRewardRsp other) => default; // 0x000000018108DAC0-0x000000018108DBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018108DFC0-0x000000018108E0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018108E8F0-0x000000018108EAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018108E690-0x000000018108E7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018108DBE0-0x000000018108DD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeEffigyFirstPassRewardRsp other) {} // 0x000000018108D760-0x000000018108D890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018108D600-0x000000018108D700
}

