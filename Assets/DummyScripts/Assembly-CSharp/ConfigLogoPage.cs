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
public class ConfigLogoPage : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18514
{
	// Fields
	private string _channelName; // 0x10
	private string _logoFileName; // 0x18
	private bool _showTipText; // 0x20
	private string _tipTextMapID; // 0x28
	private bool _showTipImgAW; // 0x30
	private string _tipImgAWName; // 0x38
	private bool _showWarningView; // 0x40
	private string _warningTitle; // 0x48
	private string _warningDesc; // 0x50
	private bool _showKoranTipsView; // 0x58
	private string _koranTipsDesc; // 0x60

	// Properties
	public string channelName { /* [XID] */ /* 0x0000000189953150-0x0000000189953170 */ get => default; /* [XID] */ /* 0x000000018995A810-0x000000018995A830 */ private set {} } // 0x00000001846CECD0-0x00000001846CED70 0x00000001846CEA10-0x00000001846CEAC0
	public string logoFileName { /* [XID] */ /* 0x0000000189962330-0x0000000189962350 */ get => default; /* [XID] */ /* 0x00000001899697A0-0x00000001899697C0 */ private set {} } // 0x00000001846D0450-0x00000001846D04F0 0x00000001846D04F0-0x00000001846D05A0
	public bool showTipText { /* [XID] */ /* 0x00000001899714E0-0x0000000189971500 */ get => default; /* [XID] */ /* 0x0000000189978E90-0x0000000189978EB0 */ private set {} } // 0x00000001846CF9A0-0x00000001846CFA40 0x00000001846CFAF0-0x00000001846CFBA0
	public string tipTextMapID { /* [XID] */ /* 0x000000018997FF80-0x000000018997FFA0 */ get => default; /* [XID] */ /* 0x0000000189987730-0x0000000189987750 */ private set {} } // 0x00000001846CFC40-0x00000001846CFCE0 0x00000001846D05A0-0x00000001846D0650
	public bool showTipImgAW { /* [XID] */ /* 0x000000018998F380-0x000000018998F3A0 */ get => default; /* [XID] */ /* 0x0000000189996D20-0x0000000189996D40 */ private set {} } // 0x00000001846CFCE0-0x00000001846CFD80 0x00000001846D0D50-0x00000001846D0E00
	public string tipImgAWName { /* [XID] */ /* 0x000000018999E930-0x000000018999E950 */ get => default; /* [XID] */ /* 0x00000001899A6310-0x00000001899A6330 */ private set {} } // 0x00000001846CE600-0x00000001846CE6A0 0x00000001846CFEB0-0x00000001846CFF60
	public bool showWarningView { /* [XID] */ /* 0x00000001899AD940-0x00000001899AD960 */ get => default; /* [XID] */ /* 0x00000001899B51E0-0x00000001899B5200 */ private set {} } // 0x00000001846D03B0-0x00000001846D0450 0x00000001846D0300-0x00000001846D03B0
	public string warningTitle { /* [XID] */ /* 0x00000001899BC870-0x00000001899BC890 */ get => default; /* [XID] */ /* 0x00000001899C42C0-0x00000001899C42E0 */ private set {} } // 0x00000001846CE560-0x00000001846CE600 0x00000001846CFA40-0x00000001846CFAF0
	public string warningDesc { /* [XID] */ /* 0x00000001899CBA20-0x00000001899CBA40 */ get => default; /* [XID] */ /* 0x00000001899D2F10-0x00000001899D2F30 */ private set {} } // 0x00000001846CE970-0x00000001846CEA10 0x00000001846CF570-0x00000001846CF620
	public bool showKoranTipsView { /* [XID] */ /* 0x00000001899DA500-0x00000001899DA520 */ get => default; /* [XID] */ /* 0x00000001899E1F20-0x00000001899E1F40 */ private set {} } // 0x00000001846CFBA0-0x00000001846CFC40 0x00000001846CDAE0-0x00000001846CDB90
	public string koranTipsDesc { /* [XID] */ /* 0x00000001899E9420-0x00000001899E9440 */ get => default; /* [XID] */ /* 0x00000001899F0B10-0x00000001899F0B30 */ private set {} } // 0x00000001846D0260-0x00000001846D0300 0x00000001846CEC20-0x00000001846CECD0

	// Constructors
	public ConfigLogoPage() {} // 0x00000001846D11E0-0x00000001846D1240

	// Methods
	// [XID] // 0x00000001899F8410-0x00000001899F8430
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846D0E00-0x00000001846D1000
	// [XID] // 0x00000001899FFA00-0x00000001899FFA20
	public void InitEmpty() {} // 0x00000001846CFD80-0x00000001846CFEB0
	[BlackList] // 0x0000000189A07230-0x0000000189A07270
	// [XID] // 0x0000000189A07230-0x0000000189A07270
	public bool FromJson(JSONNode node) => default; // 0x00000001846CF620-0x00000001846CF9A0
	// [XID] // 0x0000000189A11A60-0x0000000189A11A80
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001846CDB90-0x00000001846CE560
	// [XID] // 0x0000000189A18CB0-0x0000000189A18CD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA001 */, bool useObjectPool = false /* Metadata: 0x00AFA005 */) => default; // 0x00000001846CFF60-0x00000001846D0260
	// [XID] // 0x0000000189A20390-0x0000000189A203B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA006 */, bool useObjectPool = false /* Metadata: 0x00AFA00A */) => default; // 0x00000001846CED70-0x00000001846CF570
	[BlackList] // 0x0000000189A27780-0x0000000189A277C0
	// [XID] // 0x0000000189A27780-0x0000000189A277C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001846CE6A0-0x00000001846CE970
	// [XID] // 0x0000000189A31D60-0x0000000189A31D80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846D0650-0x00000001846D0D50
	[BlackList] // 0x0000000189A39790-0x0000000189A397D0
	// [XID] // 0x0000000189A39790-0x0000000189A397D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001846CEAC0-0x00000001846CEB60
	[BlackList] // 0x0000000189A43F50-0x0000000189A43F90
	// [XID] // 0x0000000189A43F50-0x0000000189A43F90
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846CEB60-0x00000001846CEC20
	[BlackList] // 0x0000000189A4E660-0x0000000189A4E6A0
	// [XID] // 0x0000000189A4E660-0x0000000189A4E6A0
	public virtual void ReturnToObjectPool() {} // 0x00000001846D1140-0x00000001846D11E0
	[BlackList] // 0x0000000189A58C20-0x0000000189A58C60
	// [XID] // 0x0000000189A58C20-0x0000000189A58C60
	public virtual void OnPoolAllocated() {} // 0x00000001846D10A0-0x00000001846D1140
	[BlackList] // 0x0000000189A63790-0x0000000189A637D0
	// [XID] // 0x0000000189A63790-0x0000000189A637D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846D1000-0x00000001846D10A0
}

