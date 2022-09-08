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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelTileAttackPlugin : BaseComponentPlugin // TypeDefIndex: 12124
{
	// Fields
	private Dictionary<string, HashSet<long>> tileAttackGroupIdDic; // 0x58
	private Dictionary<string, Dictionary<uint, HashSet<long>>> tileActionGroupIdDic; // 0x60
	private Dictionary<string, Dictionary<long, HashSet<TileComplexInfo>>> tileComplexGroupDic; // 0x68
	private static uint ENVIRO_CAMP; // 0x00
	private bool _isDoingAction; // 0x70
	private static Vector3 DEFAULT_ATTAK_SIZE; // 0x04
	private static Vector3 DEFAULT_ATTAK_OFFSET; // 0x10
	private bool _isDirty; // 0x71

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018962E7A0-0x000000018962E7C0 */ get => default; } // 0x0000000181A721D0-0x0000000181A72270 

	// Constructors
	public LevelTileAttackPlugin() {} // 0x0000000181A72150-0x0000000181A721D0
	static LevelTileAttackPlugin() {} // 0x0000000181A72040-0x0000000181A72150

	// Methods
	// [XID] // 0x0000000189636440-0x0000000189636460
	public override void Init() {} // 0x0000000181A70C50-0x0000000181A70D60
	// [XID] // 0x000000018963DA50-0x000000018963DA70
	public override void Destroy() {} // 0x0000000181A6F920-0x0000000181A6FA20
	// [XID] // 0x0000000189645000-0x0000000189645020
	public void RegisterAttackTile(string name, Vector3 pos) {} // 0x0000000181A6F540-0x0000000181A6F740
	// [XID] // 0x000000018964CAC0-0x000000018964CAE0
	public void UnregisterAttackTile(string name, Vector3 pos) {} // 0x0000000181A71320-0x0000000181A714D0
	// [XID] // 0x0000000189653EF0-0x0000000189653F10
	public int GetAttackedEntities(string name, BaseEntity[] results, int max) => default; // 0x0000000181A70160-0x0000000181A70550
	// [IDTag] // 0x000000018965B8B0-0x000000018965B8F0
	// [XID] // 0x000000018965B8B0-0x000000018965B8F0
	private bool IsEntityInTile(HashSet<long> group, BaseEntity entity) => default; // 0x0000000181A71EA0-0x0000000181A72040
	// [XID] // 0x0000000189665D80-0x0000000189665DA0
	private void RegisterActionTileInternal(string name, Vector3 pos, uint entityId) {} // 0x0000000181A70550-0x0000000181A707C0
	// [XID] // 0x000000018966D4F0-0x000000018966D510
	public void RegisterActionTile(string name, Vector3 pos, uint entityId) {} // 0x0000000181A6F740-0x0000000181A6F920
	// [XID] // 0x0000000189675510-0x0000000189675530
	public int DoTileAction(string name, Vector3[] groupPosList, float[] groupRadiusList, uint[] groupEntityIdList, int maxCount) => default; // 0x0000000181A6FA20-0x0000000181A70040
	// [XID] // 0x000000018967CB80-0x000000018967CBA0
	public TileComplexInfo RegisterComplexTile(string name, Vector3 pos, Quaternion rotate, TileShapeInfo shapeInfo) => default; // 0x0000000181A70DC0-0x0000000181A712B0
	// [XID] // 0x00000001896841A0-0x00000001896841C0
	public void UnregisterComplexTile(string name, ref TileComplexInfo info) {} // 0x0000000181A714D0-0x0000000181A71910
	// [XID] // 0x000000018968BE50-0x000000018968BE70
	public int GetComplexAttackedEntities(BaseEntity attacker, string name, BaseEntity[] results, Vector3[] hitPoints, int max, uint srcCamp) => default; // 0x0000000181A707C0-0x0000000181A70C50
	// [IDTag] // 0x00000001896939D0-0x0000000189693A10
	// [XID] // 0x00000001896939D0-0x0000000189693A10
	private bool IsEntityInTile(Dictionary<long, HashSet<TileComplexInfo>> group, BaseEntity entity, int frameCount) => default; // 0x0000000181A71A90-0x0000000181A71EA0
	// [XID] // 0x000000018969E0A0-0x000000018969E0C0
	public void RegisterActionTileFromThread(string name, Vector3 pos, uint entityId) {} // 0x0000000181A70040-0x0000000181A70160
	// [XID] // 0x00000001896A5110-0x00000001896A5130
	public void FlushRegisterActionTile() {} // 0x0000000181A71910-0x0000000181A71A90
}

