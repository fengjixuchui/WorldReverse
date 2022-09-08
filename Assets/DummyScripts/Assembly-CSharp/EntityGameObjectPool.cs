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

public class EntityGameObjectPool // TypeDefIndex: 20803
{
	// Fields
	private Dictionary<uint, IndexHandleObjectList<EntityGameObjectNode>> _configId2EntityGameObjectPool; // 0x10
	private EntityGameObjectNode _head; // 0x18
	private EntityGameObjectNode _tail; // 0x20
	private int _cnt; // 0x28
	private int _maxNum; // 0x2C

	// Constructors
	public EntityGameObjectPool() {} // 0x00000001825B4820-0x00000001825B48D0

	// Methods
	// [XID] // 0x0000000189B8D210-0x0000000189B8D230
	public static EntityGameObjectPool Create(int maxNum) => default; // 0x00000001825B4340-0x00000001825B4420
	// [XID] // 0x0000000189B94970-0x0000000189B94990
	internal void Init(int maxNum) {} // 0x00000001825B4100-0x00000001825B41B0
	// [XID] // 0x000000018970E430-0x000000018970E450
	private void DeleteFromList(EntityGameObjectNode node) {} // 0x00000001825B4740-0x00000001825B4820
	// [XID] // 0x0000000189BA3790-0x0000000189BA37B0
	private void AddToList(EntityGameObjectNode node) {} // 0x00000001825B3F60-0x00000001825B4100
	// [XID] // 0x0000000189706AA0-0x0000000189706AC0
	public EntityGameObjectNode Get(uint configId) => default; // 0x00000001825B4420-0x00000001825B45B0
	// [XID] // 0x0000000189BB20D0-0x0000000189BB20F0
	public void Set(uint configId, EntityGameObjectNode node) {} // 0x00000001825B45B0-0x00000001825B4740
	// [XID] // 0x0000000189BB94C0-0x0000000189BB94E0
	public void Clear(uint configId) {} // 0x00000001825B41B0-0x00000001825B4340
	// [XID] // 0x0000000189BC12E0-0x0000000189BC1300
	public void ClearAll() {} // 0x00000001825B3DA0-0x00000001825B3F60
}

