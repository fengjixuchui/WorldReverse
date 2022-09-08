/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetCityReputationMapInfoRsp : MessageBase, IMessage<GetCityReputationMapInfoRsp> // TypeDefIndex: 24789
{
	// Fields
	private static readonly MessageParser<GetCityReputationMapInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B073D3
	private int retcode_; // 0x18
	public const int RewardCityListFieldNumber = 2; // Metadata: 0x00B073D7
	private static readonly FieldCodec<uint> _repeated_rewardCityList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> rewardCityList_; // 0x20
	public const int IsNewRequestFieldNumber = 3; // Metadata: 0x00B073DB
	private bool isNewRequest_; // 0x28
	public const int IsNewHuntingFieldNumber = 4; // Metadata: 0x00B073DF
	private bool isNewHunting_; // 0x29
	public const int UnlockHuntingCityListFieldNumber = 5; // Metadata: 0x00B073E3
	private static readonly FieldCodec<uint> _repeated_unlockHuntingCityList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> unlockHuntingCityList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetCityReputationMapInfoRsp> Parser { get => default; } // 0x00000001831E4ED0-0x00000001831E4F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831E4C00-0x00000001831E4C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831E47D0-0x00000001831E4850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831E3D40-0x00000001831E3DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831E5400-0x00000001831E54F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831E5090-0x00000001831E50F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831E4CF0-0x00000001831E4DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831E53B0-0x00000001831E5400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831E48F0-0x00000001831E49E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001831E4690-0x00000001831E4730 0x00000001831E40D0-0x00000001831E4170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RewardCityList { get => default; } // 0x00000001831E4170-0x00000001831E41D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRequest { get => default; set {} } // 0x00000001831E4B60-0x00000001831E4C00 0x00000001831E4730-0x00000001831E47D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewHunting { get => default; set {} } // 0x00000001831E50F0-0x00000001831E5190 0x00000001831E41D0-0x00000001831E4270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockHuntingCityList { get => default; } // 0x00000001831E4C90-0x00000001831E4CF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24790
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24791
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2813
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityReputationMapInfoRsp() {} // 0x00000001831E5960-0x00000001831E5A10
	static GetCityReputationMapInfoRsp() {} // 0x00000001831E5860-0x00000001831E5960

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityReputationMapInfoRsp Clone() => default; // 0x00000001831E4DE0-0x00000001831E4ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityReputationMapInfoRsp ShallowCopy() => default; // 0x00000001831E4850-0x00000001831E48F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831E3F40-0x00000001831E3F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831E4FF0-0x00000001831E5040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831E5040-0x00000001831E5090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831E3F90-0x00000001831E40D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831E4400-0x00000001831E44D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetCityReputationMapInfoRsp other) => default; // 0x00000001831E4270-0x00000001831E4400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831E49E0-0x00000001831E4B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831E54F0-0x00000001831E5860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831E5190-0x00000001831E53B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831E44D0-0x00000001831E4690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetCityReputationMapInfoRsp other) {} // 0x00000001831E3DA0-0x00000001831E3F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831E3B30-0x00000001831E3D40
}

