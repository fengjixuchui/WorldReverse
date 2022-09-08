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
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class EntityConfigPageBase : ConfigLoadBase // TypeDefIndex: 19493
{
	// Fields
	protected ulong _configHash; // 0x38
	protected ConfigEntity _configData; // 0x40
	protected float _lastAccessTimeStamp; // 0x48
	protected Dictionary<uint, int> _refEntities; // 0x50

	// Constructors
	public EntityConfigPageBase() {} // 0x000000018294D460-0x000000018294D500

	// Methods
	// [XID] // 0x0000000189A93630-0x0000000189A93650
	public virtual void Init(ulong configHash) {} // 0x000000018294C1A0-0x000000018294C260
	// [XID] // 0x0000000189A9B220-0x0000000189A9B240
	public override void Clear() {} // 0x000000018294C260-0x000000018294C370
	// [XID] // 0x0000000189AA2500-0x0000000189AA2520
	public override string Dump() => default; // 0x000000018294C6A0-0x000000018294C900
	// [XID] // 0x0000000189AA9A40-0x0000000189AA9A60
	public virtual ulong GetConfigHash() => default; // 0x000000018294CA90-0x000000018294CB30
	// [XID] // 0x0000000189AB1940-0x0000000189AB1960
	public void ApplySerializedData(ConfigEntity configEntity) {} // 0x000000018294BE60-0x000000018294C050
	// [IDTag] // 0x0000000189AB8BE0-0x0000000189AB8C20
	// [XID] // 0x0000000189AB8BE0-0x0000000189AB8C20
	public void AddRefCount(BaseEntity entity) {} // 0x000000018294CBD0-0x000000018294CD30
	// [IDTag] // 0x0000000189AC3CC0-0x0000000189AC3D00
	// [XID] // 0x0000000189AC3CC0-0x0000000189AC3D00
	public override void AddRefCount() {} // 0x000000018294CB30-0x000000018294CBD0
	// [XID] // 0x0000000189ACE2F0-0x0000000189ACE310
	public void MinusRefCount(BaseEntity entity) {} // 0x000000018294CD30-0x000000018294D210
	// [XID] // 0x0000000189AD6040-0x0000000189AD6060
	public void Preload(BaseEntity entity) {} // 0x000000018294BD90-0x000000018294BE60
	public abstract AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish);
	// [XID] // 0x0000000189ADD910-0x0000000189ADD930
	public AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded) => default; // 0x000000018294C900-0x000000018294CA90
	// [XID] // 0x0000000189AE51E0-0x0000000189AE5200
	public void ReleasePreload(BaseEntity entity) {} // 0x000000018294BCE0-0x000000018294BD90
	// [XID] // 0x0000000189AEC820-0x0000000189AEC840
	public Status GetStatus() => default; // 0x000000018294D2D0-0x000000018294D380
	// [XID] // 0x0000000189AF4230-0x0000000189AF4250
	public virtual ConfigEntity GetEntityConfig() => default; // 0x000000018294C4F0-0x000000018294C6A0
	// [XID] // 0x0000000189AFBA40-0x0000000189AFBA60
	protected override void CheckConfig() {} // 0x000000018294D380-0x000000018294D460
	protected abstract void LoadEntityConfig(ulong configHash);
	// [XID] // 0x0000000189B030F0-0x0000000189B03110
	public static ulong GetRuntimHash(ulong binHash, ConfigMetaConfig.PathHash[] registerPaths) => default; // 0x000000018294C050-0x000000018294C1A0
	// [XID] // 0x0000000189B0A850-0x0000000189B0A870
	public static ulong GetOriginFromBin(ulong binHash, ConfigMetaConfig.PathHash[] registerPaths) => default; // 0x000000018294C370-0x000000018294C480
	// [XID] // 0x0000000189B11F00-0x0000000189B11F20
	public static ulong GetBinFromOrigin(ulong originHash, ConfigMetaConfig.PathHash[] registerPaths) => default; // 0x000000018294BB70-0x000000018294BC80
}

