/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelConfigValidationPlugin : BaseComponentPlugin // TypeDefIndex: 12070
{
	// Fields
	private static uint _uniqId; // 0x00
	private static readonly float REFRESH_INTERVAL; // 0x04
	private TimerReceiver _streamConfigTimer; // 0x58
	private Queue<ConfigValidationResult> _validatedEntityAbilityResultQueue; // 0x60
	private Queue<ConfigValidationResult> _validatedEntityCombatResultQueue; // 0x68
	private Dictionary<uint, uint> _validatedEntityAbilityUniqIdDic; // 0x70

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898850A0-0x00000001898850C0 */ get => default; } // 0x000000018180E900-0x000000018180E9A0 

	// Nested types
	private struct ConfigValidationResult // TypeDefIndex: 12071
	{
		// Fields
		public uint entityID; // 0x00
		public int hashValue; // 0x04
		public uint uniqId; // 0x08
	}

	// Constructors
	public LevelConfigValidationPlugin() {} // 0x000000018180E890-0x000000018180E900
	static LevelConfigValidationPlugin() {} // 0x000000018180E810-0x000000018180E890

	// Methods
	// [XID] // 0x000000018988C680-0x000000018988C6A0
	public override void Init() {} // 0x000000018180E360-0x000000018180E510
	// [XID] // 0x0000000189893BD0-0x0000000189893BF0
	public override void Destroy() {} // 0x000000018180DCD0-0x000000018180DE10
	// [XID] // 0x0000000189B64CC0-0x0000000189B64CE0
	private uint GenNextUniqId() => default; // 0x000000018180E6D0-0x000000018180E810
	// [XID] // 0x00000001898A2730-0x00000001898A2750
	private bool CheckAbilityUniqId(uint pEntityID, uint pUniqId) => default; // 0x000000018180DBD0-0x000000018180DCD0
	// [XID] // 0x00000001898A9CA0-0x00000001898A9CC0
	private void RemoveAbilityUniqId(uint pEntityID) {} // 0x000000018180E1A0-0x000000018180E260
	// [XID] // 0x0000000189B5D500-0x0000000189B5D520
	public uint RegistValidateAbility(uint pEntityID) => default; // 0x000000018180E510-0x000000018180E600
	// [XID] // 0x00000001898B90A0-0x00000001898B90C0
	public void AddAbilityResult(uint pEntityID, int pHashValue, uint pUniqId) {} // 0x000000018180DAA0-0x000000018180DBD0
	// [XID] // 0x00000001898C0640-0x00000001898C0660
	public void AddCombatResult(uint pEntityID, int pHashValue) {} // 0x000000018180E260-0x000000018180E360
	// [XID] // 0x00000001898C7E20-0x00000001898C7E40
	private bool SendValidationResult() => default; // 0x000000018180DE10-0x000000018180E1A0
}

