/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class PSActivitiesActivityConfig : PSActivitiesBaseConfig, IAutoAllocRecycle // TypeDefIndex: 15957
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _activityNameTextMapHash; // 0x20
	protected uint _activityDescTextMapHash; // 0x24
	protected PSActivitiesCategoryType _category; // 0x28
	protected bool _availableByDefault; // 0x2C
	protected bool _isRequiredForCompletion; // 0x2D
	protected bool _hidden; // 0x2E
	protected bool _isOnlineMultiplay; // 0x2F
	protected string _largeIcon; // 0x30
	protected string _smallIcon; // 0x38

	// Properties
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityNameTextMapHash { /* [XID] */ /* 0x000000018984FB40-0x000000018984FB60 */ get => default; /* [XID] */ /* 0x0000000189856F00-0x0000000189856F20 */ protected set {} } // 0x00000001831A8700-0x00000001831A87A0 0x00000001831A8510-0x00000001831A85C0
	public string activityName { /* [XID] */ /* 0x000000018985E110-0x000000018985E130 */ get => default; } // 0x00000001831A88B0-0x00000001831A8A30 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityDescTextMapHash { /* [XID] */ /* 0x0000000189865B10-0x0000000189865B30 */ get => default; /* [XID] */ /* 0x000000018986D0D0-0x000000018986D0F0 */ protected set {} } // 0x00000001831A7900-0x00000001831A79A0 0x00000001831A7660-0x00000001831A7710
	public string activityDesc { /* [XID] */ /* 0x0000000189874500-0x0000000189874520 */ get => default; } // 0x00000001831A8B90-0x00000001831A8D10 
	public PSActivitiesCategoryType category { /* [XID] */ /* 0x000000018987C080-0x000000018987C0A0 */ get => default; /* [XID] */ /* 0x00000001898831F0-0x0000000189883210 */ protected set {} } // 0x00000001831A77C0-0x00000001831A7860 0x00000001831A79A0-0x00000001831A7A50
	public bool availableByDefault { /* [XID] */ /* 0x000000018988A930-0x000000018988A950 */ get => default; /* [XID] */ /* 0x0000000189891E20-0x0000000189891E40 */ protected set {} } // 0x00000001831A8470-0x00000001831A8510 0x00000001831A7710-0x00000001831A77C0
	public bool isRequiredForCompletion { /* [XID] */ /* 0x00000001898996B0-0x00000001898996D0 */ get => default; /* [XID] */ /* 0x00000001898A0850-0x00000001898A0870 */ protected set {} } // 0x00000001831A68B0-0x00000001831A6950 0x00000001831A6800-0x00000001831A68B0
	public bool hidden { /* [XID] */ /* 0x00000001898A7FB0-0x00000001898A7FD0 */ get => default; /* [XID] */ /* 0x00000001898AFA30-0x00000001898AFA50 */ protected set {} } // 0x00000001831A85C0-0x00000001831A8660 0x00000001831A8D10-0x00000001831A8DC0
	public bool isOnlineMultiplay { /* [XID] */ /* 0x00000001898B6FD0-0x00000001898B6FF0 */ get => default; /* [XID] */ /* 0x00000001898BE740-0x00000001898BE760 */ protected set {} } // 0x00000001831A7860-0x00000001831A7900 0x00000001831A8AE0-0x00000001831A8B90
	public string largeIcon { /* [XID] */ /* 0x00000001898C5F10-0x00000001898C5F30 */ get => default; /* [XID] */ /* 0x00000001898CD6C0-0x00000001898CD6E0 */ protected set {} } // 0x00000001831A8660-0x00000001831A8700 0x00000001831A8800-0x00000001831A88B0
	public string smallIcon { /* [XID] */ /* 0x00000001898D51D0-0x00000001898D51F0 */ get => default; /* [XID] */ /* 0x00000001898DCA50-0x00000001898DCA70 */ protected set {} } // 0x00000001831A6560-0x00000001831A6600 0x00000001831A8A30-0x00000001831A8AE0

	// Constructors
	public PSActivitiesActivityConfig() {} // 0x00000001831A8E60-0x00000001831A8EC0

	// Methods
	// [IDTag] // 0x00000001898E44C0-0x00000001898E4500
	// [XID] // 0x00000001898E44C0-0x00000001898E4500
	public virtual bool ParseFromLine(string line) => default; // 0x00000001831A7010-0x00000001831A7660
	// [IDTag] // 0x00000001898EF000-0x00000001898EF040
	// [XID] // 0x00000001898EF000-0x00000001898EF040
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001831A69B0-0x00000001831A7010
	// [XID] // 0x00000001898F9810-0x00000001898F9830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C39 */, bool useObjectPool = false /* Metadata: 0x00AF2C3D */) => default; // 0x00000001831A7B40-0x00000001831A8470
	[BlackList] // 0x0000000189901190-0x00000001899011D0
	// [XID] // 0x0000000189901190-0x00000001899011D0
	public override void AutoAllocTypeFields() {} // 0x00000001831A6600-0x00000001831A66A0
	[BlackList] // 0x000000018990B7D0-0x000000018990B810
	// [XID] // 0x000000018990B7D0-0x000000018990B810
	public override void AutoRecycleTypeFields() {} // 0x00000001831A66A0-0x00000001831A6760
	[BlackList] // 0x0000000189916160-0x00000001899161A0
	// [XID] // 0x0000000189916160-0x00000001899161A0
	public override void ReturnToObjectPool() {} // 0x00000001831A8DC0-0x00000001831A8E60
}

