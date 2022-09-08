/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TLEntityMgr // TypeDefIndex: 26207
{
	// Fields
	private static TLEntityMgr _inst; // 0x00
	private Dictionary<int, BaseEntity> _existEntityDic; // 0x10
	private Dictionary<int, BaseEntity> _tlEntityDic; // 0x18

	// Properties
	public static TLEntityMgr inst { get => default; } // 0x0000000185239DA0-0x0000000185239EA0 

	// Constructors
	public TLEntityMgr() {} // 0x0000000185239CF0-0x0000000185239DA0
	static TLEntityMgr() {} // 0x0000000185239C90-0x0000000185239CF0

	// Methods
	public BaseEntity GetExistEntity(int instID) => default; // 0x0000000185239AA0-0x0000000185239B40
	public void AddExistEntity(int instID, BaseEntity entity) {} // 0x0000000185239140-0x0000000185239200
	public void RemoveExistEntity(int instID) {} // 0x0000000185239BE0-0x0000000185239C90
	public void ClearExistEntity(int instID) {} // 0x0000000185239200-0x0000000185239290
	public BaseEntity GetTLEntity(int instID) => default; // 0x0000000185239B40-0x0000000185239BE0
	public BaseEntity CreateTLEntity(GameObject go) => default; // 0x0000000185239290-0x00000001852393E0
	public void DestroyTLEntity(int instID) {} // 0x00000001852399B0-0x0000000185239AA0
	public BaseEntity CreateTLStandInEntity(GameObject go, BaseEntity actorEntity) => default; // 0x00000001852393E0-0x0000000185239640
	public void DestroyTLEntityAll() {} // 0x0000000185239690-0x00000001852399B0
	private void DestroyMonoOfEntity(BaseEntity entity) {} // 0x0000000185239640-0x0000000185239690
}

