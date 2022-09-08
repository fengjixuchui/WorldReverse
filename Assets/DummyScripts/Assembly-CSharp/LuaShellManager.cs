/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LuaShellManager : LuaBaseManager // TypeDefIndex: 21138
{
	// Fields
	private readonly string localLuaShellFile; // 0x18
	private ulong _lastLevelSaftyCheckStamp; // 0x20
	private LuaFunction _onUpdate; // 0x28
	private LuaFunction _onTick; // 0x30
	private bool tickChest; // 0x38
	private bool tickMonster; // 0x39
	private bool tickWorld; // 0x3A
	private ulong tickWordCD; // 0x40

	// Constructors
	public LuaShellManager() {} // 0x0000000182C51230-0x0000000182C51320

	// Methods
	// [XID] // 0x00000001897FD880-0x00000001897FD8A0
	public void TestLuaShell() {} // 0x0000000182C50BE0-0x0000000182C50C90
	// [XID] // 0x00000001898050B0-0x00000001898050D0
	public override void Init() {} // 0x0000000182C507D0-0x0000000182C508D0
	// [XID] // 0x000000018980C5B0-0x000000018980C5D0
	public void DoString(byte[] luaBytes) {} // 0x0000000182C502F0-0x0000000182C503C0
	// [XID] // 0x0000000189813D60-0x0000000189813D80
	public void DoFile(string file) {} // 0x0000000182C50C90-0x0000000182C50DE0
	// [XID] // 0x000000018981B8E0-0x000000018981B900
	public void ReportLuaShellResult(string type, string value) {} // 0x0000000182C50DE0-0x0000000182C50F50
	// [XID] // 0x0000000189822E90-0x0000000189822EB0
	public void RunScript(byte[] script) {} // 0x0000000182C508D0-0x0000000182C50BE0
	// [XID] // 0x000000018982A7F0-0x000000018982A810
	public void OnLevelBegin(BaseLevel level) {} // 0x0000000182C50570-0x0000000182C50690
	// [XID] // 0x0000000189831BE0-0x0000000189831C00
	public void OnLevelEnd(BaseLevel level) {} // 0x0000000182C51110-0x0000000182C51230
	// [XID] // 0x0000000189839240-0x0000000189839260
	public void OnMonsterBattle(BaseEntity entity) {} // 0x0000000182C500B0-0x0000000182C502F0
	// [XID] // 0x0000000189840890-0x00000001898408B0
	public void OnOpenChest() {} // 0x0000000182C50490-0x0000000182C50570
	// [XID] // 0x0000000189847DE0-0x0000000189847E00
	public void OnTeleport() {} // 0x0000000182C4FFE0-0x0000000182C500B0
	// [XID] // 0x000000018984F560-0x000000018984F580
	public void UpdateLevelTick() {} // 0x0000000182C50F50-0x0000000182C510A0
	// [XID] // 0x0000000189856740-0x0000000189856760
	public void OnDungeonChallengeEnd() {} // 0x0000000182C503C0-0x0000000182C50490
	// [XID] // 0x000000018985D9F0-0x000000018985DA10
	public void InitGG(bool openGG) {} // 0x0000000182C50690-0x0000000182C507D0
}

