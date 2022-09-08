/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua.CSObjectWrap
{
	public sealed class MoleMoleActorManagerILuaActorManagerBridge : LuaBase, ActorManager.ILuaActorManager // TypeDefIndex: 32243
	{
		// Constructors
		public MoleMoleActorManagerILuaActorManagerBridge() {} // Dummy constructor
		public MoleMoleActorManagerILuaActorManagerBridge(int reference, LuaEnv luaenv) {} // 0x0000000186498750-0x00000001864987D0
	
		// Methods
		public static LuaBase __Create(int reference, LuaEnv luaenv) => default; // 0x00000001864986C0-0x0000000186498750
		void MoleMole.ActorManager.ILuaActorManager.InitGlobal() {} // 0x00000001864978B0-0x0000000186497AF0
		void MoleMole.ActorManager.ILuaActorManager.InitSubGlobal() {} // 0x0000000186497AF0-0x0000000186497D30
		ILuaActor MoleMole.ActorManager.ILuaActorManager.GetActor(string alias) => default; // 0x0000000186497310-0x0000000186497630
		ILuaActor MoleMole.ActorManager.ILuaActorManager.CreateActor(string alias, string metaPath, bool isAutoStart) => default; // 0x0000000186495DD0-0x0000000186496100
		ILuaActor MoleMole.ActorManager.ILuaActorManager.CreateActorWithData(ILuaActorInfoData data) => default; // 0x0000000186495AB0-0x0000000186495DD0
		ILuaActor MoleMole.ActorManager.ILuaActorManager.CreateLocalActorWithData(ILuaActorInfoData data) => default; // 0x0000000186496100-0x0000000186496420
		ILuaActor MoleMole.ActorManager.ILuaActorManager.CreateQuestActor(string alias, string metaPath, uint mainID, uint mainConfigID) => default; // 0x0000000186496420-0x0000000186496760
		void MoleMole.ActorManager.ILuaActorManager.StartActor(string alias) {} // 0x0000000186498460-0x00000001864986C0
		void MoleMole.ActorManager.ILuaActorManager.DestroyActor(string alias, bool isActorOnly) {} // 0x00000001864969C0-0x0000000186496C30
		void MoleMole.ActorManager.ILuaActorManager.DestroyActorMeta(string alias) {} // 0x0000000186496760-0x00000001864969C0
		void MoleMole.ActorManager.ILuaActorManager.Destroy() {} // 0x00000001864970D0-0x0000000186497310
		void MoleMole.ActorManager.ILuaActorManager.DestroySoft() {} // 0x0000000186496E90-0x00000001864970D0
		void MoleMole.ActorManager.ILuaActorManager.SetEntityHandler(string alias, uint runtimeID) {} // 0x00000001864981F0-0x0000000186498460
		uint MoleMole.ActorManager.ILuaActorManager.GetEntityHandler(string alias) => default; // 0x0000000186497630-0x00000001864978B0
		void MoleMole.ActorManager.ILuaActorManager.DestroyEntityHandler(string alias) {} // 0x0000000186496C30-0x0000000186496E90
		void MoleMole.ActorManager.ILuaActorManager.NotifyBanDailyExternal(string alias) {} // 0x0000000186497D30-0x0000000186497F90
		void MoleMole.ActorManager.ILuaActorManager.NotifyStartDailyExternal(string alias) {} // 0x0000000186497F90-0x00000001864981F0
		void MoleMole.ActorManager.ILuaActorManager.ChangeActorAlias(ILuaActor actor, string alias) {} // 0x0000000186495810-0x0000000186495AB0
	}
}
