/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAISensing : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17385
{
	// Fields
	private bool _enable; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAISensingSetting> _settings; // 0x18
	private Dictionary<string, Dictionary<string, string>> _templates; // 0x20
	public static Action<ConfigAISensing, bool> postProcessData; // 0x00
	public static Action<ConfigAISensing> postInitEmpty; // 0x08
	public static readonly string DEFAULT_SETTING; // 0x10
	public static readonly string DEFAULT_POSES; // 0x18
	public static readonly string DEFAULT_TEMPLATE; // 0x20
	[BlackList] // 0x0000000189A3C630-0x0000000189A3C680
	[JsonIgnore] // 0x0000000189A3C630-0x0000000189A3C680
	// [PooledField] // 0x0000000189A3C630-0x0000000189A3C680
	public Dictionary<string, Dictionary<string, ConfigAISensingSetting>> templatesSetting; // 0x28
	public static ConfigAISensingSetting defaultSetting; // 0x28
	public static Dictionary<string, ConfigAISensingSetting> defaultTemplate; // 0x30
	public static Dictionary<string, Dictionary<string, ConfigAISensingSetting>> defaultTemplatesSetting; // 0x38

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189A97750-0x0000000189A97770 */ get => default; /* [XID] */ /* 0x0000000189A13340-0x0000000189A13360 */ private set {} } // 0x00000001830AF7A0-0x00000001830AF840 0x00000001830B04A0-0x00000001830B0550
	public Dictionary<string, ConfigAISensingSetting> settings { /* [XID] */ /* 0x0000000189A1A4F0-0x0000000189A1A510 */ get => default; /* [XID] */ /* 0x0000000189A21C70-0x0000000189A21C90 */ private set {} } // 0x00000001830AFA80-0x00000001830AFB20 0x00000001830B03F0-0x00000001830B04A0
	public Dictionary<string, Dictionary<string, string>> templates { /* [XID] */ /* 0x0000000189A291C0-0x0000000189A291E0 */ get => default; /* [XID] */ /* 0x0000000189A307D0-0x0000000189A307F0 */ private set {} } // 0x00000001830AEFD0-0x00000001830AF070 0x00000001830AEF20-0x00000001830AEFD0

	// Constructors
	public ConfigAISensing() {} // 0x00000001830B0EF0-0x00000001830B0F60
	static ConfigAISensing() {} // 0x00000001830B0BD0-0x00000001830B0EF0

	// Methods
	// [XID] // 0x0000000189A381B0-0x0000000189A381D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830B0870-0x00000001830B0990
	// [XID] // 0x0000000189A3F900-0x0000000189A3F920
	public void InitEmpty() {} // 0x00000001830AF920-0x00000001830AFA80
	[BlackList] // 0x0000000189A46FD0-0x0000000189A47010
	// [XID] // 0x0000000189A46FD0-0x0000000189A47010
	public bool FromJson(JSONNode node) => default; // 0x00000001830AF3A0-0x00000001830AF7A0
	// [XID] // 0x0000000189A51770-0x0000000189A51790
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830AE410-0x00000001830AE790
	// [XID] // 0x0000000189A58F20-0x0000000189A58F40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C8F */, bool useObjectPool = false /* Metadata: 0x00AF6C93 */) => default; // 0x00000001830AFB20-0x00000001830AFEA0
	// [XID] // 0x0000000189A60840-0x0000000189A60860
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C94 */, bool useObjectPool = false /* Metadata: 0x00AF6C98 */) => default; // 0x00000001830AF070-0x00000001830AF3A0
	[BlackList] // 0x0000000189A68630-0x0000000189A68670
	// [XID] // 0x0000000189A68630-0x0000000189A68670
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830AE790-0x00000001830AEA60
	// [XID] // 0x0000000189A72B20-0x0000000189A72B40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830B0550-0x00000001830B0870
	// [XID] // 0x0000000189A7A5F0-0x0000000189A7A610
	public virtual void OnPoolAllocated() {} // 0x00000001830B0A90-0x00000001830B0B30
	// [XID] // 0x0000000189A81AF0-0x0000000189A81B10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830B0990-0x00000001830B0A90
	// [XID] // 0x0000000189A89610-0x0000000189A89630
	private static void OnPostInitEmpty(ConfigAISensing data) {} // 0x00000001830AF840-0x00000001830AF920
	// [XID] // 0x0000000189A90DD0-0x0000000189A90DF0
	private static void OnPostProcessDataCallback(ConfigAISensing data, bool useObjectPool) {} // 0x00000001830AFEA0-0x00000001830B03F0
	// [XID] // 0x0000000189A985A0-0x0000000189A985C0
	private static Dictionary<string, ConfigAISensingSetting> BuildTemplate(ConfigAISensing data, Dictionary<string, string> configTemplate, Dictionary<string, ConfigAISensingSetting> repository) => default; // 0x00000001830AEBD0-0x00000001830AEF20
	[BlackList] // 0x0000000189A9F9F0-0x0000000189A9FA30
	// [XID] // 0x0000000189A9F9F0-0x0000000189A9FA30
	public virtual void AutoAllocTypeFields() {} // 0x00000001830AEA60-0x00000001830AEB00
	[BlackList] // 0x0000000189AA9E60-0x0000000189AA9EA0
	// [XID] // 0x0000000189AA9E60-0x0000000189AA9EA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830AEB00-0x00000001830AEBD0
	[BlackList] // 0x0000000189AB49B0-0x0000000189AB49F0
	// [XID] // 0x0000000189AB49B0-0x0000000189AB49F0
	public virtual void ReturnToObjectPool() {} // 0x00000001830B0B30-0x00000001830B0BD0
}

