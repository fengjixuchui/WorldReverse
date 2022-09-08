/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAvatarStaminaStepRsp : MessageBase, IMessage<SceneAvatarStaminaStepRsp> // TypeDefIndex: 24925
{
	// Fields
	private static readonly MessageParser<SceneAvatarStaminaStepRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07913
	private int retcode_; // 0x18
	public const int UseClientRotFieldNumber = 2; // Metadata: 0x00B07917
	private bool useClientRot_; // 0x1C
	public const int RotFieldNumber = 3; // Metadata: 0x00B0791B
	private Vector rot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAvatarStaminaStepRsp> Parser { get => default; } // 0x0000000184613C70-0x0000000184613D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184613960-0x00000001846139F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184613500-0x0000000184613580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184612AE0-0x0000000184612B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846140A0-0x0000000184614190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184613E90-0x0000000184613EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184613A90-0x0000000184613B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184614050-0x00000001846140A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184613620-0x0000000184613710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001846133C0-0x0000000184613460 0x0000000184612F50-0x0000000184612FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseClientRot { get => default; set {} } // 0x0000000184613460-0x0000000184613500 0x00000001846138C0-0x0000000184613960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x00000001846139F0-0x0000000184613A90 0x0000000184612B40-0x0000000184612BE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24926
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24927
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			CmdId = 211
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepRsp() {} // 0x00000001846144C0-0x0000000184614520
	static SceneAvatarStaminaStepRsp() {} // 0x0000000184614400-0x00000001846144C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepRsp Clone() => default; // 0x0000000184613B80-0x0000000184613C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepRsp ShallowCopy() => default; // 0x0000000184613580-0x0000000184613620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184612D90-0x0000000184612E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184613D90-0x0000000184613E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184613E10-0x0000000184613E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184612E10-0x0000000184612F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184612FF0-0x00000001846130C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAvatarStaminaStepRsp other) => default; // 0x00000001846130C0-0x0000000184613210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184613710-0x00000001846138C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184614190-0x0000000184614400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184613EF0-0x0000000184614050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184613210-0x00000001846133C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAvatarStaminaStepRsp other) {} // 0x0000000184612BE0-0x0000000184612D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184612980-0x0000000184612AE0
}

