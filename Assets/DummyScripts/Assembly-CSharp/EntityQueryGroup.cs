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

public class EntityQueryGroup // TypeDefIndex: 20809
{
	// Fields
	private const int DEFAULT_CACHE_SIZE = 50; // Metadata: 0x00AFE472
	private IndexHandleObjectList<BaseEntity>[] _entityQueryArr; // 0x10
	private Dictionary<uint, IndexHandleObjectList<BaseEntity>>[] _entityQueryDicArr; // 0x18
	private EntityManager _entityMgr; // 0x20

	// Constructors
	public EntityQueryGroup() {} // 0x00000001829137C0-0x0000000182913830

	// Methods
	// [XID] // 0x000000018961D490-0x000000018961D4B0
	public static EntityQueryGroup Create(EntityManager entityMgr) => default; // 0x0000000182912C10-0x0000000182912CF0
	// [XID] // 0x0000000189624990-0x00000001896249B0
	public void Init(EntityManager entityMgr) {} // 0x00000001829129F0-0x0000000182912C10
	// [XID] // 0x000000018962C130-0x000000018962C150
	public void Destroy() {} // 0x0000000182912620-0x00000001829129F0
	// [IDTag] // 0x0000000189633C70-0x0000000189633CB0
	// [XID] // 0x0000000189633C70-0x0000000189633CB0
	public void Add(EntityQueryType queryType, BaseEntity entity) {} // 0x0000000182913480-0x00000001829135E0
	// [IDTag] // 0x000000018963E3C0-0x000000018963E400
	// [XID] // 0x000000018963E3C0-0x000000018963E400
	public void Add(EntityQueryDicType queryType, uint subKey, BaseEntity entity) {} // 0x0000000182913290-0x0000000182913480
	// [IDTag] // 0x0000000189648B40-0x0000000189648B80
	// [XID] // 0x0000000189648B40-0x0000000189648B80
	public void Remove(EntityQueryType queryType, BaseEntity entity) {} // 0x0000000182912CF0-0x0000000182912E70
	// [IDTag] // 0x00000001896533A0-0x00000001896533E0
	// [XID] // 0x00000001896533A0-0x00000001896533E0
	public void Remove(EntityQueryDicType queryType, uint subKey, BaseEntity entity) {} // 0x0000000182912E70-0x0000000182913040
	// [IDTag] // 0x000000018965DB50-0x000000018965DB90
	// [XID] // 0x000000018965DB50-0x000000018965DB90
	public IndexHandleObjectList<BaseEntity> Get(EntityQueryType queryType) => default; // 0x0000000182913040-0x0000000182913120
	// [IDTag] // 0x00000001896683C0-0x0000000189668400
	// [XID] // 0x00000001896683C0-0x0000000189668400
	public IndexHandleObjectList<BaseEntity> Get(EntityQueryDicType queryType, uint subKey) => default; // 0x0000000182913120-0x0000000182913290
	// [IDTag] // 0x0000000189672F60-0x0000000189672FA0
	// [XID] // 0x0000000189672F60-0x0000000189672FA0
	public BaseEntity GetEntity(EntityQueryType queryType, uint runtimeID) => default; // 0x0000000182912390-0x00000001829124D0
	// [IDTag] // 0x000000018967D7C0-0x000000018967D800
	// [XID] // 0x000000018967D7C0-0x000000018967D800
	public BaseEntity GetEntity(EntityQueryDicType queryType, uint subKey, uint runtimeID) => default; // 0x00000001829124D0-0x0000000182912620
	// [IDTag] // 0x0000000189688340-0x0000000189688380
	// [XID] // 0x0000000189688340-0x0000000189688380
	public bool HasEntity(EntityQueryType queryType, BaseEntity entity) => default; // 0x00000001829136D0-0x00000001829137C0
	// [IDTag] // 0x0000000189692F10-0x0000000189692F50
	// [XID] // 0x0000000189692F10-0x0000000189692F50
	public bool HasEntity(EntityQueryType queryType, uint runtimeID) => default; // 0x00000001829135E0-0x00000001829136D0
}

