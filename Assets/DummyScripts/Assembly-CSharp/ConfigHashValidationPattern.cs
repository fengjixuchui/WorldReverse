/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConfigHashValidationPattern : ISimplePoolObject // TypeDefIndex: 26586
{
	// Fields
	private static SimpleObjectPool<ConfigHashValidationPattern> _pool; // 0x00
	private object _configData; // 0x10
	private uint _configOwnerID; // 0x18
	private uint _uniqId; // 0x1C
	private BaseEntity _owner; // 0x20
	private int _hashVal; // 0x28
	private ConfigHashGetter _hashGetter; // 0x30
	private Action<uint, int, object, uint> _onHashCalculated; // 0x38
	private Func<object> _getConfigData; // 0x40

	// Properties
	public uint configOwnerID { /* [XID] */ /* 0x0000000189B84A80-0x0000000189B84AA0 */ get => default; } // 0x0000000183350600-0x00000001833506A0 

	// Constructors
	public ConfigHashValidationPattern() {} // 0x0000000183350C90-0x0000000183350D00
	static ConfigHashValidationPattern() {} // 0x0000000183350C20-0x0000000183350C90

	// Methods
	// [XID] // 0x0000000189B46CE0-0x0000000189B46D00
	public static ConfigHashValidationPattern Create(ConfigHashGetter hashGetter, Action<uint, int, object, uint> onHashCalculated) => default; // 0x00000001833506A0-0x00000001833507C0
	// [XID] // 0x0000000189B55AC0-0x0000000189B55AE0
	public static void Release(ConfigHashValidationPattern pattern) {} // 0x0000000183350970-0x0000000183350A60
	// [XID] // 0x000000018976DAA0-0x000000018976DAC0
	public void Init(ConfigHashGetter hashGetter, Action<uint, int, object, uint> onHashCalculated) {} // 0x0000000183350530-0x0000000183350600
	// [XID] // 0x0000000189B92F60-0x0000000189B92F80
	public void AddConfigData(uint ownerID, object data, uint uniqId, BaseEntity en, Func<object> getConfigData = null) {} // 0x0000000183350280-0x0000000183350390
	// [XID] // 0x0000000189B9A540-0x0000000189B9A560
	public void ResetObject() {} // 0x0000000183350B60-0x0000000183350C20
	// [XID] // 0x0000000189BA1CF0-0x0000000189BA1D10
	public bool CheckEntity(BaseEntity en) => default; // 0x0000000183350390-0x0000000183350470
	// [XID] // 0x0000000189BA90B0-0x0000000189BA90D0
	public void CheckConfigData() {} // 0x0000000183350470-0x0000000183350530
	// [XID] // 0x0000000189BB0820-0x0000000189BB0840
	public void ComputeHash() {} // 0x0000000183350A60-0x0000000183350B60
	// [XID] // 0x0000000189BB7BA0-0x0000000189BB7BC0
	public void Flush() {} // 0x00000001833507C0-0x0000000183350970
}

