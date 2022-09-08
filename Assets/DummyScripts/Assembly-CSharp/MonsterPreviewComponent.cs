/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterPreviewComponent : BaseContextComponent // TypeDefIndex: 29464
{
	// Fields
	private object _listObj; // 0x30
	private DataProvider _provider; // 0x38

	// Nested types
	public abstract class DataProvider // TypeDefIndex: 29465
	{
		// Properties
		public virtual int count { /* [XID] */ /* 0x0000000189AAC8D0-0x0000000189AAC8F0 */ get; } // 0x00000001826AB2B0-0x00000001826AB350 
		public virtual bool showLevel { /* [XID] */ /* 0x0000000189AB4190-0x0000000189AB41B0 */ get; } // 0x00000001826AB0B0-0x00000001826AB150 

		// Constructors
		protected DataProvider() {} // 0x00000001826AB350-0x00000001826AB3B0

		// Methods
		// [XID] // 0x0000000189ABBED0-0x0000000189ABBEF0
		public virtual uint GetMonsterId(int idx) => default; // 0x00000001826AB150-0x00000001826AB200
		// [XID] // 0x0000000189AC3660-0x0000000189AC3680
		public virtual uint GetMonsterLevel(int idx) => default; // 0x00000001826AB200-0x00000001826AB2B0
	}

	// Constructors
	public MonsterPreviewComponent() {} // 0x00000001826AC910-0x00000001826AC970

	// Methods
	// [XID] // 0x0000000189A812E0-0x0000000189A81300
	public override void Init(GameObject view) {} // 0x00000001826AC850-0x00000001826AC910
	// [IDTag] // 0x0000000189A88CC0-0x0000000189A88D00
	// [XID] // 0x0000000189A88CC0-0x0000000189A88D00
	public void Setup(MonoGridScroller listObj, DataProvider provider) {} // 0x00000001826AC6B0-0x00000001826AC780
	// [IDTag] // 0x0000000189A93260-0x0000000189A932A0
	// [XID] // 0x0000000189A93260-0x0000000189A932A0
	public void Setup(MonoSimpleReusableList listObj, DataProvider provider) {} // 0x00000001826AC780-0x00000001826AC850
	// [XID] // 0x0000000189A9D860-0x0000000189A9D880
	public void Refresh() {} // 0x00000001826ABEE0-0x00000001826AC1E0
	// [XID] // 0x0000000189AA5150-0x0000000189AA5170
	private void RefreshItem(Transform trans, int idx) {} // 0x00000001826AC260-0x00000001826AC6B0
}

