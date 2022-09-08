/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ActorCommand : BaseCommand // TypeDefIndex: 20605
{
	// Fields
	private static List<ActorCommandType[]> _commandGroupTypeInfos; // 0x00
	private static List<ActorCommandGroupType> _command2GroupType; // 0x08
	private static Dictionary<int, Queue<BaseCommand>> _pool; // 0x10
	protected ActorCommandType _cmdID; // 0x10

	// Properties
	public virtual ActorCommandType CmdID { /* [XID] */ /* 0x0000000189A82600-0x0000000189A82620 */ get => default; } // 0x0000000181FBA680-0x0000000181FBA720 

	// Constructors
	public ActorCommand() {} // 0x0000000181FBAAE0-0x0000000181FBAB50
	static ActorCommand() {} // 0x0000000181FBA7C0-0x0000000181FBAAE0

	// Methods
	// [XID] // 0x000000018969B9F0-0x000000018969BA10
	public static ActorCommandType[] GetGroupTypeInfos(int actorCommandGroupType) => default; // 0x0000000181FBA220-0x0000000181FBA310
	// [XID] // 0x00000001896A30C0-0x00000001896A30E0
	public static ActorCommandGroupType GetGroupType(int actorCommandType) => default; // 0x0000000181FB9F30-0x0000000181FBA020
	// [XID] // 0x00000001896AA510-0x00000001896AA530
	public static void ReleaseCommandDic(Dictionary<int, List<BaseCommand>> cmdDic) {} // 0x0000000181FBA020-0x0000000181FBA220
	// [XID] // 0x000000018985A990-0x000000018985A9B0
	public static void ReleaseCommandList(List<BaseCommand> cmds) {} // 0x0000000181FBA3C0-0x0000000181FBA520
	public static CmdType Get<CmdType>(ActorCommandType cType)
		where CmdType : BaseCommand, new() => default;
	// [XID] // 0x00000001896B8EB0-0x00000001896B8ED0
	public static void Release(BaseCommand cmd) {} // 0x0000000181FBA520-0x0000000181FBA680
	// [XID] // 0x00000001896C79B0-0x00000001896C79D0
	public void Init(ActorCommandType cmdID) {} // 0x0000000181FBA310-0x0000000181FBA3C0
	// [XID] // 0x00000001896CF2A0-0x00000001896CF2C0
	public virtual void ResetObject() {} // 0x0000000181FBA720-0x0000000181FBA7C0
}

