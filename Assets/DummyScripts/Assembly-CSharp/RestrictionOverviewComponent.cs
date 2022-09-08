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

public sealed class RestrictionOverviewComponent : BaseContextComponent // TypeDefIndex: 29466
{
	// Fields
	private object _listObj; // 0x30
	private DataProvider _provider; // 0x38

	// Nested types
	public abstract class DataProvider // TypeDefIndex: 29467
	{
		// Properties
		public virtual int count { /* [XID] */ /* 0x0000000189AF6DD0-0x0000000189AF6DF0 */ get; } // 0x000000018260F850-0x000000018260F8F0 

		// Constructors
		protected DataProvider() {} // 0x000000018260F9A0-0x000000018260FA00

		// Methods
		// [XID] // 0x0000000189AFE300-0x0000000189AFE320
		public virtual uint GetFactorGroupId(int idx) => default; // 0x000000018260F8F0-0x000000018260F9A0
		// [XID] // 0x0000000189B05AF0-0x0000000189B05B10
		public virtual string GetRestrictionIconName(int idx) => default; // 0x000000018260F770-0x000000018260F850
		// [XID] // 0x0000000189B0D280-0x0000000189B0D2A0
		public virtual string GetOverrideDesc(int idx) => default; // 0x000000018260F690-0x000000018260F770
	}

	// Constructors
	public RestrictionOverviewComponent() {} // 0x00000001825FD610-0x00000001825FD670

	// Methods
	// [XID] // 0x0000000189ACACF0-0x0000000189ACAD10
	public override void Init(GameObject view) {} // 0x00000001825FD560-0x00000001825FD610
	// [IDTag] // 0x0000000189AD2760-0x0000000189AD27A0
	// [XID] // 0x0000000189AD2760-0x0000000189AD27A0
	public void Setup(MonoGridScroller listObj, DataProvider provider) {} // 0x00000001825FD3C0-0x00000001825FD490
	// [IDTag] // 0x0000000189ADD4D0-0x0000000189ADD510
	// [XID] // 0x0000000189ADD4D0-0x0000000189ADD510
	public void Setup(MonoSimpleReusableList listObj, DataProvider provider) {} // 0x00000001825FD490-0x00000001825FD560
	// [XID] // 0x0000000189AE7B50-0x0000000189AE7B70
	public void Refresh() {} // 0x00000001825FCC50-0x00000001825FCFB0
	// [XID] // 0x0000000189AEF8B0-0x0000000189AEF8D0
	public void RefreshItem(Transform trans, int idx) {} // 0x00000001825FD030-0x00000001825FD3C0
}

