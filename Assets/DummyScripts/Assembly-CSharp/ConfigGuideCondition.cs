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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGuideCondition : ConfigBaseGuide, IAutoAllocRecycle // TypeDefIndex: 18195
{
	// Fields
	protected NotifyTypes[] _listenNotifyList; // 0x10
	protected bool _isTickCheck; // 0x18

	// Constructors
	public ConfigGuideCondition() {} // 0x000000018161CCA0-0x000000018161CD30

	// Methods
	// [XID] // 0x0000000189BD95E0-0x0000000189BD9600
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018161CB50-0x000000018161CC00
	// [XID] // 0x00000001895E6150-0x00000001895E6170
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018161C810-0x000000018161C8C0
	// [XID] // 0x00000001895EDA90-0x00000001895EDAB0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF8FD9 */) => default; // 0x000000018161C420-0x000000018161C500
	// [XID] // 0x00000001895F52F0-0x00000001895F5310
	public override int GetHashNum() => default; // 0x000000018161AE20-0x000000018161AEF0
	// [XID] // 0x00000001895FC8B0-0x00000001895FC8D0
	public override void InitEmpty() {} // 0x000000018161BEB0-0x000000018161BF50
	[BlackList] // 0x0000000189604210-0x0000000189604250
	// [XID] // 0x0000000189604210-0x0000000189604250
	public override bool FromJson(JSONNode node) => default; // 0x000000018161B2B0-0x000000018161B630
	// [XID] // 0x000000018960EA00-0x000000018960EA20
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018161A7F0-0x000000018161A8E0
	[BlackList] // 0x0000000189616000-0x0000000189616040
	// [XID] // 0x0000000189616000-0x0000000189616040
	public static new ConfigGuideCondition ParseFromJson(JSONNode node) => default; // 0x000000018161C560-0x000000018161C7B0
	// [XID] // 0x0000000189620880-0x00000001896208A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FDA */, bool useObjectPool = false /* Metadata: 0x00AF8FDE */) => default; // 0x000000018161C120-0x000000018161C420
	// [XID] // 0x0000000189627D70-0x0000000189627D90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FDF */, bool useObjectPool = false /* Metadata: 0x00AF8FE3 */) => default; // 0x000000018161AFD0-0x000000018161B100
	// [XID] // 0x000000018962F6A0-0x000000018962F6C0
	public static new ConfigGuideCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FE4 */, bool useObjectPool = false /* Metadata: 0x00AF8FE8 */) => default; // 0x000000018161B630-0x000000018161B850
	[BlackList] // 0x00000001896371E0-0x0000000189637220
	// [XID] // 0x00000001896371E0-0x0000000189637220
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018161A8E0-0x000000018161ABB0
	// [XID] // 0x0000000189641660-0x0000000189641680
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018161CA60-0x000000018161CB50
	[BlackList] // 0x0000000189648FA0-0x0000000189648FE0
	// [XID] // 0x0000000189648FA0-0x0000000189648FE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018161C030-0x000000018161C120
	public static bool CheckOperate<T>(GuideOperator opt, T current, T target)
		where T : IComparable => default;
	// [XID] // 0x0000000189653600-0x0000000189653620
	public static bool IsValidContext(BaseContext baseContext, GuidePageType pageType) => default; // 0x000000018161B950-0x000000018161BD60
	// [XID] // 0x000000018965AE70-0x000000018965AE90
	public bool DoPrepare(GuideManager manager) => default; // 0x000000018161B850-0x000000018161B950
	// [XID] // 0x00000001896623E0-0x0000000189662400
	public void DoFinish(GuideManager manager) {} // 0x000000018161C8C0-0x000000018161C9B0
	// [XID] // 0x0000000189669FA0-0x0000000189669FC0
	public virtual bool Ready(object body = null) => default; // 0x000000018161BDD0-0x000000018161BEB0
	// [XID] // 0x0000000189671BE0-0x0000000189671C00
	protected virtual bool Prepare(GuideManager manager) => default; // 0x000000018161B200-0x000000018161B2B0
	// [XID] // 0x0000000189679410-0x0000000189679430
	protected virtual void Finish(GuideManager manager) {} // 0x000000018161C9B0-0x000000018161CA60
	[BlackList] // 0x0000000189680B40-0x0000000189680B80
	// [XID] // 0x0000000189680B40-0x0000000189680B80
	public override void AutoAllocTypeFields() {} // 0x000000018161ABB0-0x000000018161AC50
	[BlackList] // 0x000000018968B5D0-0x000000018968B610
	// [XID] // 0x000000018968B5D0-0x000000018968B610
	public override void AutoRecycleTypeFields() {} // 0x000000018161AC50-0x000000018161AD00
	[BlackList] // 0x00000001896961B0-0x00000001896961F0
	// [XID] // 0x00000001896961B0-0x00000001896961F0
	public override void ReturnToObjectPool() {} // 0x000000018161CC00-0x000000018161CCA0
}

