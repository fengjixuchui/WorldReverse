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

public class EntityExecutionStat // TypeDefIndex: 27822
{
	// Fields
	private uint configID; // 0x10
	private string sampleName; // 0x18
	private Dictionary<string, ComponentExecutionStat> compStatMap; // 0x20
	private Dictionary<EntityManager.TickType, MMAField> entityStatMap; // 0x28

	// Constructors
	public EntityExecutionStat() {} // Dummy constructor
	public EntityExecutionStat(uint inConfigID) {} // 0x00000001812BD580-0x00000001812BD710

	// Methods
	// [XID] // 0x000000018990F820-0x000000018990F840
	public void StatComponent(BaseComponent comp, float elapsedTime, EntityManager.TickType statCategory) {} // 0x00000001812BCD10-0x00000001812BCEC0
	// [XID] // 0x00000001899172B0-0x00000001899172D0
	public void StatEntity(EntityManager.TickType statCategory, int deltaFrame) {} // 0x00000001812BC7D0-0x00000001812BC960
	// [XID] // 0x000000018991E970-0x000000018991E990
	public static string ToCSVTitleSingle(int compCount) => default; // 0x00000001812BCEC0-0x00000001812BD010
	// [XID] // 0x0000000189926210-0x0000000189926230
	public string ToCSVStringEntity() => default; // 0x00000001812BD390-0x00000001812BD580
	// [XID] // 0x00000001899AB8B0-0x00000001899AB8D0
	public static string ToCSVTitleEntity() => default; // 0x00000001812BD270-0x00000001812BD390
	// [XID] // 0x0000000189934DB0-0x0000000189934DD0
	public string ToCSVStringSinglePrefix() => default; // 0x00000001812BD010-0x00000001812BD270
	// [IDTag] // 0x000000018993C8A0-0x000000018993C8E0
	// [XID] // 0x000000018993C8A0-0x000000018993C8E0
	public string ToCSVStringSingle(string compName, EntityManager.TickType inTickType, bool withEmptyString = false /* Metadata: 0x00B0CFCD */) => default; // 0x00000001812BC960-0x00000001812BCB30
	// [IDTag] // 0x0000000189946D80-0x0000000189946DC0
	// [XID] // 0x0000000189946D80-0x0000000189946DC0
	public string ToCSVStringSingle(List<string> comps, EntityManager.TickType inTickType) => default; // 0x00000001812BCB30-0x00000001812BCD10
}

