/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAvatarStaminaStepReq : MessageBase, IMessage<SceneAvatarStaminaStepReq> // TypeDefIndex: 24922
{
	// Fields
	private static readonly MessageParser<SceneAvatarStaminaStepReq> _parser; // 0x00
	public const int UseClientRotFieldNumber = 1; // Metadata: 0x00B078F7
	private bool useClientRot_; // 0x18
	public const int RotFieldNumber = 2; // Metadata: 0x00B078FB
	private Vector rot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAvatarStaminaStepReq> Parser { get => default; } // 0x0000000182270A60-0x0000000182270AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182270750-0x00000001822707E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182270320-0x00000001822703A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018226FAE0-0x000000018226FB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182270E50-0x0000000182270F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182270C80-0x0000000182270CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182270880-0x0000000182270970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182270E00-0x0000000182270E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182270440-0x0000000182270530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseClientRot { get => default; set {} } // 0x0000000182270280-0x0000000182270320 0x00000001822706B0-0x0000000182270750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x00000001822707E0-0x0000000182270880 0x000000018226FB40-0x000000018226FBE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24923
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24924
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 210
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepReq() {} // 0x00000001822711E0-0x0000000182271240
	static SceneAvatarStaminaStepReq() {} // 0x0000000182271120-0x00000001822711E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepReq Clone() => default; // 0x0000000182270970-0x0000000182270A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarStaminaStepReq ShallowCopy() => default; // 0x00000001822703A0-0x0000000182270440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018226FD60-0x000000018226FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182270B80-0x0000000182270C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182270C00-0x0000000182270C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018226FDE0-0x000000018226FF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018226FF10-0x000000018226FFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAvatarStaminaStepReq other) => default; // 0x000000018226FFE0-0x0000000182270110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182270530-0x00000001822706B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182270F40-0x0000000182271120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182270CE0-0x0000000182270E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182270110-0x0000000182270280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAvatarStaminaStepReq other) {} // 0x000000018226FBE0-0x000000018226FD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018226F9A0-0x000000018226FAE0
}

